using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TestRada1.DTO;
using TestRada1.BUS;
using DevExpress.XtraEditors;

namespace TestRada1
{
    public partial class UC_General_map : UserControl
    {
        private static UC_General_map _instance;
        public static UC_General_map Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_General_map( );
                return _instance;
            }
        }

        BanDoBus _bd = new BanDoBus();
        RadaBus _rd = new RadaBus();
        long idBanDo = 0;

        public UC_General_map( )
        {
            InitializeComponent( );
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Parent.Controls.Remove(this);
            
            this.ParentForm.Close();
        }


        private void btn_apply_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string isCheckNull = checkNull( );
                

            //    if (_bd.isCheckBanDo())
            //    {
            //        var banDo = _bd.getBanDo( );
            //        var raDa = _rd.getRaDa( );
            //        var id_banDo = long.Parse(banDo.GetType( ).GetProperty("bando_id").GetValue(banDo, null).ToString( ));
            //        var id_raDa = long.Parse(raDa.GetType( ).GetProperty("rada_id").GetValue(raDa, null).ToString( ));
            //        // cap nhat
            //        if ( isCheckNull == "true" )
            //        {
            //            ST_BanDo bd = new ST_BanDo( );
            //            bd.bando_x = float.Parse(txt_x.Text.ToString( ));
            //            bd.bando_y = float.Parse(txt_y.Text.ToString( ));

            //            Image img = pic_Logo.Image;
            //            byte[] arr;
            //            ImageConverter converter = new ImageConverter( );
            //            arr = (byte[]) converter.ConvertTo(img, typeof(byte[]));

            //            bd.bando_image = arr;

            //            bd.bando_id = id_banDo;

            //            bool isUpdateBanDo = _bd.update(bd);



            //            ST_RaDa rd = new ST_RaDa();
            //            rd.rada_x = float.Parse(txt_Ox.Text);
            //            rd.rada_y = float.Parse(txt_Oy.Text);
            //            rd.rada_id = id_raDa;

            //            bool isUpdateRada = _rd.update(rd);

            //            if ( isUpdateBanDo && isUpdateRada )
            //            {
            //                Messeage.capNhatThanhCong( );
            //            }
            //            else
            //            {
            //                Messeage.khongTheCapNhat( );
            //            }
            //        }
            //        else
            //        {
            //            Messeage.error(isCheckNull);
            //        }
            //    }
            //    else
            //    {
            //        // them moi
            //        if ( isCheckNull == "true" )
            //        {
            //            // them moi ban do
            //            ST_BanDo bd = new ST_BanDo( );
            //            bd.bando_x = float.Parse(txt_x.Text.ToString( ));
            //            bd.bando_y = float.Parse(txt_y.Text.ToString( ));
                        
            //            Image img = pic_Logo.Image;
            //            byte[] arr;
            //            ImageConverter converter = new ImageConverter( );
            //            arr = (byte[]) converter.ConvertTo(img, typeof(byte[]));
            //            bd.bando_image = arr;


            //            bool isInsertBanDo = _bd.insert(bd);

            //            // them moi rada
            //            ST_RaDa rd = new ST_RaDa();
            //            rd.rada_x = float.Parse(txt_Ox.Text);
            //            rd.rada_y = float.Parse(txt_Oy.Text);


            //            bool insertRada = _rd.insert(rd);


            //            if ( isInsertBanDo && insertRada )
            //            {
            //                Messeage.themMoiThanhCong( );
            //            }
            //            else
            //            {
            //                Messeage.khongTheThemMoi( );
            //            }
            //        }
            //        else
            //        {
            //            Messeage.error(isCheckNull);
            //        }
            //    }
                
            //}
            //catch(Exception)
            //{
            //    Messeage.khongTheCapNhat();
            //}
            
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            string linkImage = "";
            OpenFileDialog openFile = new OpenFileDialog( );
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";

            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if ( openFile.ShowDialog( ) == DialogResult.OK )
            {
                linkImage = openFile.FileName;
                txt_link_path.Text = linkImage.ToString();

                pic_Logo.Image = Image.FromFile(linkImage);
            }
        }


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
            else if ( txt_Ox.Text == "" )
            {
                txt_Ox.Focus( );
                return "Vui Lòng Nhập Tọa Độ OX";
            }
            else if ( txt_Oy.Text == "" )
            {
                txt_Oy.Focus( );
                return "Vui Lòng Nhập Tọa Độ OY";
            }
            else
            {
                return "true";
            }
        }

        //ảnh -> byte[]
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream( );
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray( );
        }

        //byte[] -> ảnh
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void UC_General_map_Load(object sender, EventArgs e)
        {
            if (_bd.isCheckBanDo())
            {
                loadBanDo();
            }
        }

        private void loadBanDo()
        {
            try
            {
                var bd = _bd.getBanDo( );

                var x = bd.GetType( ).GetProperty("bando_x").GetValue(bd, null);
                if ( x != null )
                    txt_x.Text = x.ToString( );

                var y = bd.GetType( ).GetProperty("bando_y").GetValue(bd, null);
                if ( y != null )
                    txt_y.Text = y.ToString( );

                var id_bd = bd.GetType( ).GetProperty("bando_id").GetValue(bd, null);

                //hien thi hinh anh
                var bd_image = bd.GetType( ).GetProperty("bando_image").GetValue(bd, null);
                if ( bd_image != null )
                {
                    var brimary = bd_image;
                    byte[] array = (brimary as System.Data.Linq.Binary).ToArray( );
                    MemoryStream ms = new MemoryStream(array);

                    pic_Logo.Image = Image.FromStream(ms);
                }

                idBanDo = long.Parse(id_bd.ToString());

            }
            catch(Exception)
            {
                Messeage.error("Không thể tải bản đồ !");
            }
            
        }

        public bool IsNullOrEmptyPic(PictureEdit pb)
        {
            return pb == null || pb.Image == null;
        }

     
    }
}
