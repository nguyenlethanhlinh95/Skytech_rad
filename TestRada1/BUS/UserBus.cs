﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DAO;
using TestRada1.DTO;

namespace TestRada1.BUS
{
    public class UserBus
    {
        UserDao _userDao = new UserDao();
        public Int64 CheckLogin(string username, string password)
        {
            return _userDao.CheckLogin(username,password );
        }

        public Object getUserById(Int64 id)
        {
            var user = _userDao.getUserById(id);
            return user;
        }

        //public Object getUserById(Int64 id);

        public IEnumerable<Object> getAllUser( )
        {
            return _userDao.getAllUser();
        }

        public Object getUserByUserName(string userName)
        {
            return _userDao.getUserByUserName(userName);
        }

        public bool updatePassword(string pass, Int64 id)
        {
            return _userDao.updatePassword(pass,id);
        }

        public bool updateUser(DTO.ST_User user)
        {
            return _userDao.updateUser(user);
        }

        public Int64 insertUser(ST_User em)
        {
            return _userDao.insertUser(em);
        }

        public bool delete(Int64 id)
        {
            return _userDao.delete(id);
        }
    }
}
