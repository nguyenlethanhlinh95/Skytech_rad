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
    public partial class frm_DanhSachBanDo : DevExpress.XtraEditors.XtraForm
    {
        public frm_DanhSachBanDo( )
        {
            InitializeComponent( );
        }
        int index;
        BanDoBus _banDo = new BanDoBus();

        private void frm_DanhSachBanDo_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.styleGridControl(grdc_BanDo, grdv_BanDo);
            loadGridViewBanDo( );
        }

        private void loadGridViewBanDo()
        {
            var datasource = _banDo.getAll( );
            if ( datasource != null )
            {
                grdc_BanDo.DataSource = datasource;
            }
            else
            {
                Messeage.error("Không thể tải dữ liệu !");
            }
        }

        /// <summary>
        /// Them Moi Ban Do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_AddNewBanDo frm = new frm_AddNewBanDo( );
            frm.FormClosed += new FormClosedEventHandler(dongform);
            frm.ShowDialog( );
        }

        /// <summary>
        /// Dong form, load lai form
        /// </summary>
        private void dongform(object sender, EventArgs e)
        {
            loadGridViewBanDo();
        }

        /// <summary>
        /// lay chi so row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdv_BanDo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( grdv_BanDo.RowCount > 0 )
            {
                if ( index >= 0 )
                {
                    frm_AddNewBanDo frm = new frm_AddNewBanDo( );
                    frm.FormClosed += new FormClosedEventHandler(dongform);
                    frm.id = Convert.ToInt64(grdv_BanDo.GetRowCellValue(index, "bando_id").ToString( ));
                    frm.ShowDialog( );
                }
                else
                {
                    Messeage.error("Bạn Hãy Chọn Bản Đồ!");
                }
            }
            else
            {
                Messeage.error("Không Có Bản Đồ");
            }
        }

        /// <summary>
        /// Xoa ban do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if ( grdv_BanDo.RowCount > 0 )
            //{
            //    if ( index >= 0 )
            //    {
            //        Int64 unitId = Convert.ToInt64(grdv_BanDo.GetRowCellValue(index, "unit_id").ToString( ));
            //        string unitName = grdv_BanDo.GetRowCellValue(index, "unit_name").ToString( );

            //        bool boolCheckDelete = Messeage.info("Bạn Có Muốn Xóa Tên Đơn Vị Này '", unitName);

            //        if ( boolCheckDelete == true )
            //        {
            //            bool boolDeleteBuildContractor = _unitBus.deleteVendor(unitId);
            //            if ( boolDeleteBuildContractor == true )
            //            {
            //                Messeage.success("Xóa Tên Đơn Vị Thành Công!");

            //                loadGridViewBanDo();
            //            }
            //            else
            //            {
            //                Messeage.error("Xóa Đơn Vị Thất Bại!");

            //            }
            //        }
            //    }
            //    else
            //    {
            //        Messeage.error("Bạn Hãy Chọn Đơn Vị Tính");
            //    }
            //}
            //else
            //{
            //    Messeage.error("Không Có Gì Để Xóa!!");
            //}
        }
    }
}