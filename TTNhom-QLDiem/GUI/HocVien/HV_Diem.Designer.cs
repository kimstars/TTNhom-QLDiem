
namespace TTNhom_QLDiem.GUI.HocVien
{
    partial class HV_Diem
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenGV = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemTK = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemThi = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemTX = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemCC = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHP = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvChitietDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemTX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.tablePanel1.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.cbTK);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtTenGV);
            this.groupControl1.Controls.Add(this.txtDiemTK);
            this.groupControl1.Controls.Add(this.txtDiemThi);
            this.groupControl1.Controls.Add(this.txtDiemTX);
            this.groupControl1.Controls.Add(this.txtDiemCC);
            this.groupControl1.Controls.Add(this.txtTenHP);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 0);
            this.groupControl1.Size = new System.Drawing.Size(883, 227);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin phiếu điểm";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = "Tên học kỳ";
            this.radioGroup1.Location = new System.Drawing.Point(621, 106);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Tên học kỳ", "Tên học kỳ", true, null, "TenHocKy"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Tên học phần", "Tên học phần", true, null, "TenHocPhan")});
            this.radioGroup1.Size = new System.Drawing.Size(239, 37);
            this.radioGroup1.TabIndex = 17;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // cbTK
            // 
            this.cbTK.FormattingEnabled = true;
            this.cbTK.Location = new System.Drawing.Point(621, 150);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(121, 24);
            this.cbTK.TabIndex = 15;
            this.cbTK.SelectedIndexChanged += new System.EventHandler(this.cbTK_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tìm kiếm theo:";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Location = new System.Drawing.Point(443, 151);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(125, 22);
            this.txtTenGV.TabIndex = 11;
            // 
            // txtDiemTK
            // 
            this.txtDiemTK.Enabled = false;
            this.txtDiemTK.Location = new System.Drawing.Point(443, 114);
            this.txtDiemTK.Name = "txtDiemTK";
            this.txtDiemTK.Size = new System.Drawing.Size(125, 22);
            this.txtDiemTK.TabIndex = 10;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Enabled = false;
            this.txtDiemThi.Location = new System.Drawing.Point(443, 75);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(125, 22);
            this.txtDiemThi.TabIndex = 9;
            // 
            // txtDiemTX
            // 
            this.txtDiemTX.Enabled = false;
            this.txtDiemTX.Location = new System.Drawing.Point(179, 149);
            this.txtDiemTX.Name = "txtDiemTX";
            this.txtDiemTX.Size = new System.Drawing.Size(125, 22);
            this.txtDiemTX.TabIndex = 8;
            // 
            // txtDiemCC
            // 
            this.txtDiemCC.Enabled = false;
            this.txtDiemCC.Location = new System.Drawing.Point(179, 112);
            this.txtDiemCC.Name = "txtDiemCC";
            this.txtDiemCC.Size = new System.Drawing.Size(125, 22);
            this.txtDiemCC.TabIndex = 7;
            // 
            // txtTenHP
            // 
            this.txtTenHP.Enabled = false;
            this.txtTenHP.Location = new System.Drawing.Point(179, 73);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(125, 22);
            this.txtTenHP.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điểm chuyên cần";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm thường xuyên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên giảng viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm tổng kết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên học phần";
            // 
            // gridControl1
            // 
            this.tablePanel1.SetColumn(this.gridControl1, 0);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 236);
            this.gridControl1.MainView = this.dgvChitietDiem;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel1.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(883, 530);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChitietDiem});
            // 
            // dgvChitietDiem
            // 
            this.dgvChitietDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.dgvChitietDiem.GridControl = this.gridControl1;
            this.dgvChitietDiem.Name = "dgvChitietDiem";
            this.dgvChitietDiem.OptionsBehavior.Editable = false;
            this.dgvChitietDiem.OptionsView.ShowGroupPanel = false;
            this.dgvChitietDiem.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.dgvChitietDiem_RowClick);
            this.dgvChitietDiem.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvChitietDiem_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên học phần";
            this.gridColumn1.FieldName = "TenHocPhan";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Điểm CC";
            this.gridColumn2.FieldName = "DiemCC";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Điểm TX";
            this.gridColumn3.FieldName = "DiemTX";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điểm thi";
            this.gridColumn4.FieldName = "DiemThi";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Điểm tổng kết";
            this.gridColumn5.FieldName = "DiemTK";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tên giảng viên";
            this.gridColumn6.FieldName = "HoTenGV";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tên học kỳ";
            this.gridColumn7.FieldName = "TenHocKy";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 94;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.56F)});
            this.tablePanel1.Controls.Add(this.gridControl1);
            this.tablePanel1.Controls.Add(this.groupControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 233.2012F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(889, 769);
            this.tablePanel1.TabIndex = 0;
            // 
            // HV_Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Name = "HV_Diem";
            this.Size = new System.Drawing.Size(889, 769);
            this.Load += new System.EventHandler(this.HV_Diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemTX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitietDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChitietDiem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.ComboBox cbTK;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtTenGV;
        private DevExpress.XtraEditors.TextEdit txtDiemTK;
        private DevExpress.XtraEditors.TextEdit txtDiemThi;
        private DevExpress.XtraEditors.TextEdit txtDiemTX;
        private DevExpress.XtraEditors.TextEdit txtDiemCC;
        private DevExpress.XtraEditors.TextEdit txtTenHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}
