using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TestRada1.BUS
{
    class HoatDongBus
    {
        DAO.HoatDongDao hoatDongDao = new DAO.HoatDongDao();
        public IEnumerable<object> getAll(DateTime now)
        {
            return hoatDongDao.getAll(now);
        }

        public object getAllAction()
        {
            return hoatDongDao.getAllAction();
        }
        public bool deleteAction(Int64 ActionId)
        {
            return hoatDongDao.deleteAction(ActionId);
        }
        public object getAction(int actionId)
        {
            return hoatDongDao.getAction(actionId);
        }
        public bool updateAction(DTO.ST_HoatDong action)
        {
            return hoatDongDao.updateAction(action);
        }
    }
}
