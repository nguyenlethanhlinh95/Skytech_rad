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
    public partial class UC_Label_basic : UserControl
    {
        private static UC_Label_basic _instance;
        public static UC_Label_basic Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Label_basic( );
                return _instance;
            }
        }
        public UC_Label_basic( )
        {
            InitializeComponent( );
        }
    }
}
