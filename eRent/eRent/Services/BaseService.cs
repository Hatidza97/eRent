using AutoMapper;
using eRent.Database;
using eRent.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Services
{
    public class BaseService<TModel, Tsearch, TDatabase> : IService<TModel, Tsearch> where TDatabase : class where Tsearch : class
    {
        protected readonly MobisContext _context;
        protected readonly IMapper _mapper;

        public BaseService(MobisContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual List<TModel> Get(Tsearch search = null)
        {
            return _mapper.Map<List<TModel>>(_context.Set<TDatabase>().ToList());
        }

        public virtual TModel GetByID(int id)
        {
            return _mapper.Map<TModel>(_context.Set<TDatabase>().Find(id));
        }
    }
}
