using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestRada1.DTO;

namespace TestRada1.DAO
{
    public class RadaDao
    {
        DataClasses1DataContext db = new DataClasses1DataContext( );

        public bool insert(DTO.ST_RaDa rd)
        {
            try
            {
                db.ST_RaDas.InsertOnSubmit(rd);
                db.SubmitChanges( );
                return true;
            }
            catch ( Exception )
            {
                return false;
            }
        }


        public bool update(DTO.ST_RaDa rd)
        {
            try
            {
                var updateRD = db.ST_RaDas.Where(p => p.rada_id.Equals(rd.rada_id)).SingleOrDefault( );

                updateRD.rada_x = rd.rada_x;
                updateRD.rada_y = rd.rada_y;
                updateRD.rada_name = rd.rada_name;
             
                db.SubmitChanges( );
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool isCheckRada( )
        {
            try
            {
                int countRaDa = db.ST_RaDas.Count( );
                if ( countRaDa > 0 )
                {
                    return true;
                }
                return false;
            }
            catch ( Exception )
            {
                return false;
            }
        }

        public Object getRaDa(Int64 idBanDo)
        {
            try
            {
                var raDa = (from b in db.ST_RaDas
                            where b.bando_id == idBanDo
                             select b
                            ).First( );
                return raDa;
            }
            catch ( Exception )
            {
                return null;
            }
        }


        public bool delete(Int64 id, Int64 idBanDo)
        {
            try
            {
                var delete = (from b in db.ST_RaDas
                            where b.bando_id == idBanDo && b.rada_id == id
                            select b).Single();

                db.ST_RaDas.DeleteOnSubmit(delete);
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
