using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRada1
{
    public partial class frm_ListVungNguyHiem : Form
    {
        BUS.VungNguyHiemBus _vungNHBus = new BUS.VungNguyHiemBus();
        int index;
        public frm_ListVungNguyHiem()
        {
            InitializeComponent();
        }
        private void loadVNH()
        {
            grdc_VNH.DataSource = _vungNHBus.getAllVNHShow();
        }
        private void frm_ListVungNguyHiem_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.styleGridControl(grdc_VNH, grdv_VNH);
            loadVNH();
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_VungNguyHiem frm = new frm_VungNguyHiem();
            frm.FormClosed += new FormClosedEventHandler(dongform);
            frm.ShowDialog();
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Refesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grdv_VNH.ClearColumnsFilter();
            loadVNH();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grdv_VNH.RowCount > 0)
            {
                if (index >= 0)
                {
                    int vungNHId = Convert.ToInt32(grdv_VNH.GetRowCellValue(index, "vungNguyHiem_id").ToString());
                   
                    bool isDelete = Messeage.info("Bạn Có Muốn Xóa?","" );
                    if (isDelete == true)
                    {
                        bool isDeleteSuccess = _vungNHBus.deleteVNH(vungNHId);
                        if (isDeleteSuccess == true)
                        {
                            Messeage.xoaThanhCong();
                        }
                        else
                        {
                            Messeage.khongTheXoa();
                        }
                    }
                }
                else
                {
                    Messeage.error("Vui Lòng Chọn Dữ Liệu!");
                }
            }
            else
            {
                Messeage.error("Không Có Gì Để Xóa!");
            }
        }

        private void grdv_VNH_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdv_VNH.RowCount > 0)
                index = e.FocusedRowHandle;
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grdv_VNH.RowCount > 0)
            {
                if (index >= 0)
                {
                    int vungNHId = Convert.ToInt32(grdv_VNH.GetRowCellValue(index, "vungNguyHiem_id").ToString());
                    frm_updateVungNguyHiem frm = new frm_updateVungNguyHiem();
                    frm.FormClosed += new FormClosedEventHandler(dongform);
                    frm.vungNguyHiemId = vungNHId;
                    frm.ShowDialog();
                }
                else
                {
                    Messeage.error("Vui Lòng Chọn Dữ Liệu!");
                }
            }
            else
            {
                Messeage.error("Không Có Gì Để Chỉnh Sửa!");
            }
        }

        private void dongform(object sender, EventArgs e)
        {
            loadVNH();

        }
        
    }
}
