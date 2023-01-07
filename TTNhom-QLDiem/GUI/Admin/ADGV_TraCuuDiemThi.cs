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
            gridControl1.DataSource = (db.ADV_TraCuuDiemHV.Where(s => 
                                        (txtMaHV.Text == "" || s.MaHocVien.ToString().Contains(txtMaHV.Text))
                                        && (txtTenHV.Text=="" || s.HoTenHV.Contains(txtTenHV.Text)) 
                                        && (cbLopCN.Text == "" || s.TenLopChuyenNganh.Contains(cbLopCN.Text)) 
                                        && (cbMonThi.Text == "" || s.TenHocPhan.Contains(cbMonThi.Text)) 
                                        && (cbHocKy.Text == "" || s.TenHocKy.Contains(cbHocKy.Text))).ToList());
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
            getHocKy();
            getLopCN();
            getMonThi();
            gridControl1.DataSource = db.ADV_TraCuuDiemHV.ToList();
        }
    }
}
