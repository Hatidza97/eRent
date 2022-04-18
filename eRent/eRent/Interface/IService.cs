using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IService<TModel, Tsearch> where Tsearch : class
    {
        List<TModel> Get(Tsearch search = null);
        TModel GetByID(int id);
    }
}
