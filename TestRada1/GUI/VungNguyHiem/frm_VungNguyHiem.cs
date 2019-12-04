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
    public partial class frm_VungNguyHiem : Form
    {
        public frm_VungNguyHiem()
        {
            InitializeComponent();
        }
        BUS.VungNguyHiemBus _vungNHBus = new BUS.VungNguyHiemBus();
        private void frm_VungNguyHiem_Load(object sender, EventArgs e)
        {
            cbb_Type.SelectedItem = "Hình Tròn";
        }

        private void cbb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Type.Text == "Hình Tròn")
            {
                txt_BanKinh.Enabled = true;
                txt_1X.Enabled = true;
                txt_1Y.Enabled = true;
                txt_2X.Enabled = false;
                txt_2Y.Enabled = false;
                txt_3X.Enabled = false;
                txt_3Y.Enabled = false;
                txt_4X.Enabled = false;
                txt_4Y.Enabled = false;
            }
            else if (cbb_Type.Text == "Tam Giác")
            {
                txt_BanKinh.Enabled = false;
                txt_1X.Enabled = true;
                txt_1Y.Enabled = true;
                txt_2X.Enabled = true;
                txt_2Y.Enabled = true;
                txt_3X.Enabled = true;
                txt_3Y.Enabled = true;
                txt_4X.Enabled = false;
                txt_4Y.Enabled = false;
            }
            else
            {
                txt_BanKinh.Enabled = false;
                txt_1X.Enabled = true;
                txt_1Y.Enabled = true;
                txt_2X.Enabled = true;
                txt_2Y.Enabled = true;
                txt_3X.Enabled = true;
                txt_3Y.Enabled = true;
                txt_4X.Enabled = true;
                txt_4Y.Enabled = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string checkNull()
        {
            if (cbb_Type.Text == "Hình Tròn")
            {
                if (txt_BanKinh.Text == "")
                {
                    txt_BanKinh.Focus();
                    return "Vui Lòng Nhập Bán Kính!";
                }
                else if (txt_1X.Text == "")
                {
                    txt_1X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 1 X !";
                }
                else if (txt_1Y.Text == "")
                {
                    txt_1Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 1 Y !";
                }
                else
                {
                    return "true";
                }
            }
            else if (cbb_Type.Text == "Tam Giác")
            {
                if (txt_1X.Text == "")
                {
                    txt_1X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 1 X !";
                }
                else if (txt_1Y.Text == "")
                {
                    txt_1Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 1 Y !";
                }
                else if (txt_2X.Text == "")
                {
                    txt_2X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 2 X !";
                }
                else if (txt_2Y.Text == "")
                {
                    txt_2Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 2 Y !";
                }
                else if (txt_3X.Text == "")
                {
                    txt_3X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 3 X !";
                }
                else if (txt_3Y.Text == "")
                {
                    txt_3Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 3 Y !";
                }
                else
                {
                    return "true";
                }
            }
            else
            {
                if (txt_1X.Text == "")
                {
                    txt_1X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 1 X !";
                }
                else if (txt_1Y.Text == "")
                {
                    txt_1Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 1 Y !";
                }
                else if (txt_2X.Text == "")
                {
                    txt_2X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 2 X !";
                }
                else if (txt_2Y.Text == "")
                {
                    txt_2Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 2 Y !";
                }
                else if (txt_3X.Text == "")
                {
                    txt_3X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 3 X !";
                }
                else if (txt_3Y.Text == "")
                {
                    txt_3Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 3 Y !";
                }
                else if (txt_4X.Text == "")
                {
                    txt_4X.Focus();
                    return "Vui Lòng Nhập Tọa Độ 4 X !";
                }
                else if (txt_4Y.Text == "")
                {
                    txt_4Y.Focus();
                    return "Vui Lòng Nhập Tọa Độ 4 Y !";
                }
                else
                {
                    return "true";
                }
            }
        }

        private bool insertVungNguyHiem()
        {
            DTO.ST_VungNguyHiem newVungNguyHiem = new DTO.ST_VungNguyHiem();
            if (cbb_Type.Text == "Hình Tròn")
            {
                newVungNguyHiem.vungNguyHiem_loai = cbb_Type.Text;
                newVungNguyHiem.vungNguyHiem_ban_kinh = Convert.ToInt32(txt_BanKinh.Text);
                newVungNguyHiem.vungNguyHiem_1_X = Convert.ToInt32(txt_1X.Text);
                newVungNguyHiem.vungNguyHiem_1_Y = Convert.ToInt32(txt_1Y.Text);
            }
            else if (cbb_Type.Text == "Tam Giác")
            {
                newVungNguyHiem.vungNguyHiem_loai = cbb_Type.Text;
                newVungNguyHiem.vungNguyHiem_1_X = Convert.ToInt32(txt_1X.Text);
                newVungNguyHiem.vungNguyHiem_1_Y = Convert.ToInt32(txt_1Y.Text);
                newVungNguyHiem.vungNguyHiem_2_X = Convert.ToInt32(txt_2X.Text);
                newVungNguyHiem.vungNguyHiem_2_Y = Convert.ToInt32(txt_2Y.Text);
                newVungNguyHiem.vungNguyHiem_3_X = Convert.ToInt32(txt_3X.Text);
                newVungNguyHiem.vungNguyHiem_3_Y = Convert.ToInt32(txt_3Y.Text);
            }
            else
            {
                newVungNguyHiem.vungNguyHiem_loai = cbb_Type.Text;
                newVungNguyHiem.vungNguyHiem_1_X = Convert.ToInt32(txt_1X.Text);
                newVungNguyHiem.vungNguyHiem_1_Y = Convert.ToInt32(txt_1Y.Text);
                newVungNguyHiem.vungNguyHiem_2_X = Convert.ToInt32(txt_2X.Text);
                newVungNguyHiem.vungNguyHiem_2_Y = Convert.ToInt32(txt_2Y.Text);
                newVungNguyHiem.vungNguyHiem_3_X = Convert.ToInt32(txt_3X.Text);
                newVungNguyHiem.vungNguyHiem_3_Y = Convert.ToInt32(txt_3Y.Text);
                newVungNguyHiem.vungNguyHiem_4_X = Convert.ToInt32(txt_4X.Text);
                newVungNguyHiem.vungNguyHiem_4_Y = Convert.ToInt32(txt_4Y.Text);
            }
            return _vungNHBus.insertVNH(newVungNguyHiem);

        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string check = checkNull();
            if (check == "true")
            {
                if (insertVungNguyHiem() == true)
                {
                    Messeage.themMoiThanhCong();
                    this.Close();
                }
                else
                {
                    Messeage.khongTheThemMoi();
                }
            }
            else
            {
                Messeage.error(check);
            }
        }
    }
}
