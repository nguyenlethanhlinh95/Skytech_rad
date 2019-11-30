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
    }
}
