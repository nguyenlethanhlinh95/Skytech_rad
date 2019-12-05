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
    public partial class frm_Target : Form
    {
        public frm_Target()
        {
            InitializeComponent();
        }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int OX { get; set; }
        public int OY { get; set; }
        public int id { get; set; }
        BUS.HoatDongBus _hoatDongBus = new BUS.HoatDongBus();
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void friendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void suspectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hostileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unknownToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neutralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Target_Load(object sender, EventArgs e)
        {
            cbSensor.SelectedItem = "None";
            cbCourse.SelectedItem = "deg";
            cbSpeed.SelectedItem = "km/h";
            cbRange.SelectedItem = "Km";
            cbAzimuth.SelectedItem = "deg";
            cbHeight.SelectedItem = "Km";
            cbX.SelectedItem = "Km";
            cbY.SelectedItem = "Km";
            cbLatLong.SelectedItem = "Lat/Long deg";
            cbTrue.SelectedItem = "deg";
            cbCourseOver.SelectedItem = "deg";
            cbSpeedOver.SelectedItem = "km/h";
            cbRate.SelectedItem = "deg";
            cbDraught.SelectedItem = "Km";
            cbLeght.SelectedItem = "Km";
            cbWidth.SelectedItem = "Km";
            cbEnvironment.SelectedItem = "Surface";
            cbPrimary.SelectedItem = "Line";
            cbSecondary.SelectedItem = "No Statement";
            
            // kinematic

            var data = _hoatDongBus.getAction(id);
            lbCourse.Text = "Son Tra";
            lbSpeed.Text = data.GetType().GetProperty("HoatDong_soBuocNhay").GetValue(data, null).ToString();
            double kc =Math.Sqrt((X1 - OX) * (X1 - OX) + (Y1 - OY) * (Y1 - OY));
            lbRange.Text = kc.ToString() ;

            int X2 = OX;
            int Y2 = X1;
            int OX2 = X2 - OX;
            int OY2 = Y2 - OY;
            int OX1 = X1 - OX;
            int OY1 = Y1 - OY;
            double Azimuth = Math.Acos((OX1 * OX2) + (OY1 * OY2) / (Math.Sqrt(OX1 * OX1 + OY1 * OY1) * Math.Sqrt(OX2 * OX2 + OY2 * OY2)));


            lbAzimuth.Text = (Azimuth * 180 / Math.PI).ToString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbHeight.Text = "10";
            lbX.Text = X1.ToString();
            lbY.Text = Y1.ToString();
            lbLongLat.Text = "Lat : "+X1+" , Long: "+Y1;
        }

        private void As_Click(object sender, EventArgs e)
        {

        }
    }
}
