using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace TestRada1
{
    public partial class frm_NewAction : Form
    {
        public frm_NewAction()
        {
            InitializeComponent();
        }
        DataTable table;
        BUS.VatTheBus _vatTheBus = new BUS.VatTheBus();
        int index;

        public int indexOld {get;set;} 
        public int xStartOld {get;set;}
        public int yStartOld { get; set; }
        public int xEndOld { get; set; }
        public int yEndOld { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {

            repositoryLUE1.NullText = "Chọn";
            phuongTien.ColumnEdit = repositoryLUE1;
            repositoryLUE1.DataSource = _vatTheBus.getAll();
            repositoryLUE1.ValueMember = "vatThe_id";
            repositoryLUE1.DisplayMember = "vatThe_name";


            table = new DataTable();
            table.Columns.Add("phuongTien", typeof(string));
            table.Columns.Add("xStart", typeof(string));
            table.Columns.Add("yStart", typeof(string));
            table.Columns.Add("xEnd", typeof(string));
            table.Columns.Add("yEnd", typeof(string));
            table.Columns.Add("buocNhay", typeof(string));
            table.Columns.Add("time", typeof(string));
            
          
            gridControl1.DataSource =  table;

            StyleDevxpressGridControl.styleGridControl(gridControl1, gridView1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           DTO.DataClasses1DataContext db = new DTO.DataClasses1DataContext();
           RepositoryItemLookUpEdit editor = phuongTien.ColumnEdit as RepositoryItemLookUpEdit;  
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DTO.ST_HoatDong _newHoatDong = new DTO.ST_HoatDong();
                DateTime now = DateTime.Now;
                string time = gridView1.GetRowCellValue(i, "time").ToString();
                DateTime now2 = now.AddSeconds(Convert.ToInt32(time));
                int code =Convert.ToInt32( gridView1.GetRowCellValue(i, phuongTien));
                //string description = editor.GetDisplayValueByKeyValue(code);

                _newHoatDong.vatThe_id=code;
                 _newHoatDong.HoatDong_xBatDau= Convert.ToInt32( gridView1.GetRowCellValue(i, "xStart"));
                 _newHoatDong.HoatDong_yBatDau=  Convert.ToInt32(gridView1.GetRowCellValue(i, "yStart"));
                 _newHoatDong.HoatDong_xKetThuc=  Convert.ToInt32(gridView1.GetRowCellValue(i, "xEnd"));
                 _newHoatDong.HoatDong_yKetThuc=  Convert.ToInt32(gridView1.GetRowCellValue(i, "yEnd"));
                 _newHoatDong.HoatDong_soBuocNhay=  Convert.ToInt32(gridView1.GetRowCellValue(i, "buocNhay"));
                 _newHoatDong.HoatDong_thoiGianBatDauChay=now2;
                  db.ST_HoatDongs.InsertOnSubmit(_newHoatDong);
                  db.SubmitChanges();
          
            }
          
           
        }
        int x2;
        int y2;
        public void tayBac()
        {
            
            x2 = rd.Next(0, 75);       
            y2 = rd.Next(0, 76 - x2);
                     
        }
        public void tayNam()
        {
            
            x2 = rd.Next(0, 100);
            y2 = rd.Next(x2+299, 400);

        }
        Random rd = new Random();
        public void dongBac()
        {
           
            x2 = rd.Next(300, 400);
            y2 = rd.Next(0,x2-299);
        }
        public void dongNam()
        {
          
            x2 = rd.Next(275, 400);
            y2 = rd.Next(650-x2, 400);
        }

       

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            table.Clear();
            gridControl1.DataSource = table;
        }
        private string CheckNull(int i)
        {
            if (gridView1.GetRowCellValue(i, "xStart") == "")
            {
                return "Tọa Độ Bắt Đầu X Của Hàng" + i + 1 + " Rỗng!!";
            }
            else if (gridView1.GetRowCellValue(i, "yStart") == "")
            {
                return "Tọa Độ  Bắt Đầu Y Của Hàng" + i + 1 + " Rỗng!!";
            }
            else if (gridView1.GetRowCellValue(i, "xEnd") == "")
            {
                return "Tọa Độ  Kết Thúc X Của Hàng" + i + 1 + " Rỗng!!";
            }
            else if (gridView1.GetRowCellValue(i, "yEnd") == "")
            {
                return "Tọa Độ  Kết Thúc Y Của Hàng" + i + 1 + " Rỗng!!";
            }
            else if (gridView1.GetRowCellValue(i, "buocNhay") == "")
            {
                return "Số Bước Nhãy Của Hàng" + i + 1 + " Rỗng!!";
            }
            else if (gridView1.GetRowCellValue(i, "time") == "")
            {
                return "Thời Gian Bắt Đầu Của Hàng" + i + 1 + " Rỗng!!";
            }
            else
                return "true";
        }
        private void btn_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DTO.DataClasses1DataContext db = new DTO.DataClasses1DataContext();
                RepositoryItemLookUpEdit editor = phuongTien.ColumnEdit as RepositoryItemLookUpEdit;
                string check="";
                bool isEmpty = false;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (CheckNull(i) != "true")
                    {
                        isEmpty = true;
                        break;
                    }
                }

                if (isEmpty == false)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {

                        DTO.ST_HoatDong _newHoatDong = new DTO.ST_HoatDong();
                        DateTime now = DateTime.Now;
                        string time = gridView1.GetRowCellValue(i, "time").ToString();
                        DateTime now2 = now.AddSeconds(Convert.ToInt32(time));
                        int code = Convert.ToInt32(gridView1.GetRowCellValue(i, phuongTien));
                        //string description = editor.GetDisplayValueByKeyValue(code);

                        _newHoatDong.vatThe_id = code;
                        _newHoatDong.HoatDong_xBatDau = Convert.ToInt32(gridView1.GetRowCellValue(i, "xStart"));
                        _newHoatDong.HoatDong_yBatDau = Convert.ToInt32(gridView1.GetRowCellValue(i, "yStart"));
                        _newHoatDong.HoatDong_xKetThuc = Convert.ToInt32(gridView1.GetRowCellValue(i, "xEnd"));
                        _newHoatDong.HoatDong_yKetThuc = Convert.ToInt32(gridView1.GetRowCellValue(i, "yEnd"));
                        _newHoatDong.HoatDong_soBuocNhay = Convert.ToInt32(gridView1.GetRowCellValue(i, "buocNhay"));
                        _newHoatDong.HoatDong_thoiGianBatDauChay = now2;
                        db.ST_HoatDongs.InsertOnSubmit(_newHoatDong);
                        db.SubmitChanges();

                    }
                    Messeage.success("Thêm Mới Thành Công!");
                }
                else
                {
                    Messeage.error(check);
                }


            }
            catch (Exception)
            {
                Messeage.err();
            }
        }

        private void btn_Refesh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gridView1.ClearColumnsFilter();
            table.Clear();
            gridControl1.DataSource = table;
        }

        private void btn_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                if (index >= 0)
                {
                    gridView1.DeleteRow(index);
                }
                else
                {
                    Messeage.error("Không Có Gì Để Xóa!"); 
                }
            }
            else
            {
                Messeage.error("Không Có Gì Để Xóa!");
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView1.RowCount>0)
            index = e.FocusedRowHandle;
        }

        private void btn_addLocationAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("phuongTien") != null)
            {
                frm_AddLocation form = new frm_AddLocation();
                form.index = index;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    

                    this.xEndOld = form.xEnd;
                    this.yEndOld = form.yEnd;
                    this.xStartOld= form.xStart;
                    this.yStartOld = form.yStart;
                    this.indexOld = form.index;
                }

                gridView1.SetRowCellValue(indexOld, "xStart", xStartOld);
                gridView1.SetRowCellValue(indexOld, "yStart", yStartOld);
                gridView1.SetRowCellValue(indexOld, "xEnd", xEndOld);
                gridView1.SetRowCellValue(indexOld, "yEnd", yEndOld);




            }
            else
            {
                Messeage.error("Vui Lòng Chọn Phương Tiện!");
            }
        }
        private void dongform(object sender, EventArgs e)
        {

            Messeage.error(xEndOld.ToString());
                  
                 
            
        }
      
    }
}
