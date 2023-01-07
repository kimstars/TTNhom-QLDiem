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
            List<Model.HocKy> dsHocKi = new List<HocKy>();
            dsHocKi = db.HocKies.ToList();

            dgvDSHocVien.DataSource = dsHocVien;

        }

        
        private void load_LopchuyenNganh()
        {
            List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            cbLopCN.Items.Clear();
            foreach (var item in lcn.ToList())
            {
                cbLopCN.Items.Add(item.TenLopChuyenNganh);
            }

        }
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            Model.HocVien hv = new Model.HocVien();
            if (Check())
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
                
                dgvDSHocVien.DataSource = null;
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
        public bool Check()
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
            txtSuaTenHV.Text = hv.HoTenHV;
            dateSuaNgaySinhHV.EditValue = hv.NgaySinh;


        }

        private void cbThemChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<Model.LopChuyenNganh> lcn = db.LopChuyenNganhs.ToList();
            //cbLopCN.Items.Clear();
            //foreach (var item in lcn.ToList())
            //{
            //    cbLopCN.Items.Add(item.TenLopChuyenNganh);
            //}
        }
    }
}
