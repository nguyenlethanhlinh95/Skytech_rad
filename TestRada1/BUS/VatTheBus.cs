using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DAO;
using System.Data;

namespace TestRada1.BUS
{
    public class VatTheBus
    {
        VatTheDao _vt = new VatTheDao();
        public IEnumerable<Object> getAll( )
        {
            return _vt.getAll();
        }
        
        public bool insert(DTO.ST_VatThe vt)
        {
            return _vt.insert(vt);
        }

        public bool update(DTO.ST_VatThe vt)
        {
            return _vt.update(vt);
        }

        public object getDetail(Int32 id)
        {
            return _vt.getDetail(id);
        }

        public bool delete(Int64 id)
        {
            return _vt.delete(id);
        }

    }
}
