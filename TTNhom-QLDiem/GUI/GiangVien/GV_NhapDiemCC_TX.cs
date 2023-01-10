﻿using DevExpress.XtraEditors;
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
        int maHK;
        int maHp;
        int maLhp;

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

        private void DSHocVien(int maHK, int maHp, int maLhp)
        {
            using (var ctx = new Model.QLDHV_model())
            {
                List<GV_NhapDiem> dsAll = ctx.GV_NhapDiem.SqlQuery("Select * from GV_NhapDiem").ToList();

                List<GV_NhapDiem> DSHV = dsAll.Where(
                    m => (maHK == 0 || m.MaHocKy == maHK)
                && (maHp == 0 || m.MaHocPhan == maHp)
                && (maLhp == 0 || m.MaLopHocPhan == maLhp)
                && (m.MaGiangVien == MainForm.MaID)
                ).ToList();

                dsTTDiemHVCurr = DSHV;
                dgvDSHocVien.DataSource = DSHV;
            }
        }

        private void cbbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHocPhan.SelectedIndexChanged -= cbbHocPhan_SelectedIndexChanged;
            lstHocKy = db.HocKies.ToList();
            int id = cbbHocKy.SelectedIndex;
            maHK = lstHocKy[id].MaHocKy;
            lstHocPhan = (from hp in db.HocPhans
                          join lhp in db.LopHocPhans on hp.MaHocPhan equals lhp.MaHocPhan
                          where lhp.MaGiangVien == MainForm.MaID && lhp.MaHocKy == maHK
                          select hp).ToList();
            if (lstHocPhan.Count == 0)
            {
                MessageBox.Show("Không dạy học phần nào trong kỳ này!");
            }
            else
            {
                cbbHocPhan.DataSource = lstHocPhan;
                cbbHocPhan.ValueMember = "MaHocPhan";
                cbbHocPhan.DisplayMember = "TenHocPhan";
              
                cbbHocPhan.Text = "";
              
                DSHocVien(maHK, 0, 0);
                cbbHocPhan.SelectedIndexChanged += cbbHocPhan_SelectedIndexChanged;

            }


        }


        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbLopHocPhan.SelectedIndexChanged -= cbbLopHocPhan_SelectedIndexChanged;

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
            LoadCBBLopHocPhan(maHp, maHK);

            //đổ danh sách học viên ra theo học kỳ và học phần
            DSHocVien(maHK, maHp, 0);
            cbbLopHocPhan.SelectedIndexChanged += cbbLopHocPhan_SelectedIndexChanged;

        }

        private void LoadCBBLopHocPhan(int mahp, int maHk)
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
                txtHanNhapDiem.EditValue = lhp.NgayThi.AddDays(-7).ToString("dd/MM/yyyy");

                if (lhp.NgayThi.AddDays(-7) < DateTime.Now)
                {
                    MessageBox.Show("Quá hạn nhập điểm!");
                }


                DSHocVien(maHK, maHp, maLhp);
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
            txtDiemCC.EditValue = item.DiemCC;
            txtDiemTX.EditValue = item.DiemTX;

        }
        int MaCTPDcurr;

        private void btnLuu_Click(object sender, EventArgs e)
        {

            using (var ctx = new Model.QLDHV_model())
            {

                ChiTietPhieuDiem ttpd2 = ctx.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == MaCTPDcurr).FirstOrDefault();

                if (txtDiemCC.Text != "")
                {
                    ttpd2.DiemCC = Convert.ToDouble(txtDiemCC.Text);

                }
                if (txtDiemTX.Text != "")
                {
                    ttpd2.DiemTX = Convert.ToDouble(txtDiemTX.Text);

                }

                ctx.SaveChanges();

            }


            DSHocVien(maHK, maHp, maLhp);

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtMaHocVien.Text = "";
            txtTenHocVien.EditValue = null;
            txtLopChuyenNganh.Text = "";
            txtDiemCC.Text = "";
            txtDiemTX.Text = "";


        }

        List<GV_NhapDiem> dsTTDiemHVCurr = new List<GV_NhapDiem>();
       
        private void btnSua_Click(object sender, EventArgs e)
        {

            using (var ctx = new Model.QLDHV_model())
            {
                List<GV_NhapDiem> afterEditRows = (List<GV_NhapDiem>)dgvDSHocVien.DataSource;

                foreach (GV_NhapDiem obj in afterEditRows)
                {
                    ChiTietPhieuDiem ttpd2;
                    int ma = Convert.ToInt32(obj.MaChiTietPhieuDiem);
                    ttpd2 = ctx.ChiTietPhieuDiems.Where(m => m.MaChiTietPhieuDiem == ma).FirstOrDefault();


                    if (obj.DiemCC != null)
                    {
                        ttpd2.DiemCC = Convert.ToDouble(obj.DiemCC);
                    }

                  
                    if (obj.DiemTX != null)
                    {
                        ttpd2.DiemTX = obj.DiemTX;
                    }
                    ctx.SaveChanges();
                }
            }

            DSHocVien(maHK, maHp, maLhp);

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            

        }
    }
}
