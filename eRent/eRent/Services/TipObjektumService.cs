using AutoMapper;
using eRent.Database;
using eRent.Interface;
using eRent.Model.Request.TipObjektum;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class TipObjektumService:ITipObjektumService
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;
        public TipObjektumService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<Model.Model.TipObjektum> Get(TipObjektumSearchRequest request)
        {
            //var query = _context.Korisnik.AsQueryable();
            var query = _context.TipObjekta.AsQueryable();

            if (!string.IsNullOrEmpty(request.Tip))
            {
                query = query.Where(x => x.Tip == request.Tip);

            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.TipObjektum>>(list);
        }

        [HttpGet]
        public Model.Model.TipObjektum GetById(int id)
        {
            var entitet = _context.TipObjekta.Find(id);
            return _mapper.Map<Model.Model.TipObjektum>(entitet);
        }

        [HttpPost]
        public Model.Model.TipObjektum Insert(TipObjektumInsertRequest request)
        {
            var entitet = _mapper.Map<Database.TipObjektum>(request);
            _context.TipObjekta.Add(entitet);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.TipObjektum>(entitet);
        }

        [HttpPut("{id}")]
        public Model.Model.TipObjektum Update(int id, TipObjektumInsertRequest request)
        {
            var entitet = _context.TipObjekta.Find(id);
            entitet.Tip = request.Tip;
            entitet.MaxKapacitet = request.MaxKapacitet;
            _context.TipObjekta.Attach(entitet);
            _context.TipObjekta.Update(entitet);
            _mapper.Map(entitet, request);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.TipObjektum>(entitet);

        }



        public bool Delete(int id)
        {
            var entitet = _context.TipObjekta.Find(id);

            if (entitet != null)
            {
                _context.TipObjekta.Remove(entitet);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
