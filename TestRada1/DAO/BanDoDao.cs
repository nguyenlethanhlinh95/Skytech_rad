using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DTO;

namespace TestRada1.DAO
{
    public class BanDoDao
    {
        DataClasses1DataContext db = new DataClasses1DataContext( );

        public Int64 insert(DTO.ST_BanDo bd)
        {
            try
            {
                db.ST_BanDos.InsertOnSubmit(bd);
                db.SubmitChanges( );
                return bd.bando_id;
            }
            catch ( Exception )
            {
                return 0;
            }
        }


        public bool update(DTO.ST_BanDo bd)
        {
            try
            {
                var updateBT = db.ST_BanDos.Where(p => p.bando_id.Equals(bd.bando_id)).SingleOrDefault( );

                updateBT.bando_image = bd.bando_image;
                updateBT.bando_name = bd.bando_name;
                updateBT.bando_x = bd.bando_x;
                updateBT.bando_y = bd.bando_y;
                db.SubmitChanges( );
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isCheckBanDo()
        {
            try
            {
                 int countBanDo = db.ST_BanDos.Count();
                 if ( countBanDo > 0 )
                 {
                    return true;
                 }
                 return false;            
            }
            catch(Exception)
            {
                return false;
            }
        }

        public Object getBanDo()
        {
            try
            {
                var banDo = (from b in db.ST_BanDos
                            select b
                            ).First();
                return banDo;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public IEnumerable<object> getAll( )
        {
            var dlg = new DevExpress.Utils.WaitDialogForm("Đang tải dữ liệu ...", "Thông báo");
            try
            {
                db.Dispose( );
                db = new DTO.DataClasses1DataContext( );
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var datasource = from t1 in db.ST_BanDos
                                 select t1;
                return datasource;
            }
            catch ( Exception )
            {
                return null;
            }
            finally
            {
                dlg.Close( );
            }
        }

        public object getDetail(Int64 id)
        {
            try
            {
                db.Dispose( );
                db = new DTO.DataClasses1DataContext( );
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var unit = (from t1 in db.ST_BanDos
                            where t1.bando_id == id
                            select t1).First( );
                return unit;
            }
            catch ( Exception )
            {
                return null;
            }
        }

        public bool delete(Int64 Id)
        {
            try
            {
                var delete = db.ST_BanDos.Where(p => p.bando_id.Equals(Id)).SingleOrDefault( );

                db.ST_BanDos.DeleteOnSubmit(delete);
                db.SubmitChanges( );
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
