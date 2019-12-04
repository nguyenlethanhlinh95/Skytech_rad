using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils.Taskbar.Core;
using System.Data.SqlClient;
using DevExpress.UserSkins;
using System.IO;
using System.Threading.Tasks;
using DevExpress.XtraBars.ToastNotifications;

namespace TestRada1
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string Vitual_Username;
        public static Int64 Vitual_id = 0;
        public static string Vitual_Chinhanh;
        public static Int64 Vitual_Quyen;
        private Form kiemtraform(Type ftype)
        {
            foreach ( Form f in this.MdiChildren )
            {
                if ( f.GetType( ) == ftype )
                {
                    return f;
                }
            }
            return null;
        }
        public frm_Main()
        {
            InitializeComponent();

            // The following line provides localization for the application's user interface.  
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("vi");

            // The following line provides localization for data formats.  
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("vi-VN");    

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register( );
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem2, true);

            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, SkinSvgPalette.Bezier.OfficeColorful);

            taskbarAssistant1.ProgressMode = TaskbarButtonProgressMode.Indeterminate;
            taskbarAssistant1.ProgressCurrentValue = 100;


            load_login( );
        }

        private void load_login( )
        {
            btnUserInformation.Visibility = BarItemVisibility.Never;
            btnPermission.Visibility = BarItemVisibility.Never;
            btnRegistered.Visibility = BarItemVisibility.Never;
            ribbonPageGroup11.Visible = false;

            ribbonPage1.Visible = false;
            ribbonPage9.Visible = false;
            ribbonPage8.Visible = false;
            ribbonPage2.Visible = false;
            ribbonPageGroup25.Visible = false;
            LoginEvent( );
        }

        private void LoginEvent( )
        {
            foreach ( Form childForm in MdiChildren )
            {
                childForm.Close( );
            }
            frm_DangNhap log = new frm_DangNhap( );
            if ( log.ShowDialog( ) == DialogResult.OK )
            {
                try
                {
                    //xử lí sự kiện đăng nhập thành công
                    // quyen 1 admin
                    if ( Vitual_Quyen == 1 )
                    {
                        barButtonItem_login.Visibility = BarItemVisibility.Never;
                        Menu_adminstrator_true( );
                    }
                    else
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra khi thao tác với CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void Menu_adminstrator_true( )
        {
            btnUserInformation.Visibility = BarItemVisibility.Always;
            btnPermission.Visibility = BarItemVisibility.Always;
            btnRegistered.Visibility = BarItemVisibility.Always;
            ribbonPageGroup25.Visible = true;
            ribbonPageGroup11.Visible = true;

            barButtonItem1_DangXuat.Visibility = BarItemVisibility.Always;

            ribbonPage1.Visible = true;
            ribbonPage9.Visible = true;
            ribbonPage8.Visible = true;
            ribbonPage2.Visible = true;
        }

        void Menu_HocVien_true()
        {
            btnUserInformation.Visibility = BarItemVisibility.Always;
            btnPermission.Visibility = BarItemVisibility.Always;
            btnRegistered.Visibility = BarItemVisibility.Always;
            ribbonPageGroup11.Visible = true;

            barButtonItem1_DangXuat.Visibility = BarItemVisibility.Always;

            ribbonPage9.Visible = true;
            ribbonPage8.Visible = true;
        }

        private void barButtonItem_login_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap( );
            frm.ShowDialog( );
        }

        private void btnUserInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_UpdateUser));
            if ( frm == null )
            {
                frm_UpdateUser forms = new frm_UpdateUser( );
                forms.MdiParent = this;
                forms.userId = frm_Main.Vitual_id;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

        private void btnBar_ChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_UserInfo));
            if ( frm == null )
            {
                frm_ChucVu forms = new frm_ChucVu( );
                forms.MdiParent = this;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

        private void btnRegistered_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_NewUser));
            if ( frm == null )
            {
                frm_NewUser forms = new frm_NewUser( );
                forms.MdiParent = this;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_User));
            if ( frm == null )
            {
                frm_User forms = new frm_User( );
                forms.MdiParent = this;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_RePassword));
            if ( frm == null )
            {
                frm_RePassword forms = new frm_RePassword( );
                forms.MdiParent = this;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

        private void barButtonItem1_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ( Messeage.info("Bạn có muốn thoát", "") )
            {
                this.Close( );
            }
        }

        private void barBtn_rada_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form frm = kiemtraform(typeof(frm_rada5));
            //if ( frm == null )
            //{
            //    frm_rada5 forms = new frm_rada5( );
            //    forms.MdiParent = this;
            //    forms.Show( );
            //}
            //else
            //{
            //    frm.Activate( );
            //}

            frm_rada5 forms = new frm_rada5( );
            forms.ShowDialog( );
        }

        private void barBtnCaiDat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(Pref));
            if ( frm == null )
            {
                Pref forms = new Pref( );
                forms.MdiParent = this;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

        private void barBtn_VatThe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_VatThes));
            if ( frm == null )
            {
                frm_VatThes forms = new frm_VatThes( );
                forms.MdiParent = this;
                forms.Show( );
            }
            else
            {
                frm.Activate( );
            }
        }

    }
}