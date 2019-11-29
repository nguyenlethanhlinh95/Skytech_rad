using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestRada1.BUS;

namespace TestRada1
{
    public partial class frm_ChucVu : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChucVu( )
        {
            InitializeComponent( );
        }

        DeparmentBus _dep = new DeparmentBus( );

        public int index;

        #region Load
        private void frm_ChucVu_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.styleGridControl(grdc_ChucVu, grdv_ChucVu);

            LoadDepartment();
        }

        private void LoadDepartment( )
        {

            var datasource = _dep.listAll( );
            if ( datasource == null )
            {
                Messeage.error("Không thể load dữ liệu");
            }
            else
            {
                grdc_ChucVu.DataSource = datasource;
            }

        }
        #endregion Load


        #region Event
        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Newdepartment frm = new frm_Newdepartment( );
            frm.FormClosed += new FormClosedEventHandler(dongform);
            frm.Show( );
        }

        private void dongform(object sender, EventArgs e)
        {
            LoadDepartment( );

        }

        #endregion EndEvent

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if ( grdv_ChucVu.RowCount > 0 )
                {
                    if (index >= 0)
                    {
                        frm_Newdepartment frm = new frm_Newdepartment( );
                        frm.FormClosed += new FormClosedEventHandler(dongform);

                        frm.id = Convert.ToInt64(grdv_ChucVu.GetRowCellValue(index, "department_id").ToString( ));
                        frm.checkNew = false;

                        frm.ShowDialog( );
                    }
                    else
                    {
                        Messeage.error("Bạn Hãy Chọn Chức Vụ!");
                    }
                }
            }
            catch(Exception)
            {
                Messeage.err();
            }
            
        }

        private void grdv_ChucVu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }
    }
}