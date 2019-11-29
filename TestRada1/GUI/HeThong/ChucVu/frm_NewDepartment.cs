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
using TestRada1.DTO;

namespace TestRada1
{
    public partial class frm_Newdepartment : DevExpress.XtraEditors.XtraForm
    {
        public frm_Newdepartment( )
        {
            InitializeComponent( );
        }

        DeparmentBus depBus = new DeparmentBus();
        public Int64 id = 0;
        public bool checkNew = true;

        private void btn_New_Click(object sender, EventArgs e)
        {
            if ( txt_deparment.Text != "" )
            {
                ST_Department newDp = new ST_Department();
                newDp.department_name = txt_deparment.Text;
                bool status = depBus.insertDepartment(newDp);

                if ( status )
                {
                    Messeage.themMoiThanhCong();

                    this.Close( );
                }
                else
                {
                    Messeage.khongTheThemMoi();
                }
            }
            else
            {
                XtraMessageBox.Show("Dữ liệu trống?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frm_Newdepartment_Load(object sender, EventArgs e)
        {
            try
            {
                if ( checkNew )
                {
                    btn_New.Visible = true;
                    btn_Update.Visible = false;
                    this.AcceptButton = btn_New;
                    this.Text = "Thêm Mới Chức Vụ";
                }
                else
                {
                    btn_New.Visible = false;
                    btn_Update.Visible = true;
                    LoadChucVu( );
                    this.AcceptButton = btn_Update;
                    this.Text = "Chỉnh Sửa Chức Vụ";
                }
            }
            catch(Exception)
            {
                Messeage.err();
            }           
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close( );
        }


        private void LoadChucVu()
        {
            try{
                var department = depBus.getDepartment(id);
                if ( department != null )
                {
                    var propertyName = department.GetType( ).GetProperty("department_name").GetValue(department, null);
                    var pro = (propertyName == null) ? "" : propertyName.ToString( );


                    txt_deparment.Text = pro;
                }
                else
                {
                    Messeage.error("Có lỗi, hãy kiểm tra lại !");
                }
            }
            catch(Exception)
            {
                Messeage.err();
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                ST_Department dep = new ST_Department();

                if ( txt_deparment.Text != "" )
                {
                    dep.department_name = txt_deparment.Text;
                    dep.department_id = id;
                    dep.user_created = frm_Main.Vitual_id;

                    bool bUpdate = depBus.update(dep);
                    if ( bUpdate )
                    {
                        Messeage.capNhatThanhCong( );
                        this.Close( );
                    }
                    else
                    {
                        Messeage.khongTheCapNhat( );
                    }
                }
                else
                {
                    Messeage.error("Bạn Chưa nhập Tên Chức Vụ");
                }  
            }
            catch(Exception)
            {
                Messeage.err();
            }
        }




 
    }
}