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
    public partial class XemDSHocVien : DevExpress.XtraEditors.XtraUserControl
    {
        //public int magv = MainForm.MaID;
        public int magv = 1;

        public QLDHV_model db = new QLDHV_model();
        List<GV_LopChuyenNganh> lopCN ;
        //QLDHV_model db = new QLDHV_model();
        int mabm;

        public XemDSHocVien()
        {
            InitializeComponent();
            
        }
        private void getBoMon()
        {
            List<BoMon> lsbm = db.BoMons.ToList();
            foreach (var item in lsbm)
            {
                cbBoMon.Items.Add(item.MaBoMon);
            }
        }
        private void getHocKy()
        {
            List<HocKy> lshk = db.HocKies.ToList();
            foreach (var item in lshk)
            {
                cbHocKy.Items.Add(item.TenHocKy);
            }
        }
        private void getHocPhan()
        {
            List<HocPhan> lshp = db.HocPhans.ToList();
            foreach (var item in lshp)
            {
                cbHocPhan.Items.Add(item.TenHocPhan);
            }
        }
        private void getLopHocPhanPhuTrach()
        {
            List<LopHocPhan> lhp = db.LopHocPhans.Where(p => p.MaGiangVien == magv).ToList();
            cbLopHPphutrach.Items.Clear();
            foreach (var item in lhp.ToList())
            {
                cbLopHPphutrach.Items.Add(item.MaLopHocPhan);
            }
        }
        public void reload()
        {
            Model.GiangVien gv = db.GiangViens.Where(m => m.MaGiangVien == magv).FirstOrDefault();
            cbBoMon.Text = "";
            cbHocKy.Text = "";
            cbHocPhan.Text = "";
            cbLopHPphutrach.Text = "";
            getBoMon();
            getHocKy();
            getHocPhan();
            getLopHocPhanPhuTrach();
            List<GV_LopChuyenNganh> lscn1 = new List<GV_LopChuyenNganh>();
            lscn1 = db.GV_LopChuyenNganh.ToList();
            gridControl_DSChuyenNganh.DataSource = lscn1;
        }

        private void grdView_DSLopChuyenNganh_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            grid_HocVien.DataSource = null;
            int index = e.RowHandle;
            GV_LopChuyenNganh lcn = lopCN[index];
            int malcn = lcn.MaLopChuyenNganh;
            List<Model.HocVien> hv = db.HocViens.Where(s => s.MaLopChuyenNganh == malcn).ToList();
            grid_HocVien.DataSource = hv;
        }

        private void XemDSHocVien_Load(object sender, EventArgs e)
        {
            reload();
        }
        void TimKiem(bool isall = false)
        {
            if (isall)
            {
                gridControl_DSChuyenNganh.DataSource = db.GV_LopChuyenNganh.ToList();
            }
            else
            {
                gridControl_DSChuyenNganh.DataSource = (db.GV_LopChuyenNganh.Where(s =>
                                          (cbBoMon.Text == "" || s.TenBoMon == cbBoMon.Text)
                                          && (cbHocKy.Text == "" || s.TenHocKy.Contains(cbHocKy.Text))
                                           && (cbLopHPphutrach.Text == "" || s.TenLopHocPhan.Contains(cbLopHPphutrach.Text))
                                           && (cbHocPhan.Text == "" || s.TenHocPhan.Contains(cbHocPhan.Text))).ToList());
                                           
            }
        }

        private void cbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mabm = db.BoMons.Where(s => s.TenBoMon == cbBoMon.Text).FirstOrDefault().MaBoMon;
            TimKiem();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void cbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void cbLopHPphutrach_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
