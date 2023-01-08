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
    public partial class GV_NhapDiemThi : DevExpress.XtraEditors.XtraUserControl
    {
        QLDHV_model db = new QLDHV_model();
        public GV_NhapDiemThi()
        {
            InitializeComponent();
        }
        List<HocKy> lstHocKy;
        List<HocPhan> lstHocPhan;
        List<LopHocPhan> lstLopHocPhan;
        int maHK;
        int maHp;
        int maLhp;
        ChiTietPhieuDiem ctpd = new ChiTietPhieuDiem();

        private void GV_NhapDiemThi_Load(object sender, EventArgs e)
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
            maHK = 0;

            LoadCBBHocPhan();
            LoadCBBLopHocPhan();
            txtNgayThi.Text = "";
            txtSoTinChi.Text = "";
            txtHanNhapDiem.Text = "";
            radioGroup2.SelectedIndex = -1;
            cbbHocKy.SelectedIndexChanged += cbbHocKy_SelectedIndexChanged;
            cbbHocPhan.SelectedIndexChanged += cbbHocPhan_SelectedIndexChanged;
            cbbLopHocPhan.SelectedIndexChanged += cbbLopHocPhan_SelectedIndexChanged;

        }
        private void LoadCBBHocPhan()
        {
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            if(lstHocPhan.Count==0)
            {
                MessageBox.Show("Không dạy học phần nào");
            }
            cbbHocPhan.DataSource = lstHocPhan;
            cbbHocPhan.ValueMember = "MaHocPhan";
            cbbHocPhan.DisplayMember = "TenHocPhan";
            cbbHocPhan.SelectedIndex = -1;
        }
        private void LoadCBBLopHocPhan()
        {
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID).ToList();
            
            cbbLopHocPhan.DataSource = lstLopHocPhan;
            cbbLopHocPhan.DisplayMember = "TenLopHocPhan";
            cbbLopHocPhan.ValueMember = "MaLopHocPhan";
            cbbLopHocPhan.SelectedIndex = -1;
        }
        private void DSHV(int maHK, int maHp, int maLhp)
        {
            List<TTDHV> DSHV = db.TTDHVs.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp && m.MaGiangVien == MainForm.MaID).ToList();

            dgvDSHocVien.DataSource = DSHV;

        }
        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            if(cbbHocPhan.SelectedIndex ==-1 && cbbLopHocPhan.SelectedIndex == -1)
            {
                
            }
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            LoadCBBHocPhan();
            maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == maHp).ToList();

            maLhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
            DSHV(maHK, maHp, maLhp);

        }

        /*private void LoadCBBHocPhan()
        {
            //cbbHocPhan.Items.Clear();
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            cbbHocPhan.DataSource = lstHocPhan;
            cbbHocPhan.ValueMember = "MaHocPhan";
            cbbHocPhan.DisplayMember = "TenHocPhan";
            //cbbHocPhan.SelectedIndex = 0;
            cbbHocPhan.Text = "";
            maHp = lstHocPhan[0].MaHocPhan;
            LoadCBBLopHocPhan(maHp);

        }*/
        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID
                          select hp).ToList();
            maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            LoadCBBLopHocPhan(maHp);
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            maLhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;

            DSHV(maHK, maHp, maLhp);

        }

       /* private void LoadCBBLopHocPhan(int mahp)
        {

            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == mahp).ToList();
            cbbLopHocPhan.DataSource = lstLopHocPhan;
            cbbLopHocPhan.DisplayMember = "TenLopHocPhan";
            cbbLopHocPhan.ValueMember = "MaLopHocPhan";
            cbbLopHocPhan.SelectedIndex = 0;
            cbbLopHocPhan.Text = "";
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
            maLhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
            LopHocPhan lhp = db.LopHocPhans.Where(m => m.MaHocPhan == mahp && m.MaLopHocPhan == maLhp).FirstOrDefault();
            txtNgayThi.EditValue = lhp.NgayThi.ToString("dd/MM/yyyy");
            txtHanNhapDiem.EditValue = lhp.NgayThi.AddDays(10).ToString("dd/MM/yyyy");
            if (lhp.NgayThi.AddDays(10) < DateTime.Now)
            {

                MessageBox.Show("Quá hạn nhập điểm!");
            }
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            DSHV(maHK, mahp, maLhp);

        }*/

        private void cbbLopHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            // int malhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
            lstHocPhan = (from hps in db.HocPhans
                          join lhps in db.LopHocPhans on hps.MaHocPhan equals lhps.MaHocPhan
                          where lhps.MaGiangVien == MainForm.MaID
                          select hps).ToList();
            maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == maHp).ToList();
            maLhp = lstLopHocPhan[cbbLopHocPhan.SelectedIndex].MaLopHocPhan;
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


            LopHocPhan lhp = db.LopHocPhans.Where(m => m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp && m.MaHocKy == maHK).FirstOrDefault();
            if (lhp != null)
            {
                txtNgayThi.EditValue = lhp.NgayThi.ToString("dd/MM/yyyy");
                txtHanNhapDiem.EditValue = lhp.NgayThi.AddDays(10).ToString("dd/MM/yyyy");
                if (lhp.NgayThi.AddDays(10) < DateTime.Now)
                {

                    MessageBox.Show("Quá hạn nhập điểm!");
                }
                DSHV(maHK, maHp, maLhp);
            }


        }
        private void LoadCTPD()
        {
            try
            {
                int mactpd = (int)dgvDSHocVien_View.GetFocusedRowCellValue("MaChiTietPhieuDiem");
                ctpd = db.ChiTietPhieuDiems.Where(p => p.MaChiTietPhieuDiem == mactpd).FirstOrDefault();
            }
            catch { }
            txtMaHocVien.EditValue = ctpd.MaHocVien;
            txtTenHocVien.EditValue = dgvDSHocVien_View.GetFocusedRowCellValue("HoTenHV");
            txtLopChuyenNganh.EditValue = dgvDSHocVien_View.GetFocusedRowCellValue("TenLopChuyenNganh");
            txtDiemThi.EditValue = ctpd.DiemThi;
            txtGhiChu.EditValue = ctpd.GhiChu;


        }
        private void dgvDSHocVien_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            LoadCTPD();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            using (var ctx = new Model.QLDHV_model())
            {

                ChiTietPhieuDiem ttpd2 = ctx.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == ctpd.MaChiTietPhieuDiem).FirstOrDefault();

                if (txtDiemThi.Text != "")
                {
                    ttpd2.DiemThi = Convert.ToDouble(txtDiemThi.Text);

                }
                if (txtGhiChu.Text != "")
                {
                    ttpd2.GhiChu = txtGhiChu.Text;

                }

                ctx.SaveChanges();

            }

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //


            dgvDSHocVien.DataSource = null;
            List<TTDHV> dsTTDiemHV = new List<TTDHV>();
            using (var ctx = new Model.QLDHV_model())
            {
                List<TTDHV> dsAll = ctx.TTDHVs.SqlQuery("Select * from TTDHV").ToList<TTDHV>();

                dsTTDiemHV = dsAll.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();

            }
            dgvDSHocVien.DataSource = dsTTDiemHV;

            dgvDSHocVien.Refresh();

            //DSHV(maHK, maHp, maLhp);
            //LoadCTPD();
            txtMaHocVien.Text = "";
            txtTenHocVien.EditValue = null;
            txtLopChuyenNganh.Text = "";
            txtDiemThi.Text = "";
            txtGhiChu.Text = "";


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            List<TTDHV> dsTTDiemHV = new List<TTDHV>();
            using (var ctx = new Model.QLDHV_model())
            {

                
                List<TTDHV> dsAll = ctx.TTDHVs.SqlQuery("Select * from TTDHV").ToList<TTDHV>();
                

                dsTTDiemHV = dsAll.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();

                List<TTDHV> afterEditRows = (List<TTDHV>)dgvDSHocVien.DataSource;

                foreach(TTDHV obj in afterEditRows)
                {
                    ChiTietPhieuDiem ttpd2;
                    int ma = Convert.ToInt32(obj.MaChiTietPhieuDiem);
                    ttpd2 = db.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == ma).FirstOrDefault();
                    

                    if (obj.DiemThi != null)
                    {
                        ttpd2.DiemThi = Convert.ToDouble(obj.DiemThi);
                    }
                    if (obj.GhiChu != null)
                    {
                        ttpd2.GhiChu = obj.GhiChu;
                    }
                    ctx.SaveChanges();
                }

                

            }

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //


            dgvDSHocVien.DataSource = null;
            
            using (var ctx = new Model.QLDHV_model())
            {
                List<TTDHV> dsAll = ctx.TTDHVs.SqlQuery("Select * from TTDHV").ToList<TTDHV>();

                dsTTDiemHV = dsAll.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();

            }
            dgvDSHocVien.DataSource = dsTTDiemHV;

            dgvDSHocVien.Refresh();

        }

        /*private void dgvDSHocVien_View_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            ChiTietPhieuDiem ttpd2 = db.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == ctpd.MaChiTietPhieuDiem).FirstOrDefault();

            ttpd2.DiemThi = Convert.ToDouble(dgvDSHocVien_View.GetRowCellValue(e.RowHandle, "DiemThi").ToString());
            ttpd2.GhiChu = dgvDSHocVien_View.GetRowCellValue(e.RowHandle, "GhiChu").ToString();

            db.SaveChanges();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //

            dgvDSHocVien.DataSource = null;
            DSHV(maHK, maHp, maLhp);
        }*/
    }
}
