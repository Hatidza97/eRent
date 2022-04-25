﻿using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.Objekat;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class ObjekatService:IObjekatService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public ObjekatService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        [HttpGet]
        public List<Model.Model.Objekat> Get(ObjekatSearchRequest request)
        {
            //var query = _context.Korisnik.AsQueryable();
            var query = _context.Set<Database.Objekat>()
                .Include(x=>x.Kategorija)
                .Include(x=>x.TipObjekta)
                .Include(x=>x.Vlasnik)
                .AsQueryable();

            if (!string.IsNullOrEmpty(request.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(request.Naziv));

            }
            if (request.ObjekatId.HasValue)
            {
                query = query.Where(x => x.ObjekatId == request.ObjekatId);
            }
            if (request.KategorijaId.HasValue)
            {
                query = query.Where(x => x.KategorijaId == request.KategorijaId);
            }
            if (request.TipObjektaId.HasValue)
            {
                query = query.Where(x => x.TipObjektaId == request.TipObjektaId);
            }
            if (!string.IsNullOrEmpty(request.Adresa))
            {
                query = query.Where(x => x.Adresa.StartsWith(request.Adresa));

            }
            if (!string.IsNullOrEmpty(request.Email))
            {
                query = query.Where(x => x.Email.StartsWith(request.Email));

            }
            //if ((request.Rezervisano==false))
            //{
            //    query = query.Where(x => x.Rezervisano==false);
            //}
            //if (request.GradId.HasValue)
            //{
            //    query = query.Where(x => x.GradId == request.GradId);
            //}
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.Objekat>>(list);
        }
        
        [HttpGet]
        public Model.Model.Objekat GetById(int id)
        {
            var entitet = _context.Objekats.Find(id);
            return _mapper.Map<Model.Model.Objekat>(entitet);
        }
        //public List<Model.Model.Objekat> GetNaziv(ObjekatNazivRequest request) 
        //{
        //    var query = _context.Objekats
        //      .Include(x => x.Kategorija)
        //      .Include(x => x.TipObjekta)
        //      .Include(x => x.Vlasnik)
        //      .AsQueryable();
        //    if (!string.IsNullOrEmpty(request.Naziv))
        //    {
        //        query = query.Where(x => x.Naziv == request.Naziv);
        //    }
        //    var list = query.ToList();
        //    return _mapper.Map<List<Model.Model.Objekat>>(list);
        //}


        [HttpPost]
        public Model.Model.Objekat Insert(ObjekatInserRequest request)
        {
            var entitet = _mapper.Map<Database.Objekat>(request);
            _context.Objekats.Add(entitet);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Objekat>(entitet);
        }

        [HttpPut("{id}")]
        public Model.Model.Objekat Update(int id, ObjekatInserRequest request)
        {
            var entitet = _context.Objekats.Find(id);
            entitet.Naziv = request.Naziv;
            entitet.Adresa = request.Adresa;
            entitet.Email = request.Email;
            entitet.BrTelefona = request.BrTelefona;
            entitet.Email = request.Email;
            entitet.GradId = request.GradId;
            entitet.TipObjektaId = request.TipObjektaId;
            _context.Objekats.Attach(entitet);
            _context.Objekats.Update(entitet);
            _mapper.Map(entitet, request);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Objekat>(entitet);

        }



        public bool Delete(int id)
        {
            var entitet = _context.Objekats.Find(id);

            if (entitet != null)
            {
                _context.Objekats.Remove(entitet);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
