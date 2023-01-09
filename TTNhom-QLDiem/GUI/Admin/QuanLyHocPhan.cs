using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNhom_QLDiem.Model;

namespace TTNhom_QLDiem.GUI.Admin
{
    public partial class QuanLyHocPhan : DevExpress.XtraEditors.XtraUserControl
    {
        QLDHV_model db = new QLDHV_model();
        public QuanLyHocPhan()
        {
            InitializeComponent();
        }

        List<Model.BoMon> lbm;
        List<AD_QLLHP_DSHocPhan> dsHocPhan;
        private void QuanLyHocPhan_Load(object sender, EventArgs e)
        {
            dsHocPhan = new List<AD_QLLHP_DSHocPhan>();
            dsHocPhan = db.AD_QLLHP_DSHocPhan.ToList();

            dgvDSHocPhan.DataSource = dsHocPhan;

            lbm = db.BoMons.ToList();

            foreach (var item in lbm.ToList())
            {
                cbThemTenBM.Items.Add(item.TenBoMon);
                cbSuaTenBM.Items.Add(item.TenBoMon);
            }
            //int mahp = db.HocPhans.OrderBy(m => m.MaHocPhan).().MaHocPhan;
            //txtMaHP.Text = mahp.ToString();

        }
        public bool Check()
        {
            if (txtThemTenHP.Text == "" || txtThemDonvihoctrinh.ToString() == "" || txtThemSoTC.ToString() == "" || txtThemSoTiet.ToString() == "" || cbThemTenBM.Text == "" || radThemHinhThucThi.Text == "")
            {
                MessageBox.Show("Thông tin học phần được thêm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        private void btnThemHP_Click(object sender, EventArgs e)
        {
            Model.HocPhan hp = new Model.HocPhan();
            if (Check())
            {
                hp.TenHocPhan = txtThemTenHP.Text;
                hp.DonViHocTrinh = Int32.Parse(txtThemDonvihoctrinh.Text);
                hp.SoTC = Int32.Parse(txtThemSoTC.Text);
                hp.SoTiet = Int32.Parse(txtThemSoTiet.Text);
                hp.MaBoMon = mabm;
                hp.HinhThucThi = radThemHinhThucThi.Text;
                db.HocPhans.Add(hp);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDSHocPhan.DataSource = null;
                dsHocPhan = db.AD_QLLHP_DSHocPhan.ToList();
                dgvDSHocPhan.DataSource = dsHocPhan;
                txtThemTenHP.Text = "";
                txtThemDonvihoctrinh.Text = "";
                txtThemSoTC.Text = "";
                txtThemSoTiet.Text = "";
                cbThemTenBM.Text = "";
                radThemHinhThucThi.Text = "";
            }
        }
        int mabm;

        private void TenBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemTenBM.SelectedIndex;
            mabm = lbm[index].MaBoMon;
            // MessageBox.Show(mabm.ToString());
        }
        string hinhthucthi;
        private void dgvHP_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int index = e.RowHandle;
            AD_QLLHP_DSHocPhan hp = dsHocPhan[index];
            int mahp = hp.MaHocPhan;
            HocPhan dbHp = db.HocPhans.Where(m => m.MaHocPhan == mahp).FirstOrDefault();
            
            if (dgvDSHocPhan_View.FocusedColumn == dgvDSHocPhan_View.Columns["btnXoa"])
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    dsHocPhan.RemoveAt(index);
                    db.HocPhans.Remove(dbHp);
                    db.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    dsHocPhan = db.AD_QLLHP_DSHocPhan.ToList();
                    dgvDSHocPhan.DataSource = dsHocPhan;

                }
            }
            else
            {
                xtraTabPage2.Show();
                txtMaHP.Text = hp.MaHocPhan.ToString();
                txtSuaTenHP.Text = hp.TenHocPhan;
                txtSuaDonViHocTrinh.Text = hp.DonViHocTrinh.ToString();
                txtSuaSoTC.Text = hp.SoTC.ToString();
                txtSuaSoTiet.Text = hp.SoTiet.ToString();
                cbSuaTenBM.Text = hp.TenBoMon;
                string hinhthucthi = hp.HinhThucThi;
                int selectIndex = 0;
                if (hinhthucthi == "Thi viết") selectIndex = 1;
                if (hinhthucthi == "Thi trực tuyến") selectIndex = 2;

                radSuaHinhThucThi.SelectedIndex = selectIndex;

                mabm = hp.MaBoMon;
            }
        }

        private void btnSuaHP_Click(object sender, EventArgs e)
        {
            int mahp = Convert.ToInt32(txtMaHP.Text);
            HocPhan dbHp = db.HocPhans.Where(m => m.MaHocPhan == mahp).FirstOrDefault();
            if (dbHp == null) throw new Exception("");
            dbHp.TenHocPhan = txtSuaTenHP.Text;
            dbHp.DonViHocTrinh = Int32.Parse(txtSuaDonViHocTrinh.Text);
            dbHp.SoTC = Int32.Parse(txtSuaSoTC.Text);
            dbHp.SoTiet = Int32.Parse(txtSuaSoTiet.Text);
            dbHp.MaBoMon = mabm;
            //string hinhthucthi;
            int selectIndex = radSuaHinhThucThi.SelectedIndex;
            if (selectIndex == 0) hinhthucthi = "Thi vấn đáp";
            if (selectIndex == 1) hinhthucthi = "Thi viết";
            if (selectIndex == 2) hinhthucthi = "Thi trực tuyến";
            dbHp.HinhThucThi = hinhthucthi;
            MessageBox.Show(hinhthucthi);
            db.SaveChanges();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dgvDSHocPhan.Refresh();
            //dsHocPhan = new List<AD_QLHP_DSHocPhan>();   
            dgvDSHocPhan.DataSource = null;
            dsHocPhan = db.AD_QLLHP_DSHocPhan.ToList();
            dgvDSHocPhan.DataSource = dsHocPhan;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}