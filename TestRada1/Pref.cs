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
    public partial class Pref : Form
    {
        public Pref()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Pref_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage31_Click(object sender, EventArgs e)
        {

        }

        private void tabControl6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( !tabPage31.Controls.Contains(UC_General_map.Instance) )
            {
                tabPage31.Controls.Add(UC_General_map.Instance);
                UC_General_map.Instance.Dock = DockStyle.Fill;
                UC_General_map.Instance.BringToFront( );
            }
            else
                UC_General_map.Instance.BringToFront( );

            if ( !tabPage32.Controls.Contains(UC_Geographical_map.Instance) )
            {
                tabPage32.Controls.Add(UC_Geographical_map.Instance);
                UC_Geographical_map.Instance.Dock = DockStyle.Fill;
                UC_Geographical_map.Instance.BringToFront( );
            }
            else
                UC_Geographical_map.Instance.BringToFront( );

            if ( !tabPage33.Controls.Contains(UC_Luciad_map.Instance) )
            {
                tabPage33.Controls.Add(UC_Luciad_map.Instance);
                UC_Luciad_map.Instance.Dock = DockStyle.Fill;
                UC_Luciad_map.Instance.BringToFront( );
            }
            else
                UC_Luciad_map.Instance.BringToFront( );

            if ( !tabPage34.Controls.Contains(UC_Luciad_map.Instance) )
            {
                tabPage34.Controls.Add(UC_Navigation_map.Instance);
                UC_Navigation_map.Instance.Dock = DockStyle.Fill;
                UC_Navigation_map.Instance.BringToFront( );
            }
            else
                UC_Navigation_map.Instance.BringToFront( );
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
