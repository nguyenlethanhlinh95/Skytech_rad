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
    public partial class UC_Navigation_map : UserControl
    {
        private static UC_Navigation_map _instance;
        public static UC_Navigation_map Instance
        {
            get
            {
                if ( _instance == null )
                    _instance = new UC_Navigation_map( );
                return _instance;
            }
        }
        public UC_Navigation_map( )
        {
            InitializeComponent( );
        }

        private void UC_Navigation_map_Load(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
