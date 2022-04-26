using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.ObjekatSlike;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class ObjekatSlikeService:IObjekatSlikeService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public ObjekatSlikeService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Model.Model.ObjekatSlike> Get(ObjekatSlikeSearchRequest request = null)
        {
            var query = _context.ObjekatSlikes
                .Include(x => x.Objekat)
                .AsQueryable();
            
            if (request.ObjekatId.HasValue)
            {
                query = query.Where(x => x.ObjekatId == request.ObjekatId);
            }
            
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.ObjekatSlike>>(list);
        }
        [HttpGet]
        public Model.Model.ObjekatSlike GetById(int id)
        {
            var entitet = _context.Cjenovniks.Find(id);
            return _mapper.Map<Model.Model.ObjekatSlike>(entitet);
        }
        [HttpPost]
        public Model.Model.ObjekatSlike Insert(ObjekatSlikeInsertRequest request)
        {
            var entitet = _mapper.Map<Database.ObjekatSlike>(request);
            _context.ObjekatSlikes.Add(entitet);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.ObjekatSlike>(entitet);
        }
    }
}
