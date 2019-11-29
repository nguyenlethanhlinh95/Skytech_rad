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
using TestRada1.DTO;
using TestRada1.BUS;

namespace TestRada1
{
    public partial class frm_AddNewVatThe : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddNewVatThe( )
        {
            InitializeComponent( );
        }

        public bool checkNew = true;
        public Int32 idVatThe = 0;

        VatTheBus _vtBus = new VatTheBus();
        private string linkImage = "";

        // add new
        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                string check = checkNull( );
                if ( check == "true" )
                {
                    ST_VatThe vt = new ST_VatThe();
                    vt.vatThe_name = txt_name.Text;
                    vt.vatThe_mau = ced_Mau.Text.ToString();

                    byte[] fileByte = converImageToBirany(pic_Logo.Image);
                    System.Data.Linq.Binary fileBinary = new System.Data.Linq.Binary(fileByte);
                    vt.vatThe_hinhAnh = fileBinary;

                    bool isInsert = _vtBus.insert(vt);

                    if (isInsert)
                    {
                        Messeage.success("Thêm mới thành công !");
                        resetForm( );
                    }
                    else
                    {
                        Messeage.error("Thêm mới thất bại !");
                        resetForm( );
                    }
                }
                else
                {
                    Messeage.error(check);
                }
            }
            catch(Exception)
            {
                Messeage.error("Có lỗi ! Hãy kiểm tra lại");
            }
        }

        // update
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string checkNull1 = checkNull( );
                if ( checkNull1 == "true" )
                {

                    bool boolUpdateVatThe = updateVatThe( );
                    if ( boolUpdateVatThe == true )
                    {
                        Messeage.capNhatThanhCong();
                        this.Close( );
                    }
                    else
                    {
                        Messeage.khongTheCapNhat();
                    }
                }
                else
                {
                    Messeage.error(checkNull1);
                }

            }
            catch ( Exception )
            {
                Messeage.err( );
            }
        }

        private bool updateVatThe( )
        {
            DTO.ST_VatThe vatthe = new DTO.ST_VatThe( );
            vatthe.vatThe_id = idVatThe;
            vatthe.vatThe_name = txt_name.Text;
            vatthe.vatThe_mau = ced_Mau.Text;

            byte[] fileByte = converImageToBirany(pic_Logo.Image);
            System.Data.Linq.Binary fileBinary = new System.Data.Linq.Binary(fileByte);
            vatthe.vatThe_hinhAnh = fileBinary;

            return _vtBus.update(vatthe);
        }

        private string checkNull()
        {
            if ( txt_name.Text == "" )
            {
                txt_name.Focus( );
                return "Vui Lòng Nhập Tên Vật Thể";
            }
            else if ( ced_Mau.Text == "" )
            {
                ced_Mau.Focus( );
                return "Vui Lòng Chọn Màu";
            }

            else if ( pic_Logo.Image == null )
            {
                return "Vui Lòng Chọn Hình Ảnh Vật Thể";
            }
         
            else
            {
                return "true";
            }

        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog( );
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";

            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if ( openFile.ShowDialog( ) == DialogResult.OK )
            {
                linkImage = openFile.FileName;
                pic_Logo.Image = Image.FromFile(linkImage);

            }   
        }

        private void resetForm()
        {
            txt_name.Text = "";
            ced_Mau.EditValue = "";
            linkImage = "";
            pic_Logo.Image = null;
        }
        //ảnh -> byte[]
        byte[] converImageToBirany(Image img)
        {
            using ( MemoryStream ms = new MemoryStream( ) )
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray( );
            }
        }

        private void frm_AddNewVatThe_Load(object sender, EventArgs e)
        {
            try
            {
                if ( checkNew )
                {
                    btn_New.Visible = true;
                    btn_Update.Visible = false;
                }
                else
                {
                    btn_New.Visible = false;
                    btn_Update.Visible = true;

                    loadVatThe( );
                }
            }
            catch(Exception)
            {
                Messeage.err();
            }
            
        }

        // load vat the Khi edit
        private void loadVatThe()
        {
            if ( idVatThe != 0)
            {
                var VatThe = _vtBus.getDetail(idVatThe);

                var Name = VatThe.GetType( ).GetProperty("vatThe_name").GetValue(VatThe, null);
                txt_name.Text = (Name == null) ? "" : Name.ToString( );

                var mau = VatThe.GetType( ).GetProperty("vatThe_mau").GetValue(VatThe, null);
                ced_Mau.Text = (mau == null) ? "" : mau.ToString( );

                

                //hien thi hinh anh
                var hinhAnh = VatThe.GetType( ).GetProperty("vatThe_hinhAnh").GetValue(VatThe, null);
                if ( hinhAnh != null )
                {
                    var brimary = hinhAnh;
                    byte[] array = (brimary as System.Data.Linq.Binary).ToArray( );
                    MemoryStream ms = new MemoryStream(array);

                    pic_Logo.Image = Image.FromStream(ms);
                }

            }
            else
            {
                Messeage.err();
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}