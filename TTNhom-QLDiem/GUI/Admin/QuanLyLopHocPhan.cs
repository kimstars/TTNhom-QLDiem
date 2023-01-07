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

        List<HocPhan> dsHocPhan;
        List<HocKy> dsHocKy;
        List<PhongHoc> dsPhongHoc;
        List<Model.GiangVien> dsGiangVien;
        List<LopChuyenNganh> dsLopCN;


        private void QuanLyLopHocPhan_Load(object sender, EventArgs e)
        {
            //cbThemHKi.SelectedIndexChanged += cbThemHKi_SelectedIndexChanged;


            dsHocPhan = db.HocPhans.ToList();
            dsHocKy = db.HocKies.ToList();
            dsPhongHoc = db.PhongHocs.ToList();
            dsLopCN = db.LopChuyenNganhs.ToList();


            dsGiangVien = db.GiangViens.ToList();
            cbThemGV.DataSource = dsGiangVien;
            cbThemGV.DisplayMember = "HoTenGV";
            cbThemGV.ValueMember = "MaGiangVien";


            cbThemHKi.DataSource = dsHocKy;
            cbThemHKi.DisplayMember = "TenHocKy";
            cbThemHKi.ValueMember = "MaHocKy";

            cbThemHocPhan.DataSource = dsHocPhan;
            cbThemHocPhan.DisplayMember = "TenHocPhan";
            cbThemHocPhan.ValueMember = "MaHocPhan";

            cbThemLopCN.DataSource = dsLopCN;
            cbThemLopCN.DisplayMember = "TenLopChuyenNganh";
            cbThemLopCN.ValueMember = "MaLopChuyenNganh";

            cbThemPhongHoc.DataSource = dsPhongHoc;
            cbThemPhongHoc.DisplayMember = "TenPhongHoc";
            cbThemPhongHoc.ValueMember = "MaPhongHoc";



            cbSuaGV.DataSource = dsGiangVien;
            cbSuaGV.DisplayMember = "HoTenGV";
            cbSuaGV.ValueMember = "MaGiangVien";

            cbSuaHocKi.DataSource = dsHocKy;
            cbSuaHocKi.DisplayMember = "TenHocKy";
            cbSuaHocKi.ValueMember = "MaHocKy";

            cbSuaHocPhan.DataSource = dsHocPhan;
            cbSuaHocPhan.DisplayMember = "TenHocPhan";
            cbSuaHocPhan.ValueMember = "MaHocPhan";

            cbSuaLopCN.DataSource = dsLopCN;
            cbSuaLopCN.DisplayMember = "TenLopChuyenNganh";
            cbSuaLopCN.ValueMember = "MaLopChuyenNganh";

            cbSuaPhongHoc.DataSource = dsPhongHoc;
            cbSuaPhongHoc.DisplayMember = "TenPhongHoc";
            cbSuaPhongHoc.ValueMember = "MaPhongHoc";

        }

        private void btnThemAddLopHP_Click(object sender, EventArgs e)
        {
            LopHocPhan newLHP = new LopHocPhan();
            newLHP.TenLopHocPhan = txtThemTenLHP.Text;
            newLHP.MaHocKy = maHK;
            newLHP.NgayThi = dateThemNgayThi.DateTime;
            newLHP.MaHocPhan = maHP;
            newLHP.MaPhongHoc = maPH;
            newLHP.MaGiangVien = MaGV;
            newLHP.TongHV = TongSiSo;
            db.LopHocPhans.Add(newLHP);
            db.SaveChanges();


            foreach(var item in dsLopCN)
            {
                db.LopChuyenNganhs.Where(m => m.MaLopChuyenNganh == item.MaLopChuyenNganh).FirstOrDefault().LopHocPhans.Add(newLHP);
            }

            db.SaveChanges();

            MessageBox.Show($"Thêm Lớp học phần '{txtThemTenLHP.Text}' thành công !!", "Thông báo");



        }


        string TenHP, TenHocKi, TenPhongHoc;
        int maHP, maHK, maPH;

        private void cbThemHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemHocPhan.SelectedIndex;
            ChangeNameClass(index, true);

        }

        private void cbSuaHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSuaHocPhan.SelectedIndex;
            ChangeNameClass(index, false);
        }


        void ChangeNameClass(int index,bool isAdd)
        {
            maHP = dsHocPhan[index].MaHocPhan;
            maHK = dsHocKy[index].MaHocKy;
            maPH = dsPhongHoc[index].MaPhongHoc;
            string tenlhp = "Lớp "
                + dsHocPhan[index].TenHocPhan
                + " - "
                + dsHocKy[index].TenHocKy
                + " - "
                + dsPhongHoc[index].TenPhongHoc;
            if (isAdd)
            {
                txtThemTenLHP.Text = tenlhp;
            }
            else
            {
                txtSuaTenLopHP.Text = tenlhp;

            }
        }

        private void cbSuaHocKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSuaHocKi.SelectedIndex;
            ChangeNameClass(index,false);
        }

        private void cbThemHKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemHKi.SelectedIndex;
            ChangeNameClass(index, true);
        }

        private void cbThemPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemPhongHoc.SelectedIndex;
            ChangeNameClass(index, true);
        }

        private void cbSuaPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSuaPhongHoc.SelectedIndex;
            ChangeNameClass(index,false);
        }


        int TongSiSo;

        void LoadTongSiSo(int sohv)
        {
            TongSiSo = 0;
            foreach(var item in dsThem_LopCN)
            {
                TongSiSo += item.SoHocVien;

            }
            lbThemSiSo.Text = TongSiSo.ToString();
        }

        List<Object_QLHP_DSLopCN> dsThem_LopCN = new List<Object_QLHP_DSLopCN>();
        private void btnthemAddLopCN_Click(object sender, EventArgs e)
        {
            Object_QLHP_DSLopCN newitem = new Object_QLHP_DSLopCN();

            LopChuyenNganh templcn = dsLopCN[cbThemLopCN.SelectedIndex];


            foreach(var item in dsThem_LopCN)
            {
                if(item.MaLopChuyenNganh == templcn.MaLopChuyenNganh)
                {
                    MessageBox.Show("Đã tồn tại lớp chuyên ngành trong danh sách!!", "Error");
                    return;
                }
            }


            newitem.TenLopChuyenNganh = templcn.TenLopChuyenNganh;
            newitem.MaLopChuyenNganh = templcn.MaLopChuyenNganh;

            int sohv = db.HocViens.Where(m => m.MaLopChuyenNganh == MaLopCN).Count();

            //MessageBox.Show(templcn.TenLopChuyenNganh + " - " + sohv.ToString());


            newitem.SoHocVien = sohv;


            dsThem_LopCN.Add(newitem);

            LoadTongSiSo(sohv);

            gridControl1.DataSource = null;
            gridControl1.DataSource = dsThem_LopCN;

        }

        int MaLopCN, MaGV;

        private void cbThemGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaGV = dsGiangVien[cbThemGV.SelectedIndex].MaGiangVien;

        }

        private void cbThemLopCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index  = cbThemLopCN.SelectedIndex;
            MaLopCN = dsLopCN[index].MaLopChuyenNganh;


        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.FocusedColumn == gridView1.Columns["fldXoa"])
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int index = e.RowHandle;
                    dsThem_LopCN.RemoveAt(index);


                    MessageBox.Show("Xóa thành công");
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = dsThem_LopCN;
                   
                }
                return;
            }


        }

        






    }
}
