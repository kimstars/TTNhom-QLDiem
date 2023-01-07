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
    public partial class QuanLyGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyGiangVien()
        {
            InitializeComponent();
            load_BoMon();
        }
        QLDHV_model db = new QLDHV_model();
        public static int MaTaiKhoan;
        public int magv;
        List<Model.GiangVien> dsGiangVien;
        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            dsGiangVien = new List<Model.GiangVien>();
            dsGiangVien = db.GiangViens.ToList();
            dgvTTGV.DataSource = dsGiangVien;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan newtk = new ThemTaiKhoan();
            newtk.Show();
            newtk.FormClosed += Newtk_FormClosed;
        }
        private void Newtk_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtThemMaTKGV.Text = MaTaiKhoan.ToString();
        }

        List<Model.BoMon> bm;
        private void load_BoMon()
        {
            bm = new List<Model.BoMon>();
            //   List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            bm = db.BoMons.ToList();
            cbThemBoMon.Items.Clear();
            foreach (var item in bm.ToList())
            {
                cbThemBoMon.Items.Add(item.TenBoMon);
                cbSuaBoMon.Items.Add(item.TenBoMon);
            }

        }
        public bool CheckThemGV()
        {
            if (txtThemTenGV.Text == "" || dateThemNgaySinhGV.ToString() == "" || cbGioiTinh.Text == "" || txtThemCapBacGV.Text == "" || txtThemChucVuGV.Text == "" || cbThemBoMon.Text == ""  || txtThemMaTKGV.Text == "")
            {
                MessageBox.Show("Thông tin học viên được thêm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            Model.GiangVien gv = new Model.GiangVien();
            if (CheckThemGV())
            {
                gv.HoTenGV = txtThemTenGV.Text;
                gv.NgaySinh = dateThemNgaySinhGV.DateTime;
                gv.GioiTinh = cbGioiTinh.Text;
                gv.CapBac = txtThemCapBacGV.Text;
                gv.ChucVu = txtThemChucVuGV.Text;

                List<Model.BoMon> bm = db.BoMons.ToList();
                int mabm = bm.Find(s => s.TenBoMon == cbThemBoMon.Text).MaBoMon;
                gv.MaBoMon = mabm;               
                gv.MaTK = int.Parse(txtThemMaTKGV.Text);

                db.GiangViens.Add(gv);
                db.SaveChanges();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dsGiangVien = new List<Model.GiangVien>();
                dsGiangVien = db.GiangViens.ToList();
                dgvTTGV.DataSource = dsGiangVien;

                txtThemTenGV.Text = "";
                dateThemNgaySinhGV.EditValue = null;
                cbGioiTinh.Text = "";
                txtThemCapBacGV.Text = "";
                txtThemChucVuGV.Text = "";
                cbThemBoMon.Text = "";
                txtThemMaTKGV.Text = "";
            }
        }

    }
}
