using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DTO;
using TestRada1.DAO;

namespace TestRada1.BUS
{
    public class BanDoBus
    {
        BanDoDao _bd = new BanDoDao();
        public bool insert(DTO.ST_BanDo bd)
        {
            return _bd.insert(bd);
        }

        public bool update(DTO.ST_BanDo bd)
        {
            return _bd.update(bd);
        }

        public bool isCheckBanDo()
        {
            return _bd.isCheckBanDo();
        }

        public Object getBanDo()
        {
            return _bd.getBanDo();
        }
    }
}
