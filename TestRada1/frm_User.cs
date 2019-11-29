using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestRada1.DTO;
using TestRada1.DAO;


namespace TestRada1
{
    public partial class frm_User : DevExpress.XtraEditors.XtraForm
    {
        public frm_User( )
        {
            InitializeComponent( );
        }
        DataClasses1DataContext db = new DataClasses1DataContext( );

        UserDao _user = new UserDao();

        #region KhoiTao
        private void frm_User_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.styleGridControl(grdc_user, grdv_user);
            LoadEmployee( );
        }

        private void LoadEmployee( )
        {
            var datasource = _user.getAllUser( );
            if ( datasource != null )
            {
                grdc_user.DataSource = datasource;
            }

        }
        #endregion End KhoiTao

        #region Event
        private void dongformEmployee(object sender, EventArgs e)
        {
            LoadEmployee( );
        }

        #endregion EndEvent
    }
}