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
    public partial class frm_ListAction : Form
    {
        BUS.HoatDongBus _hoatDongBus = new BUS.HoatDongBus();
        
           
        public frm_ListAction()
        {
            InitializeComponent();
        }
        int index;
        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NewAction frm = new frm_NewAction();
            frm.FormClosed += new FormClosedEventHandler(dongform);
            frm.ShowDialog();
        }
        public void loadAction()
        {
            try
            {
                var datasource = _hoatDongBus.getAllAction( );
                if ( datasource != null )
                {
                    gridControl1.DataSource = datasource;
                }
                else
                {
                    Messeage.error("Không thể tải dữ liệu !");
                }
            }
            catch ( Exception )
            {

            }
        }
        private void frm_ListAction_Load(object sender, EventArgs e)
        {
          loadAction();
          StyleDevxpressGridControl.styleGridControl(gridControl1, gridView1);
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (index >= 0)
                {
                    int idAction = Convert.ToInt32(gridView1.GetRowCellValue(index, "HoatDong_id").ToString());

                    frm_UpdateAction frm = new frm_UpdateAction();
                    frm.FormClosed += new FormClosedEventHandler(dongform);
                    frm.actionId = idAction;
                    frm.ShowDialog();

                    
                }
                else
                {
                    Messeage.error("Vui Lòng Chọn!");
                }
            }
            else
            {
                Messeage.error("Không Có Gì Để Xóa!");
            }

        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (index >=0)
                {
                    Int64 idAction = Convert.ToInt64(gridView1.GetRowCellValue(index, "HoatDong_id").ToString());
                   
                    

                            bool boolCheckDelete = Messeage.info("Bạn Có Muốn Xóa","");

                            if (boolCheckDelete == true)
                            {


                                bool deleteAction = _hoatDongBus.deleteAction(idAction);
                                if (deleteAction == true)
                                {
                                    Messeage.success("Xóa Thành Công!");


                                    loadAction();
                                }
                                else
                                {
                                    Messeage.error("Xóa   Thất Bại!");

                                }
                            }
                }
                else
                  {
                        Messeage.error("Vui Lòng Chọn!");
                 }
            }
            else
            {
                Messeage.error("Không Có Gì Để Xóa!");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.RowCount > 0)
                index = e.FocusedRowHandle;
        }

        private void btn_Refesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadAction();
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void dongform(object sender, EventArgs e)
        {
            loadAction();

        }
    }
}
