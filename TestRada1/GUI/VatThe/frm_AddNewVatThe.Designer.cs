namespace TestRada1
{
    partial class frm_AddNewVatThe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddNewVatThe));
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.btn_image = new DevExpress.XtraEditors.SimpleButton();
            this.pic_Logo = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ced_Mau = new DevExpress.XtraEditors.ColorEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_New = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ced_Mau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(535, 61);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(5, 15);
            this.labelControl13.TabIndex = 292;
            this.labelControl13.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(96, 61);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 16);
            this.labelControl6.TabIndex = 290;
            this.labelControl6.Text = "Tên vật thể";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(236, 58);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Properties.Appearance.Options.UseFont = true;
            this.txt_name.Size = new System.Drawing.Size(291, 22);
            this.txt_name.TabIndex = 1;
            // 
            // btn_image
            // 
            this.btn_image.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_image.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_image.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_image.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_image.Appearance.Options.UseBackColor = true;
            this.btn_image.Appearance.Options.UseFont = true;
            this.btn_image.Appearance.Options.UseForeColor = true;
            this.btn_image.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btn_image.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_image.ImageOptions.Image")));
            this.btn_image.Location = new System.Drawing.Point(679, 237);
            this.btn_image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(100, 23);
            this.btn_image.TabIndex = 3;
            this.btn_image.Text = "Hình ảnh";
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Location = new System.Drawing.Point(634, 61);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_Logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pic_Logo.Size = new System.Drawing.Size(176, 169);
            this.pic_Logo.TabIndex = 294;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(96, 91);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 296;
            this.labelControl1.Text = "Chọn màu";
            // 
            // ced_Mau
            // 
            this.ced_Mau.EditValue = System.Drawing.Color.Empty;
            this.ced_Mau.Location = new System.Drawing.Point(236, 90);
            this.ced_Mau.Name = "ced_Mau";
            this.ced_Mau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ced_Mau.Properties.Appearance.Options.UseFont = true;
            this.ced_Mau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ced_Mau.Size = new System.Drawing.Size(291, 22);
            this.ced_Mau.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(535, 93);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(5, 15);
            this.labelControl2.TabIndex = 298;
            this.labelControl2.Text = "*";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Exit.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Appearance.Options.UseBackColor = true;
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Appearance.Options.UseForeColor = true;
            this.btn_Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(463, 322);
            this.btn_Exit.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gray;
            this.btn_Exit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.btn_Exit.LookAndFeel.SkinName = "Office 2010 Black";
            this.btn_Exit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 36);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.ToolTipTitle = "ESC";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_New.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_New.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_New.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_New.Appearance.Options.UseBackColor = true;
            this.btn_New.Appearance.Options.UseFont = true;
            this.btn_New.Appearance.Options.UseForeColor = true;
            this.btn_New.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_New.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_New.ImageOptions.Image")));
            this.btn_New.Location = new System.Drawing.Point(347, 322);
            this.btn_New.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_New.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_New.LookAndFeel.SkinName = "Office 2010 Black";
            this.btn_New.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_New.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(110, 36);
            this.btn_New.TabIndex = 299;
            this.btn_New.Text = "Thêm mới";
            this.btn_New.ToolTipTitle = "Ctrl +S";
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Update.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Update.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Appearance.Options.UseBackColor = true;
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Appearance.Options.UseForeColor = true;
            this.btn_Update.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.Location = new System.Drawing.Point(347, 322);
            this.btn_Update.LookAndFeel.SkinMaskColor = System.Drawing.Color.RoyalBlue;
            this.btn_Update.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Update.LookAndFeel.SkinName = "Office 2010 Black";
            this.btn_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 36);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.ToolTipTitle = "Ctrl +S";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_AddNewVatThe
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 419);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ced_Mau);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.pic_Logo);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "frm_AddNewVatThe";
            this.ShowIcon = false;
            this.Text = "THÊM MỚI VẬT THỂ";
            this.Load += new System.EventHandler(this.frm_AddNewVatThe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ced_Mau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.SimpleButton btn_image;
        private DevExpress.XtraEditors.PictureEdit pic_Logo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ColorEdit ced_Mau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_New;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
    }
}