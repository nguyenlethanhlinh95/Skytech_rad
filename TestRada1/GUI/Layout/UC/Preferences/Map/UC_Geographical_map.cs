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
    public partial class UC_Geographical_map : UserControl
    {
        private static UC_Geographical_map _instance;
        public static UC_Geographical_map Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Geographical_map( );
                return _instance;
            }
        }

        public UC_Geographical_map( )
        {
            InitializeComponent( );
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
