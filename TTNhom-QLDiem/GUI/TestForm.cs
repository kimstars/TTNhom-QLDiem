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
using TTNhom_QLDiem.GUI;


namespace TTNhom_QLDiem.GUI
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            Admin.QuanLyTaiKhoan testform = new Admin.QuanLyTaiKhoan();
            panelshow.Controls.Add(testform);
            testform.Dock = DockStyle.Fill;
        }
    }
}