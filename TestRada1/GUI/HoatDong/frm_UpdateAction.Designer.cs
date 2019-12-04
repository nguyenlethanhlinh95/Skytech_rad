namespace TestRada1
{
    partial class frm_UpdateAction
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UpdateAction));
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.btn_AddBuildingContractor = new DevExpress.XtraEditors.SimpleButton();
            this.lke_VaThe = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TimeStart = new DevExpress.XtraEditors.TextEdit();
            this.but_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.txt_XStart = new DevExpress.XtraEditors.TextEdit();
            this.txt_XEnd = new DevExpress.XtraEditors.TextEdit();
            this.txt_YStart = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_YEnd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BuocNhay = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lke_VaThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BuocNhay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl18.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.Location = new System.Drawing.Point(561, 25);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(8, 16);
            this.labelControl18.TabIndex = 467;
            this.labelControl18.Text = "*";
            // 
            // btn_AddBuildingContractor
            // 
            this.btn_AddBuildingContractor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddBuildingContractor.ImageOptions.Image")));
            this.btn_AddBuildingContractor.Location = new System.Drawing.Point(532, 26);
            this.btn_AddBuildingContractor.Name = "btn_AddBuildingContractor";
            this.btn_AddBuildingContractor.Size = new System.Drawing.Size(23, 23);
            this.btn_AddBuildingContractor.TabIndex = 466;
            this.btn_AddBuildingContractor.Click += new System.EventHandler(this.btn_AddBuildingContractor_Click);
            // 
            // lke_VaThe
            // 
            this.lke_VaThe.Location = new System.Drawing.Point(235, 26);
            this.lke_VaThe.Name = "lke_VaThe";
            this.lke_VaThe.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lke_VaThe.Properties.Appearance.Options.UseFont = true;
            this.lke_VaThe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lke_VaThe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatThe_id", "Mã Vật Thể"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatThe_name", "Tên Vật Thể")});
            this.lke_VaThe.Properties.NullText = "Chọn";
            this.lke_VaThe.Size = new System.Drawing.Size(291, 22);
            this.lke_VaThe.TabIndex = 464;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(150, 27);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(79, 16);
            this.labelControl19.TabIndex = 465;
            this.labelControl19.Text = "Phương Tiện";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(111, 109);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(118, 16);
            this.labelControl6.TabIndex = 459;
            this.labelControl6.Text = "Tọa Độ X Kết Thúc";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(115, 57);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 16);
            this.labelControl5.TabIndex = 458;
            this.labelControl5.Text = "Tọa Độ X Bắt Đầu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(116, 195);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 16);
            this.labelControl1.TabIndex = 456;
            this.labelControl1.Text = "Thời Gian Bắt Đầu";
            // 
            // txt_TimeStart
            // 
            this.txt_TimeStart.Location = new System.Drawing.Point(235, 194);
            this.txt_TimeStart.Name = "txt_TimeStart";
            this.txt_TimeStart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeStart.Properties.Appearance.Options.UseFont = true;
            this.txt_TimeStart.Size = new System.Drawing.Size(291, 22);
            this.txt_TimeStart.TabIndex = 455;
            this.txt_TimeStart.EditValueChanged += new System.EventHandler(this.txt_TimeStart_EditValueChanged);
            this.txt_TimeStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TimeStart_MouseClick);
            // 
            // but_Exit
            // 
            this.but_Exit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_Exit.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.but_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.but_Exit.Appearance.ForeColor = System.Drawing.Color.White;
            this.but_Exit.Appearance.Options.UseBackColor = true;
            this.but_Exit.Appearance.Options.UseFont = true;
            this.but_Exit.Appearance.Options.UseForeColor = true;
            this.but_Exit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.but_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("but_Exit.ImageOptions.Image")));
            this.but_Exit.Location = new System.Drawing.Point(416, 233);
            this.but_Exit.LookAndFeel.SkinMaskColor = System.Drawing.Color.Gray;
            this.but_Exit.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.but_Exit.LookAndFeel.SkinName = "Office 2010 Black";
            this.but_Exit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.but_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_Exit.Name = "but_Exit";
            this.but_Exit.Size = new System.Drawing.Size(110, 36);
            this.but_Exit.TabIndex = 451;
            this.but_Exit.Text = "Đóng";
            this.but_Exit.ToolTipTitle = "ESC";
            this.but_Exit.Click += new System.EventHandler(this.but_Exit_Click);
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
            this.btn_Update.Location = new System.Drawing.Point(235, 233);
            this.btn_Update.LookAndFeel.SkinMaskColor = System.Drawing.Color.RoyalBlue;
            this.btn_Update.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Update.LookAndFeel.SkinName = "Office 2010 Black";
            this.btn_Update.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 36);
            this.btn_Update.TabIndex = 450;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.ToolTipTitle = "Ctrl +S";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_XStart
            // 
            this.txt_XStart.Location = new System.Drawing.Point(235, 54);
            this.txt_XStart.Name = "txt_XStart";
            this.txt_XStart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XStart.Properties.Appearance.Options.UseFont = true;
            this.txt_XStart.Size = new System.Drawing.Size(291, 22);
            this.txt_XStart.TabIndex = 468;
            // 
            // txt_XEnd
            // 
            this.txt_XEnd.Location = new System.Drawing.Point(235, 110);
            this.txt_XEnd.Name = "txt_XEnd";
            this.txt_XEnd.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XEnd.Properties.Appearance.Options.UseFont = true;
            this.txt_XEnd.Size = new System.Drawing.Size(291, 22);
            this.txt_XEnd.TabIndex = 469;
            // 
            // txt_YStart
            // 
            this.txt_YStart.Location = new System.Drawing.Point(235, 82);
            this.txt_YStart.Name = "txt_YStart";
            this.txt_YStart.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_YStart.Properties.Appearance.Options.UseFont = true;
            this.txt_YStart.Size = new System.Drawing.Size(291, 22);
            this.txt_YStart.TabIndex = 471;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(115, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 16);
            this.labelControl2.TabIndex = 470;
            this.labelControl2.Text = "Tọa Độ Y Bắt Đầu";
            // 
            // txt_YEnd
            // 
            this.txt_YEnd.Location = new System.Drawing.Point(235, 138);
            this.txt_YEnd.Name = "txt_YEnd";
            this.txt_YEnd.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_YEnd.Properties.Appearance.Options.UseFont = true;
            this.txt_YEnd.Size = new System.Drawing.Size(291, 22);
            this.txt_YEnd.TabIndex = 473;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(111, 137);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 16);
            this.labelControl3.TabIndex = 472;
            this.labelControl3.Text = "Tọa Độ Y Kết Thúc";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(141, 167);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 16);
            this.labelControl4.TabIndex = 475;
            this.labelControl4.Text = "Số Bước Nhảy";
            // 
            // txt_BuocNhay
            // 
            this.txt_BuocNhay.Location = new System.Drawing.Point(235, 166);
            this.txt_BuocNhay.Name = "txt_BuocNhay";
            this.txt_BuocNhay.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuocNhay.Properties.Appearance.Options.UseFont = true;
            this.txt_BuocNhay.Size = new System.Drawing.Size(291, 22);
            this.txt_BuocNhay.TabIndex = 474;
            // 
            // frm_UpdateAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 288);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_BuocNhay);
            this.Controls.Add(this.txt_YEnd);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_YStart);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_XEnd);
            this.Controls.Add(this.txt_XStart);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.btn_AddBuildingContractor);
            this.Controls.Add(this.lke_VaThe);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_TimeStart);
            this.Controls.Add(this.but_Exit);
            this.Controls.Add(this.btn_Update);
            this.Name = "frm_UpdateAction";
            this.ShowIcon = false;
            this.Text = "CHỈNH SỬA HOẠT ĐỘNG";
            this.Load += new System.EventHandler(this.frm_UpdateAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lke_VaThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TimeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BuocNhay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.SimpleButton btn_AddBuildingContractor;
        private DevExpress.XtraEditors.LookUpEdit lke_VaThe;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_TimeStart;
        private DevExpress.XtraEditors.SimpleButton but_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.TextEdit txt_XStart;
        private DevExpress.XtraEditors.TextEdit txt_XEnd;
        private DevExpress.XtraEditors.TextEdit txt_YStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_YEnd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_BuocNhay;
    }
}