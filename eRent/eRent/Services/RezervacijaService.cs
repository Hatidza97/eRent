using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.Rezervacija;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class RezervacijaService:IRezervacijaService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public RezervacijaService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Model.Model.Rezervacija> Get(RezervacijaSearchRequest request=null)
        {
            //var query = _context.Korisnik.AsQueryable();
            var query = _context.Rezervacijas
                .Include(x=>x.Objekat)
                .Include(x=>x.Korisnik)
                .AsQueryable();


            if (request.DatumPrijave != null && request.DatumOdjave != null)
            {
                var datumOd = request.DatumPrijave?.Date;
                var datumDo = request.DatumOdjave?.Date;
                query = query.Where(x => x.DatumPrijave.Date >= datumOd && x.DatumOdjave.Date <= datumDo);
            }
            //if (request.ObjekatSearchRequest.Rezervisano == false)
            //{
            //    var datumOd = request.DatumPrijave?.Date;
            //    var datumDo = request.DatumOdjave?.Date;
            //    query = query.Where(x => x.Objekat.Naziv==request.ObjekatSearchRequest.Naziv);
            //}
            if (request.ObjekatId.HasValue)
            {
                query = query.Where(x => x.ObjekatId == request.ObjekatId);
            }
            if (request.KorisnikId.HasValue)
            {
                query = query.Where(x => x.KorisnikId == request.KorisnikId);
            }
            if (request.CjenovnikId.HasValue)
            {
                query = query.Where(x => x.CjenovnikId == request.CjenovnikId);
            }
            if (request.ObjekatSearchRequest!=null)
            {
                query = query.Where(x => x.Objekat.GradId == request.ObjekatSearchRequest.GradId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.Rezervacija>>(list);
        }
      
        [HttpGet]
        public Model.Model.Rezervacija GetById(int id)
        {
            var entitet = _context.Rezervacijas.Find(id);
            return _mapper.Map<Model.Model.Rezervacija>(entitet);
        }

        [HttpPost]
        public Model.Model.Rezervacija Insert(RezervacijaInsertRequest request)
        {
            var entitet = _mapper.Map<Database.Rezervacija>(request);
           


            _context.Rezervacijas.Add(entitet);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Rezervacija>(entitet);
        }

        [HttpPut("{id}")]
        public Model.Model.Rezervacija Update(int id, RezervacijaInsertRequest request)
        {
            var entitet = _context.Rezervacijas.Find(id);
            entitet.DatumPrijave = request.DatumPrijave;
            entitet.DatumOdjave = request.DatumOdjave;
            entitet.DatumRezervacije = request.DatumRezervacije;
            entitet.BrojMjestaDjeca = request.BrojMjestaDjeca;
            entitet.BrojMjestaOdrasli = request.BrojMjestaOdrasli;
            _context.Rezervacijas.Attach(entitet);
            _context.Rezervacijas.Update(entitet);
            _mapper.Map(entitet, request);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Rezervacija>(entitet);

        }



        public bool Delete(int id)
        {
            var entitet = _context.Rezervacijas.Find(id);

            if (entitet != null)
            {
                _context.Rezervacijas.Remove(entitet);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
