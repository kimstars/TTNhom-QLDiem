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
    public partial class QuanLyGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyGiangVien()
        {
            InitializeComponent();
        }
        QLDHV_model db = new QLDHV_model();
        public static int MaTaiKhoan;
        List<Model.GiangVien> dsGiangVien;
        private void QuanLyGiangVien_Load(object sender, EventArgs e)
        {
            dsGiangVien = new List<Model.GiangVien>();
            dsGiangVien = db.GiangViens.ToList();
            dgvTTGV.DataSource = dsGiangVien;
        }
    }
}
