using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TTNhom_QLDiem.Model;


namespace TTNhom_QLDiem.GUI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            using(QLDHV_model db = new QLDHV_model())
            {
                string hashedPass = HashPass(txtPassword.Text);

                if (db.TaiKhoans.Any(s => s.TenDangNhap == txtUsername.Text && s.MatKhau == hashedPass))
                {
                    TaiKhoan acc = db.TaiKhoans.Where(s => s.TenDangNhap == txtUsername.Text && s.MatKhau == hashedPass).FirstOrDefault();

                    Model.GiangVien gv = db.GiangViens.Where(s => s.MaTK == acc.MaTK).FirstOrDefault();

                    Model.HocVien hv = db.HocViens.Where(s => s.MaTK == acc.MaTK).FirstOrDefault();

                    MainForm fm;

                    if (gv != null)
                    {
                        fm = new MainForm(gv.MaGiangVien, acc.Quyen);

                    }
                    else if (hv != null)
                    {
                        fm = new MainForm(hv.MaHocVien, acc.Quyen);

                    }
                    else
                    {
                        fm = new MainForm(acc.Quyen);
                    }


                    this.Hide();
                    fm.ShowDialog();
                    if (!fm.IsDisposed)
                    {
                        txtPassword.Text = "";
                        txtUsername.Focus();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        public static string HashPass(string pass)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}