using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TestRada1
{
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        private static XtraUserControl1 _instance;
        public static XtraUserControl1 Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new XtraUserControl1( );
                return _instance;
            }
        }
        public XtraUserControl1( )
        {
            InitializeComponent( );
        }

        private void XtraUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
