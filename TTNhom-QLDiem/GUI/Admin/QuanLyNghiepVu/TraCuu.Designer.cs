
namespace TTNhom_QLDiem.GUI.Admin.QuanLyNghiepVu
{
    partial class TraCuu
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_monthi = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ten_hoc_vien = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ma_hoc_vien = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monthi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten_hoc_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ma_hoc_vien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(14, 183);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1151, 609);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Điểm Thi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btn_search);
            this.groupControl2.Controls.Add(this.txt_monthi);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.tb_ten_hoc_vien);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.tb_ma_hoc_vien);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(16, 61);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1147, 116);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Bộ lọc";
            this.groupControl2.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.Location = new System.Drawing.Point(1018, 47);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(106, 39);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Tìm Kiếm";
            // 
            // txt_monthi
            // 
            this.txt_monthi.Location = new System.Drawing.Point(757, 49);
            this.txt_monthi.Name = "txt_monthi";
            this.txt_monthi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthi.Properties.Appearance.Options.UseFont = true;
            this.txt_monthi.Size = new System.Drawing.Size(148, 32);
            this.txt_monthi.TabIndex = 6;
            this.txt_monthi.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Môn Thi";
            this.label3.Visible = false;
            // 
            // tb_ten_hoc_vien
            // 
            this.tb_ten_hoc_vien.Location = new System.Drawing.Point(448, 49);
            this.tb_ten_hoc_vien.Name = "tb_ten_hoc_vien";
            this.tb_ten_hoc_vien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten_hoc_vien.Properties.Appearance.Options.UseFont = true;
            this.tb_ten_hoc_vien.Size = new System.Drawing.Size(148, 32);
            this.tb_ten_hoc_vien.TabIndex = 4;
            this.tb_ten_hoc_vien.Visible = false;
            this.tb_ten_hoc_vien.EditValueChanged += new System.EventHandler(this.tb_ten_hoc_vien_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học viên";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_ma_hoc_vien
            // 
            this.tb_ma_hoc_vien.Location = new System.Drawing.Point(142, 49);
            this.tb_ma_hoc_vien.Name = "tb_ma_hoc_vien";
            this.tb_ma_hoc_vien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ma_hoc_vien.Properties.Appearance.Options.UseFont = true;
            this.tb_ma_hoc_vien.Size = new System.Drawing.Size(148, 32);
            this.tb_ma_hoc_vien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(389, -7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(397, 37);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tra Cứu Điểm Thi Học Viên";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1147, 579);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 785);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "TraCuu";
            this.Text = "TraCuu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_monthi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten_hoc_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ma_hoc_vien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit tb_ten_hoc_vien;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tb_ma_hoc_vien;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.TextEdit txt_monthi;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}