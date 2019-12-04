using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRada1
{
    public partial class UC_Markers : UserControl
    {
        private static UC_Markers _instance;
        public static UC_Markers Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Markers( );
                return _instance;
            }       
        }

        public UC_Markers( )
        {
            InitializeComponent( );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
