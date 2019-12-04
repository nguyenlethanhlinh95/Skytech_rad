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
    public partial class UC_Luciad_map : UserControl
    {
        private static UC_Luciad_map _instance;
        public static UC_Luciad_map Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Luciad_map( );
                return _instance;
            }
        }

        public UC_Luciad_map( )
        {
            InitializeComponent( );
        }
    }
}
