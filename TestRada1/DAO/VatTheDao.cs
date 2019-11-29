using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DTO;
using System.Data;

namespace TestRada1.DAO
{
    public class VatTheDao
    {
        DataClasses1DataContext db = new DataClasses1DataContext( );
        public IEnumerable<Object> getAll( )
        {
            try
            {
                db.Dispose( );
                db = new DTO.DataClasses1DataContext( );
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var getAllVatTu = from vt in db.ST_VatThes 
                                    select vt;
                return getAllVatTu;
            }
            catch ( Exception )
            {
                return null;
            }
        }

        public bool insert(DTO.ST_VatThe vt)
        {
            try
            {
                db.ST_VatThes.InsertOnSubmit(vt);
                db.SubmitChanges( );
                return true;
            }
            catch ( Exception )
            {
                return false;
            }
        }


        public bool update(DTO.ST_VatThe vt)
        {
            try
            {
                var updateVT = db.ST_VatThes.Where(p => p.vatThe_id.Equals(vt.vatThe_id)).SingleOrDefault( );

                updateVT.vatThe_name = vt.vatThe_name;
                updateVT.vatThe_mau = vt.vatThe_mau;
                updateVT.vatThe_hinhAnh = vt.vatThe_hinhAnh;
                db.SubmitChanges( );
                return true;
            }
            catch
            {
                return false;
            }
        }


        public object getDetail(Int32 id)
        {
            try
            {
                db.Dispose( );
                db = new DTO.DataClasses1DataContext( );
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var vatthe = (from vt in db.ST_VatThes
                                         where vt.vatThe_id == id
                                         select vt).First();
                return vatthe;
            }
            catch ( Exception )
            {
                return null;
            }
        }
    }
}
