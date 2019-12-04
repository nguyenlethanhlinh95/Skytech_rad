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
    public partial class frm_AddLocation : Form
    {
        public int index { get; set; }
        public int xStart{ get; set; }
        public int yStart { get; set; }
        public int xEnd { get; set; }
        public int yEnd { get; set; }
        public frm_AddLocation()
        {
            InitializeComponent();
        }

        private void frm_AddLocation_Load(object sender, EventArgs e)
        {
            textEdit1.Location = new Point(0, pictureBox1.Height - 22);
            simpleButton1.Location = new Point(403, pictureBox1.Height - 22);
            simpleButton2.Location = new Point(428, pictureBox1.Height - 22);
            textEdit1.Text = "Tọa Độ Ban Đầu X: 0, Y: 0 , Tọa Độ Kết Thúc X: 0, Y: 0";
            xEnd = -1;
            yEnd = -1;
            xStart = -1;
            yStart = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (xStart == -1)
            {
                xStart = Cursor.Position.X;
                yStart = Cursor.Position.Y-20;
                Image img = Image.FromFile(Application.StartupPath + "/img/map.png");
                Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawRectangle(new Pen(Color.Red, 2), xStart, yStart,2,2);
                textEdit1.Text = "Tọa Độ Ban Đầu X: " + xStart + ", Y:" + yStart + ", Tọa Độ Kết Thúc X: 0, Y: 0";
                pictureBox1.Image = bmp;

            }
            else
            {
                xEnd = Cursor.Position.X;
                yEnd = Cursor.Position.Y-20;
                Image img = Image.FromFile(Application.StartupPath + "/img/map.png");
                Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawRectangle(new Pen(Color.Red, 2), xStart, yStart, 2, 2);
                g.DrawLine(new Pen(Color.Red, 2), xStart, yStart, xEnd, yEnd);
                textEdit1.Text = "Tọa Độ Ban Đầu X: " + xStart + ", Y:" + yStart + ", Tọa Độ Kết Thúc X: "+ xEnd+ ", Y: "+yEnd;

                pictureBox1.Image = bmp;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (xEnd != -1)
            {
                xEnd = -1;
                yEnd = -1;

               
                Image img = Image.FromFile(Application.StartupPath + "/img/map.png");
                Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawRectangle(new Pen(Color.Red, 2), xStart, yStart, 2, 2);
                textEdit1.Text = "Tọa Độ Ban Đầu X: " + xStart + ", Y:" + yStart + ", Tọa Độ Kết Thúc X: 0, Y: 0";
                pictureBox1.Image = bmp;

            }
            else
            {
                Image img = Image.FromFile(Application.StartupPath + "/img/map.png");
                xStart = -1;
                yStart = -1;
                textEdit1.Text = "Tọa Độ Ban Đầu X: 0, Y: 0 , Tọa Độ Kết Thúc X: 0, Y: 0";
                pictureBox1.Image = img;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (xStart == -1)
                xStart = 0;
            if (yStart == -1)
                yStart = 0;
            if (xEnd == -1)
                xEnd = 0;
            if (yEnd == -1)
                yEnd = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
