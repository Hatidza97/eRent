using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.Cjenovnik;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class CjenovnikService : ICjenovnikService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public CjenovnikService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Model.Model.Cjenovnik> Get(CjenovnikSearchRequest request = null)
        {
            //var query = _context.Korisnik.AsQueryable();
            var query = _context.Cjenovniks
                .Include(x => x.Objekat)
                .AsQueryable();
            if (request.CjenovnikId.HasValue)
            {
                query = query.Where(x => x.CjenovnikId == request.CjenovnikId);
            }
            if (request.ObjekatId.HasValue)
            {
                query = query.Where(x => x.ObjekatId == request.ObjekatId);
            }
            if (request.Cijena.HasValue)
            {
                query = query.Where(x => x.Cijena == request.Cijena);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.Cjenovnik>>(list);
        }
        [HttpGet]
        public Model.Model.Cjenovnik GetById(int id)
        {
            var entitet = _context.Cjenovniks.Find(id);
            return _mapper.Map<Model.Model.Cjenovnik>(entitet);
        }

    }
}
