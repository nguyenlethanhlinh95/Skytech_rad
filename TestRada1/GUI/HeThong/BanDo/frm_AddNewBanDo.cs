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
    public partial class frm_AddNewBanDo : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddNewBanDo( )
        {
            InitializeComponent( );
        }

        public bool isChinhSua = false;
        public Int64 id = 0;

        BanDoBus _banDoBus = new BanDoBus();
        RadaBus _radaBus = new RadaBus();

        /// <summary>
        /// Them moi ban do
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_AddNewBanDo_Load(object sender, EventArgs e)
        {  
            if (id != 0)
            {
                loadBanDo(id);
                btn_Update.Enabled = true;
                btn_New.Enabled = false;                   
                this.AcceptButton = btn_Update;     
            }
            else
            {
                btn_Update.Enabled = false;
                btn_New.Enabled = true;

                this.AcceptButton = btn_New;
            }
        }

        /// <summary>
        /// Kiem tra du lieu
        /// </summary>
        /// <returns>string true or mess</returns>
        private string checkNull( )
        {
            if ( IsNullOrEmptyPic(pic_Logo) )
            {
                //txt_link_path.Focus( );
                return "Vui Lòng Chọn Bản Đồ";
            }
            else if ( txt_x.Text == "" )
            {
                txt_x.Focus( );
                return "Vui Lòng Nhập Tọa Độ X";
            }
            else if ( txt_y.Text == "" )
            {
                txt_y.Focus( );
                return "Vui Lòng Nhập Tọa Độ Y";
            }
            else if ( txt_ox.Text == "" )
            {
                txt_ox.Focus( );
                return "Vui Lòng Nhập Tọa Trục Ox";
            }
            else if ( txt_oy.Text == "" )
            {
                txt_oy.Focus( );
                return "Vui Lòng Nhập Tọa Trục Oy";
            }     
            else
            {
                return "true";
            }
        }

        /// <summary>
        /// Check image
        /// </summary>
        /// <param name="pb"></param>
        /// <returns>bool</returns>

        /// <summary>
        /// Convert image to byte
        /// </summary>
        /// <param name="imageIn"></param>
        /// <returns>byte image</returns>
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream( );
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray( );
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog( );
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";

            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if ( openFile.ShowDialog( ) == DialogResult.OK )
            {
                var linkImage = openFile.FileName;
                pic_Logo.Image = Image.FromFile(linkImage);
            }
        }

        /// <summary>
        /// Thêm mới bản đồ, rada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_New_Click(object sender, EventArgs e)
        {
            string isCheckNull = checkNull( );
            if ( isCheckNull == "true" )
            {
                bool tinhTrang = false;
                tinhTrang = bool.Parse(chk_active.EditValue.ToString( ));
                // them moi ban do
                ST_BanDo bd = new ST_BanDo( );
                bd.bando_name = txt_Name.Text.ToString();
                bd.bando_x = float.Parse(txt_x.Text.ToString( ));
                bd.bando_y = float.Parse(txt_y.Text.ToString( ));
                bd.bando_tinhTrang = tinhTrang;


                Image img = pic_Logo.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter( );
                arr = (byte[]) converter.ConvertTo(img, typeof(byte[]));
                bd.bando_image = arr;


                Int64 idInsertBanDo = _banDoBus.insert(bd);

                if ( idInsertBanDo != 0)
                {
                    ST_RaDa rd = new ST_RaDa();
                    rd.rada_x = float.Parse(txt_ox.Text);
                    rd.rada_y = float.Parse(txt_oy.Text);
                    rd.bando_id = idInsertBanDo;

                    _radaBus.insert(rd);

                    Messeage.themMoiThanhCong( );
                    this.Close();
                }
                else
                {
                    Messeage.khongTheThemMoi( );
                }
            }
            else
            {
                Messeage.error(isCheckNull);
            }
        }

        /// <summary>
        /// Load Ban Do
        /// </summary>
        /// <param name="id"></param>
        private void loadBanDo(long id)
        {
            try
            {
                var bd = _banDoBus.getDetail(id);
                var rd = _radaBus.getRaDa(id);

                var name = bd.GetType( ).GetProperty("bando_name").GetValue(bd, null);
                if ( name != null )
                    txt_Name.Text = name.ToString( );

                var x = bd.GetType( ).GetProperty("bando_x").GetValue(bd, null);
                if ( x != null )
                    txt_x.Text = x.ToString( );

                var y = bd.GetType( ).GetProperty("bando_y").GetValue(bd, null);
                if ( y != null )
                    txt_y.Text = y.ToString( );

                var status = bd.GetType( ).GetProperty("bando_tinhTrang").GetValue(bd, null);
                if ( status != null )
                    chk_active.EditValue = bool.Parse(status.ToString( ));

                var ox = rd.GetType( ).GetProperty("rada_x").GetValue(rd, null);
                if ( ox != null )
                    txt_ox.Text = ox.ToString( );

                var oy = rd.GetType( ).GetProperty("rada_y").GetValue(rd, null);
                if ( oy != null )
                    txt_oy.Text = oy.ToString( );


                //hien thi hinh anh
                var bd_image = bd.GetType( ).GetProperty("bando_image").GetValue(bd, null);
                if ( bd_image != null )
                {
                    var brimary = bd_image;
                    byte[] array = (brimary as System.Data.Linq.Binary).ToArray( );
                    MemoryStream ms = new MemoryStream(array);

                    pic_Logo.Image = Image.FromStream(ms);
                }

            }
            catch ( Exception )
            {
                Messeage.error("Không thể tải bản đồ !");
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cập nhật bản đồ, rada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string isCheckNull = checkNull();
            if ( isCheckNull == "true" )
            {
                ST_BanDo bd = new ST_BanDo( );
                bd.bando_x = float.Parse(txt_x.Text.ToString( ));
                bd.bando_y = float.Parse(txt_y.Text.ToString( ));
                bd.bando_name = txt_Name.Text;

                Image img = pic_Logo.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter( );
                arr = (byte[]) converter.ConvertTo(img, typeof(byte[]));

                bd.bando_image = arr;

                bd.bando_id = id;

                bool isUpdateBanDo = _banDoBus.update(bd);

                if (isUpdateBanDo)
                {
                    Messeage.capNhatThanhCong();
                    this.Close();
                }
                else
                {
                    Messeage.khongTheCapNhat();
                }
            }
            else
            {
                Messeage.error(isCheckNull);
            }
            
        }

        public bool IsNullOrEmptyPic(PictureEdit pb)
        {
            return pb == null || pb.Image == null;
        }

        /// <summary>
        /// Chon toa độ O 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_find_Click(object sender, EventArgs e)
        {
            if ( IsNullOrEmptyPic(pic_Logo))
            {
                Messeage.error("Bạn chưa chọn Bản Đồ !!");
            }
            else
            {
                frm_ChonToaDoONhanh frm = new frm_ChonToaDoONhanh();
                frm.hinhAnh = pic_Logo;
                frm.ShowDialog();
            }
        }
    }
}