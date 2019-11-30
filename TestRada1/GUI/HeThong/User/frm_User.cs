using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestRada1.DTO;
using TestRada1.DAO;


namespace TestRada1
{
    public partial class frm_User : DevExpress.XtraEditors.XtraForm
    {
        public frm_User( )
        {
            InitializeComponent( );
        }
        DataClasses1DataContext db = new DataClasses1DataContext( );

        UserDao _user = new UserDao();
        public int index;

        #region KhoiTao
        private void frm_User_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.styleGridControl(grdc_user, grdv_user);
            LoadEmployee( );
        }

        private void LoadEmployee( )
        {
            var datasource = _user.getAllUser( );
            if ( datasource == null )
            {
                Messeage.error("Không thể load dữ liệu");
            }
            else
            {
                grdc_user.DataSource = datasource;
            }

        }
        #endregion End KhoiTao

        #region Event
        private void dongformEmployee(object sender, EventArgs e)
        {
            LoadEmployee( );
        }

        #endregion EndEvent

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NewUser frm = new frm_NewUser( );
            frm.FormClosed += new FormClosedEventHandler(dongformEmployee);
            frm.Show( );
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if ( grdv_user.RowCount > 0 )
                {
                    if ( index >= 0 )
                    {
                        frm_UpdateUser frm = new frm_UpdateUser( );
                        frm.FormClosed += new FormClosedEventHandler(dongformEmployee);

                        frm.userId = Convert.ToInt32(grdv_user.GetRowCellValue(index, "user_id").ToString( ));       

                        frm.ShowDialog( );
                    }
                    else
                    {
                        Messeage.error("Bạn Hãy Chọn Nguời Dùng!");
                    }
                }
            }
            catch ( Exception )
            {
                Messeage.err( );
            }
        }

        private void grdv_user_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( grdv_user.RowCount > 0 )
            {
                if ( index >= 0 )
                {
                    Int64 id = Convert.ToInt64(grdv_user.GetRowCellValue(index, "user_id").ToString( ));
                    string Name = grdv_user.GetRowCellValue(index, "user_name").ToString( );

                    bool boolCheckDelete = Messeage.info("Bạn Có Muốn Xóa Người Dùng Thể Này '", Name);

                    if ( boolCheckDelete == true )
                    {
                        bool boolDelete = _user.delete(id);
                        if ( boolDelete == true )
                        {
                            Messeage.xoaThanhCong( );

                            LoadEmployee( );
                        }
                        else
                        {
                            Messeage.khongTheXoa( );

                        }
                    }
                }
                else
                {
                    Messeage.error("Bạn Hãy Chọn Đơn Vật Thể");
                }
            }
            else
            {
                Messeage.err( );
            }
        }
    }
}