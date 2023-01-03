
namespace TTNhom_QLDiem.GUI
{
    partial class Login
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
            this.grpCtrl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditNhoMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lbPass = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrl1)).BeginInit();
            this.grpCtrl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNhoMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCtrl1
            // 
            this.grpCtrl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCtrl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.grpCtrl1.Appearance.Options.UseBackColor = true;
            this.grpCtrl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grpCtrl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCtrl1.AppearanceCaption.Options.UseBackColor = true;
            this.grpCtrl1.AppearanceCaption.Options.UseFont = true;
            this.grpCtrl1.Controls.Add(this.pictureBox1);
            this.grpCtrl1.Controls.Add(this.btnCancel);
            this.grpCtrl1.Controls.Add(this.btnOK);
            this.grpCtrl1.Controls.Add(this.checkEditNhoMatKhau);
            this.grpCtrl1.Controls.Add(this.checkEditHienMatKhau);
            this.grpCtrl1.Controls.Add(this.txtPass);
            this.grpCtrl1.Controls.Add(this.lbPass);
            this.grpCtrl1.Controls.Add(this.txtUser);
            this.grpCtrl1.Controls.Add(this.lbUser);
            this.grpCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCtrl1.Location = new System.Drawing.Point(0, 0);
            this.grpCtrl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.grpCtrl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grpCtrl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCtrl1.Name = "grpCtrl1";
            this.grpCtrl1.Size = new System.Drawing.Size(553, 274);
            this.grpCtrl1.TabIndex = 2;
            this.grpCtrl1.Text = "Thông tin đăng nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::TTNhom_QLDiem.Properties.Resources.japan_lofi;
            this.pictureBox1.Location = new System.Drawing.Point(6, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 212);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(131, 212);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Đăng nhập";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkEditNhoMatKhau
            // 
            this.checkEditNhoMatKhau.Location = new System.Drawing.Point(179, 168);
            this.checkEditNhoMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEditNhoMatKhau.Name = "checkEditNhoMatKhau";
            this.checkEditNhoMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditNhoMatKhau.Properties.Appearance.Options.UseFont = true;
            this.checkEditNhoMatKhau.Properties.Caption = "Nhớ mật khẩu";
            this.checkEditNhoMatKhau.Size = new System.Drawing.Size(114, 23);
            this.checkEditNhoMatKhau.TabIndex = 5;
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(390, 139);
            this.checkEditHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditHienMatKhau.Properties.Appearance.Options.UseFont = true;
            this.checkEditHienMatKhau.Properties.Caption = "Hiện mật khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(122, 23);
            this.checkEditHienMatKhau.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(177, 135);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(207, 30);
            this.txtPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Appearance.Options.UseFont = true;
            this.lbPass.Location = new System.Drawing.Point(179, 109);
            this.lbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(81, 23);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(179, 67);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(207, 30);
            this.txtUser.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(179, 41);
            this.lbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(122, 23);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 274);
            this.Controls.Add(this.grpCtrl1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrl1)).EndInit();
            this.grpCtrl1.ResumeLayout(false);
            this.grpCtrl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditNhoMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCtrl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckEdit checkEditNhoMatKhau;
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
        public DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl lbPass;
        public DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl lbUser;
    }
}