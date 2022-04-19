using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.Kategorija;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class KategorijaService:IKategorijaService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public KategorijaService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Model.Model.Kategorija> Get(KategorijaSearchRequest request)
        {
            //var query = _context.Korisnik.AsQueryable();
            var query = _context.Kategorijas.AsQueryable();

            if (!string.IsNullOrEmpty(request.NazivKategorije))
            {
                query = query.Where(x => x.NazivKategorije == request.NazivKategorije);

            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.Kategorija>>(list);
        }

        [HttpGet]
        public Model.Model.Kategorija GetById(int id)
        {
            var entitet = _context.Kategorijas.Find(id);
            return _mapper.Map<Model.Model.Kategorija>(entitet);
        }

        [HttpPost]
        public Model.Model.Kategorija Insert(KategorijaInsertRequest request)
        {
            var entitet = _mapper.Map<Database.Kategorija>(request);
            _context.Kategorijas.Add(entitet);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Kategorija>(entitet);
        }

        [HttpPut("{id}")]
        public Model.Model.Kategorija Update(int id, KategorijaInsertRequest request)
        {
            var entitet = _context.Kategorijas.Find(id);
            entitet.NazivKategorije = request.NazivKategorije;
            _context.Kategorijas.Attach(entitet);
            _context.Kategorijas.Update(entitet);
            _mapper.Map(entitet, request);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Kategorija>(entitet);

        }



        public bool Delete(int id)
        {
            var entitet = _context.Kategorijas.Find(id);

            if (entitet != null)
            {
                _context.Kategorijas.Remove(entitet);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
