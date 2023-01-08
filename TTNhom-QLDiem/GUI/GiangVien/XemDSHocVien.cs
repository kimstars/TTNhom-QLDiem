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
        public int magv = MainForm.MaID;
        public QLDHV_model db = new QLDHV_model();
        List<GV_DSLopChuyenNganh_HV> lscn ;
        //QLDHV_model db = new QLDHV_model();

        public XemDSHocVien()
        {
            InitializeComponent();
            
        }
        private void getBoMon()
        {
            List<BoMon> lsbm = db.BoMons.ToList();
            foreach (var item in lsbm)
            {
                cbBoMon.Items.Add(item.TenBoMon);
            }
        }
        private void getHocKy()
        {
            List<HocKy> lshk = db.HocKies.ToList();
            foreach (var item in lshk)
            {
                cbBoMon.Items.Add(item.TenHocKy);
            }
        }
        private void getHocPhan()
        {
            List<HocPhan> lshp = db.HocPhans.ToList();
            foreach (var item in lshp)
            {
                cbBoMon.Items.Add(item.TenHocPhan);
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
            List<GV_DSLopChuyenNganh_HV> lscn1 = new List<GV_DSLopChuyenNganh_HV>();
            lscn1 = db.GV_DSLopChuyenNganh_HV.ToList();
            gridControl_DSChuyenNganh.DataSource = lscn;
        }

        private void grdView_DSLopChuyenNganh_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            grid_HocVien.DataSource = null;
            int index = e.RowHandle;
            Model.GV_DSLopChuyenNganh_HV lcn = lscn[index];
            int malcn = lcn.MaLopChuyenNganh;
            //List<HocKy> lshk = db.HocKies.ToList();
            List<Model.HocVien> hv = db.HocViens.Where(s => s.MaLopChuyenNganh == malcn).ToList();
            grid_HocVien.DataSource = hv;
        }

        private void XemDSHocVien_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
