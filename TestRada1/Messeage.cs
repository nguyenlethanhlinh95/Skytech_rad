using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.ToastNotifications;

namespace TestRada1
{
    public static class Messeage
    {
        public static void success(string mess)
        {
            XtraMessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        public static void error(string mess)
        {
            XtraMessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void warnning(string mess)
        {
            XtraMessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool info(string mess, string name)
        {
            
            DialogResult dialogResult = XtraMessageBox.Show(mess + name, "Thông Báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void err()
        {
            XtraMessageBox.Show("Chương trình bị lỗi, hãy kiểm tra lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void capNhatThanhCong()
        {
            XtraMessageBox.Show("Cập Nhật Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void khongTheCapNhat( )
        {
            XtraMessageBox.Show("Không Thể Cập Nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void themMoiThanhCong( )
        {
            XtraMessageBox.Show("Thêm Mới Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void khongTheThemMoi( )
        {
            XtraMessageBox.Show("Không Thể Thêm Mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void xoaThanhCong( )
        {
            XtraMessageBox.Show("Xóa Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void khongTheXoa( )
        {
            XtraMessageBox.Show("Không Thể Xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       


        //public static thongBaoHangMuc()
        //{
        
        //}

        public static void thongBaoCongTrinh(ToastNotificationsManager toast, string mess1, string mess2)
        {
            var note = new ToastNotification("Nhắc nhở", null, "Thông báo", mess1, mess2, ToastNotificationTemplate.Text04);

        
            toast.Notifications.Add(note);
            toast.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.True;
            toast.ShowNotification(toast.Notifications[0]);
        }


    }
}
