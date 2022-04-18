using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.Korisnik;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class KorisniciService:IKorisniciService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public KorisniciService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public List<Models.Korisnik> Get()
        //{

        //    var list = _context.Korisnik.ToList();

        //    return _mapper.Map<List<Models.Korisnik>>(list);
        //}

        [HttpGet]
        public List<Model.Model.Korisnik> Get(KorisniciSearchRequest request)
        {
            //var query = _context.Korisnik.AsQueryable();
            var query = _context.Korisniks.AsQueryable();

            if (!string.IsNullOrEmpty(request.KorisnickoIme))
            {
                query = query.Where(x => x.Username == request.KorisnickoIme);

            }
            if (!string.IsNullOrEmpty(request.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));

            }
            if (!string.IsNullOrEmpty(request.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));

            }
            if (request.UlogaId != 0)
            {
                query = query.Where(x => x.UlogaId == request.UlogaId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.Korisnik>>(list);
        }
        public Model.Model.Korisnik Authentifikacija(string korisnickoime, string password)
        {
            var user = _context.Korisniks.Include("Uloga").FirstOrDefault(x => x.Username == korisnickoime);
            if (user != null)
            {
                //var noviHash = GenerateHash(user.LozinkaSalt, password);

                //if (noviHash == user.LozinkaHash)
                //{
                    return _mapper.Map<Model.Model.Korisnik>(user);
                
            }
            return null;
        }
        [HttpGet]
        public Model.Model.Korisnik GetById(int id)
        {
            var entitet = _context.Korisniks.Find(id);
            return _mapper.Map<Model.Model.Korisnik>(entitet);
        }

        [HttpPost]
        public Model.Model.Korisnik Insert(KorisniciInsertRequest request)
        {
            var entitet = _mapper.Map<Database.Korisnik>(request);
            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Paswordi se ne slazu!");
            }
           


            _context.Korisniks.Add(entitet);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Korisnik>(entitet);
        }

        [HttpPut("{id}")]
        public Model.Model.Korisnik Update(int id, KorisniciInsertRequest request)
        {
            var entitet = _context.Korisniks.Find(id);
            entitet.Ime = request.Ime;
            entitet.Username = request.Username;
            entitet.Prezime = request.Prezime;
            entitet.UlogaId = request.UlogaId;
            entitet.Email = request.Email;
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slazu!");
                }
                else
                {


                    entitet.Password = request.Password;
                }


            }

            _context.Korisniks.Attach(entitet);
            _context.Korisniks.Update(entitet);
            _mapper.Map(entitet, request);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Korisnik>(entitet);

        }

        

        public bool Delete(int id)
        {
            var entitet = _context.Korisniks.Find(id);

            if (entitet != null)
            {
                _context.Korisniks.Remove(entitet);
                var listkarte = _context.Rezervacijas.Where(x => x.KorisnikId == entitet.KorisnikId);
                foreach (var x in listkarte)
                {
                    _context.Rezervacijas.Remove(x);
                }
                var listocjena = _context.Autorizacijas.Where(x => x.KorisnikId == entitet.KorisnikId);
                foreach (var x in listocjena)
                {
                    _context.Autorizacijas.Remove(x);
                }
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
