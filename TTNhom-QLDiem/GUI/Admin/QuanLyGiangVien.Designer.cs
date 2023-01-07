
namespace TTNhom_QLDiem.GUI.Admin
{
    partial class QuanLyGiangVien
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.Thêm = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateThemNgaySinhCB = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThemMaTKCB = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThemChucVuCB = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThemCapBacCB = new DevExpress.XtraEditors.TextEdit();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtThemTenCB = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThemCB = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dgvTTCB = new DevExpress.XtraGrid.GridControl();
            this.dgvTTCB_View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thêm)).BeginInit();
            this.Thêm.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateThemNgaySinhCB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThemNgaySinhCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemMaTKCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemChucVuCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemCapBacCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemTenCB.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTCB_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.Thêm);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 462);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1121, 298);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Chỉnh sửa thông tin ";
            // 
            // Thêm
            // 
            this.Thêm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Thêm.Location = new System.Drawing.Point(2, 28);
            this.Thêm.Name = "Thêm";
            this.Thêm.SelectedTabPage = this.xtraTabPage1;
            this.Thêm.Size = new System.Drawing.Size(1117, 268);
            this.Thêm.TabIndex = 0;
            this.Thêm.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.comboBox1);
            this.xtraTabPage1.Controls.Add(this.dateThemNgaySinhCB);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtThemMaTKCB);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.txtThemChucVuCB);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.txtThemCapBacCB);
            this.xtraTabPage1.Controls.Add(this.label14);
            this.xtraTabPage1.Controls.Add(this.label15);
            this.xtraTabPage1.Controls.Add(this.txtThemTenCB);
            this.xtraTabPage1.Controls.Add(this.label16);
            this.xtraTabPage1.Controls.Add(this.btnThemCB);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1115, 237);
            this.xtraTabPage1.Text = "Thêm";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // dateThemNgaySinhCB
            // 
            this.dateThemNgaySinhCB.EditValue = null;
            this.dateThemNgaySinhCB.Location = new System.Drawing.Point(43, 99);
            this.dateThemNgaySinhCB.Name = "dateThemNgaySinhCB";
            this.dateThemNgaySinhCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThemNgaySinhCB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateThemNgaySinhCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateThemNgaySinhCB.Size = new System.Drawing.Size(235, 22);
            this.dateThemNgaySinhCB.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bộ môn";
            // 
            // txtThemMaTKCB
            // 
            this.txtThemMaTKCB.EditValue = "";
            this.txtThemMaTKCB.Location = new System.Drawing.Point(425, 164);
            this.txtThemMaTKCB.Name = "txtThemMaTKCB";
            this.txtThemMaTKCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThemMaTKCB.Size = new System.Drawing.Size(287, 22);
            this.txtThemMaTKCB.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tài khoản";
            // 
            // txtThemChucVuCB
            // 
            this.txtThemChucVuCB.EditValue = "";
            this.txtThemChucVuCB.Location = new System.Drawing.Point(424, 45);
            this.txtThemChucVuCB.Name = "txtThemChucVuCB";
            this.txtThemChucVuCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThemChucVuCB.Size = new System.Drawing.Size(288, 22);
            this.txtThemChucVuCB.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chức vụ";
            // 
            // txtThemCapBacCB
            // 
            this.txtThemCapBacCB.EditValue = "";
            this.txtThemCapBacCB.Location = new System.Drawing.Point(43, 164);
            this.txtThemCapBacCB.Name = "txtThemCapBacCB";
            this.txtThemCapBacCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThemCapBacCB.Size = new System.Drawing.Size(235, 22);
            this.txtThemCapBacCB.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Cấp bậc";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Ngày sinh";
            // 
            // txtThemTenCB
            // 
            this.txtThemTenCB.EditValue = "";
            this.txtThemTenCB.Location = new System.Drawing.Point(43, 45);
            this.txtThemTenCB.Name = "txtThemTenCB";
            this.txtThemTenCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtThemTenCB.Size = new System.Drawing.Size(235, 22);
            this.txtThemTenCB.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Họ tên";
            // 
            // btnThemCB
            // 
            this.btnThemCB.Location = new System.Drawing.Point(774, 43);
            this.btnThemCB.Name = "btnThemCB";
            this.btnThemCB.Size = new System.Drawing.Size(146, 140);
            this.btnThemCB.TabIndex = 14;
            this.btnThemCB.Text = "Thêm";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.comboBox2);
            this.xtraTabPage2.Controls.Add(this.dateEdit1);
            this.xtraTabPage2.Controls.Add(this.label6);
            this.xtraTabPage2.Controls.Add(this.textEdit3);
            this.xtraTabPage2.Controls.Add(this.label7);
            this.xtraTabPage2.Controls.Add(this.textEdit4);
            this.xtraTabPage2.Controls.Add(this.label8);
            this.xtraTabPage2.Controls.Add(this.textEdit5);
            this.xtraTabPage2.Controls.Add(this.label9);
            this.xtraTabPage2.Controls.Add(this.label10);
            this.xtraTabPage2.Controls.Add(this.textEdit6);
            this.xtraTabPage2.Controls.Add(this.label11);
            this.xtraTabPage2.Controls.Add(this.simpleButton1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1115, 237);
            this.xtraTabPage2.Text = "Sửa";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(426, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(288, 24);
            this.comboBox2.TabIndex = 50;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(45, 104);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateEdit1.Size = new System.Drawing.Size(235, 22);
            this.dateEdit1.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Bộ môn";
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "";
            this.textEdit3.Location = new System.Drawing.Point(427, 159);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEdit3.Size = new System.Drawing.Size(287, 22);
            this.textEdit3.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tài khoản";
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "";
            this.textEdit4.Location = new System.Drawing.Point(426, 50);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEdit4.Size = new System.Drawing.Size(288, 22);
            this.textEdit4.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Chức vụ";
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "";
            this.textEdit5.Location = new System.Drawing.Point(45, 159);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEdit5.Size = new System.Drawing.Size(235, 22);
            this.textEdit5.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cấp bậc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Ngày sinh";
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "";
            this.textEdit6.Location = new System.Drawing.Point(45, 50);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textEdit6.Size = new System.Drawing.Size(235, 22);
            this.textEdit6.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Họ tên";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(776, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(146, 140);
            this.simpleButton1.TabIndex = 38;
            this.simpleButton1.Text = "Thêm";
            // 
            // dgvTTCB
            // 
            this.dgvTTCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTCB.Location = new System.Drawing.Point(2, 28);
            this.dgvTTCB.MainView = this.dgvTTCB_View;
            this.dgvTTCB.Name = "dgvTTCB";
            this.dgvTTCB.Size = new System.Drawing.Size(1117, 432);
            this.dgvTTCB.TabIndex = 0;
            this.dgvTTCB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvTTCB_View});
            // 
            // dgvTTCB_View
            // 
            this.dgvTTCB_View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.dgvTTCB_View.GridControl = this.dgvTTCB;
            this.dgvTTCB_View.Name = "dgvTTCB_View";
            this.dgvTTCB_View.OptionsBehavior.Editable = false;
            this.dgvTTCB_View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã giảng viên";
            this.gridColumn1.FieldName = "MaGiangVien";
            this.gridColumn1.MinWidth = 29;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 107;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Họ tên";
            this.gridColumn2.FieldName = "HoTen";
            this.gridColumn2.MinWidth = 29;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 107;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày sinh";
            this.gridColumn3.FieldName = "NgaySinh";
            this.gridColumn3.MinWidth = 29;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 107;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cấp bậc";
            this.gridColumn4.FieldName = "CapBac";
            this.gridColumn4.MinWidth = 29;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 107;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Chức vụ";
            this.gridColumn5.FieldName = "ChucVu";
            this.gridColumn5.MinWidth = 29;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 107;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên đăng nhập";
            this.gridColumn6.FieldName = "TenDangNhap";
            this.gridColumn6.MinWidth = 29;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 107;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên bộ môn";
            this.gridColumn7.FieldName = "TenBoMon";
            this.gridColumn7.MinWidth = 29;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 107;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvTTCB);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1121, 462);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Danh sách giảng viên";
            // 
            // QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "QuanLyGiangVien";
            this.Size = new System.Drawing.Size(1121, 760);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thêm)).EndInit();
            this.Thêm.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateThemNgaySinhCB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateThemNgaySinhCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemMaTKCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemChucVuCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemCapBacCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThemTenCB.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTCB_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraTab.XtraTabControl Thêm;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.DateEdit dateThemNgaySinhCB;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtThemMaTKCB;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtThemChucVuCB;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtThemCapBacCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txtThemTenCB;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.SimpleButton btnThemCB;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl dgvTTCB;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvTTCB_View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
