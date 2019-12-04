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
    public partial class frm_updateVungNguyHiem : Form
    {
        public Int64 vungNguyHiemId { get; set; }
        BUS.VungNguyHiemBus _vungNguyHiemBus = new BUS.VungNguyHiemBus();
        public frm_updateVungNguyHiem()
        {
            InitializeComponent();
        }


        public void loadVNH()
        {
            var data = _vungNguyHiemBus.getVNHShow(vungNguyHiemId);
            cbb_Type.SelectedItem = data.GetType().GetProperty("vungNguyHiem_loai").GetValue(data, null).ToString();
            var bankinh = data.GetType().GetProperty("vungNguyHiem_ban_kinh").GetValue(data, null);
            if (bankinh != null)
                txt_BanKinh.Text = bankinh.ToString();

            var X1 = data.GetType().GetProperty("vungNguyHiem_1_X").GetValue(data, null);
            if (X1 != null)
                txt_1X.Text = X1.ToString();
            var Y1 = data.GetType().GetProperty("vungNguyHiem_1_Y").GetValue(data, null);
            if (Y1 != null)
                txt_1Y.Text = Y1.ToString();
            var X2 = data.GetType().GetProperty("vungNguyHiem_2_X").GetValue(data, null);
            if (X2 != null)
                txt_2X.Text = X2.ToString();
            var Y2 = data.GetType().GetProperty("vungNguyHiem_2_Y").GetValue(data, null);
            if (Y2 != null)
                txt_2Y.Text = Y2.ToString();
            var X3 = data.GetType().GetProperty("vungNguyHiem_3_X").GetValue(data, null);
            if (X3 != null)
                txt_3X.Text = X3.ToString();
            var Y3 = data.GetType().GetProperty("vungNguyHiem_3_Y").GetValue(data, null);
            if (Y3 != null)
                txt_3Y.Text = Y3.ToString();
            var X4 = data.GetType().GetProperty("vungNguyHiem_4_X").GetValue(data, null);
            if (X4 != null)
                txt_4X.Text = X4.ToString();
            var Y4 = data.GetType().GetProperty("vungNguyHiem_4_Y").GetValue(data, null);
            if (Y4 != null)
                txt_4Y.Text = Y4.ToString();

        }
        private void frm_updateVungNguyHiem_Load(object sender, EventArgs e)
        {
            loadVNH();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool updateVNH()
        {
            DTO.ST_VungNguyHiem newVungNguyHiem = new DTO.ST_VungNguyHiem();
            newVungNguyHiem.vungNguyHiem_id = vungNguyHiemId;
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
            return _vungNguyHiemBus.updateVNH(newVungNguyHiem);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string check = checkNull();
            if (check == "true")
            {
                if (updateVNH() == true)
                {
                    Messeage.capNhatThanhCong();
                }
                else
                {
                    Messeage.khongTheCapNhat();
                }
            }
            else
            {
                Messeage.error(check);
            }
        }
    }
}
