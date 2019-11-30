namespace TestRada1
{
    partial class Form2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.phuongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryLUE1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.yEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buocNhay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLUE1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryLUE1});
            this.gridControl1.Size = new System.Drawing.Size(1052, 333);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.phuongTien,
            this.xStart,
            this.yStart,
            this.xEnd,
            this.yEnd,
            this.buocNhay,
            this.time});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // phuongTien
            // 
            this.phuongTien.Caption = "Phương Tiện";
            this.phuongTien.ColumnEdit = this.repositoryLUE1;
            this.phuongTien.FieldName = "phuongTien";
            this.phuongTien.Name = "phuongTien";
            this.phuongTien.Visible = true;
            this.phuongTien.VisibleIndex = 0;
            // 
            // repositoryLUE1
            // 
            this.repositoryLUE1.AutoHeight = false;
            this.repositoryLUE1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryLUE1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatThe_id", "Mã Vật Thể"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatThe_name", "Tên Vật Thể")});
            this.repositoryLUE1.Name = "repositoryLUE1";
            // 
            // xStart
            // 
            this.xStart.Caption = "X Bắt Đầu";
            this.xStart.FieldName = "xStart";
            this.xStart.Name = "xStart";
            this.xStart.Visible = true;
            this.xStart.VisibleIndex = 1;
            // 
            // yStart
            // 
            this.yStart.Caption = "Y Bắt Đầu";
            this.yStart.FieldName = "yStart";
            this.yStart.Name = "yStart";
            this.yStart.Visible = true;
            this.yStart.VisibleIndex = 2;
            // 
            // xEnd
            // 
            this.xEnd.Caption = "X Kết Thúc";
            this.xEnd.FieldName = "xEnd";
            this.xEnd.Name = "xEnd";
            this.xEnd.Visible = true;
            this.xEnd.VisibleIndex = 3;
            // 
            // yEnd
            // 
            this.yEnd.Caption = "Y Kết Thúc";
            this.yEnd.FieldName = "yEnd";
            this.yEnd.Name = "yEnd";
            this.yEnd.Visible = true;
            this.yEnd.VisibleIndex = 4;
            // 
            // buocNhay
            // 
            this.buocNhay.Caption = "Bước Nhảy";
            this.buocNhay.FieldName = "buocNhay";
            this.buocNhay.Name = "buocNhay";
            this.buocNhay.Visible = true;
            this.buocNhay.VisibleIndex = 5;
            // 
            // time
            // 
            this.time.Caption = "Thời Gian Bắt Đầu (s)";
            this.time.FieldName = "time";
            this.time.Name = "time";
            this.time.Visible = true;
            this.time.VisibleIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(523, 91);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(626, 91);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "Xóa";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 453);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLUE1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn phuongTien;
        private DevExpress.XtraGrid.Columns.GridColumn xStart;
        private DevExpress.XtraGrid.Columns.GridColumn yStart;
        private DevExpress.XtraGrid.Columns.GridColumn xEnd;
        private DevExpress.XtraGrid.Columns.GridColumn yEnd;
        private DevExpress.XtraGrid.Columns.GridColumn buocNhay;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn time;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryLUE1;
    }
}