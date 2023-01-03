using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNhom_QLDiem.GUI
{
    public partial class formchung : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string state = "";
        public formchung(string State)
        {
            InitializeComponent();
            //state = State;
        }

        private void dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void doimk_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMK Dmk = new DoiMK();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void Themtk_ItemClick(object sender, ItemClickEventArgs e)
        {
            Admin.QuanLyQuyen.ThemTK Dmk = new Admin.QuanLyQuyen.ThemTK();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void formchung_Load(object sender, EventArgs e)
        {
            if(state=="Học Viên")
            {
                HocVien.QLyHV Dmk = new HocVien.QLyHV();
                panelchung.Controls.Clear();
                panelchung.Dock = DockStyle.Fill;
                panelchung.Controls.Add(Dmk);
                Dmk.Dock = DockStyle.Fill;
                Dmk.Show();
            }
            else if (state == "Giảng Viên")
            {
                GiangVien.QLyGV Dmk = new GiangVien.QLyGV();
                panelchung.Controls.Clear();
                panelchung.Dock = DockStyle.Fill;
                panelchung.Controls.Add(Dmk);
                Dmk.Dock = DockStyle.Fill;
                Dmk.Show();
            }
            else
            {
                panelchung.Controls.Clear();
            }
        }

        private void DSHV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(state=="Giảng Viên")
            {
                GiangVien.DSHVien Dmk = new GiangVien.DSHVien();
                panelchung.Controls.Clear();
                panelchung.Dock = DockStyle.Fill;
                panelchung.Controls.Add(Dmk);
                Dmk.Dock = DockStyle.Fill;
                Dmk.Show();
            }
            else if (state == "Admin") {
                Admin.QuanLyNghiepVu.QuanLyHV Dmk = new Admin.QuanLyNghiepVu.QuanLyHV();
                panelchung.Controls.Clear();
                panelchung.Dock = DockStyle.Fill;
                panelchung.Controls.Add(Dmk);
                Dmk.Dock = DockStyle.Fill;
                Dmk.Show();
            }
            else
            {
                HocVien.QLyHV Dmk = new HocVien.QLyHV();
                panelchung.Controls.Clear();
                panelchung.Dock = DockStyle.Fill;
                panelchung.Controls.Add(Dmk);
                Dmk.Dock = DockStyle.Fill;
                Dmk.Show();

            }
        }

        private void traCuuDiemThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Admin.QuanLyNghiepVu.TraCuu Dmk = new Admin.QuanLyNghiepVu.TraCuu();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void QuanLyLopHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Admin.QuanLyNghiepVu.Quanlylop.TaolopHP Dmk = new Admin.QuanLyNghiepVu.Quanlylop.TaolopHP();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void HocPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Admin.QuanLyNghiepVu.Quanlylop.TaoHP Dmk = new Admin.QuanLyNghiepVu.Quanlylop.TaoHP();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void NhapDlan1_ItemClick(object sender, ItemClickEventArgs e)
        {
            GiangVien.NhapDiemL1 Dmk = new GiangVien.NhapDiemL1();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void DiemHocLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            GiangVien.NhapdiemHocLai Dmk = new GiangVien.NhapdiemHocLai();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }

        private void DiemThiLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            GiangVien.NhapDiemThi Dmk = new GiangVien.NhapDiemThi();
            panelchung.Controls.Clear();
            panelchung.Dock = DockStyle.Fill;
            panelchung.Controls.Add(Dmk);
            Dmk.Dock = DockStyle.Fill;
            Dmk.Show();
        }
    }
}