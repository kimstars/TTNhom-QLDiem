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
    public partial class DoiMK : DevExpress.XtraEditors.XtraUserControl
    {
        QLDHV_model db = new QLDHV_model();
        int ma_user = MainForm.MaID;
        public DoiMK()
        {
            InitializeComponent();
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

        private void btnOK_Click(object sender, EventArgs e)
        {

            using (QLDHV_model db = new QLDHV_model())
            {
                string oldPass = HashPass(txtOldPass.Text);
                string newPass = HashPass(txtNewPass.Text);
                string renewPass = HashPass(txtReNewPass.Text);
                if (txtOldPass.Text != "" && txtNewPass.Text != "" && txtReNewPass.Text != "")
                {

                    if (db.TaiKhoans.Any(s => s.MaTK == ma_user && s.MatKhau != oldPass))
                    {
                        MessageBox.Show("Mật khẩu không đúng");

                    }
                    else
                    {
                        TaiKhoan acc = db.TaiKhoans.Where(s => s.MaTK == ma_user && s.MatKhau == oldPass).FirstOrDefault();
                        if (oldPass == newPass)
                        {
                            MessageBox.Show("Mật khẩu mới không được trùng mật khẩu cũ");
                            txtNewPass.Text = "";
                            txtReNewPass.Text = "";
                        }
                        else if (newPass != renewPass)
                        {
                            MessageBox.Show("Mật khẩu không khớp");
                            txtReNewPass.Text = "";
                        }
                        else
                        {
                            acc.MatKhau = newPass;
                            db.SaveChanges();
                            MessageBox.Show("Chuyển mật khẩu thành công");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đủ thông tin");

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Khoong bieet quay veef trang trc kieeru gif
            
        }
    }
}
