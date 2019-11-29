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
    public partial class frm_RePassword : DevExpress.XtraEditors.XtraForm
    {
        public frm_RePassword( )
        {
            InitializeComponent( );
        }

        UserBus userBus = new UserBus( );


        private void frm_RePassword_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_Update;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try{
                var oldPass = txt_OldPass.Text;
                var NewPass = txt_OldPass.Text;
                var RePass = txt_ReNewPass.Text;

                var check = checkNull( );
                if ( check == "true" )
                {
                    var id = frm_Main.Vitual_id;
                    var user = userBus.getUserById(id);

                    var pass = user.GetType( ).GetProperty("user_password").GetValue(user, null);
                    var passString = (pass == null) ? "" : pass.ToString( );

                    if ( oldPass == passString )
                    {
                        if ( userBus.updatePassword(RePass, id) )
                        {
                            Messeage.capNhatThanhCong( );
                        }
                        else
                        {
                            Messeage.khongTheCapNhat( );
                        }
                    }
                    else
                    {
                        Messeage.error("Mật Khẩu Cũ Không đúng !");

                    }
                }
                else
                {
                    Messeage.error(check);
                }
            }
            catch(Exception)
            {
                Messeage.err();
            }
            
        }


        private string checkNull( )
        {
            if ( txt_OldPass.Text == "" )
            {
                txt_OldPass.Focus( );
                return "Vui Lòng Mật Khẩu";
            }
            else if ( txt_NewPass.Text == "" )
            {
                txt_NewPass.Focus( );
                return "Vui Lòng Nhập Mật Khẩu Mới";
            }
            else if ( txt_ReNewPass.Text == "" )
            {
                txt_ReNewPass.Focus( );
                return "Vui Lòng Nhập Lại Mật Khẩu Mới";
            }
            else if (txt_NewPass.Text != txt_ReNewPass.Text)
            {
                txt_ReNewPass.Focus( );
                return "Mật Khẩu Mới và Nhập Lại Mật Khẩu Mới Không Trùng Nhau";
            }          
            else
            {
                return "true";
            }

        }


        
    }
}