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
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frm_DangNhap( )
        {
            InitializeComponent( );
        }

        UserBus _userBus = new UserBus();

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string isCheck = checkNull( );
                if ( isCheck == "true" )
                {
                    Int64 IntCheckLogin = _userBus.CheckLogin(txt_UserName.Text, txt_PassWord.Text);

                    if ( IntCheckLogin > 0 )
                    {
                        var user = _userBus.getUserById(IntCheckLogin);

                        // check quyen
                        var Quyen = user.GetType( ).GetProperty("role_id").GetValue(user, null);
                        var Vitual_Quyen = (Quyen == null) ? 0 : Int64.Parse(Quyen.ToString( ));

                        frm_Main.Vitual_Username = txt_UserName.Text;
                        frm_Main.Vitual_Quyen = Vitual_Quyen;
                        frm_Main.Vitual_id = IntCheckLogin;

                        Messeage.success("Đăng nhập thành công!");

                        this.DialogResult = DialogResult.OK;
                        this.Close( );
                    }
                    else
                    {
                        Messeage.error("Tên đăng nhập hoặc mật khẩu không đúng!");
                    }
                }
                else
                {
                    Messeage.error(isCheck);
                }
            }
            catch(Exception)
            {
                Messeage.err();
            }
            
        }

        private string checkNull()
        {
            if ( txt_UserName.Text == "" )
            {
                txt_UserName.Focus( );
                return "Vui Lòng Nhập Tên Đăng Nhập";
            }
            else if ( txt_PassWord.Text == "" )
            {
                txt_PassWord.Focus( );
                return "Vui Lòng Nhập Mật Khẩu";
            }
            else
            {
                return "true";
            }

        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login;
        }
        

    }
}