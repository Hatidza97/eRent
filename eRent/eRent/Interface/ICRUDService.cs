using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface ICRUDService<TModel, Tsearch, TInsert, TUpdate> : IService<TModel, Tsearch> where Tsearch : class
    {
        TModel Insert(TInsert request);
        TModel Update(int id, TUpdate request);
        void Delete(int id);

    }
}
