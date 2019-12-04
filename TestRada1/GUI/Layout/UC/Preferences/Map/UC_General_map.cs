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
    }
}
