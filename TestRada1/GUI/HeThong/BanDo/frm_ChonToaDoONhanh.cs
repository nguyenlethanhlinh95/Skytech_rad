using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace TestRada1
{
    public partial class frm_ChonToaDoONhanh : DevExpress.XtraEditors.XtraForm
    {
        public PictureEdit hinhAnh = null;
        Bitmap bmp;
        Image imgs;
        Graphics g;

        public frm_ChonToaDoONhanh( )
        {
            InitializeComponent( );
        }

       
        private void frm_ChonToaDoONhanh_Load(object sender, EventArgs e)
        {
            this.Width = 1024;
            this.Height = 768;
            RadaChart.BackImage.Image = hinhAnh.Image;
        }
    }
}