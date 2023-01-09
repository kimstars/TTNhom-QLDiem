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
            cbbHocKy.SelectedIndex = -1;
            cbbHocKy.Text = "";
            //maHK = 0;

            //LoadCBBHocPhan(maHK);
            txtNgayThi.Text = "";
            txtSoTinChi.Text = "";
            txtHanNhapDiem.Text = "";
            radioGroup2.SelectedIndex = -1;
            cbbHocKy.SelectedIndexChanged += cbbHocKy_SelectedIndexChanged;
            cbbHocPhan.SelectedIndexChanged += cbbHocPhan_SelectedIndexChanged;
            cbbLopHocPhan.SelectedIndexChanged += cbbLopHocPhan_SelectedIndexChanged;

        }
       
        private void DSHV(int maHK, int maHp, int maLhp)
        {
            using (var ctx = new Model.QLDHV_model())
            {
                List<GV_NhapDiem> dsAll = ctx.GV_NhapDiem.SqlQuery("Select * from GV_NhapDiem").ToList();

                List<GV_NhapDiem> DSHV = dsAll.Where(
                    m =>(maHK==0 || m.MaHocKy == maHK )
                && (maHp == 0 || m.MaHocPhan == maHp )
                && (maLhp == 0||m.MaLopHocPhan == maLhp) 
                && (m.MaGiangVien == MainForm.MaID)
                ).ToList();

                dsTTDiemHVCurr = DSHV;
                dgvDSHocVien.DataSource = DSHV;
            }
        }   
        
        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID && lhp.MaHocKy == maHK
                          select hp).ToList();
            if(lstHocPhan.Count == 0)
            {
                MessageBox.Show("Không dạy học phần nào trong kỳ này!");
            }
            else
            {
                cbbHocPhan.DataSource = lstHocPhan;
                cbbHocPhan.ValueMember = "MaHocPhan";
                cbbHocPhan.DisplayMember = "TenHocPhan";
                //cbbHocPhan.SelectedIndex = -1;
                cbbHocPhan.Text = "";
                //cbbLopHocPhan.SelectedIndex = -1;
                List<GV_NhapDiem> DSHV = db.GV_NhapDiem.Where(m => m.MaHocKy == maHK && m.MaGiangVien == MainForm.MaID).ToList();

                dgvDSHocVien.DataSource = DSHV;
            }
          

        }

       
        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbbHocPhan.SelectedIndexChanged += cbbHocPhan_SelectedIndexChanged;

            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID && lhp.MaHocKy == maHK
                          select hp).ToList();
            int id1 = cbbHocPhan.SelectedIndex;
            maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            //MessageBox.Show(maHp.ToString());
            LoadCBBLopHocPhan(maHp,maHK);
           
            //đổ danh sách học viên ra theo học kỳ và học phần
            DSHV(maHK, maHp,0);

        }

        private void LoadCBBLopHocPhan(int mahp,int maHk)
        {

            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == mahp && m.MaHocKy == maHk).ToList();
            cbbLopHocPhan.DataSource = lstLopHocPhan;
            cbbLopHocPhan.DisplayMember = "TenLopHocPhan";
            cbbLopHocPhan.ValueMember = "MaLopHocPhan";
           // cbbLopHocPhan.SelectedIndex = -1;
            cbbLopHocPhan.Text = "";

        }

        private void cbbLopHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*// lấy mã học kỳ
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;  
            // lấy mã học phần
            lstHocPhan = (from hps in db.HocPhans
                          join lhps in db.LopHocPhans on hps.MaHocPhan equals lhps.MaHocPhan
                          where lhps.MaGiangVien == MainForm.MaID
                          select hps).ToList();
            maHp = lstHocPhan[cbbHocPhan.SelectedIndex].MaHocPhan;
            lstLopHocPhan = db.LopHocPhans.Where(m => m.MaGiangVien == MainForm.MaID && m.MaHocPhan == maHp).ToList();*/


            //lấy mã lớp học phần
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

        private void dgvDSHocVien_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            int index = e.RowHandle;
            GV_NhapDiem item = dsTTDiemHVCurr[index];
            MaCTPDcurr = item.MaChiTietPhieuDiem;
            txtMaHocVien.EditValue = item.MaHocVien;
            txtTenHocVien.EditValue = item.HoTenHV;
            txtLopChuyenNganh.EditValue = item.TenLopChuyenNganh;
            txtDiemThi.EditValue = item.DiemThi;
            txtGhiChu.EditValue = item.GhiChu;

        }
        int MaCTPDcurr;

        private void btnLuu_Click(object sender, EventArgs e)
        {

            using (var ctx = new Model.QLDHV_model())
            {

                ChiTietPhieuDiem ttpd2 = ctx.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == MaCTPDcurr).FirstOrDefault();

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
            List<GV_NhapDiem> dsTTDiemHV = new List<GV_NhapDiem>();

            using (var ctx = new Model.QLDHV_model())
            {
                List<GV_NhapDiem> dsAll = ctx.GV_NhapDiem.SqlQuery("Select * from GV_NhapDiem").ToList();

                dsTTDiemHV = dsAll.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();
                dsTTDiemHVCurr = dsTTDiemHV;

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
        
        List<GV_NhapDiem> dsTTDiemHVCurr = new List<GV_NhapDiem>();
        private void btnSua_Click(object sender, EventArgs e)
        {
            List<GV_NhapDiem> dsTTDiemHV = new List<GV_NhapDiem>();
            using (var ctx = new Model.QLDHV_model())
            {

                
                List<GV_NhapDiem> dsAll = ctx.GV_NhapDiem.SqlQuery("Select * from GV_NhapDiem").ToList<GV_NhapDiem>();
                

                dsTTDiemHV = dsAll.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();

                List<GV_NhapDiem> afterEditRows = (List<GV_NhapDiem>)dgvDSHocVien.DataSource;

                foreach(GV_NhapDiem obj in afterEditRows)
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
                List<GV_NhapDiem> dsAll = ctx.GV_NhapDiem.SqlQuery("Select * from GV_NhapDiem").ToList<GV_NhapDiem>();

                dsTTDiemHV = dsAll.Where(m => m.MaHocKy == maHK && m.MaHocPhan == maHp && m.MaLopHocPhan == maLhp).ToList();

            }
            dgvDSHocVien.DataSource = dsTTDiemHV;

            dgvDSHocVien.Refresh();

        }


        // Chưa sửa lưu khi sửa trực tiếp trên gridview



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
