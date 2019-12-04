using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRada1.DAO
{
    class VungNguyHiemDao
    {
        DTO.DataClasses1DataContext db = new DTO.DataClasses1DataContext();
        public bool insertVNH(DTO.ST_VungNguyHiem vungNH)
        {
            try
            {
                db.ST_VungNguyHiems.InsertOnSubmit(vungNH);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Object> getAllVungNH()
        {
            try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var data = from t1 in db.ST_VungNguyHiems
                                  select t1;
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public object getAllVNHShow()
        {

            try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var data = from t1 in db.ST_VungNguyHiems select t1;

                           
                return data;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public object getVNHShow(Int64 id)
        {

            try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var data = from t1 in db.ST_VungNguyHiems where t1.vungNguyHiem_id==id select t1;


                return data.First() ;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public bool deleteVNH(Int64 id)
        {
            try
            {
                var delete = db.ST_VungNguyHiems.Where(p => p.vungNguyHiem_id.Equals(id)).SingleOrDefault();

                db.ST_VungNguyHiems.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateVNH(DTO.ST_VungNguyHiem vungNguyHiem)

        {
            try
            {
                var updateVNH = db.ST_VungNguyHiems.Where(p => p.vungNguyHiem_id.Equals(vungNguyHiem.vungNguyHiem_id)).SingleOrDefault();

                updateVNH.vungNguyHiem_loai = vungNguyHiem.vungNguyHiem_loai;
                updateVNH.vungNguyHiem_ban_kinh = vungNguyHiem.vungNguyHiem_ban_kinh;
                updateVNH.vungNguyHiem_1_X = vungNguyHiem.vungNguyHiem_1_X;
                updateVNH.vungNguyHiem_1_Y = vungNguyHiem.vungNguyHiem_1_Y;
                updateVNH.vungNguyHiem_2_X = vungNguyHiem.vungNguyHiem_2_X;
                updateVNH.vungNguyHiem_2_Y = vungNguyHiem.vungNguyHiem_2_Y;
                updateVNH.vungNguyHiem_3_X = vungNguyHiem.vungNguyHiem_3_X;
                updateVNH.vungNguyHiem_3_Y = vungNguyHiem.vungNguyHiem_3_Y;
                updateVNH.vungNguyHiem_4_X = vungNguyHiem.vungNguyHiem_4_X;
                updateVNH.vungNguyHiem_4_Y = vungNguyHiem.vungNguyHiem_4_Y;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
