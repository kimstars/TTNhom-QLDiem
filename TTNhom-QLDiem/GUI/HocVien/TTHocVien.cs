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

namespace TTNhom_QLDiem.GUI.HocVien
{
    public partial class TTHocVien : DevExpress.XtraEditors.XtraUserControl
    {
        public TTHocVien()
        {
            InitializeComponent();
        }
        QLDHV_model db = new QLDHV_model();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int maid = MainForm.MaID;
            Model.HocVien hv = db.HocViens.Where(s => s.MaHocVien == maid).FirstOrDefault();
            LopChuyenNganh lcn = db.LopChuyenNganhs.Where(s => s.MaLopChuyenNganh == hv.MaLopChuyenNganh).FirstOrDefault();
            txtMaHV.Text = hv.MaHocVien.ToString();
            txtHoTenHV.Text = hv.HoTenHV;
            txtGioiTinh.Text = hv.GioiTinh;
            txtCapBac.Text = hv.CapBac;
            txtChucVu.Text = hv.ChucVu;
            txtMaLopCN.Text = hv.MaLopChuyenNganh.ToString();
            txtMaTK.Text = hv.MaTK.ToString();
            dtNgaySinh.Text = hv.NgaySinh.ToString();
            txtTenLopCN.Text = lcn.TenLopChuyenNganh;
        }
    }
}
