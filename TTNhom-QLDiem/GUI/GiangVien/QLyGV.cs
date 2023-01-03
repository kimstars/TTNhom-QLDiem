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

namespace TTNhom_QLDiem.GUI.GiangVien
{
    public partial class QLyGV : DevExpress.XtraEditors.XtraUserControl
    {
        public QLyGV()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            GiangVien.TTCT Dmk = new GiangVien.TTCT();
            Dmk.Show();
        }
    }
}
