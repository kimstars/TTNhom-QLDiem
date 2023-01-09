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
        private void getHocKy()
        {
            List<HocKy> dt = db.HocKies.ToList();
            foreach(var item in dt)
            {
                cbHocKy.Items.Add(item.TenHocKy);
            }
        }
        private void getLopCN()
        {
            List<LopChuyenNganh> dt = db.LopChuyenNganhs.ToList();
            foreach (var item in dt)
            {
                cbLopCN.Items.Add(item.TenLopChuyenNganh);
            }
        }
        private void getMonThi()
        {
            List<HocPhan> dt = db.HocPhans.ToList();
            foreach (var item in dt)
            {
                cbMonThi.Items.Add(item.TenHocPhan);
            }
        }
        QLDHV_model db = new QLDHV_model();
        List<ADV_TraCuuDiemHV> TraCuuDiemHV = new List<ADV_TraCuuDiemHV>();
        private void btn_search_Click(object sender, EventArgs e)
        {
            TimKiem(true);
        }

        void TimKiem(bool isall = false)
        {
            if (isall)
            {
                gridControl1.DataSource = db.ADV_TraCuuDiemHV.ToList();
            }
            else
            {
                gridControl1.DataSource = (db.ADV_TraCuuDiemHV.Where(s =>
                                           (txtMaHV.Text == "" || s.MaHocVien== int.Parse(txtMaHV.Text))
                                           && (txtTenHV.Text == "" || s.HoTenHV.Contains(txtTenHV.Text))
                                           && (cbLopCN.Text == "" || s.TenLopChuyenNganh.Contains(cbLopCN.Text))
                                           && (cbMonThi.Text == "" || s.TenHocPhan.Contains(cbMonThi.Text))
                                           && (cbHocKy.Text == "" || s.TenHocKy.Contains(cbHocKy.Text))).ToList());
            }
        }
        private void reload()
        {
            cbHocKy.Text = "";
            cbLopCN.Text = "";
            cbMonThi.Text = "";
            txtMaHV.Text = "";
            txtTenHV.Text = "";
            getHocKy();
            getLopCN();
            getMonThi();
            List<ADV_TraCuuDiemHV> TraCuuDiemHV1 = new List<ADV_TraCuuDiemHV>();
            TraCuuDiemHV1 = db.ADV_TraCuuDiemHV.ToList();
            gridControl1.DataSource = TraCuuDiemHV1; 
        }

        private void txtMaHV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHV.Text != "")
            {
                txtTenHV.Enabled = false;
                txtTenHV.Text = db.HocViens.Where(s => s.MaHocVien.ToString() == txtMaHV.Text).FirstOrDefault().HoTenHV;
            }
            else
            {
                txtTenHV.Enabled = true;
                txtTenHV.Text = "";
            }
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();

        }

        private void cbLopCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();

        }

        private void cbMonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiem();

        }
    }
}
