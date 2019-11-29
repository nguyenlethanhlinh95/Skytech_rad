using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DAO;
using TestRada1.DTO;

namespace TestRada1.BUS
{
    public class DeparmentBus
    {
        DepartmentDao departmentDao = new DepartmentDao( );
        public IEnumerable<Object> listAll( )
        {
            return departmentDao.getAllDepartment( );
        }

        public bool insertDepartment(ST_Department dep)
        {
            return departmentDao.insertDepartment(dep);
        }

        public Object getDepartment(Int64 id)
        {
            return departmentDao.getDeparment(id);
        }

        public bool update(ST_Department depar)
        {
            return departmentDao.update(depar);
        }

        public bool deleteDepartment(Int64 idDepartment)
        {
            return departmentDao.deleteDepartment(idDepartment);
        }

        public bool isCheckDepament(Int64 id)
        {
            return departmentDao.isCheckDepament(id);
        }
    }
}
