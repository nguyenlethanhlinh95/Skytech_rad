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

        public bool insert(DTO.ST_BanDo bd)
        {
            try
            {
                db.ST_BanDos.InsertOnSubmit(bd);
                db.SubmitChanges( );
                return true;
            }
            catch ( Exception )
            {
                return false;
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
    }
}
