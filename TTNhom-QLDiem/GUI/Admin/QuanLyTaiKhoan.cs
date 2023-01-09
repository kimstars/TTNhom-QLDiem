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
    public partial class QuanLyTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        QLDHV_model db = new QLDHV_model();
        List<Model.TaiKhoan> ltk;
        private int mataikhoan;
        private string tentk;
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            ltk = new List<Model.TaiKhoan>();
            ltk = db.TaiKhoans.ToList();
            dgvDSTaiKhoan.DataSource = ltk;
        }

        public bool CheckThem()
        {
            if (txtThemTenDangNhap.Text == "" || txtThemMatKhau.Text == "" || cbThemQuyen.Text == "")
            {
                MessageBox.Show("Thông tin tài khoản được thêm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

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

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            if (CheckThem() && checkTenTK(txtThemTenDangNhap.Text))
            {
                string user = txtThemTenDangNhap.Text;
                string pass = txtThemMatKhau.Text;
                string hash = HashPass(pass);
                string quyen = cbThemQuyen.Text;

                switch (quyen)
                {

                    case "Giảng viên":
                        quyen = "GV";
                        break;

                    case "Học viên":
                        quyen = "HV";
                        break;

                    default:
                        break;

                }

                Model.TaiKhoan newtk = new Model.TaiKhoan();
                newtk.TenDangNhap = user;
                newtk.MatKhau = hash;
                newtk.Quyen = quyen;

                db.TaiKhoans.Add(newtk);
                db.SaveChanges();
                MessageBox.Show(newtk.MaTK.ToString());
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ltk = new List<Model.TaiKhoan>();
                ltk = db.TaiKhoans.ToList();
                dgvDSTaiKhoan.DataSource = ltk;
                txtThemTenDangNhap.Text = "";
                txtThemMatKhau.Text = "";

            }
        }

       
        private bool checkTenTK(string Tentk)
        {
            ltk = new List<Model.TaiKhoan>();
            ltk = db.TaiKhoans.ToList();
            foreach (var item in ltk.ToList())
            {
                if (item.TenDangNhap == Tentk)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void dgvDSTaiKhoan_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtraSuaXoa.Show();
            int index = e.RowHandle;
            Model.TaiKhoan tk = ltk[index];
            mataikhoan = tk.MaTK;
            tentk = tk.TenDangNhap;
            txtSuaTenDangNhap.Text = tk.TenDangNhap;
            txtSuaMatKhau.Text = tk.MatKhau;
            string quyen = tk.Quyen;
            switch (quyen)
            {

                case "GV":
                    quyen = "Giảng viên";
                    break;
                case "gv":
                    quyen = "Giảng viên";
                    break;

                case "HV":
                    quyen = "Học viên";
                    break;
                case "hv":
                    quyen = "Học viên";
                    break;

                default:
                    break;

            }
            cbSuaQuyen.Text = quyen;

        }
        public bool CheckSua()
        {
            if (txtSuaTenDangNhap.Text == "" || txtSuaMatKhau.Text == "" || cbSuaQuyen.Text == "")
            {
                MessageBox.Show("Thông tin tài khoản được thêm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private bool checkTenTKSua(string tentk1, string tentk2)
        {
            ltk = new List<Model.TaiKhoan>();
            ltk = db.TaiKhoans.ToList();
            foreach (var item in ltk.ToList())
            {
                
                if (item.TenDangNhap == tentk1 && tentk1 != tentk2)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void bntSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (CheckSua() && checkTenTKSua(txtSuaTenDangNhap.Text, tentk))
            {
                Model.TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == mataikhoan).FirstOrDefault();
                tk.TenDangNhap = txtSuaTenDangNhap.Text;
                tk.MatKhau = HashPass(txtSuaMatKhau.Text);
                string quyen = cbSuaQuyen.Text;
                switch (quyen)
                {

                    case "Giảng viên":
                        quyen = "GV";
                        break;

                    case "Học viên":
                        quyen = "HV";
                        break;

                    default:
                        break;

                }
                tk.Quyen = quyen;
                db.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ltk = new List<Model.TaiKhoan>();
                ltk = db.TaiKhoans.ToList();
                dgvDSTaiKhoan.DataSource = ltk;
                txtSuaTenDangNhap.Text = "";
                txtSuaMatKhau.Text = "";
                cbSuaQuyen.Text = "";
            } 
            


        }

       

        private void bntXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            Model.TaiKhoan tk = db.TaiKhoans.Where(p => p.MaTK == mataikhoan).First();
            if (MessageBox.Show($"Xóa tài khoản sẽ xóa tất cả thông tin liên quan của tài khoản! \nBạn có chắc chắn xóa tài khoản {mataikhoan} ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<Model.HocVien> lhv = db.HocViens.Where(p => p.MaTK == mataikhoan).ToList();
                List<Model.GiangVien> lgv = db.GiangViens.Where(p => p.MaTK == mataikhoan).ToList();
                foreach (var item in lhv.ToList())
                {
                    item.MaTK = null;
                    db.SaveChanges();
                }

                foreach (var item in lgv.ToList())
                {
                    item.MaTK = null;
                    db.SaveChanges();
                }

                db.TaiKhoans.Remove(tk);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");

                ltk = new List<Model.TaiKhoan>();
                ltk = db.TaiKhoans.ToList();
                dgvDSTaiKhoan.DataSource = ltk;
                txtSuaTenDangNhap.Text = "";
                txtSuaMatKhau.Text = "";
                cbSuaQuyen.Text = "";

            }
        }
    }
}
