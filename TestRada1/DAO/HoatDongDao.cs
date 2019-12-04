using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlTypes;

namespace TestRada1.DAO
{
    class HoatDongDao
    {
        DTO.DataClasses1DataContext db = new DTO.DataClasses1DataContext();

        public IEnumerable<object> getAll(DateTime now)
        {
             try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);

                var data = from hoatDong in db.ST_HoatDongs
                           join vatThe in db.ST_VatThes
                           on hoatDong.vatThe_id equals vatThe.vatThe_id
                           where hoatDong.HoatDong_thoiGianBatDauChay>=now
                           select new
                           {
                           hoatDong.HoatDong_id,
                           hoatDong.HoatDong_soBuocNhay,
                           hoatDong.HoatDong_thoiGianBatDauChay,
                           hoatDong.HoatDong_xBatDau,
                           hoatDong.HoatDong_xKetThuc,
                           hoatDong.HoatDong_yBatDau,
                           hoatDong.HoatDong_yKetThuc,
                           vatThe.vatThe_name,
                           vatThe.vatThe_mau,
                           vatThe.vatThe_hinhAnh
                       };




                return data;

            }
             catch (Exception)
             {
                 return null;
             }
        }


        public object getAllAction()
        {
             try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var data = from hoatDong in db.ST_HoatDongs
                           join vatThe in db.ST_VatThes
                               on hoatDong.vatThe_id equals vatThe.vatThe_id
                          
                           select new
                           {
                               hoatDong.HoatDong_id,
                               hoatDong.HoatDong_soBuocNhay,
                               hoatDong.HoatDong_thoiGianBatDauChay,
                               hoatDong.HoatDong_xBatDau,
                               hoatDong.HoatDong_xKetThuc,
                               hoatDong.HoatDong_yBatDau,
                               hoatDong.HoatDong_yKetThuc,
                               vatThe.vatThe_name,
                               vatThe.vatThe_mau,
                               vatThe.vatThe_hinhAnh
                           };
                return data;
            }
             catch (Exception)
             {
                 return null;
             }
        }

        public object getAction(int actionId)
        {
            try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var data = from hoatDong in db.ST_HoatDongs

                           where hoatDong.HoatDong_id == actionId
                           select hoatDong;

                return data.First(); ;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool deleteAction(Int64 ActionId)
        {
            try
            {
                var delete = db.ST_HoatDongs.Where(p => p.HoatDong_id.Equals(ActionId)).SingleOrDefault();

                db.ST_HoatDongs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateAction(DTO.ST_HoatDong action)
        {
            try
            {
                var _updateAction = db.ST_HoatDongs.Where(p => p.HoatDong_id.Equals(action.HoatDong_id)).SingleOrDefault();
                _updateAction.HoatDong_soBuocNhay = action.HoatDong_soBuocNhay;
                _updateAction.HoatDong_xBatDau = action.HoatDong_xBatDau;
                _updateAction.HoatDong_yBatDau = action.HoatDong_yBatDau;
                _updateAction.HoatDong_xKetThuc = action.HoatDong_xKetThuc;
                _updateAction.HoatDong_yKetThuc = action.HoatDong_yKetThuc;
                _updateAction.HoatDong_thoiGianBatDauChay = action.HoatDong_thoiGianBatDauChay;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
