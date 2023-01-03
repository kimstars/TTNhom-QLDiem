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
            string state = "";
            formchung frm = new formchung(state);
            this.Hide();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //int CheckLogin(string _name, string _pass)
        //{
        //    int check = 0;
        //    List<User> list_hv = new List<User>();
        //    List<User> list_dd = new List<User>();
        //    List<User> list_gv = new List<User>();
        //    List<User> list_ad = new List<User>();
        //    string sql1 = "SELECT CONVERT(VARCHAR(10),MaHocVien) AS tendangnhap, MatKhau AS matkhau FROM dbo.HocVien";
        //    string sql2 = "SELECT MaDaiDoi AS tendangnhap, MatKhau AS matkhau FROM dbo.DaiDoi";
        //    string sql3 = "SELECT MaGiaoVien AS tendangnhap, MatKhau AS matkhau FROM dbo.GiaoVien";
        //    string sql4 = "SELECT MaQuanTriVien AS tendangnhap , MatKhau AS matkhau FROM dbo.QuanTriVien";
        //    list_hv = Program.userSql.LayDSNguoiDung(sql1);
        //    list_dd = Program.userSql.LayDSNguoiDung(sql2);
        //    list_gv = Program.userSql.LayDSNguoiDung(sql3);
        //    list_ad = Program.userSql.LayDSNguoiDung(sql4);
        //    foreach (var value in list_hv)
        //    {

        //        if (value.Username.ToLower() == _name.ToLower() && _pass.ToLower() == value.Password.ToLower())
        //        {
        //            check = 1;
        //            Program.user = new User();
        //            Program.user.Username = value.Username;
        //            Program.user.Password = value.Password;
        //            Program.user.Chucvu = "HocVien";
        //            break;
        //        }
        //    }
        //    if (check == 0)
        //    {
        //        foreach (var value in list_dd)
        //        {

        //            if (value.Username.ToLower() == _name.ToLower() && _pass.ToLower() == value.Password.ToLower())
        //            {
        //                check = 1;
        //                Program.user = new User();
        //                Program.user.Username = value.Username;
        //                Program.user.Password = value.Password;
        //                Program.user.Chucvu = "DaiDoi";
        //                break;
        //            }
        //        }
        //    }
        //    if (check == 0)
        //    {
        //        foreach (var value in list_gv)
        //        {

        //            if (value.Username.ToLower() == _name.ToLower() && _pass.ToLower() == value.Password.ToLower())
        //            {
        //                check = 1;
        //                Program.user = new User();
        //                Program.user.Username = value.Username;
        //                Program.user.Password = value.Password;
        //                Program.user.Chucvu = "GiaoVien";
        //                break;
        //            }
        //        }
        //    }
        //    if (check == 0)
        //    {
        //        foreach (var value in list_ad)
        //        {

        //            if (value.Username.ToLower() == _name.ToLower() && _pass.ToLower() == value.Password.ToLower())
        //            {
        //                check = 1;
        //                Program.user = new User();
        //                Program.user.Username = value.Username;
        //                Program.user.Password = value.Password;
        //                Program.user.Chucvu = "Admin";
        //                break;
        //            }
        //        }
        //    }
        //    if (check == 1)
        //    {
        //        Program.list_Q = new List<Quyen>();
        //        Program.list_Q = Program.quyenSql.Select_Quyen_chucvu(Program.user.Chucvu);
        //    }
        //    return check;
        //}
    }
}