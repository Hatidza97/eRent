using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRent.Database;
using eRent.Model.Request;
using eRent.Model.Request.Drzava;

namespace eRent.Services
{
    public class DrzavaService : BaseService<Model.Model.Drzava, Model.Request.DrzavaSearchRequest, Database.Drzava>
    {
       
        public DrzavaService(MobisContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override List<Model.Model.Drzava> Get(DrzavaSearchRequest search = null)
        {
            var entity = _context.Set<Database.Drzava>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.NazivDrzave))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.NazivDrzave));
            }
            if (search.DrzavaId.HasValue)
            {
                entity = entity.Where(x => x.DrzavaId == search.DrzavaId);
            }
            var list = entity.ToList();
            return _mapper.Map<List<Model.Model.Drzava>>(list);

        }
    }
}
