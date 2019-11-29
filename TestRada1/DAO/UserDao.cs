using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DTO;

namespace TestRada1.DAO
{
    public class UserDao
    {
        DataClasses1DataContext db = new DataClasses1DataContext( );

        public Int64 CheckLogin(string username, string password)
        {
            try
            {
                var user = (from u in db.ST_Users
                            where u.user_username == username && u.user_password == password
                            select u.user_id).First( );
                if ( user > 0 )
                {
                    return user;
                }
                else
                {
                    return 0;
                }
            }
            catch ( Exception ex )
            {
                return 0;
            }

        }

        public Object getUserById(Int64 id)
        {
            try{
                var users = (from u in db.ST_Users
                             where u.user_id == id
                             select u).First( );
                return users;
            }
            catch(Exception)
            {
                return null;
            }
            
        }

        public IEnumerable<Object> getAllUser( )
        {
            var dlg = new DevExpress.Utils.WaitDialogForm("Đang tải dữ liệu ...", "Thông báo");
            try
            {
                var users = from u in db.ST_Users
                            join dep in db.ST_Departments on u.department_id equals dep.department_id
                            select new { u.user_name, u.user_username, u.user_password, u.user_address, u.user_email, u.user_phone, u.user_date_of_birth, u.user_gender, u.role_id, u.user_image, dep.department_name, u.user_status, u.user_created_date,  u.user_created };

                return users;
            }
            catch
            {
                return null;
            }
            finally
            {
                dlg.Close( );
            }

        }

        public Object getUserByUserName(string userName)
        {
            var users = (from u in db.ST_Users
                         where u.user_username == userName
                         select u).First( );
            return users;
        }

        public Int64 insertUser(ST_User em)
        {
            try
            {
                db.ST_Users.InsertOnSubmit(em);
                db.SubmitChanges( );

                Int64 id = Int64.Parse(em.user_id.ToString( ));
                return id;
            }
            catch
            {
                return 0;
            }

        }

        public bool updatePassword(string pass, Int64 id)
        {
            try
            {
                var user = (from u in db.ST_Users
                            where u.user_id == id
                            select u).Single( );

                user.user_password = pass;
                db.SubmitChanges( );
                return true;
            }
            catch ( Exception )
            {
                return false;
            }

        }
    }
}
