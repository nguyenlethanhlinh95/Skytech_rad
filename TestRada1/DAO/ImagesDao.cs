using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRada1.DAO
{
    class ImagesDao
    {
        DTO.DataClasses1DataContext db = new DTO.DataClasses1DataContext();
        public bool insertImg(DTO.ST_Image img)
        {
            try
            {
                db.ST_Images.InsertOnSubmit(img);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Object> getAllImage()
        {
            try
            {
                db.Dispose();
                db = new DTO.DataClasses1DataContext();
                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                var data = from t1 in db.ST_Images
                           select t1;
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
