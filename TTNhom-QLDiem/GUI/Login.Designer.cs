
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lbPass = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(386, 24);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "ĐĂNG NHẬP QUẢN LÝ ĐIỂM MTA 2023";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(86, 275);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(308, 37);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDangNhap.Location = new System.Drawing.Point(86, 227);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(308, 37);
            this.btnDangNhap.TabIndex = 37;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(86, 197);
            this.checkEditHienMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditHienMatKhau.Properties.Appearance.Options.UseFont = true;
            this.checkEditHienMatKhau.Properties.Caption = "Hiện mật khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(172, 27);
            this.checkEditHienMatKhau.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(86, 154);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(308, 28);
            this.txtPassword.TabIndex = 36;
            // 
            // lbPass
            // 
            this.lbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPass.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Appearance.Options.UseFont = true;
            this.lbPass.Location = new System.Drawing.Point(86, 128);
            this.lbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(78, 23);
            this.lbPass.TabIndex = 37;
            this.lbPass.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(86, 86);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(308, 28);
            this.txtUsername.TabIndex = 35;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUser.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(86, 61);
            this.lbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(130, 23);
            this.lbUser.TabIndex = 33;
            this.lbUser.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 351);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.checkEditHienMatKhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUser);
            this.Name = "Login";
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
        public DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lbPass;
        public DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.LabelControl lbUser;
    }
}