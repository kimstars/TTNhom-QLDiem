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
    public partial class TTGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        public TTGiangVien()
        {
            InitializeComponent();
        }
        QLDHV_model db = new QLDHV_model();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int maid = MainForm.MaID;
            Model.GiangVien gv = db.GiangViens.Where(s => s.MaGiangVien == maid).FirstOrDefault();
            BoMon bm = db.BoMons.Where(s => s.MaBoMon == gv.MaBoMon).FirstOrDefault();
            txtMaGV.Text = gv.MaGiangVien.ToString();
            txtHoTenGV.Text = gv.HoTenGV;
            txtGioiTinh.Text = gv.GioiTinh;
            txtCapBac.Text = gv.CapBac;
            txtChucVu.Text = gv.ChucVu;
            txtMaBM.Text = gv.MaBoMon.ToString();
            txtMaTK.Text = gv.MaTK.ToString();
            dtNgaySinh.Text = gv.NgaySinh.ToString();
            txtTenBM.Text = bm.TenBoMon;
        }
    }
}
