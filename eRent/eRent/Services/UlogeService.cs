using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.Uloga;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class UlogeService:IUlogeService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;

        public UlogeService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public List<Model.Model.Uloga> Get(UlogeSearchRequest search = null)
        {
            var entity = _context.Set<Database.Uloga>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if (search.UlogaId!=0)
            {
                entity = entity.Where(x => x.UlogaId == search.UlogaId);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Model.Model.Uloga>>(list);

        }
        [HttpGet]
        public Model.Model.Uloga GetById(int id)
        {
            var entitet = _context.Ulogas.Find(id);
            return _mapper.Map<Model.Model.Uloga>(entitet);
        }
    }
}
