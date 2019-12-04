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
    public partial class UC_Symbol_Basic : UserControl
    {
        private static UC_Symbol_Basic _instance;
        public static UC_Symbol_Basic Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Symbol_Basic( );
                return _instance;
            }
        }
        public UC_Symbol_Basic( )
        {
            InitializeComponent( );
        }
    }
}
