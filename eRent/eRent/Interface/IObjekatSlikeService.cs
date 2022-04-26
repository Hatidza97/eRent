using eRent.Model.Request.ObjekatSlike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface IObjekatSlikeService
    {
        List<Model.Model.ObjekatSlike> Get(ObjekatSlikeSearchRequest request);
        Model.Model.ObjekatSlike GetById(int id);
        Model.Model.ObjekatSlike Insert(ObjekatSlikeInsertRequest request);

    }
}
