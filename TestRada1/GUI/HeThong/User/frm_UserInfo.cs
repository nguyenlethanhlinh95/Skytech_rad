using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraEditors.Mask;
using System.Runtime.Serialization.Formatters.Binary;
using TestRada1.BUS;

namespace TestRada1
{
    public partial class frm_UserInfo : DevExpress.XtraEditors.XtraForm
    {
        public frm_UserInfo( )
        {
            InitializeComponent( );
        }

        DeparmentBus _dep = new DeparmentBus();

        // check neu chinh sua thong tin user
        public Int64 user_id = 0;
        private bool gender = false;
        public bool checkNew = false;
        private Int64 idDeparment = 0;
        private string linkImage = "";


        private void frm_UserInfo_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_Update;
           
            StyleDevxpressGridControl.autoDateEdit(dt_DateOfBirth);
            StyleDevxpressGridControl.autoLookUpEdit(lue_deparment);
            loadDeparment();

            if (checkNew)
            {
                btn_New.Visible = true;
                btn_Update.Visible = false;
                this.AcceptButton = btn_New;
                this.Text = "Thêm Mới Người Dùng";
            }
            else
            {
                btn_New.Visible = false;
                btn_Update.Visible = true;
                this.AcceptButton = btn_Update;
                this.Text = "Chỉnh Sửa Người Dùng";
            }
            //LoadData();           
        }

        #region Load
        private void loadDeparment( )
        {

            try
            {
                var datasource = _dep.listAll( );
                if ( datasource != null )
                {
                    lue_deparment.Properties.DataSource = datasource;
                    lue_deparment.Properties.ValueMember = "department_id";
                    lue_deparment.Properties.DisplayMember = "department_name";
                }
                else
                {
                    Messeage.error("Không thể tải dữ liệu !");
                }
            }
            catch(Exception)
            {
                
            }
        }

        public void LoadData( )
        {
            
        }
        #endregion Load
    }
}