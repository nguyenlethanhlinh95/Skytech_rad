using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRada1
{
    public partial class Pref : Form
    {
        public Pref()
        {
            InitializeComponent();
        }

       
        private void Pref_Load(object sender, EventArgs e)
        {
            
            //this.Parent.Dispose( );
            loadUserControl();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

         private void loadUserControl()
         {
            /**
             * Map
             * */
             
             loadMapUserControl();

             loadTrackControl( );

             loadRadarImageUserControl();
         }

         private void loadMapUserControl()
         {
             if ( !tabPage31.Controls.Contains(UC_General_map.Instance) )
             {
                 tabPage31.Controls.Add(UC_General_map.Instance);
                 UC_General_map.Instance.Dock = DockStyle.Fill;
                 UC_General_map.Instance.BringToFront( );
             }
             else
                 UC_Volumes.Instance.BringToFront( );

             if ( !tabPage32.Controls.Contains(UC_Geographical_map.Instance) )
             {
                 tabPage32.Controls.Add(UC_Geographical_map.Instance);
                 UC_Geographical_map.Instance.Dock = DockStyle.Fill;
                 UC_Geographical_map.Instance.BringToFront( );
             }
             else
                 UC_Geographical_map.Instance.BringToFront( );

             if ( !tabPage33.Controls.Contains(UC_Luciad_map.Instance) )
             {
                 tabPage33.Controls.Add(UC_Luciad_map.Instance);
                 UC_Luciad_map.Instance.Dock = DockStyle.Fill;
                 UC_Luciad_map.Instance.BringToFront( );
             }
             else
                 UC_Luciad_map.Instance.BringToFront( );


             if ( !tabPage34.Controls.Contains(UC_Navigation_map.Instance) )
             {
                 tabPage34.Controls.Add(UC_Navigation_map.Instance);
                 UC_Navigation_map.Instance.Dock = DockStyle.Fill;
                 UC_Navigation_map.Instance.BringToFront( );
             }
             else
                 UC_Navigation_map.Instance.BringToFront( );
         }

         private void loadRadarImageUserControl()
         {

             if ( !tabPage7.Controls.Contains(UC_Markers.Instance) )
             {
                 tabPage7.Controls.Add(UC_Markers.Instance);
                 UC_Markers.Instance.Dock = DockStyle.Fill;
                 UC_Markers.Instance.BringToFront( );
             }
             else
                 UC_Markers.Instance.BringToFront( );

             if ( !tabPage9.Controls.Contains(UC_Sectors.Instance) )
             {
                 tabPage9.Controls.Add(UC_Sectors.Instance);
                 UC_Sectors.Instance.Dock = DockStyle.Fill;
                 UC_Sectors.Instance.BringToFront( );
             }
             else
                 UC_Sectors.Instance.BringToFront( );

             if ( !tabPage8.Controls.Contains(UC_Volumes.Instance) )
             {
                 tabPage8.Controls.Add(UC_Volumes.Instance);
                 UC_Volumes.Instance.Dock = DockStyle.Fill;
                 UC_Volumes.Instance.BringToFront( );
             }
             else
                 UC_Volumes.Instance.BringToFront( );


             if ( !tabPage9.Controls.Contains(UC_Sectors.Instance) )
             {
                 tabPage9.Controls.Add(UC_Sectors.Instance);
                 UC_Sectors.Instance.Dock = DockStyle.Fill;
                 UC_Sectors.Instance.BringToFront( );
             }
             else
                 UC_Sectors.Instance.BringToFront( );
         }

         private void loadTrackControl( )
         {           
             if ( !tabPage20.Controls.Contains(UC_Symbol_Basic.Instance) )
             {
                 tabPage20.Controls.Add(UC_Symbol_Basic.Instance);
                 UC_Symbol_Basic.Instance.Dock = DockStyle.Fill;
                 UC_Symbol_Basic.Instance.BringToFront( );
             }
             else
                 UC_Symbol_Basic.Instance.BringToFront( );

             if ( !tabPage21.Controls.Contains(UC_Label_basic.Instance) )
             {
                 tabPage21.Controls.Add(UC_Label_basic.Instance);
                 UC_Label_basic.Instance.Dock = DockStyle.Fill;
                 UC_Label_basic.Instance.BringToFront( );
             }
             else
                 UC_Label_basic.Instance.BringToFront( );

             if ( !tabPage22.Controls.Contains(UC_Symbol_CAT.Instance) )
             {
                 tabPage22.Controls.Add(UC_Symbol_CAT.Instance);
                 UC_Symbol_CAT.Instance.Dock = DockStyle.Fill;
                 UC_Symbol_CAT.Instance.BringToFront( );
             }
             else
                 UC_Symbol_CAT.Instance.BringToFront( );
         }

         private void tabPage7_Click(object sender, EventArgs e)
         {

         }
    }
}
