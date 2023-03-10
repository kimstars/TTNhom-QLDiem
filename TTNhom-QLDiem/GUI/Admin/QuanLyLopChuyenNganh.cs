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
    public partial class QuanLyLopChuyenNganh : DevExpress.XtraEditors.XtraUserControl
    {
        public QuanLyLopChuyenNganh()
        {
            InitializeComponent();
            reload();
        }
        QLDHV_model db = new QLDHV_model();
        List<AD_LopChuyenNganh> dsViewLopCN;
        List<LopChuyenNganh> lcn;
        int macn;
        private void reload()
        {
            getMaBM();
            getMaLP();
            txtThemTenLopCN.Text = "";
            cbMaBM.Text = "";
            txtTenBM.Text = "";
            txtEditLopCN.Text = "";
            cbEditMaBM.Text = "";
            textEditTenBM.Text = "";
            cbMaloptruong.Text = "";
            cbEditMaLP.Text = "";
            txtLopTruong.Text = "";
            textEditLopTruong.Text = "";
            textMaLopCN.Text = "";
            QLDHV_model db1 = new QLDHV_model();
            dgvDSLopCN.DataSource = null;
            dsViewLopCN = db1.AD_LopChuyenNganh.ToList();
            dgvDSLopCN.DataSource = dsViewLopCN;
        }
        private void getMaLP()
        {
            List<Model.HocVien> dt = db.HocViens.ToList();
            foreach (var item in dt)
            {
                cbMaloptruong.Items.Add(item.MaHocVien);
                cbEditMaLP.Items.Add(item.MaHocVien);
            }
        }
        private void getMaBM()
        {
            List<BoMon> dt = db.BoMons.ToList();
            foreach (var item in dt)
            {
                cbMaBM.Items.Add(item.MaBoMon);
                cbEditMaBM.Items.Add(item.MaBoMon);
            }
        }
        private void btnThemCB_Click(object sender, EventArgs e)
        {
            LopChuyenNganh lopcn = new LopChuyenNganh();
            if (CheckThemlopCN())
            {
                lopcn.TenLopChuyenNganh = txtThemTenLopCN.Text;
                lopcn.MaBoMon = int.Parse(cbMaBM.Text);
                if (cbMaloptruong.Text != "")
                {
                    if (checkloptruong())
                    {
                        lopcn.MaLopTruong = int.Parse(cbMaloptruong.Text);
                        db.LopChuyenNganhs.Add(lopcn);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    lopcn.MaLopTruong = null;
                    db.LopChuyenNganhs.Add(lopcn);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            reload();
        }

        private void btnSuaLopCN_Click(object sender, EventArgs e)
        {
            LopChuyenNganh lopcn = db.LopChuyenNganhs.Where(s => s.MaLopChuyenNganh == macn).FirstOrDefault();
            if (CheckSualopCN())
            {
                lopcn.TenLopChuyenNganh = txtEditLopCN.Text;
                lopcn.MaBoMon = int.Parse(cbEditMaBM.Text);
                if (cbEditMaLP.Text != "")
                {
                    if (checkloptruongEdit())
                    {
                        lopcn.MaLopTruong = int.Parse(cbEditMaLP.Text);
                        db.SaveChanges();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                    }
                }
                else
                {
                    lopcn.MaLopTruong = null;
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            reload();
        }
        public bool CheckThemlopCN()
        {
            if (txtThemTenLopCN.Text == "" || cbMaBM.Text == "" )
            {
                MessageBox.Show("Thông tin Lớp Chuyên Ngành không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        public bool CheckSualopCN()
        {
            if (txtEditLopCN.Text == "" || cbEditMaBM.Text == "")
            {
                MessageBox.Show("Thông tin Lớp Chuyên Ngành không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        private void dgvTTCB_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtraTabPageSua.Show();
            int index = e.RowHandle;
            AD_LopChuyenNganh lopcn = dsViewLopCN[index];
            textMaLopCN.Text = lopcn.MaLopChuyenNganh.ToString();
            macn = lopcn.MaLopChuyenNganh;
            txtEditLopCN.Text = lopcn.TenLopChuyenNganh;
            cbEditMaLP.Text = lopcn.MaLopTruong.ToString();
            cbEditMaBM.Text = lopcn.MaBoMon.ToString();
            textEditTenBM.Text = db.BoMons.Where(s => s.MaBoMon.ToString() == cbEditMaBM.Text).FirstOrDefault().TenBoMon;
            if (cbEditMaLP.Text == "")
            {
                textEditLopTruong.Text = "";
            }else
            {
                textEditLopTruong.Text=db.HocViens.Where(s => s.MaHocVien.ToString() == cbEditMaLP.Text).FirstOrDefault().HoTenHV;
            }
        }

        private void cbMaloptruong_TextChanged(object sender, EventArgs e)
        {
            txtLopTruong.Text = db.HocViens.Where(s => s.MaHocVien.ToString() == cbMaloptruong.Text).FirstOrDefault().HoTenHV; 
        }

        private void cbMaBM_TextChanged(object sender, EventArgs e)
        {
            txtTenBM.Text = db.BoMons.Where(s => s.MaBoMon.ToString() == cbMaBM.Text).FirstOrDefault().TenBoMon;
        }

        private void cbEditMaLP_TextChanged(object sender, EventArgs e)
        {
            textEditLopTruong.Text = db.HocViens.Where(s => s.MaHocVien.ToString() == cbEditMaLP.Text).FirstOrDefault().HoTenHV;
        }

        private void cbEditMaBM_TextChanged(object sender, EventArgs e)
        {
            textEditTenBM.Text = db.BoMons.Where(s => s.MaBoMon.ToString() == cbEditMaBM.Text).FirstOrDefault().TenBoMon;
        }
        public bool checkloptruong()
        {
            QLDHV_model db1 = new QLDHV_model();
            List<AD_LopChuyenNganh> dt = db1.AD_LopChuyenNganh.ToList();
            foreach(var item in dt)
            {
                if (cbMaloptruong.Text==item.MaLopTruong.ToString()) 
                {
                    MessageBox.Show("Lớp trưởng đã tồn tại, hãy chọn người khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                    break;
                }
                
            }
            return true;
        }
        public bool checkloptruongEdit()
        {
            QLDHV_model db1 = new QLDHV_model();
            List<AD_LopChuyenNganh> dt = db1.AD_LopChuyenNganh.ToList();
            foreach (var item in dt)
            {
                if (cbEditMaLP.Text == item.MaLopTruong.ToString())
                {
                    MessageBox.Show("Lớp trưởng đã tồn tại, hãy chọn người khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                    break;
                }

            }
            return true;
        }
    }
}
