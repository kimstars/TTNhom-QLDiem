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
        public int mahv;
        public static int MaTaiKhoan ;
     
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
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            Model.HocVien hv = new Model.HocVien();
            if (CheckThemHV())
            {
                hv.HoTenHV = txtThemTenHV.Text;
                hv.NgaySinh = dateThemNgaySinhHV.DateTime;
                hv.GioiTinh = cbGioiTinh.Text;
                hv.CapBac = txtThemCapBacHV.Text;
                hv.ChucVu = cbThemChucVu.Text;

                List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
                int maLCN = lcn.Find(s => s.TenLopChuyenNganh == cbLopCN.Text).MaLopChuyenNganh;
                hv.MaLopChuyenNganh = maLCN;
                
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
        public bool CheckThemHV()
        {
            if (txtThemTenHV.Text == "" || dateThemNgaySinhHV.ToString() == "" || cbGioiTinh.Text == "" || txtThemCapBacHV.Text == "" || cbThemChucVu.Text == "" || cbLopCN.Text == "" || txtQuequan.Text == "" || txtThemMaTKHV.Text == "")
            {
                MessageBox.Show("Thông tin học viên được thêm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
            Model.HocVien hv = db.HocViens.Where(p => p.MaHocVien == mahv).FirstOrDefault();
            if (CheckSuaHV())
            {
                hv.HoTenHV = txtSuaTenHV.Text;
                hv.NgaySinh = dateSuaNgaySinhHV.DateTime;
                hv.GioiTinh = cbSuaGT.Text;
                hv.CapBac = txtSuaCapBacHV.Text;
                hv.ChucVu = cbSuaChucVu.Text;

                List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
                int maLCN = lcn.Find(s => s.TenLopChuyenNganh == cbSuaLopChuyenNganh.Text).MaLopChuyenNganh;
                hv.MaLopChuyenNganh = maLCN;
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
        public bool CheckSuaHV()
        {
            if (txtSuaTenHV.Text == "" || dateSuaNgaySinhHV.ToString() == "" || cbSuaGT.Text == "" || txtSuaCapBacHV.Text == "" || cbSuaChucVu.Text == "" || cbSuaLopChuyenNganh.Text == "" || txtSuaQQ.Text == "" )
            {
                MessageBox.Show("Thông tin học viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        
    }
}
