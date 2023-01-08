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
<<<<<<< HEAD
            GiangVien.XemDSHocVien testform = new GiangVien.XemDSHocVien();
=======
            Admin.QuanLyLopChuyenNganh testform = new Admin.QuanLyLopChuyenNganh();
            //Admin.QuanLyHocVien testform = new Admin.QuanLyHocVien();
>>>>>>> main
            panelshow.Controls.Add(testform);
            testform.Dock = DockStyle.Fill;
        }
    }
}