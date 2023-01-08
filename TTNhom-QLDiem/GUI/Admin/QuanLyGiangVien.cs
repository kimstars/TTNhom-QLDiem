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
        private int magv;
        private int matk;
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
            if (txtThemTenGV.Text == "" || dateThemNgaySinhGV.ToString() == "" || cbGioiTinh.Text == "" || txtThemCapBacGV.Text == "" || txtThemChucVuGV.Text == "" || cbThemBoMon.Text == "" || txtThemMaTKGV.Text == "")
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

        private void dgvTTGV_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtraTabPageSua.Show();
            int index = e.RowHandle;
            Model.GiangVien gv = dsGiangVien[index];
            magv = gv.MaGiangVien;
            matk = int.Parse(gv.MaTK.ToString());
           // MessageBox.Show($"{matk}");
            txtSuaTenGV.Text = gv.HoTenGV;
            dateSuaNgaySinhGV.EditValue = gv.NgaySinh;
            cbSuaGioiTinhGV.Text = gv.GioiTinh;
            txtSuaCapBacGV.Text = gv.CapBac;
            txtSuaChucVuGV.Text = gv.ChucVu;

            List<Model.BoMon> bm = db.BoMons.ToList();
            string tenBoMon = bm.Find(s => s.MaBoMon == gv.MaBoMon).TenBoMon;
            cbSuaBoMon.Text = tenBoMon;
            if (dgvTTGV_View.FocusedColumn == dgvTTGV_View.Columns["Xoa"])
            {
                if (MessageBox.Show($"Xóa giảng viên sẽ xóa tất cả thông tin liên quan của giảng viên! \nBạn có chắc chắn xóa giảng viên {gv.HoTenGV} ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    List<LopHocPhan> lhp = db.LopHocPhans.Where(p => p.MaGiangVien == magv).ToList();
                    foreach(var item in lhp.ToList())
                    {
                        item.MaGiangVien = null;
                        db.SaveChanges();
                    }
                    dsGiangVien.RemoveAt(index);
                    db.GiangViens.Remove(gv);
                    List<TaiKhoan> tk = db.TaiKhoans.Where(p => p.MaTK == matk).ToList();
                    db.TaiKhoans.RemoveRange(tk);
                    MessageBox.Show("Xóa thành công");
                    dgvTTGV.DataSource = null;
                    dgvTTGV.DataSource = dsGiangVien;

                }
                return;
            }


        }
        public bool CheckSuaGV()
        {
            if (txtSuaTenGV.Text == "" || dateSuaNgaySinhGV.ToString() == "" || cbSuaGioiTinhGV.Text == "" || txtSuaCapBacGV.Text == "" || txtSuaChucVuGV.Text == "" || cbSuaBoMon.Text == "")
            {
                MessageBox.Show("Thông tin học viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Model.GiangVien gv = db.GiangViens.Where(p => p.MaGiangVien == magv).FirstOrDefault();
            if (CheckSuaGV())
            {
                gv.HoTenGV = txtSuaTenGV.Text;
                gv.NgaySinh = dateSuaNgaySinhGV.DateTime;
                gv.GioiTinh = cbSuaGioiTinhGV.Text;
                gv.CapBac = txtSuaCapBacGV.Text;
                gv.ChucVu = txtSuaChucVuGV.Text;


                List<Model.BoMon> bm = db.BoMons.ToList();
                int maBM = bm.Find(s => s.TenBoMon == cbSuaBoMon.Text).MaBoMon;
                gv.MaBoMon = maBM;

                db.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dsGiangVien = new List<Model.GiangVien>();
                dsGiangVien = db.GiangViens.ToList();
                dgvTTGV.DataSource = dsGiangVien;

                txtSuaTenGV.Text = "";
                dateSuaNgaySinhGV.EditValue = null;
                cbSuaGioiTinhGV.Text = "";
                txtSuaCapBacGV.Text = "";
                txtSuaChucVuGV.Text = "";
                cbSuaBoMon.Text = "";
            }


        }
    }
}
