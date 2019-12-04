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
        public UC_General_map( )
        {
            InitializeComponent( );
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }


        private void btn_apply_Click(object sender, EventArgs e)
        {
            Messeage.success("Ok");
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

                Messeage.success(linkImage);
            }


            //hien thi hinh anh
            //var employee_image = user.GetType( ).GetProperty("employee_image").GetValue(user, null);
            //if ( employee_image != null )
            //{
            //    var brimary = employee_image;
            //    byte[] array = (brimary as System.Data.Linq.Binary).ToArray( );
            //    MemoryStream ms = new MemoryStream(array);

            //    pic_Logo.Image = Image.FromStream(ms);
            //}
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
    }
}
