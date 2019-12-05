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

        public Object getRaDa( )
        {
            return _rada.getRaDa();
        }
    }
}
