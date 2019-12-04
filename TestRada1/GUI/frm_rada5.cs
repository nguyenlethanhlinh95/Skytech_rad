using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using System.Drawing.Imaging;
using TestRada1.BUS;
using System.IO;

namespace TestRada1
{
    public partial class frm_rada5 : DevExpress.XtraEditors.XtraForm
    {
        public frm_rada5( )
        {
            InitializeComponent( );
        }

        /**
         * Khai bao phuong tien
         * 
         * */
        public string phuongTien { get; set; }
        public int xStart;
        public int yStart;
        public int xEnd;
        public int yEnd;
        public int buocNhay;
        int start = 0;
        IEnumerable<object> dt;
        public Color cl_mayBay;
        public Color cl_xe;
        public Color cl_thuyen;
        //int[] numberRun;
        Image img;
        //Point[] pointt;
        Bitmap bmp;
        Pen p;
        Graphics g;
        string[] phuongTienTim;
        MenuStrip MnuStrip;
        bool keVuong = false;

        List<int> numberRun;
        List<Point> pointt;
        int count;

        DateTime TimeStart;
        /**
         * Khai bao truc toa do O, va toa do con chuot, dung de tinh khoang cach khi hover
         * 
         * */
         int xO = 0 , yO = 0;
         int xChuot = 0 , yChuot = 0;
         ToolTip tt = new ToolTip( );
         ToolTip tt_vatthe = new ToolTip( );
       
        Series _seri_default = new Series("default", ViewType.Point);
        Series series1 = new Series("Series 1", ViewType.RadarLine);
        Series series2 = new Series("Series 2", ViewType.RadarArea);
        
        // toa do tay truc quay
        int xKimQuay = 0;
        ////int yKimQuay = 360;
        int yKimQuay = 3000;
        bool checkLine = false;
        bool checkVongTron = false;

        bool isDoKhoanCachSoO = false;
        int numKiemTraSoLanClickSoO = 0;
        bool isVeToaDoTrungTam = false; // check toa do ve diem 
        int xToaDoDiemSoSoVoiO = 0, yToaDoDiemSoVoiO = 0;

        bool isDoKhoanCachGiuaHaiDiem = false;
        int numKiemTraSoLanClickHaiDiem = 0; // so luong lan click va hai diem
        Point toaDo1 = new Point(0, 0);// toa do diem 1 do khoan cach 2 diem
        Point toaDo2 = new Point(0, 0); // toa do diem 2 do khoan cach 2 diem
        bool isVeToaDoHaiDiem = false; // check toa do 2 diem xong
        /**
         * Setup toa do diem, va truc
         * */
        double thamSoX;
        double thamSoY;

        HoatDongBus hoatDongBus = new HoatDongBus();

        private void frm_rada5_Load(object sender, EventArgs e)
        {
            TimeStart = DateTime.Now;
            dt = hoatDongBus.getAll(TimeStart);
            
            // context menu
            MnuStrip = new MenuStrip( );
            MnuStrip.Dock = DockStyle.None;
            // set truc toa do so voi man hinh
            xO = (int)this.Width/2;
            yO = (int) this.Height / 2;

            PictureBox pb = new PictureBox() { Image  = Image.FromFile(Application.StartupPath + "/img/add.png")};
            this.Cursor = new Cursor(((Bitmap)pb.Image).GetHicon());

            thamSoX=(RadarLineChart.Width / 2) / (350 * 1.0);
            thamSoY = (RadarLineChart.Height / 2) / (350 * 1.0);
            bmp = new Bitmap(RadarLineChart.Width, RadarLineChart.Height);

            count = 0;
            foreach ( var dtRow in dt )
            {
                count++;
            }
            numberRun = new List<int>( );
            pointt = new List<Point>( );
            int b = 0;
            pointt.Add(new Point(0, 0));
            foreach ( var dtRow in dt )
            {
                pointt.Add(new Point(0, 0));
                numberRun.Add(0);
                b = b + 1;
            }
            //RadarLineChart.BackColor = Color.;
            RadarLineChart.LookAndFeel.UseDefaultLookAndFeel = false;
                      
            //RadarLineChart

            toolTip( );

            //Toa do mat dinh cua 
            _seri_default.Points.Add(new SeriesPoint(350, 350));
            // toa do truc kim dong ho
            series1.Points.Add(new SeriesPoint(0, 0));
            series1.Points.Add(new SeriesPoint(xKimQuay, yKimQuay));
            series1.ArgumentScaleType = ScaleType.Numerical;

            // them diem
            //SeriesPoint p1 = new SeriesPoint(50, 90);
           
            //series2.

            // Add the series to the chart. 
            RadarLineChart.Series.Add(series1);
            RadarLineChart.Series.Add(series2);
            RadarLineChart.Series.Add(_seri_default);
            //RadarLineChart.Series[2]. = false;

            // Flip the diagram (if necessary). 
            ((RadarDiagram) RadarLineChart.Diagram).StartAngleInDegrees = 360;
            ((RadarDiagram) RadarLineChart.Diagram).RotationDirection =
                RadarDiagramRotationDirection.Clockwise;
            ((RadarDiagram) RadarLineChart.Diagram).BackColor = Color.Transparent;
            // chỉnh số vòng 
            NumericScaleOptions yAxisOptions = ((RadarDiagram)RadarLineChart.Diagram).AxisY.NumericScaleOptions;
            // số càng nhỏ càng nhiều vòng
            //yAxisOptions.GridSpacing = 100;
            yAxisOptions.GridSpacing = 1000;

            NumericScaleOptions xAxisOptions1 = ((RadarDiagram)RadarLineChart.Diagram).AxisX.NumericScaleOptions;
            // số càng nhỏ càng nhiều vòng
            xAxisOptions1.GridSpacing = 90;


            // Vòng Trong
            ((RadarDiagram)RadarLineChart.Diagram).AxisY.MinorCount = 3;
            ((RadarDiagram)RadarLineChart.Diagram).AxisY.GridLines.Color = System.Drawing.Color.Green;
            ((RadarDiagram)RadarLineChart.Diagram).AxisY.Color = System.Drawing.Color.Blue;
           

            ((RadarDiagram)RadarLineChart.Diagram).AxisY.GridLines.MinorColor = System.Drawing.Color.Red;

            // đường đọa độ
            ((RadarDiagram) RadarLineChart.Diagram).AxisX.GridLines.Color = System.Drawing.Color.Blue;
            ((RadarDiagram)RadarLineChart.Diagram).BorderColor = System.Drawing.Color.Red;

            ((RadarDiagram) RadarLineChart.Diagram).AxisX.Label.TextColor = Color.Black;
            ((RadarDiagram) RadarLineChart.Diagram).AxisY.Label.TextColor = Color.Black;

            ((RadarDiagram) RadarLineChart.Diagram).AxisX.Label.Font = new Font("Tahoma", 10, FontStyle.Bold);
            ((RadarDiagram) RadarLineChart.Diagram).AxisY.Label.Font = new Font("Tahoma", 10, FontStyle.Bold);

            
            ((RadarDiagram) RadarLineChart.Diagram).AxisX.Logarithmic = checkLine;

            // Add a title to the chart and hide the legend. 
            ChartTitle chartTitle1 = new ChartTitle( );
            chartTitle1.Text = "Radar Score 3000";
            RadarLineChart.Titles.Add(chartTitle1);
            RadarLineChart.Legend.Visible = false;

            // Add the chart to the form. 
            RadarLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(RadarLineChart);

        }

        // ke vach cua rada
        private void btn_KeVach_Click(object sender, EventArgs e)
        {            
            if ( checkLine == false)
            {
                checkLine = true;
                NumericScaleOptions xAxisOptions1 = ((RadarDiagram) RadarLineChart.Diagram).AxisX.NumericScaleOptions;
                // số càng nhỏ càng nhiều vòng
                xAxisOptions1.GridSpacing = 30;
            }
            else
            {
                checkLine = false;
                NumericScaleOptions xAxisOptions1 = ((RadarDiagram) RadarLineChart.Diagram).AxisX.NumericScaleOptions;
                // số càng nhỏ càng nhiều vòng
                xAxisOptions1.GridSpacing = 90;
            }
            
        }

        private void btn_NhieuVong_Click(object sender, EventArgs e)
        {
            

            if ( checkVongTron == false )
            {
                checkVongTron = true;
                NumericScaleOptions yAxisOptions = ((RadarDiagram) RadarLineChart.Diagram).AxisY.NumericScaleOptions;
                // số càng nhỏ càng nhiều vòng
                yAxisOptions.GridSpacing = 500;
            }
            else
            {
                checkVongTron = false;
                NumericScaleOptions yAxisOptions = ((RadarDiagram) RadarLineChart.Diagram).AxisY.NumericScaleOptions;
                // số càng nhỏ càng nhiều vòng
                yAxisOptions.GridSpacing = 1000;
            }
        }

        /**
         * Load kim dong ho va toa do
         * Cap nhat bien xKimQuay
         * Cap Nhat toa do diem
         * */
        private void loadRada( )
        {
            series1.Points.Clear();
            series2.Points.Clear();
            // cap nhat kim dong ho
            series1.Points.Add(new SeriesPoint(0, 0));
            series1.Points.Add(new SeriesPoint(xKimQuay, yKimQuay));
            series2.Points.Add(new SeriesPoint(350,0));
            // cap nhat toa do diem
            //toaDoDiem();
            RadarLineChart.Series.Add(series2);
            RadarLineChart.Series.Add(series1);
            RadarLineChart.RefreshData( );


        }

        /**
         * Rada load tooltip
         * */
         private void toolTip()
         {
             
             
         }

        //Cap nhat lai toa do tay truc quay
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 30s 1 vong => 1ms 12do
            if ( xKimQuay < 359 && xKimQuay > 0 )
            {
                xKimQuay = xKimQuay + 2;
            }
            else
            {
                if ( xKimQuay == 359 )
                {
                    xKimQuay = 0;
                }
                else
                {
                    if ( xKimQuay == 0 )
                    {
                        xKimQuay = xKimQuay + 1;
                    }
                }
            }

            //if ( xKimQuay < 348 && xKimQuay >= 0 )
            //{
            //    xKimQuay = xKimQuay + 12;
            //}
            //else
            //{
            //    if ( xKimQuay == 348 )
            //    {
            //        xKimQuay = 0;
            //    }
            //    //else
            //    //{
            //    //    if ( xKimQuay == 0 )
            //    //    {
            //    //        xKimQuay = xKimQuay + 12;
            //    //    }
            //    //}
            //}

            //RadarLineChart.Paint += new System.Windows.Forms.PaintEventHandler(this.RadarLineChart_Paint);
            loadRada( );
            RadarLineChart.BackImage.Image = checkImage();
            
        }
        Image imgs;
      
     
        private void RadarLineChart_Paint(object sender, PaintEventArgs e)
        {
            if ( isVeToaDoTrungTam )
            {
                int x = RadarLineChart.Width / 2;
                int y = RadarLineChart.Height / 2 + 20;
                e.Graphics.DrawLine(Pens.Red, x, y, xToaDoDiemSoSoVoiO, yToaDoDiemSoVoiO);

                int khoangCachOM = (xToaDoDiemSoSoVoiO - x) * (xToaDoDiemSoSoVoiO - x) +
            (yToaDoDiemSoVoiO - y) * (yToaDoDiemSoVoiO - y);
                var doDai = Math.Sqrt(Double.Parse(khoangCachOM.ToString()));
                tt.RemoveAll( );
                tt.Show("Khoảng cách đến trục O: " + doDai, this, xToaDoDiemSoSoVoiO + 25, yChuot + 25);
            }      
            else
            {
                
            }

            if ( isDoKhoanCachGiuaHaiDiem )
            {
                if ( isVeToaDoHaiDiem )
                {
                    
                    e.Graphics.DrawLine(Pens.Red, toaDo1, toaDo2);

                    int khoangCachOM = (toaDo1.X - toaDo2.X) * (toaDo1.X - toaDo2.X) +
            (toaDo1.Y - toaDo2.Y) * (toaDo1.Y - toaDo2.Y);
                    var doDai = Math.Sqrt(Double.Parse(khoangCachOM.ToString()));
                    tt.RemoveAll( );
                    tt.Show("Khoảng cách đến trục O: " + doDai, this, toaDo1.X + 25, toaDo1.Y + 25);
                }
                else
                {
                    
                }
                
            }
            else
            {
                
            }     
        }

        private void frm_rada5_MouseHover(object sender, EventArgs e)
        {
            //textEdit1.Text = "x: " + Cursor.Position.X + " y: " + Cursor.Position.Y;
        }

        private void RadarLineChart_MouseMove(object sender, MouseEventArgs e)
        {

            textEdit1.Text = "x: " + Cursor.Position.X + " y: " + Cursor.Position.Y;

            xChuot = e.X;
            yChuot = e.Y;           
        }


        //Xem tọa độ vị trí điểm so với Trung tâm
        private void btn_xemViTriSoTrungTam_Click(object sender, EventArgs e)
        {           
            if ( Messeage.info("Bạn muốn mở ứng dụng đo khoảng cách so với vị trí trung tâm?", "") )
            {
                isDoKhoanCachSoO = true;
                numKiemTraSoLanClickSoO = 0;
                isVeToaDoTrungTam = false;
            }
            else
            {
                xToaDoDiemSoSoVoiO = 0;
                yToaDoDiemSoVoiO = 0;
                isVeToaDoTrungTam = false;
                numKiemTraSoLanClickSoO = 0;
                isDoKhoanCachSoO = false;
            }

            RadarLineChart.Paint += new System.Windows.Forms.PaintEventHandler(this.RadarLineChart_Paint);     
            
        }

        //Do khoang cach giua hai diem
        private void RadarLineChart_Click(object sender, EventArgs e)
        {
            // lay toa do 2 diem de ve khoang cach
            if (isDoKhoanCachGiuaHaiDiem)
            {
                numKiemTraSoLanClickHaiDiem += 1;
                if (numKiemTraSoLanClickHaiDiem == 1)
                {
                    int x = Cursor.Position.X;
                    int y = Cursor.Position.Y;
                    toaDo1.X = x;
                    toaDo1.Y = y;
                }
                else if (numKiemTraSoLanClickHaiDiem == 2)
                {
                    int x = Cursor.Position.X;
                    int y = Cursor.Position.Y;
                    toaDo2.X = x;
                    toaDo2.Y = y;

                    isVeToaDoHaiDiem = true;
                }
            }


            // lay toa do diem so voi vi tri trung tam de ve khoang cach
            if ( isDoKhoanCachSoO )
            {
                numKiemTraSoLanClickSoO += 1;
                if ( numKiemTraSoLanClickSoO == 1 )
                {
                    int x = Cursor.Position.X;
                    int y = Cursor.Position.Y;
                    xToaDoDiemSoSoVoiO = x;
                    yToaDoDiemSoVoiO = y;

                    isVeToaDoTrungTam = true;
                }
            }

            RadarLineChart.Paint += new System.Windows.Forms.PaintEventHandler(this.RadarLineChart_Paint);
        }

        private void btn_DoKhoanCachGiuaHaiDiem_Click(object sender, EventArgs e)
        {
            veHinhDoKhoangCachHaiDiem();
        }
        private void veHinhDoKhoangCachHaiDiem()
        {
            if ( Messeage.info("Bạn muốn mở ứng dụng đo khoảng cách giữa hai điểm?", "") )
            {
                isDoKhoanCachGiuaHaiDiem = true;
                numKiemTraSoLanClickHaiDiem = 0;
                isVeToaDoHaiDiem = false;
            }
            else
            {
                
                toaDo1.X = 0;
                toaDo1.Y = 0;
                toaDo2.X = 0;
                toaDo2.Y = 0;

                numKiemTraSoLanClickHaiDiem = 0;
                isDoKhoanCachGiuaHaiDiem = false;
                isVeToaDoHaiDiem = false;
            }

            RadarLineChart.Paint += new System.Windows.Forms.PaintEventHandler(this.RadarLineChart_Paint);       
        }

        private void RadarLineChart_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string text = "Range = " + xChuot + "/n" + "Azimuth = " + yChuot;
                tt.RemoveAll( );
                tt.Show(text, this, xChuot + 25, yChuot + 25);
                if ( e.Button == System.Windows.Forms.MouseButtons.Right )
                {
                    int i = 0;
                    int soLuongVatThe = 0;
                    int j = 0;
                    phuongTienTim = new string[count];
                    foreach ( var item in dt )
                    {
                        if ( (pointt[i].X - 30 < Cursor.Position.X && pointt[i].X > Cursor.Position.X - 30) && (pointt[i].Y - 6 < Cursor.Position.Y && pointt[i].Y + 56 > Cursor.Position.Y) )
                        {
                            soLuongVatThe++;
                            phuongTienTim[j] = item.GetType( ).GetProperty("vatThe_name").GetValue(item, null).ToString( );
                            j++;
                        }
                        i++;
                    }
                    if ( soLuongVatThe == 1 )
                    {
                        tt.RemoveAll( );
                        IWin32Window win = this;
                        tt.Show("Phương Tiện: " + phuongTienTim[0] + ", Tọa Độ X: " + Cursor.Position.X + ", Tọa Độ Y: " + Cursor.Position.Y, win, Cursor.Position);
                    }
                    else if ( soLuongVatThe > 1 )
                    {
                        tt.RemoveAll( );
                        //Control is added to the Form using the Add property
                        MnuStrip.Items.Clear( );
                        MnuStrip.Visible = true;
                        MnuStrip.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
                        this.Controls.Add(MnuStrip);
                        MnuStrip.BringToFront( );
                        ToolStripMenuItem MnuStripItem = new ToolStripMenuItem("Danh Sách");
                        MnuStrip.Items.Add(MnuStripItem);
                        ToolStripMenuItem MnuStripItem1 = new ToolStripMenuItem("Xóa", null, delte_Menu);
                        MnuStrip.Items.Add(MnuStripItem1);
                        foreach ( string rw in phuongTienTim )
                        {
                            ToolStripMenuItem SSMenu = new ToolStripMenuItem(rw, null, ChildClick);
                            // SubMenu(SSMenu,rw);  I have included this piece of code to add a Sub-Menu to the New Menu
                            MnuStripItem.DropDownItems.Add(SSMenu);
                        }
                    }
                }
            }
            catch ( Exception )
            {
                Messeage.err( );
            }
        }
        /**
         * Su kien re chuot
         * */

         /**
          * Lay Hinh Anh
          * */
        public Bitmap checkImage( )
        {
            try
            {
                imgs = Image.FromFile(Application.StartupPath + "/img/map.png");
                g = Graphics.FromImage(bmp);
                g.Clear(Color.Transparent);
                g.DrawImage(imgs, 0, 0, bmp.Width, bmp.Height);
                int j = 0;
                if (dt != null)
                    foreach (var item in dt)
                    {
                        DateTime time = Convert.ToDateTime(item.GetType().GetProperty("HoatDong_thoiGianBatDauChay").GetValue(item, null));
                        DateTime now = DateTime.Now;
                        if (time <= now)
                        {
                            Color newColor;
                            int buocNhay1 = Convert.ToInt16(item.GetType().GetProperty("HoatDong_soBuocNhay").GetValue(item, null));
                            xStart = Convert.ToInt16(item.GetType().GetProperty("HoatDong_xBatDau").GetValue(item, null));
                            yStart = Convert.ToInt16(item.GetType().GetProperty("HoatDong_yBatDau").GetValue(item, null));
                            xEnd = Convert.ToInt16(item.GetType().GetProperty("HoatDong_xKetThuc").GetValue(item, null));
                            yEnd = Convert.ToInt16(item.GetType().GetProperty("HoatDong_yKetThuc").GetValue(item, null));
                            int khoangCachX = (xEnd - xStart) / buocNhay1;
                            int khoangCachY = (yEnd - yStart) / buocNhay1;
                            int locationX = xStart + khoangCachX * (numberRun[j] + 1);
                            int locationY = yStart + khoangCachY * (numberRun[j] + 1);
                            phuongTien = item.GetType().GetProperty("vatThe_name").GetValue(item, null).ToString();
                            var brimary = item.GetType().GetProperty("vatThe_hinhAnh").GetValue(item, null);
                            byte[] array = (brimary as System.Data.Linq.Binary).ToArray();
                            MemoryStream ms = new MemoryStream(array);
                            img = Image.FromStream(ms);
                            //newColor = Color.FromArgb(Convert.ToInt32(dtRow["vatThe_mau"].ToString()));
                            newColor = System.Drawing.ColorTranslator.FromHtml(item.GetType().GetProperty("vatThe_mau").GetValue(item, null).ToString());
                            if (numberRun[j] < buocNhay1 - 1)
                            {
                                g.DrawImage(paint(img, newColor, locationX, locationY), locationX, locationY);
                                numberRun[j] = numberRun[j] + 1;
                                pointt[j] = new Point((xStart + khoangCachX * (numberRun[j] + 1)), (yStart + khoangCachY * (numberRun[j] + 1)));
                            }
                            else
                            {
                                g.DrawImage(paint(img, newColor, xEnd, yEnd), xEnd, yEnd);
                                pointt[j] = new Point(xEnd, yEnd);
                            }
                        }
                        j = j + 1;
                    }
                if (keVuong == true)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        g.DrawLine(new Pen(Color.WhiteSmoke, 2), 0, (RadarLineChart.Height / 4) * (i + 1), RadarLineChart.Width, (RadarLineChart.Height / 4) * (i + 1));
                    }
                    for (int i = 0; i < RadarLineChart.Width / 300; i++)
                    {
                        g.DrawLine(new Pen(Color.WhiteSmoke, 2), 300 * (i + 1), 0, 300 * (i + 1), RadarLineChart.Height);
                    }
                }
                return bmp;
            }
            catch (Exception)
            {
                return null;
            }
           
        }





        // ve doi tuong
         private Bitmap paint(Image img, Color newColor, int x1, int y1)
        {
            Bitmap bmp1 = new Bitmap(24, 24);
            Graphics g1 = Graphics.FromImage(bmp1);
            Color color1 = System.Drawing.ColorTranslator.FromHtml("#000000"); ;
            ColorMap[] colorMap = new ColorMap[1];
            colorMap[0] = new ColorMap( );
            colorMap[0].OldColor = color1;
            colorMap[0].NewColor = newColor;
            ImageAttributes attr = new ImageAttributes( );
            attr.SetRemapTable(colorMap);
            Rectangle rect = new Rectangle(0, 0, bmp1.Width, bmp1.Height);
            g1.DrawImage(img, 4, 4, 16, 16);
            g1.DrawImage(bmp1, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            int kc = (RadarLineChart.Height -170)/2;
            
                        
            int khoangCachOM = (x1+10 - RadarLineChart.Width / 2) * (x1+10 - RadarLineChart.Width / 2) +
            (y1+35 - (kc + 120)) * (y1+35 - (kc + 120));
            // tính bình phương bán kính
            
            int banKinh = kc * kc;
            int banKinh1 = kc * 2 / 3 * kc * 2 / 3;
            int banKinh2 = kc * 1 / 3 * kc * 1 / 3;
            
            if ( khoangCachOM > banKinh )
            {
                g1.DrawEllipse(new Pen(Color.Transparent, 2), rect);
            }
            else if ( khoangCachOM >= banKinh1 && khoangCachOM <= banKinh )
            {
                g1.DrawEllipse(new Pen(Color.Green, 2), rect);
            }
            else if ( khoangCachOM >= banKinh2 && khoangCachOM < banKinh1 )
            {
                g1.DrawEllipse(new Pen(Color.Blue, 2), rect);
            }
            else
                g1.DrawEllipse(new Pen(Color.Red, 2), rect);
            return bmp1;
        }


         public void ChildClick(object sender, System.EventArgs e)
         {
             MessageBox.Show(string.Concat("You have Clicked '", sender.ToString( ), "' Menu"), "Menu Items Event",
                                                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         public void delte_Menu(object sender, System.EventArgs e)
         {
             MnuStrip.Visible = false;
         }

         private void btn_ChiaOBanDo_Click(object sender, EventArgs e)
         {
             if ( keVuong == false )
             {
                 keVuong = true;
             }
             else
             {
                 keVuong = false;
             }
         }

         private void timer2_Tick(object sender, EventArgs e)
         {
             dt = hoatDongBus.getAll(TimeStart);
             int countNow = 0;
             foreach ( var item in dt )
             {
                 countNow++;
             }
             if ( countNow > count )
             {
                 for ( int soGiong = 0; soGiong <= countNow - count + 1; soGiong++ )
                 {
                     numberRun.Add(0);
                     pointt.Add(new Point(0, 0));
                     soGiong++;
                 }
                 count = countNow;
             }
         }

          
    }

}