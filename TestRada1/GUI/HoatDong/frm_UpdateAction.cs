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
    public partial class frm_UpdateAction : Form
    {
        public int actionId { get; set; }
        BUS.HoatDongBus _hoatDongBus = new BUS.HoatDongBus();
        BUS.VatTheBus _vatTheBus = new BUS.VatTheBus();
        public frm_UpdateAction()
        {
            InitializeComponent();
        }

        public string checkNull()
        {
            if (txt_XStart.Text == "")
            {
                txt_XStart.Focus();
                return "Vui Lòng Nhập Tọa Độ Bắt Đầu X!";
            }
            else if (txt_YStart.Text == "")
            {
                txt_YStart.Focus();
                return "Vui Lòng Nhập Tọa Độ Bắt Đầu Y!";
            }
            else if (txt_XEnd.Text == "")
            {
                txt_XEnd.Focus();
                return "Vui Lòng Nhập Tọa Độ Kết Thúc X!";
            }
            else if (txt_YEnd.Text == "")
            {
                txt_YEnd.Focus();
                return "Vui Lòng Nhập Tọa Độ Kết Thúc Y!";
            }
            else if (txt_BuocNhay.Text == "")
            {
                txt_BuocNhay.Focus();
                return "Vui Lòng Nhập Số Bước Nhảy!";
            }
            else if (txt_TimeStart.Text == "")
            {
                txt_TimeStart.Focus();
                return "Vui Lòng Nhập Thời Gian Bắt Đầu!";
            }
            else
            {
                return "true";
            }
        }

        public bool updateAction()
        {
            DTO.ST_HoatDong _updateAction = new DTO.ST_HoatDong();
            _updateAction.HoatDong_id = actionId;
            _updateAction.HoatDong_soBuocNhay = Convert.ToInt32(txt_BuocNhay.Text);
            _updateAction.HoatDong_xBatDau = Convert.ToInt32(txt_XStart.Text);
            _updateAction.HoatDong_yBatDau = Convert.ToInt32(txt_YStart.Text);
            _updateAction.HoatDong_xKetThuc = Convert.ToInt32(txt_XEnd.Text);
            _updateAction.HoatDong_yKetThuc = Convert.ToInt32(txt_YEnd.Text);


            try
            {
                DateTime now = DateTime.Now;
                DateTime timeNow = now.AddSeconds(Convert.ToInt32(txt_TimeStart.Text));
                _updateAction.HoatDong_thoiGianBatDauChay = timeNow;
            }
            catch (Exception)
            {
                _updateAction.HoatDong_thoiGianBatDauChay = Convert.ToDateTime(txt_TimeStart.Text);
            }
            return _hoatDongBus.updateAction(_updateAction);
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string checkNull1 = checkNull();
                if (checkNull1 == "true")
                {

                    bool boolUpdateProgress = updateAction();
                    if (boolUpdateProgress == true)
                    {
                        Messeage.success("Cập Nhật Thành Công!");
                        this.Close();
                    }
                    else
                    {
                        Messeage.error("Không Thể Cập Nhật!");
                    }


                }
                else
                {
                    Messeage.error(checkNull1);
                }

            }
            catch (Exception)
            {
                Messeage.err();
            }

        }
        string time = "";
        public void loadAction()
        {
           
            try
            {
                var data = _hoatDongBus.getAction(actionId);

                var vatThe = data.GetType().GetProperty("vatThe_id").GetValue(data, null);
                if (vatThe != "")
                    lke_VaThe.EditValue = vatThe.ToString();

                var HoatDong_xBatDau = data.GetType().GetProperty("HoatDong_xBatDau").GetValue(data, null);
                if (HoatDong_xBatDau != "")
                    txt_XStart.Text = HoatDong_xBatDau.ToString();

                var HoatDong_yBatDau = data.GetType().GetProperty("HoatDong_yBatDau").GetValue(data, null);
                if (HoatDong_yBatDau != "")
                    txt_YStart.Text = HoatDong_yBatDau.ToString();


                var HoatDong_xKetThuc = data.GetType().GetProperty("HoatDong_xKetThuc").GetValue(data, null);
                if (HoatDong_xKetThuc != "")
                    txt_XEnd.Text = HoatDong_xKetThuc.ToString();




                var HoatDong_yKetThuc = data.GetType().GetProperty("HoatDong_yKetThuc").GetValue(data, null);
                if (HoatDong_yKetThuc != "")
                    txt_YEnd.Text = HoatDong_yKetThuc.ToString();

                var HoatDong_soBuocNhay = data.GetType().GetProperty("HoatDong_soBuocNhay").GetValue(data, null);
                if (HoatDong_soBuocNhay != "")
                    txt_BuocNhay.Text = HoatDong_soBuocNhay.ToString();

                var HoatDong_thoiGianBatDauChay = data.GetType().GetProperty("HoatDong_thoiGianBatDauChay").GetValue(data, null);
                if (HoatDong_thoiGianBatDauChay != null)
                {
                     txt_TimeStart.EditValue = HoatDong_thoiGianBatDauChay.ToString();

                     time = HoatDong_thoiGianBatDauChay.ToString();
                }
               
            }
            catch (Exception)
            {
                Messeage.error("Lỗi !");
            }
        }
        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_UpdateAction_Load(object sender, EventArgs e)
        {
            loadAction();
            loadVatThe();
        }
        public void loadVatThe()
        {
            lke_VaThe.Properties.ValueMember="vatThe_id";
            lke_VaThe.Properties.DisplayMember="vatThe_name";
            lke_VaThe.Properties.DataSource = _vatTheBus.getAll();
                
        }

        private void txt_TimeStart_MouseClick(object sender, MouseEventArgs e)
        {
           // txt_TimeStart.Text = "";
        }

        
        private void txt_TimeStart_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_TimeStart.Text == "")
                txt_TimeStart.Text = time;
        }

        private void btn_AddBuildingContractor_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
