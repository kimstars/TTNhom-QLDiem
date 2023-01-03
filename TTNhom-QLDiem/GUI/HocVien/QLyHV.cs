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

namespace TTNhom_QLDiem.GUI.HocVien
{
    public partial class QLyHV : DevExpress.XtraEditors.XtraUserControl
    {
        public QLyHV()
        {
            InitializeComponent();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            HocVien.TTCT Dmk = new HocVien.TTCT();
            Dmk.Show();
        }
    }
}
