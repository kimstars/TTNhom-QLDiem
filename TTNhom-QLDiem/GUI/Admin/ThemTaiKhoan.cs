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
namespace TTNhom_QLDiem.GUI.Admin
{
    public partial class ThemTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }
        QLDHV_model db = new QLDHV_model();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            string user = txtUsername.Text;

            string hash = HashPass(pass);

            string quyen = cbQuyen.Text;

            switch (quyen) {


                case "Giảng viên":
                    quyen = "GV";
                    break;

                case "Học viên":
                    quyen = "HV";
                    break;

                default:
                    break;

            }



            //MessageBox.Show(cbvalue);

            Model.TaiKhoan newtk = new Model.TaiKhoan();
            newtk.TenDangNhap = user;
            newtk.MatKhau = hash;
            newtk.Quyen = quyen;


            db.TaiKhoans.Add(newtk);


            db.SaveChanges();
            MessageBox.Show(newtk.MaTK.ToString());

            QuanLyHocVien.MaTaiKhoan = newtk.MaTK;




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