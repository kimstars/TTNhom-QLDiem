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
    public partial class QuanLyHocVien : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyHocVien()
        {
            InitializeComponent();
            load_LopchuyenNganh();
        }
        private int mahv;
        public static int MaTaiKhoan;
        private string chucvu;
        QLDHV_model db = new QLDHV_model();

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan newtk = new ThemTaiKhoan();
            newtk.Show();
            newtk.FormClosed += Newtk_FormClosed;

        }

        private void Newtk_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtThemMaTKHV.Text = MaTaiKhoan.ToString();
        }

        List<Model.HocVien> dsHocVien;
        private void QuanLyHocVien_Load(object sender, EventArgs e)
        {
            dsHocVien = new List<Model.HocVien>();
            dsHocVien = db.HocViens.ToList();
            dgvDSHocVien.DataSource = dsHocVien;

        }

        List<Model.LopChuyenNganh> lcn;
        private void load_LopchuyenNganh()
        {
            lcn = new List<Model.LopChuyenNganh>();
            //   List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            lcn = db.LopChuyenNganhs.ToList();
            cbLopCN.Items.Clear();
            foreach (var item in lcn.ToList())
            {
                cbLopCN.Items.Add(item.TenLopChuyenNganh);
                cbSuaLopChuyenNganh.Items.Add(item.TenLopChuyenNganh);
            }

        }
        private bool CheckChucVuLCN(int MaLcn, string chucvu)
        {
            List<Model.HocVien> hv = db.HocViens.Where(p => p.MaLopChuyenNganh == MaLcn).ToList();
            foreach (var item in hv.ToList())
            {
                if (item.ChucVu == "Lớp trưởng" && chucvu == "Lớp trưởng")
                {
                    MessageBox.Show("Lớp chuyên ngành này đã có lớp trưởng . Vui lòng chọn lại lớp chuyên ngành hoặc chức vụ học viên!!!");
                    return false;
                }
                if (item.ChucVu == "Lớp phó" && chucvu == "Lớp phó")
                {
                    MessageBox.Show("Lớp chuyên ngành này đã có lớp phó . Vui lòng chọn lại lớp chuyên ngành hoặc chức vụ học viên!!!");
                    return false;
                }
            }
            return true;
        }
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            Model.HocVien hv = new Model.HocVien();
            List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            if (CheckThemHV())
            {

                int Malcn = lcn.Find(s => s.TenLopChuyenNganh == cbLopCN.Text).MaLopChuyenNganh;
                if (CheckChucVuLCN(Malcn, cbThemChucVu.Text))
                {
                    hv.HoTenHV = txtThemTenHV.Text;
                    hv.NgaySinh = dateThemNgaySinhHV.DateTime;
                    hv.GioiTinh = cbGioiTinh.Text;
                    hv.CapBac = txtThemCapBacHV.Text;
                    hv.ChucVu = cbThemChucVu.Text;
                    hv.MaLopChuyenNganh = Malcn;

                    hv.QueQuan = txtQuequan.Text;
                    hv.MaTK = int.Parse(txtThemMaTKHV.Text);

                    db.HocViens.Add(hv);
                    db.SaveChanges();

                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dsHocVien = new List<Model.HocVien>();
                    dsHocVien = db.HocViens.ToList();
                    dgvDSHocVien.DataSource = dsHocVien;

                    txtThemTenHV.Text = "";
                    dateThemNgaySinhHV.EditValue = null;
                    cbGioiTinh.Text = "";
                    txtThemCapBacHV.Text = "";
                    cbThemChucVu.Text = "";
                    cbLopCN.Text = "";
                    txtQuequan.Text = "";
                    txtThemMaTKHV.Text = "";

                }
            }
        }
        public bool CheckThemHV()
        {
            if (txtThemTenHV.Text == "" || dateThemNgaySinhHV.ToString() == "" || cbGioiTinh.Text == "" || txtThemCapBacHV.Text == "" || cbThemChucVu.Text == "" || cbLopCN.Text == "" || txtQuequan.Text == "" || txtThemMaTKHV.Text == "")
            {
                MessageBox.Show("Thông tin học viên được thêm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }




        private void txtThemCapBacHV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvTTHV_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtraTabPageSua.Show();
            int index = e.RowHandle;
            Model.HocVien hv = dsHocVien[index];
            mahv = hv.MaHocVien;
            chucvu = hv.ChucVu;
            txtSuaTenHV.Text = hv.HoTenHV;
            dateSuaNgaySinhHV.EditValue = hv.NgaySinh;
            cbSuaGT.Text = hv.GioiTinh;
            txtSuaCapBacHV.Text = hv.CapBac;
            cbSuaChucVu.Text = hv.ChucVu;

            List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            string TenLCN = lcn.Find(s => s.MaLopChuyenNganh == hv.MaLopChuyenNganh).TenLopChuyenNganh;
            cbSuaLopChuyenNganh.Text = TenLCN;
            txtSuaQQ.Text = hv.QueQuan;


        }

        private void cbThemChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool ChecksuaChucVuLCN(int MaLcn, string chucvu, string chucvu2)
        {
            List<Model.HocVien> hv = db.HocViens.Where(p => p.MaLopChuyenNganh == MaLcn).ToList();
            foreach (var item in hv.ToList())
            {
                if (item.ChucVu == "Lớp trưởng" && chucvu == "Lớp trưởng" && chucvu != chucvu2)
                {
                    MessageBox.Show("Lớp chuyên ngành này đã có lớp trưởng . Vui lòng chọn lại lớp chuyên ngành hoặc chức vụ học viên!!!");
                    return false;
                }
                if (item.ChucVu == "Lớp phó" && chucvu == "Lớp phó" && chucvu != chucvu2)
                {
                    MessageBox.Show("Lớp chuyên ngành này đã có lớp phó . Vui lòng chọn lại lớp chuyên ngành hoặc chức vụ học viên!!!");
                    return false;
                }
            }
            return true;
        }
        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            Model.HocVien hv = db.HocViens.Where(p => p.MaHocVien == mahv).FirstOrDefault();
            List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            if (CheckSuaHV())
            {
                int Malcn = lcn.Find(s => s.TenLopChuyenNganh == cbSuaLopChuyenNganh.Text).MaLopChuyenNganh;

                if (ChecksuaChucVuLCN(Malcn, cbSuaChucVu.Text, chucvu))
                {
                    hv.HoTenHV = txtSuaTenHV.Text;
                    hv.NgaySinh = dateSuaNgaySinhHV.DateTime;
                    hv.GioiTinh = cbSuaGT.Text;
                    hv.CapBac = txtSuaCapBacHV.Text;
                    hv.ChucVu = cbSuaChucVu.Text;

                    hv.MaLopChuyenNganh = Malcn;
                    hv.QueQuan = txtSuaQQ.Text;

                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dsHocVien = new List<Model.HocVien>();
                    dsHocVien = db.HocViens.ToList();
                    dgvDSHocVien.DataSource = dsHocVien;

                    txtSuaTenHV.Text = "";
                    dateSuaNgaySinhHV.EditValue = null;
                    cbSuaGT.Text = "";
                    txtSuaCapBacHV.Text = "";
                    cbSuaChucVu.Text = "";
                    cbSuaLopChuyenNganh.Text = "";
                    txtSuaQQ.Text = "";
                }
            }

        }
        public bool CheckSuaHV()
        {
            if (txtSuaTenHV.Text == "" || dateSuaNgaySinhHV.ToString() == "" || cbSuaGT.Text == "" || txtSuaCapBacHV.Text == "" || cbSuaChucVu.Text == "" || cbSuaLopChuyenNganh.Text == "" || txtSuaQQ.Text == "")
            {
                MessageBox.Show("Thông tin học viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            Model.HocVien hv = db.HocViens.Where(m => m.MaHocVien == mahv).First();
            if (MessageBox.Show($"Xóa học viên sẽ xóa tất cả kết quả của học viên! \nBạn có chắc chắn xóa học viên {hv.HoTenHV} ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<ChiTietPhieuDiem> ctpd = db.ChiTietPhieuDiems.Where(m => m.MaHocVien == hv.MaHocVien).ToList();
                db.ChiTietPhieuDiems.RemoveRange(ctpd);

                db.HocViens.Remove(hv);
                db.SaveChanges();



                dgvDSHocVien.DataSource = null;
                dsHocVien = db.HocViens.ToList();
                dgvDSHocVien.DataSource = dsHocVien;

                MessageBox.Show($"Xóa thành công !", "Thông báo");
            }
        }


    }
}
