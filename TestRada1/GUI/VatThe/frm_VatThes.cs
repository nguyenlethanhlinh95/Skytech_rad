using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestRada1.BUS;
using TestRada1.DTO;

namespace TestRada1
{
    public partial class frm_VatThes : DevExpress.XtraEditors.XtraForm
    {
        public frm_VatThes( )
        {
            InitializeComponent( );
        }

        VatTheBus _vtBus = new VatTheBus();
        int index;

        private void frm_VatThes_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.styleGridControl(grdc_VatThe, grdv_VatThe);
            loadAllVatThe();
        }

        private void loadAllVatThe( )
        {
            grdc_VatThe.DataSource = _vtBus.getAll( );
        }

        private void btn_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grdv_VatThe.RowCount >= 0)
            {
                if (index >= 0)
                {
                    Int64 constructionId = Convert.ToInt64(grdv_VatThe.GetRowCellValue(index, "vatThe_id").ToString( ));
                    frm_AddNewVatThe frm = new frm_AddNewVatThe( );
                    frm.FormClosed += new FormClosedEventHandler(dongformItem);

                    frm.checkNew = false;
                    Int32 idVatThe = Convert.ToInt32(grdv_VatThe.GetRowCellValue(index, "vatThe_id").ToString( ));

                    frm.idVatThe = idVatThe;
                    frm.ShowDialog( );
                }
            }
        }

        private void dongformItem(object sender, EventArgs e)
        {
            if ( grdv_VatThe.RowCount > 0 )
            {
               loadAllVatThe();
            }

        }

        private void grdv_VatThe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            index = e.FocusedRowHandle;
        }

        private void btn_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_AddNewVatThe frm = new frm_AddNewVatThe( );
            frm.FormClosed += new FormClosedEventHandler(dongformItem);
            frm.checkNew = true;
            frm.ShowDialog( );
        }
    }
}