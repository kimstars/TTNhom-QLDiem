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
namespace TTNhom_QLDiem.GUI.GiangVien
{

    public partial class GV_NhapDiemCC_TX : DevExpress.XtraEditors.XtraUserControl
    {
        QLDHV_model db = new QLDHV_model();
        public GV_NhapDiemCC_TX()
        {
            InitializeComponent();
        }
        List<HocKy> lstHocKy;
        List<HocPhan> lstHocPhan;
        List<LopHocPhan> lstLopHocPhan;
        List<TTDHV> lstThongTin;
        ChiTietPhieuDiem ctpd = new ChiTietPhieuDiem();

        private void GV_NhapDiemCC_TX_Load(object sender, EventArgs e)
        {
            cbbHocKy.SelectedIndexChanged -= cbbHocKy_SelectedIndexChanged;
            cbbHocPhan.SelectedIndexChanged -= cbbHocPhan_SelectedIndexChanged;
            cbbLopHocPhan.SelectedIndexChanged -= cbbLopHocPhan_SelectedIndexChanged;
            lstHocKy = db.HocKies.ToList();
            //cbbHocKy
            cbbHocKy.DataSource = lstHocKy;
            cbbHocKy.DisplayMember = "TenHocKy";
            cbbHocKy.ValueMember = "MaHocKy";
            cbbHocKy.SelectedIndex = 0;
            LoadCBBHocPhan();
            cbbHocKy.SelectedIndexChanged += cbbHocKy_SelectedIndexChanged;
            cbbHocPhan.SelectedIndexChanged += cbbHocPhan_SelectedIndexChanged;
            cbbLopHocPhan.SelectedIndexChanged += cbbLopHocPhan_SelectedIndexChanged;
        }
        private void SetHocPhanDefault()
        {
            cbbHocPhan.Items.Clear();
            cbbLopHocPhan.Items.Clear();
        }
        private void DSHV(int maHK, int maHp, int maLhp)
        {
            List<TTDHV> DSHV = db.TTDHVs.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();
            if (DSHV.Count == 0)
            {
                MessageBox.Show("Giáo viên không dạy lớp này trong học kỳ này");
            }
            else
            {
                dgvDSHocVien.DataSource = DSHV;
            }
        }
        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            int maHK = lstHocKy[id].MaHocKy;
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            LoadCBBHocPhan();
            int maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == maHp).ToList();

            int malhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;

            DSHV(maHK, maHp, malhp);
        }

        private void LoadCBBHocPhan()
        {
            //cbbHocPhan.Items.Clear();
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            cbbHocPhan.DataSource = lstHocPhan;
            cbbHocPhan.ValueMember = "MaHocPhan";
            cbbHocPhan.DisplayMember = "TenHocPhan";
            cbbHocPhan.SelectedIndex = 0;
            int mahp = lstHocPhan[0].MaHocPhan;
            LoadCBBLopHocPhan(mahp);


        }
        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            int maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            LoadCBBLopHocPhan(maHp);
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            int maHK = lstHocKy[id].MaHocKy;
            int malhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;

            DSHV(maHK, maHp, malhp);

        }

        private void LoadCBBLopHocPhan(int mahp)
        {
           
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == mahp).ToList();
            cbbLopHocPhan.DataSource = lstLopHocPhan;
            cbbLopHocPhan.DisplayMember = "TenLopHocPhan";
            cbbLopHocPhan.ValueMember = "MaLopHocPhan";
            cbbLopHocPhan.SelectedIndex = 0;
            HocPhan hp = db.HocPhans.Where(m => m.MaHocPhan == mahp).FirstOrDefault();
            txtSoTinChi.Text = hp.SoTC.ToString();
            if (hp.HinhThucThi == "Vấn đáp")
            {
                radioGroup2.SelectedIndex = 0;
            }
            else if (hp.HinhThucThi == "Trực tuyến")
            {
                radioGroup2.SelectedIndex = 2;

            }
            else
            {
                radioGroup2.SelectedIndex = 1;

            }
            int malhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
            LopHocPhan lhp = db.LopHocPhans.Where(m => m.MaHocPhan == mahp && m.MaLopHocPhan == malhp).FirstOrDefault();
            txtNgayThi.EditValue = lhp.NgayThi.ToString("dd/MM/yyyy");
            txtHanNhapDiem.EditValue = lhp.NgayThi.AddDays(-7).ToString("dd/MM/yyyy");
            if (lhp.NgayThi.AddDays(-7) < DateTime.Now)
            {

                MessageBox.Show("Quá hạn nhập điểm!");
            }
            
        }

        private void cbbLopHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            int maHK = lstHocKy[id].MaHocKy;
            // int malhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
            lstHocPhan = (from hps in db.HocPhans
                          join lhps in db.LopHocPhans on hps.MaHocPhan equals lhps.MaHocPhan
                          where lhps.MaGiangVien == MainForm.MaID
                          select hps).ToList();
            int maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == maHp).ToList();
            int malhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
            HocPhan hp = db.HocPhans.Where(m => m.MaHocPhan == maHp).FirstOrDefault();
            txtSoTinChi.Text = hp.SoTC.ToString();
            if (hp.HinhThucThi == "Vấn đáp")
            {
                radioGroup2.SelectedIndex = 0;
            }
            else if (hp.HinhThucThi == "Trực tuyến")
            {
                radioGroup2.SelectedIndex = 2;

            }
            else
            {
                radioGroup2.SelectedIndex = 1;

            }
            

            LopHocPhan lhp = db.LopHocPhans.Where(m => m.MaHocPhan == maHp && m.MaLopHocPhan == malhp).FirstOrDefault();
            txtNgayThi.EditValue = lhp.NgayThi.ToString("dd/MM/yyyy");
            txtHanNhapDiem.EditValue = lhp.NgayThi.AddDays(-7).ToString("dd/MM/yyyy");
            if (lhp.NgayThi.AddDays(-7) < DateTime.Now)
            {

                MessageBox.Show("Quá hạn nhập điểm!");
            }
            DSHV(maHK, maHp, malhp);

        }
        private void LoadCTPD() {
            try
            {
                int mactpd = (int)dgvDSHocVien_View.GetFocusedRowCellValue("MaChiTietPhieuDiem");
                ctpd = db.ChiTietPhieuDiems.Where(p => p.MaChiTietPhieuDiem == mactpd).FirstOrDefault();
            }
            catch { }
            txtMaHocVien.EditValue = ctpd.MaHocVien;
            txtTenHocVien.EditValue = dgvDSHocVien_View.GetFocusedRowCellValue("HoTenHV");
            txtLopChuyenNganh.EditValue = dgvDSHocVien_View.GetFocusedRowCellValue("TenLopChuyenNganh");
            txtDiemCC.EditValue = ctpd.DiemCC;
            txtDiemTX.EditValue = ctpd.DiemTX;
            
        }
        private void dgvDSHocVien_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            LoadCTPD();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ChiTietPhieuDiem ttpd2 = db.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == ctpd.MaChiTietPhieuDiem).FirstOrDefault();

            
            if (txtDiemCC.Text != "" && txtDiemTX.Text != "")
            {
                ttpd2.DiemCC = Convert.ToInt32(txtDiemCC.Text);
               ttpd2.DiemTX = Convert.ToInt32(txtDiemTX.Text);
            }
            else
            {
                MessageBox.Show("Cần nhập đủ cả hai điểm chuyên cần và thường xuyên");
            }
            db.SaveChanges();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //

            dgvDSHocVien.DataSource = null;
            var tthv_diem = db.TTDHVs.ToList();
            dgvDSHocVien.DataSource = tthv_diem;
            LoadCTPD();
            txtMaHocVien.Text = "";
            txtTenHocVien.EditValue = null;
            txtLopChuyenNganh.Text = "";
            txtDiemCC.Text = "";
            txtDiemTX.Text = "";
          
        }
    }
}
