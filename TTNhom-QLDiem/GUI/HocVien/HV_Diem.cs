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
namespace TTNhom_QLDiem.GUI.HocVien
{
    public partial class HV_Diem : DevExpress.XtraEditors.XtraUserControl
    {
        public QLDHV_model db = new QLDHV_model();
        public HocKy hk = new HocKy();
        public HocPhan hp = new HocPhan();
        List<HocKy> lstHocKy;
        List<HocPhan> lstHocPhan;
        List<TTDHV> lstDiem_HV;
        public HV_Diem()
        {
            InitializeComponent();
        }

        private void HV_Diem_Load(object sender, EventArgs e)
        {
            lstDiem_HV = db.TTDHVs.Where(m => m.MaHocVien == MainForm.MaID).ToList();
            gridControl1.DataSource = lstDiem_HV;
            SetDefault();
            lstHocKy = db.HocKies.ToList();
            radioGroup1.SelectedIndex = 0;
            cbTK.DataSource = lstHocKy;
            cbTK.ValueMember = "MaHocKy";
            cbTK.DisplayMember = "TenHocKy";

        }
       /* private void Load_dgvDiem()
        {
            
            if(radioGroup1.SelectedIndex == 0)
            {
                int maHK = db.HocKies.ToList().FirstOrDefault().MaHocKy;
                lstDiem_HV = db.TTDHVs.Where(m => m.MaHocVien == MainForm.MaID && m.MaHocKy == maHK).ToList();
                gridControl1.DataSource = lstDiem_HV;
                LoadChiTietDiemHV();
            }
            else
            {
                int mahp = db.HocPhans.ToList().FirstOrDefault().MaHocPhan;
                lstDiem_HV = db.TTDHVs.Where(m => m.MaHocVien == MainForm.MaID && m.MaHocPhan == mahp).ToList();
                gridControl1.DataSource = lstDiem_HV;
                LoadChiTietDiemHV();
            }
        }*/
       private void SetDefault()
        {
            txtTenHP.EditValue = "";
            txtDiemCC.EditValue = "";
            txtDiemTX.EditValue = "";
            txtDiemThi.EditValue = "";
            txtDiemTK.EditValue = "";
            txtTenGV.EditValue = "";
        }
        private void LoadChiTietDiemHV()
        {
            
            txtTenHP.EditValue = dgvChitietDiem.GetFocusedRowCellValue("TenHocPhan");
            txtDiemCC.EditValue = dgvChitietDiem.GetFocusedRowCellValue("DiemCC");
            txtDiemTX.EditValue = dgvChitietDiem.GetFocusedRowCellValue("DiemTX");
            txtDiemThi.EditValue = dgvChitietDiem.GetFocusedRowCellValue("DiemThi");
            txtDiemTK.EditValue = dgvChitietDiem.GetFocusedRowCellValue("DiemTK");
            txtTenGV.EditValue = dgvChitietDiem.GetFocusedRowCellValue("HoTenGV");
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

            RadioGroup edit = sender as RadioGroup;
            if (edit.SelectedIndex == 0)
            {
                lstHocKy = db.HocKies.ToList();
                cbTK.DataSource = lstHocKy;
                cbTK.ValueMember = "MaHocKy";
                cbTK.DisplayMember = "TenHocKy";


            }
            else
            {
                lstHocPhan = db.HocPhans.ToList();
                cbTK.DataSource = lstHocPhan;
                cbTK.ValueMember = "MaHocPhan";
                cbTK.DisplayMember = "TenHocPhan";
            }
        }

        private void cbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (radioGroup1.SelectedIndex == 0)
            {
                id= int.Parse(cbTK.SelectedIndex.ToString());
                int mahk = lstHocKy[id].MaHocKy;
                lstDiem_HV = db.TTDHVs.Where(m => m.MaHocVien == MainForm.MaID && m.MaHocKy ==mahk).ToList();
                gridControl1.DataSource = lstDiem_HV;
                SetDefault();
            }
            else
            {
                id = int.Parse(cbTK.SelectedIndex.ToString());
                int mahp = lstHocPhan[id].MaHocPhan;
                lstDiem_HV = db.TTDHVs.Where(m => m.MaHocVien == MainForm.MaID && m.MaHocPhan == mahp).ToList();
                gridControl1.DataSource = lstDiem_HV;
                SetDefault();
            }
        }

        private void dgvChitietDiem_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadChiTietDiemHV();
        }
    }
}
