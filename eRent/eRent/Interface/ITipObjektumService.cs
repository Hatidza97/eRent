using eRent.Model.Request.TipObjektum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Interface
{
    public interface ITipObjektumService
    {
        List<Model.Model.TipObjektum> Get(TipObjektumSearchRequest request);
        Model.Model.TipObjektum GetById(int id);
        Model.Model.TipObjektum Insert(TipObjektumInsertRequest request);

        bool Delete(int id);
        Model.Model.TipObjektum Update(int id, TipObjektumInsertRequest request);
    }
}
