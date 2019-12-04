using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRada1.BUS
{
    class VungNguyHiemBus
    {
        DAO.VungNguyHiemDao _vungNguyHiemDao = new DAO.VungNguyHiemDao();
        public bool insertVNH(DTO.ST_VungNguyHiem vungNH)
        {
            return _vungNguyHiemDao.insertVNH(vungNH);
        }
        public IEnumerable<Object> getAllVungNH()
        {
            return _vungNguyHiemDao.getAllVungNH();

        }
        public object getAllVNHShow()
        {
            return _vungNguyHiemDao.getAllVNHShow();
        }
        public bool deleteVNH(Int64 id)
        {
            return _vungNguyHiemDao.deleteVNH(id);
        }
        public object getVNHShow(Int64 id)
        {
            return _vungNguyHiemDao.getVNHShow(id);
        }
        public bool updateVNH(DTO.ST_VungNguyHiem vungNguyHiem)
        {
            return _vungNguyHiemDao.updateVNH(vungNguyHiem);
        }
    }
}
