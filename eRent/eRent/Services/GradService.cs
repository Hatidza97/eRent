using AutoMapper;
using eRent.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRent.Model.Request.Grad;
using AutoMapper;
namespace eRent.Services
{
    public class GradService : BaseCRUDService<Model.Model.Grad, GradSearchRequest, Database.Grad,GradInsertRequest,GradInsertRequest>
    {

        public GradService(MobisContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Model.Grad> Get(GradSearchRequest search = null)
        {
            var query = _context.Grads.AsQueryable();
            if (search.NazivGrada != null)
            {
                query = query.Where(x => x.Naziv.Contains(search.NazivGrada));
            }
            if (search.DrzavaId != null)
            {
                query = query.Where(x => x.DrzavaId == search.DrzavaId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Model.Grad>>(list);

        }
        public override Model.Model.Grad Update(int id, GradInsertRequest request)
        {
            var entitet = _context.Set<Database.Grad>().Find(id);

            _context.Set<Database.Grad>().Attach(entitet);
            _context.Set<Database.Grad>().Update(entitet);
            _mapper.Map(entitet, request);
            _context.SaveChanges();
            return _mapper.Map<Model.Model.Grad>(entitet);
        }

       

    }
}
