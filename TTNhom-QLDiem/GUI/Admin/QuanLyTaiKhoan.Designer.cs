
namespace TTNhom_QLDiem.GUI.Admin
{
    partial class QuanLyTaiKhoan
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
            this.dgvDSTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.dgvDSTaiKhoan_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Thêm = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtThemMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtThemTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btnThemTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.cbThemQuyen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xtraSuaXoa = new DevExpress.XtraTab.XtraTabPage();
            this.txtSuaMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtSuaTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntXoaTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.bntSuaTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.cbSuaQuyen = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thêm)).BeginInit();
            this.Thêm.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThemQuyen.Properties)).BeginInit();
            this.xtraSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSuaQuyen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.94737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.05264F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 760);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.dgvDSTaiKhoan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 259);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1115, 499);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Danh Sách Tài Khoản";
            // 
            // dgvDSTaiKhoan
            // 
            this.dgvDSTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(2, 28);
            this.dgvDSTaiKhoan.MainView = this.dgvDSTaiKhoan_View;
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(1111, 469);
            this.dgvDSTaiKhoan.TabIndex = 0;
            this.dgvDSTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDSTaiKhoan_View});
            // 
            // dgvDSTaiKhoan_View
            // 
            this.dgvDSTaiKhoan_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.dgvDSTaiKhoan_View.DetailHeight = 329;
            this.dgvDSTaiKhoan_View.GridControl = this.dgvDSTaiKhoan;
            this.dgvDSTaiKhoan_View.Name = "dgvDSTaiKhoan_View";
            this.dgvDSTaiKhoan_View.OptionsBehavior.Editable = false;
            this.dgvDSTaiKhoan_View.OptionsView.ShowGroupPanel = false;
            this.dgvDSTaiKhoan_View.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgvDSTaiKhoan_View_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã tài khoản";
            this.gridColumn1.FieldName = "MaTK";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên đăng nhập";
            this.gridColumn2.FieldName = "TenDangNhap";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Quyền";
            this.gridColumn3.FieldName = "Quyen";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Thêm);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1115, 251);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thông tin tài khoản";
            // 
            // Thêm
            // 
            this.Thêm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Thêm.Location = new System.Drawing.Point(2, 28);
            this.Thêm.Name = "Thêm";
            this.Thêm.SelectedTabPage = this.xtraTabPage1;
            this.Thêm.Size = new System.Drawing.Size(1111, 221);
            this.Thêm.TabIndex = 84;
            this.Thêm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraSuaXoa});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtThemMatKhau);
            this.xtraTabPage1.Controls.Add(this.txtThemTenDangNhap);
            this.xtraTabPage1.Controls.Add(this.btnThemTaiKhoan);
            this.xtraTabPage1.Controls.Add(this.cbThemQuyen);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1109, 190);
            this.xtraTabPage1.Text = "Thêm";
            // 
            // txtThemMatKhau
            // 
            this.txtThemMatKhau.Location = new System.Drawing.Point(54, 131);
            this.txtThemMatKhau.Name = "txtThemMatKhau";
            this.txtThemMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtThemMatKhau.Size = new System.Drawing.Size(181, 24);
            this.txtThemMatKhau.TabIndex = 81;
            // 
            // txtThemTenDangNhap
            // 
            this.txtThemTenDangNhap.Location = new System.Drawing.Point(54, 50);
            this.txtThemTenDangNhap.Name = "txtThemTenDangNhap";
            this.txtThemTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThemTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtThemTenDangNhap.Size = new System.Drawing.Size(181, 24);
            this.txtThemTenDangNhap.TabIndex = 80;
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(432, 110);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(139, 45);
            this.btnThemTaiKhoan.TabIndex = 79;
            this.btnThemTaiKhoan.Text = "Thêm tài khoản";
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // cbThemQuyen
            // 
            this.cbThemQuyen.Location = new System.Drawing.Point(432, 50);
            this.cbThemQuyen.Name = "cbThemQuyen";
            this.cbThemQuyen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbThemQuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThemQuyen.Properties.Appearance.Options.UseBackColor = true;
            this.cbThemQuyen.Properties.Appearance.Options.UseFont = true;
            this.cbThemQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbThemQuyen.Properties.Items.AddRange(new object[] {
            "Admin",
            "Giảng viên",
            "Học viên"});
            this.cbThemQuyen.Size = new System.Drawing.Size(139, 26);
            this.cbThemQuyen.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label10.Location = new System.Drawing.Point(51, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label3.Location = new System.Drawing.Point(429, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Chọn Quyền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label5.Location = new System.Drawing.Point(51, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Tên đăng nhập";
            // 
            // xtraSuaXoa
            // 
            this.xtraSuaXoa.Controls.Add(this.txtSuaMatKhau);
            this.xtraSuaXoa.Controls.Add(this.txtSuaTenDangNhap);
            this.xtraSuaXoa.Controls.Add(this.label1);
            this.xtraSuaXoa.Controls.Add(this.label2);
            this.xtraSuaXoa.Controls.Add(this.bntXoaTaiKhoan);
            this.xtraSuaXoa.Controls.Add(this.bntSuaTaiKhoan);
            this.xtraSuaXoa.Controls.Add(this.cbSuaQuyen);
            this.xtraSuaXoa.Controls.Add(this.label6);
            this.xtraSuaXoa.Name = "xtraSuaXoa";
            this.xtraSuaXoa.Size = new System.Drawing.Size(1109, 190);
            this.xtraSuaXoa.Text = "Sửa / Xóa";
            // 
            // txtSuaMatKhau
            // 
            this.txtSuaMatKhau.Location = new System.Drawing.Point(72, 107);
            this.txtSuaMatKhau.Name = "txtSuaMatKhau";
            this.txtSuaMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtSuaMatKhau.Size = new System.Drawing.Size(181, 24);
            this.txtSuaMatKhau.TabIndex = 93;
            // 
            // txtSuaTenDangNhap
            // 
            this.txtSuaTenDangNhap.Location = new System.Drawing.Point(72, 51);
            this.txtSuaTenDangNhap.Name = "txtSuaTenDangNhap";
            this.txtSuaTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtSuaTenDangNhap.Size = new System.Drawing.Size(181, 24);
            this.txtSuaTenDangNhap.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label1.Location = new System.Drawing.Point(69, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Mật Khẩu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label2.Location = new System.Drawing.Point(69, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tên đăng nhập";
            // 
            // bntXoaTaiKhoan
            // 
            this.bntXoaTaiKhoan.Location = new System.Drawing.Point(644, 50);
            this.bntXoaTaiKhoan.Name = "bntXoaTaiKhoan";
            this.bntXoaTaiKhoan.Size = new System.Drawing.Size(108, 81);
            this.bntXoaTaiKhoan.TabIndex = 89;
            this.bntXoaTaiKhoan.Text = "Xóa";
            this.bntXoaTaiKhoan.Click += new System.EventHandler(this.bntXoaTaiKhoan_Click);
            // 
            // bntSuaTaiKhoan
            // 
            this.bntSuaTaiKhoan.Location = new System.Drawing.Point(503, 50);
            this.bntSuaTaiKhoan.Name = "bntSuaTaiKhoan";
            this.bntSuaTaiKhoan.Size = new System.Drawing.Size(114, 81);
            this.bntSuaTaiKhoan.TabIndex = 88;
            this.bntSuaTaiKhoan.Text = "Lưu thay đổi";
            this.bntSuaTaiKhoan.Click += new System.EventHandler(this.bntSuaTaiKhoan_Click);
            // 
            // cbSuaQuyen
            // 
            this.cbSuaQuyen.Location = new System.Drawing.Point(315, 51);
            this.cbSuaQuyen.Name = "cbSuaQuyen";
            this.cbSuaQuyen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuaQuyen.Properties.Appearance.Options.UseFont = true;
            this.cbSuaQuyen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSuaQuyen.Properties.Items.AddRange(new object[] {
            "Giảng viên",
            "Học viên",
            "Admin"});
            this.cbSuaQuyen.Size = new System.Drawing.Size(141, 26);
            this.cbSuaQuyen.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.label6.Location = new System.Drawing.Point(312, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 82;
            this.label6.Text = "Chọn Quyền";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1121, 760);
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thêm)).EndInit();
            this.Thêm.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbThemQuyen.Properties)).EndInit();
            this.xtraSuaXoa.ResumeLayout(false);
            this.xtraSuaXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSuaQuyen.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvDSTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDSTaiKhoan_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnThemTaiKhoan;
        private DevExpress.XtraEditors.ComboBoxEdit cbThemQuyen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraTab.XtraTabControl Thêm;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraSuaXoa;
        private DevExpress.XtraEditors.SimpleButton bntSuaTaiKhoan;
        private DevExpress.XtraEditors.ComboBoxEdit cbSuaQuyen;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton bntXoaTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtThemTenDangNhap;
        private DevExpress.XtraEditors.TextEdit txtThemMatKhau;
        private DevExpress.XtraEditors.TextEdit txtSuaMatKhau;
        private DevExpress.XtraEditors.TextEdit txtSuaTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
