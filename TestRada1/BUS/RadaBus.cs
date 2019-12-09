using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DAO;

namespace TestRada1.BUS
{
    public class RadaBus
    {
        RadaDao _rada = new RadaDao( );
        public bool insert(DTO.ST_RaDa rd)
        {
            return _rada.insert(rd);
        }

        public bool update(DTO.ST_RaDa rd)
        {
            return _rada.update(rd);
        }

        public bool isCheckRada( )
        {
            return _rada.isCheckRada();
        }

        public Object getRaDa(Int64 idBanDo)
        {
            return _rada.getRaDa(idBanDo);
        }

        public bool delete(Int64 id, Int64 idBanDo)
        {
            return _rada.delete(id,idBanDo);
        }
    }
}
