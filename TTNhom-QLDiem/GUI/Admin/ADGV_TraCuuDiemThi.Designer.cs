
namespace TTNhom_QLDiem.GUI.Admin
{
    partial class ADGV_TraCuuDiemThi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColMaHV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTenHV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColLopCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColHocPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDiemCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDiemTX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDiemThi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColDiemTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbMonThi = new System.Windows.Forms.ComboBox();
            this.cbLopCN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenHV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaHV = new DevExpress.XtraEditors.TextEdit();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 222);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1004, 434);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Điểm Thi";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1000, 401);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColMaHV,
            this.gridColTenHV,
            this.gridColNS,
            this.gridColLopCN,
            this.gridColHocPhan,
            this.gridColDiemCC,
            this.gridColDiemTX,
            this.gridColDiemThi,
            this.gridColDiemTK});
            this.gridView1.DetailHeight = 329;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColMaHV
            // 
            this.gridColMaHV.Caption = "Mã học viên";
            this.gridColMaHV.FieldName = "MaHocVien";
            this.gridColMaHV.MinWidth = 25;
            this.gridColMaHV.Name = "gridColMaHV";
            this.gridColMaHV.Visible = true;
            this.gridColMaHV.VisibleIndex = 0;
            this.gridColMaHV.Width = 94;
            // 
            // gridColTenHV
            // 
            this.gridColTenHV.Caption = "Họ và tên";
            this.gridColTenHV.FieldName = "HoTenHV";
            this.gridColTenHV.MinWidth = 25;
            this.gridColTenHV.Name = "gridColTenHV";
            this.gridColTenHV.Visible = true;
            this.gridColTenHV.VisibleIndex = 1;
            this.gridColTenHV.Width = 94;
            // 
            // gridColNS
            // 
            this.gridColNS.Caption = "Ngày sinh";
            this.gridColNS.FieldName = "NgaySinh";
            this.gridColNS.MinWidth = 25;
            this.gridColNS.Name = "gridColNS";
            this.gridColNS.Visible = true;
            this.gridColNS.VisibleIndex = 2;
            this.gridColNS.Width = 94;
            // 
            // gridColLopCN
            // 
            this.gridColLopCN.Caption = "Lớp";
            this.gridColLopCN.FieldName = "TenLopChuyenNganh";
            this.gridColLopCN.MinWidth = 25;
            this.gridColLopCN.Name = "gridColLopCN";
            this.gridColLopCN.Visible = true;
            this.gridColLopCN.VisibleIndex = 3;
            this.gridColLopCN.Width = 94;
            // 
            // gridColHocPhan
            // 
            this.gridColHocPhan.Caption = "Môn học";
            this.gridColHocPhan.FieldName = "TenHocPhan";
            this.gridColHocPhan.MinWidth = 25;
            this.gridColHocPhan.Name = "gridColHocPhan";
            this.gridColHocPhan.Visible = true;
            this.gridColHocPhan.VisibleIndex = 4;
            this.gridColHocPhan.Width = 94;
            // 
            // gridColDiemCC
            // 
            this.gridColDiemCC.Caption = "Điểm CC";
            this.gridColDiemCC.FieldName = "DiemCC";
            this.gridColDiemCC.MinWidth = 25;
            this.gridColDiemCC.Name = "gridColDiemCC";
            this.gridColDiemCC.Visible = true;
            this.gridColDiemCC.VisibleIndex = 5;
            this.gridColDiemCC.Width = 94;
            // 
            // gridColDiemTX
            // 
            this.gridColDiemTX.Caption = "Điểm TX";
            this.gridColDiemTX.FieldName = "DiemTX";
            this.gridColDiemTX.MinWidth = 25;
            this.gridColDiemTX.Name = "gridColDiemTX";
            this.gridColDiemTX.Visible = true;
            this.gridColDiemTX.VisibleIndex = 6;
            this.gridColDiemTX.Width = 94;
            // 
            // gridColDiemThi
            // 
            this.gridColDiemThi.Caption = "Điểm thi";
            this.gridColDiemThi.FieldName = "DiemThi";
            this.gridColDiemThi.MinWidth = 25;
            this.gridColDiemThi.Name = "gridColDiemThi";
            this.gridColDiemThi.Visible = true;
            this.gridColDiemThi.VisibleIndex = 7;
            this.gridColDiemThi.Width = 94;
            // 
            // gridColDiemTK
            // 
            this.gridColDiemTK.Caption = "Điểm Tổng Kết";
            this.gridColDiemTK.FieldName = "DiemTK";
            this.gridColDiemTK.MinWidth = 25;
            this.gridColDiemTK.Name = "gridColDiemTK";
            this.gridColDiemTK.Visible = true;
            this.gridColDiemTK.VisibleIndex = 8;
            this.gridColDiemTK.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbMonThi);
            this.groupControl2.Controls.Add(this.cbLopCN);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.cbHocKy);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtTenHV);
            this.groupControl2.Controls.Add(this.txtMaHV);
            this.groupControl2.Controls.Add(this.btn_search);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1004, 213);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tra cứu điểm thi";
            // 
            // cbMonThi
            // 
            this.cbMonThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMonThi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonThi.FormattingEnabled = true;
            this.cbMonThi.Location = new System.Drawing.Point(55, 173);
            this.cbMonThi.Name = "cbMonThi";
            this.cbMonThi.Size = new System.Drawing.Size(188, 26);
            this.cbMonThi.TabIndex = 14;
            // 
            // cbLopCN
            // 
            this.cbLopCN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbLopCN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLopCN.FormattingEnabled = true;
            this.cbLopCN.Location = new System.Drawing.Point(55, 115);
            this.cbLopCN.Name = "cbLopCN";
            this.cbLopCN.Size = new System.Drawing.Size(188, 26);
            this.cbLopCN.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lớp CN";
            // 
            // cbHocKy
            // 
            this.cbHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbHocKy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(55, 57);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(188, 26);
            this.cbHocKy.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Học kỳ";
            // 
            // txtTenHV
            // 
            this.txtTenHV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenHV.Location = new System.Drawing.Point(477, 113);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHV.Properties.Appearance.Options.UseFont = true;
            this.txtTenHV.Size = new System.Drawing.Size(177, 24);
            this.txtTenHV.TabIndex = 9;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaHV.Location = new System.Drawing.Point(477, 54);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Properties.Appearance.Options.UseFont = true;
            this.txtMaHV.Size = new System.Drawing.Size(177, 24);
            this.txtMaHV.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.Location = new System.Drawing.Point(831, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(106, 92);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn Thi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học viên";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // ADGV_TraCuuDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ADGV_TraCuuDiemThi";
            this.Size = new System.Drawing.Size(1010, 659);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMaHV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTenHV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColLopCN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColHocPhan;
        private System.Windows.Forms.ComboBox cbMonThi;
        private System.Windows.Forms.ComboBox cbLopCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTenHV;
        private DevExpress.XtraEditors.TextEdit txtMaHV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDiemCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDiemTX;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDiemThi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColDiemTK;
    }
}
