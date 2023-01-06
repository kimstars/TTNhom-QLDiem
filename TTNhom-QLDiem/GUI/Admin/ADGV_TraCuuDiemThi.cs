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
    public partial class ADGV_TraCuuDiemThi : DevExpress.XtraEditors.XtraUserControl
    {
        public ADGV_TraCuuDiemThi()
        {
            
            InitializeComponent();
            reload();
        }
        QLDHV_model db = new QLDHV_model();
        List<ADV_TraCuuDiemHV> TraCuuDiemHV = new List<ADV_TraCuuDiemHV>();
        private void btn_search_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.ADV_TraCuuDiemHV.Where(s => s.MaHocVien.ToString().Contains(txtMaHV.Text) && s.HoTenHV.Contains(txtTenHV.Text) && s.TenLopChuyenNganh.Contains(cbLopCN.Text) && s.TenHocPhan.Contains(cbMonThi.Text) && s.TenHocKy.Contains(cbHocKy.Text)).ToList();
            cbHocKy.Text = "";
            cbLopCN.Text = "";
            cbMonThi.Text = "";
            txtMaHV.Text = "";
            txtTenHV.Text = "";
        }
        private void reload()
        {
            cbHocKy.Text = "";
            cbLopCN.Text = "";
            cbMonThi.Text = "";
            txtMaHV.Text = "";
            txtTenHV.Text = "";
            gridControl1.DataSource = db.ADV_TraCuuDiemHV.ToList();
        }
    }
}
