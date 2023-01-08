
namespace TTNhom_QLDiem.GUI.GiangVien
{
    partial class XemDSHocVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl_HocVien = new DevExpress.XtraEditors.GroupControl();
            this.grid_HocVien = new DevExpress.XtraGrid.GridControl();
            this.gridView_HocVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grDS_LopChuyenNganh = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_DSChuyenNganh = new DevExpress.XtraGrid.GridControl();
            this.grdView_DSLopChuyenNganh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cbHocPhan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoMon = new System.Windows.Forms.ComboBox();
            this.cbLopHPphutrach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_HocVien)).BeginInit();
            this.groupControl_HocVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_HocVien)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDS_LopChuyenNganh)).BeginInit();
            this.grDS_LopChuyenNganh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_DSLopChuyenNganh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl_HocVien, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 760);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl_HocVien
            // 
            this.groupControl_HocVien.Controls.Add(this.grid_HocVien);
            this.groupControl_HocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_HocVien.Location = new System.Drawing.Point(563, 3);
            this.groupControl_HocVien.Name = "groupControl_HocVien";
            this.groupControl_HocVien.Size = new System.Drawing.Size(555, 754);
            this.groupControl_HocVien.TabIndex = 3;
            this.groupControl_HocVien.Text = "Danh sách học viên";
            // 
            // grid_HocVien
            // 
            this.grid_HocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_HocVien.Location = new System.Drawing.Point(2, 28);
            this.grid_HocVien.MainView = this.gridView_HocVien;
            this.grid_HocVien.Name = "grid_HocVien";
            this.grid_HocVien.Size = new System.Drawing.Size(551, 724);
            this.grid_HocVien.TabIndex = 0;
            this.grid_HocVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_HocVien});
            // 
            // gridView_HocVien
            // 
            this.gridView_HocVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn14,
            this.gridColumn12,
            this.gridColumn13});
            this.gridView_HocVien.GridControl = this.grid_HocVien;
            this.gridView_HocVien.Name = "gridView_HocVien";
            this.gridView_HocVien.OptionsBehavior.Editable = false;
            this.gridView_HocVien.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Mã học viên";
            this.gridColumn9.FieldName = "MaHocVien";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Tên học viên";
            this.gridColumn10.FieldName = "HoTenHV";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 94;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Giới tính";
            this.gridColumn14.FieldName = "GioiTinh";
            this.gridColumn14.MinWidth = 25;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 4;
            this.gridColumn14.Width = 94;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ngày sinh";
            this.gridColumn12.FieldName = "NgaySinh";
            this.gridColumn12.MinWidth = 25;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 94;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Quê quán ";
            this.gridColumn13.FieldName = "QueQuan";
            this.gridColumn13.MinWidth = 25;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 3;
            this.gridColumn13.Width = 94;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.grDS_LopChuyenNganh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 754);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // grDS_LopChuyenNganh
            // 
            this.grDS_LopChuyenNganh.Controls.Add(this.gridControl_DSChuyenNganh);
            this.grDS_LopChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDS_LopChuyenNganh.Location = new System.Drawing.Point(3, 380);
            this.grDS_LopChuyenNganh.Name = "grDS_LopChuyenNganh";
            this.grDS_LopChuyenNganh.Size = new System.Drawing.Size(548, 371);
            this.grDS_LopChuyenNganh.TabIndex = 4;
            this.grDS_LopChuyenNganh.Text = "Danh sách lớp chuyên ngành phụ trách giảng dạy";
            // 
            // gridControl_DSChuyenNganh
            // 
            this.gridControl_DSChuyenNganh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_DSChuyenNganh.Location = new System.Drawing.Point(2, 28);
            this.gridControl_DSChuyenNganh.MainView = this.grdView_DSLopChuyenNganh;
            this.gridControl_DSChuyenNganh.Name = "gridControl_DSChuyenNganh";
            this.gridControl_DSChuyenNganh.Size = new System.Drawing.Size(544, 341);
            this.gridControl_DSChuyenNganh.TabIndex = 0;
            this.gridControl_DSChuyenNganh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdView_DSLopChuyenNganh});
            // 
            // grdView_DSLopChuyenNganh
            // 
            this.grdView_DSLopChuyenNganh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grdView_DSLopChuyenNganh.GridControl = this.gridControl_DSChuyenNganh;
            this.grdView_DSLopChuyenNganh.Name = "grdView_DSLopChuyenNganh";
            this.grdView_DSLopChuyenNganh.OptionsBehavior.Editable = false;
            this.grdView_DSLopChuyenNganh.OptionsView.ShowGroupPanel = false;
            this.grdView_DSLopChuyenNganh.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdView_DSLopChuyenNganh_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã lớp CN";
            this.gridColumn1.FieldName = "MaLopChuyenNganh";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên lớp CN";
            this.gridColumn2.FieldName = "TenLopChuyenNganh";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tổng học viên";
            this.gridColumn3.FieldName = "TongHV";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 371);
            this.panel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.groupControl3.Controls.Add(this.cbHocPhan);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.cbHocKy);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.cbBoMon);
            this.groupControl3.Controls.Add(this.cbLopHPphutrach);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(548, 371);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Xem Danh sách học viên";
            // 
            // cbHocPhan
            // 
            this.cbHocPhan.FormattingEnabled = true;
            this.cbHocPhan.Location = new System.Drawing.Point(54, 219);
            this.cbHocPhan.Name = "cbHocPhan";
            this.cbHocPhan.Size = new System.Drawing.Size(437, 24);
            this.cbHocPhan.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "Học phần";
            // 
            // cbHocKy
            // 
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(54, 153);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(437, 24);
            this.cbHocKy.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 97;
            this.label2.Text = "Học kỳ";
            // 
            // cbBoMon
            // 
            this.cbBoMon.FormattingEnabled = true;
            this.cbBoMon.Location = new System.Drawing.Point(54, 81);
            this.cbBoMon.Name = "cbBoMon";
            this.cbBoMon.Size = new System.Drawing.Size(437, 24);
            this.cbBoMon.TabIndex = 96;
            // 
            // cbLopHPphutrach
            // 
            this.cbLopHPphutrach.FormattingEnabled = true;
            this.cbLopHPphutrach.Location = new System.Drawing.Point(54, 284);
            this.cbLopHPphutrach.Name = "cbLopHPphutrach";
            this.cbLopHPphutrach.Size = new System.Drawing.Size(437, 24);
            this.cbLopHPphutrach.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 94;
            this.label1.Text = "Lớp học phần đang phụ trách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 91;
            this.label5.Text = "Bộ môn";
            // 
            // XemDSHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "XemDSHocVien";
            this.Size = new System.Drawing.Size(1121, 760);
            this.Load += new System.EventHandler(this.XemDSHocVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_HocVien)).EndInit();
            this.groupControl_HocVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_HocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_HocVien)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDS_LopChuyenNganh)).EndInit();
            this.grDS_LopChuyenNganh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_DSChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_DSLopChuyenNganh)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl_HocVien;
        private DevExpress.XtraGrid.GridControl grid_HocVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_HocVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl grDS_LopChuyenNganh;
        private DevExpress.XtraGrid.GridControl gridControl_DSChuyenNganh;
        private DevExpress.XtraGrid.Views.Grid.GridView grdView_DSLopChuyenNganh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ComboBox cbHocPhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBoMon;
        private System.Windows.Forms.ComboBox cbLopHPphutrach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
