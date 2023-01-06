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
    public partial class QuanLyLopHocPhan : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyLopHocPhan()
        {
            InitializeComponent();
        }

        QLDHV_model db = new QLDHV_model();

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int maid = MainForm.MaID;

            Model.GiangVien gv = db.GiangViens.Where(m => m.MaGiangVien == maid).FirstOrDefault();



        }
    }
}
