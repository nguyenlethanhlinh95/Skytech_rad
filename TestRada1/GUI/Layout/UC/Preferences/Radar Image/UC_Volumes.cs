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
    public partial class UC_Volumes : UserControl
    {
        private static UC_Volumes _instance;
        public static UC_Volumes Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Volumes( );
                return _instance;
            }
        }
        public UC_Volumes( )
        {
            InitializeComponent( );
        }
    }
}
