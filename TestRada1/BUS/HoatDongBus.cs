using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TestRada1.BUS
{
    public class HoatDongBus
    {
        DAO.HoatDongDao hoatDongDao = new DAO.HoatDongDao();

        public IEnumerable<object> getAll(DateTime now)
        {
            return hoatDongDao.getAll(now);
        }
    }
}
