using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using System.IO;

namespace TestRada1
{
    public partial class UC_Symbol_CAT : UserControl
    {
       
        private static UC_Symbol_CAT _instance;
        BUS.ImagesBus _imgBus = new BUS.ImagesBus();
        public static UC_Symbol_CAT Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Symbol_CAT();
                return _instance;
            }
        }
        public UC_Symbol_CAT()
        {
            InitializeComponent();
        }

        private void UC_Symbol_CAT_Load(object sender, EventArgs e)
        {

            var data = _imgBus.getAllImage();
            Image img = null;
            foreach (var item in data)
            {
                var hinhAnh = item.GetType().GetProperty("image_img").GetValue(item, null);
                if (hinhAnh != null)
                {
                    var brimary = hinhAnh;
                    byte[] array = (brimary as System.Data.Linq.Binary).ToArray();
                    MemoryStream ms = new MemoryStream(array);
                    img = Image.FromStream(ms);
                }
                imageCollection1.AddImage(img);

            }
            AddItems(imageComboBoxEdit1, imageCollection1);
            //select the last item 
            imageComboBoxEdit1.SelectedIndex = imageComboBoxEdit1.Properties.Items.Count - 1;

            cbb_DefaultColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            cbb_DefaultColor.DrawItem += new DrawItemEventHandler(ComboBox1_DrawItem);
            cbb_DefaultColor.Items.Add("Black");
            cbb_DefaultColor.Items.Add("Blue");
            cbb_DefaultColor.Items.Add("Lime");
            cbb_DefaultColor.Items.Add("Cyan");
            cbb_DefaultColor.Items.Add("Red");
            cbb_DefaultColor.Items.Add("Fuchsia");
            cbb_DefaultColor.Items.Add("Yellow");
            cbb_DefaultColor.Items.Add("White");
            cbb_DefaultColor.Items.Add("Navy");
            cbb_DefaultColor.Items.Add("Green");
            cbb_DefaultColor.Items.Add("Teal");
            cbb_DefaultColor.Items.Add("Maroon");
            cbb_DefaultColor.Items.Add("Purple");
            cbb_DefaultColor.Items.Add("Olive");
            cbb_DefaultColor.Items.Add("Gray");



            cbb_DefaultColor.SelectedItem = "Black";
            cbb_DefaultSize.SelectedItem = "16";
            cbb_Image.SelectedItem = "None";
            cbb_color.SelectedItem = "None";
            cbb_size.SelectedItem = "None";
            radioButton1.Checked = true;
        }

        private void ComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds; //Rectangle of item
            if (e.Index >= 0)
            {
                //Get item color name
                string itemName = ((System.Windows.Forms.ComboBox)sender).Items[e.Index].ToString();

                //Get instance a font to draw item name with this style
                Font itemFont = new Font("Arial", 9, FontStyle.Regular);

                //Get instance color from item name
                Color itemColor = Color.FromName(itemName);

                //Get instance brush with Solid style to draw background
                Brush brush = new SolidBrush(itemColor);

                //Draw the item name
                g.DrawString(itemName, itemFont, Brushes.Black, rect.X, rect.Top);

                //Draw the background with my brush style and rectangle of item
                g.FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height);
            }
        }

        private void AddItems(ImageComboBoxEdit editor, ImageCollection imgList)
        {
            int i = 0;
            var data = _imgBus.getAllImage();
           
            foreach (var item in data)
            {
               
                
                editor.Properties.Items.Add(new ImageComboBoxItem("Item " + (i + 1).ToString(), i, i));
                i++;
            }
            editor.Properties.SmallImages = imgList;
        }

        //display information on the selected item 
        void imageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageComboBoxEdit editor = sender as ImageComboBoxEdit;
            this.Text = "SelectedIndexChanged: index " + editor.SelectedIndex.ToString() +
                " / value " + editor.EditValue.ToString() + " / display text " + editor.Text;
        }
    }
}
