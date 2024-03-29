﻿using System;
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
        public Int64 insert(DTO.ST_BanDo bd)
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


        /// <summary>
        /// Get all BanDo
        /// </summary>
        /// <returns>List BanDo</returns>
        public IEnumerable<object> getAll( )
        {
            return _bd.getAll();
        }

        /// <summary>
        /// get detail ban do
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object getDetail(Int64 id)
        {
            return _bd.getDetail(id);
        }


        public bool delete(Int64 Id)
        {
            return _bd.delete(Id);
        }
    }
}
