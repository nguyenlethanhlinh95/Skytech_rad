using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DTO;

namespace TestRada1.DAO
{
    public class DepartmentDao
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public IEnumerable<Object> getAllDepartment()
        {
            try
            {
                db.Dispose( );
                db = new DataClasses1DataContext( );
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var data = from d in db.ST_Departments
                           select d;

                return data;
            }
            catch(Exception )
            {
                return null;
            }
        }

        public Object getDeparment(Int64 id)
        {
            
            try{
                db.Dispose( );
                db = new DataClasses1DataContext( );
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var depament = (from b in db.ST_Departments
                               where b.department_id == id
                               select b).Single();

                return depament;
            }
            catch(Exception)
            {
                return null;
            }
            
        }

        public bool insertDepartment(DTO.ST_Department dep)
        {
            try{
                db.ST_Departments.InsertOnSubmit(dep);
                db.SubmitChanges( );
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public bool deleteDepartment(Int64 idDepartment)
        {
            try{
                var delete = db.ST_Departments.Where(p => p.department_id.Equals(idDepartment)).SingleOrDefault( );

                db.ST_Departments.DeleteOnSubmit(delete);
                db.SubmitChanges( );
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public bool update(ST_Department depar)
        {
            try{
                var dep = (from b in db.ST_Departments
                           where b.department_id == depar.department_id
                           select b).Single( );

                dep.department_name = depar.department_name;
                dep.user_created = depar.user_created;

                db.SubmitChanges( );
                return true;
            }
            catch(Exception )
            {
                return false;
            }
            
        }


        public bool isCheckDepament(Int64 id)
        {
            var data = from b in db.ST_Departments
                        where b.department_id == id
                        select b.department_id;
            if (data.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
