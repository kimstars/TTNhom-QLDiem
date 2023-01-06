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
        }

        QLDHV_model db = new QLDHV_model();

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan newtk = new ThemTaiKhoan();
            newtk.Show();

            Model.HocVien hv = new Model.HocVien();

            db.HocViens.Add(hv);
            db.SaveChanges();
        }
        List<Model.HocVien> dsHocVien;
        private void QuanLyHocVien_Load(object sender, EventArgs e)
        {
            dsHocVien = new List<Model.HocVien>();
            dsHocVien = db.HocViens.ToList();

            dgvDSHocVien.DataSource = dsHocVien;



        }

        private void dgvTTCB_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int index = e.RowHandle;

            Model.HocVien itemHv = dsHocVien[index];


        }
    }
}
