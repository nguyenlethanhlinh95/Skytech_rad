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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable table;
        BUS.VatTheBus _vatTheBus = new BUS.VatTheBus();
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

      
    }
}
