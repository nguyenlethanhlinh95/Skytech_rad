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
    public partial class UC_Sectors : UserControl
    {
        private static UC_Sectors _instance;
        public static UC_Sectors Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Sectors( );
                return _instance;
            }
        }
        public UC_Sectors( )
        {
            InitializeComponent( );
        }
    }
}
