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

        List<AD_QLLHP_DSLopHocPhan> dsLopHP;

        private void QuanLyLopHocPhan_Load(object sender, EventArgs e)
        {
            //cbThemHKi.SelectedIndexChanged += cbThemHKi_SelectedIndexChanged;

            dsLopHP = db.AD_QLLHP_DSLopHocPhan.ToList();

            dgvDSLopHocPhan.DataSource = dsLopHP;

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
        List<Model.HocVien> dsHocVien;
        private void btnThemAddLopHP_Click(object sender, EventArgs e)
        {
            int MaLopHPCur;
            int MaPhieuDiemCur;

            using (var context = new QLDHV_model())
            {
                LopHocPhan newLHP = new LopHocPhan();
                newLHP.TenLopHocPhan = txtThemTenLHP.Text;
                newLHP.MaHocKy = maHK;
                newLHP.NgayThi = dateThemNgayThi.DateTime;
                newLHP.MaHocPhan = maHP;
                newLHP.MaPhongHoc = maPH;
                newLHP.MaGiangVien = MaGV;
                newLHP.TongHV = TongSiSo;
                context.LopHocPhans.Add(newLHP);
                context.SaveChanges();

                MaLopHPCur = newLHP.MaLopHocPhan;
                dsHocVien = new List<Model.HocVien>();

                foreach (var item in ds_grid_LopCN_current)
                {
                    context.LopChuyenNganhs.Where(m => m.MaLopChuyenNganh == item.MaLopChuyenNganh).FirstOrDefault().LopHocPhans.Add(newLHP);

                    List<Model.HocVien> temp = db.HocViens.Where(m => m.MaLopChuyenNganh == item.MaLopChuyenNganh).ToList();
                    dsHocVien.AddRange(temp);

                }

                context.SaveChanges();
            }


            MessageBox.Show($"Thêm Lớp học phần '{txtThemTenLHP.Text}' thành công !!", "Thông báo");

            MessageBox.Show($"Tiếp tục tạo phiếu điểm ...", "Thông báo");

            LopHocPhan tarLHP = db.LopHocPhans.Where(m => m.MaLopHocPhan == MaLopHPCur).FirstOrDefault();



            using (var context = new QLDHV_model())
            {
                PhieuDiem newPD = new PhieuDiem
                {
                    MaLopHocPhan = MaLopHPCur
                };
                context.PhieuDiems.Add(newPD);

                context.SaveChanges();
                MaPhieuDiemCur = newPD.MaPhieuDiem;

            }

            List<ChiTietPhieuDiem> dsCTPD = new List<ChiTietPhieuDiem>();

            using (var context = new QLDHV_model())
            {
                foreach (var item in dsHocVien)
                {
                    ChiTietPhieuDiem temp = new ChiTietPhieuDiem
                    {
                        MaHocVien = item.MaHocVien,
                        MaPhieuDiem = MaPhieuDiemCur

                    };
                    dsCTPD.Add(temp);
                }

                context.ChiTietPhieuDiems.AddRange(dsCTPD);

                context.SaveChanges();

            }


            MessageBox.Show($"Thêm chi tiết phiếu điểm thành công !!", "Thông báo");

            gridControl1.DataSource = null;
            dsLopHP = new List<AD_QLLHP_DSLopHocPhan>();
            dsLopHP = db.AD_QLLHP_DSLopHocPhan.SqlQuery("select * from AD_QLLHP_DSLopHocPhan").ToList();

            dgvDSLopHocPhan.DataSource = dsLopHP;

            lbSuaSiSo.Text = lbThemSiSo.Text = "0";



        }



        string TenHP, TenHocKi, TenPhongHoc;
        int maHP, maHK, maPH;

        private void cbThemHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemHocPhan.SelectedIndex;
            maHP = dsHocPhan[index].MaHocPhan;
            TenHP = dsHocPhan[index].TenHocPhan;
            ChangeNameClass(index, true);

        }

        private void cbSuaHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSuaHocPhan.SelectedIndex;
            TenHP = dsHocPhan[index].TenHocPhan;
            maHP = dsHocPhan[index].MaHocPhan;
            ChangeNameClass(index, false);
        }


        void ChangeNameClass(int index, bool isAdd)
        {
            string tenlhp = "Lớp "
                + TenHP
                + " - "
                + TenHocKi
                + " - "
                + TenPhongHoc;
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
            maHK = dsHocKy[index].MaHocKy;
            TenHocKi = dsHocKy[index].TenHocKy;
            ChangeNameClass(index, false);
        }

        private void cbThemHKi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemHKi.SelectedIndex;
            maHK = dsHocKy[index].MaHocKy;
            TenHocKi = dsHocKy[index].TenHocKy;
            ChangeNameClass(index, true);
        }

        private void cbThemPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemPhongHoc.SelectedIndex;
            maPH = dsPhongHoc[index].MaPhongHoc;
            TenPhongHoc = dsPhongHoc[index].TenPhongHoc;
            ChangeNameClass(index, true);
        }

        private void cbSuaPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSuaPhongHoc.SelectedIndex;
            maPH = dsPhongHoc[index].MaPhongHoc;
            TenPhongHoc = dsPhongHoc[index].TenPhongHoc;
            ChangeNameClass(index, false);
        }


        int TongSiSo;

        void LoadTongSiSo()
        {
            TongSiSo = 0;
            foreach (var item in ds_grid_LopCN_current)
            {
                TongSiSo += (int)item.SoHocVien;

            }
            lbThemSiSo.Text = TongSiSo.ToString();
            lbSuaSiSo.Text = TongSiSo.ToString();
        }

        List<AD_QLLHP_SuaLopCN> ds_grid_LopCN_current = new List<AD_QLLHP_SuaLopCN>();
        List<AD_QLLHP_SuaLopCN> ds_load_LopCN_fromDB = new List<AD_QLLHP_SuaLopCN>();
        private void btnthemAddLopCN_Click(object sender, EventArgs e)
        {
            LopChuyenNganh templcn = dsLopCN[cbThemLopCN.SelectedIndex];
            Add_LopCN_toGrid(templcn);
        }

        int SuaMaLopHPCurr;
        private void dgvDSLopHocPhan_View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            xtraTabPage2.Show();
            int index = e.RowHandle;
            AD_QLLHP_DSLopHocPhan selectedItem = dsLopHP[index];

            txtSuaTenLopHP.Text = selectedItem.TenLopHocPhan;
            cbSuaHocKi.SelectedValue = selectedItem.MaHocKy;
            cbSuaGV.SelectedValue = selectedItem.MaGiangVien;
            cbSuaPhongHoc.SelectedValue = selectedItem.MaPhongHoc;
            cbSuaHocPhan.SelectedValue = selectedItem.MaHocPhan;
            dateSuaNgayThi.DateTime = (DateTime)selectedItem.NgayThi;

            SuaMaLopHPCurr = selectedItem.MaLopHocPhan;

            ds_load_LopCN_fromDB = db.AD_QLLHP_SuaLopCN.Where(m => m.MaLopHocPhan == selectedItem.MaLopHocPhan).ToList();
            ds_grid_LopCN_current = ds_load_LopCN_fromDB.Select(i => new AD_QLLHP_SuaLopCN() {
                MaLopChuyenNganh = i.MaLopChuyenNganh,
                MaLopHocPhan = i.MaLopHocPhan,
                SoHocVien = i.SoHocVien,
                TenLopChuyenNganh = i.TenLopChuyenNganh

            }).ToList();

            //lấy ra các lớp chuyên ngành học cùng lớp học phần
            //tempdsLopCN = db.LopHocPhans.Where(m => m.MaLopHocPhan == selectedItem.MaLopHocPhan).SelectMany(c => c.LopChuyenNganhs).ToList();


            gridControl1.DataSource = null;
            gridControl1.DataSource = ds_load_LopCN_fromDB;
            LoadTongSiSo();

        }

        private void btnSuaDelAll_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            //if (ds_grid_LopCN_current.Count > 0) ds_grid_LopCN_current.Clear();
            lbSuaSiSo.Text  = "0";
        }
        private void btnLuuThayDoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LopHocPhan thisLHP = new LopHocPhan();
                
                #region xóa trên bảng lớp cn - lớp hp

                List<AD_QLLHP_SuaLopCN> dsHuyLopCN = new List<AD_QLLHP_SuaLopCN>();
                foreach(var item in ds_load_LopCN_fromDB)
                {
                    var test = ds_grid_LopCN_current.Where(m => m.MaLopChuyenNganh == item.MaLopChuyenNganh).FirstOrDefault();

                    if (test == null) dsHuyLopCN.Add(item);
                }


                using (var context = new QLDHV_model())
                {
                    thisLHP = context.LopHocPhans.Where(m => m.MaLopHocPhan == SuaMaLopHPCurr).FirstOrDefault();

                    foreach (var item in dsHuyLopCN)
                    {
                        context.LopChuyenNganhs.Where(m => m.MaLopChuyenNganh == item.MaLopChuyenNganh).FirstOrDefault().LopHocPhans.Remove(thisLHP);
                        context.SaveChanges();

                    }
                }
                #endregion


                #region sửa thông tin lớp học phần


                using (var context = new QLDHV_model())
                {
                    thisLHP = context.LopHocPhans.Where(m => m.MaLopHocPhan == SuaMaLopHPCurr).FirstOrDefault();

                    thisLHP.MaPhongHoc = (int)cbSuaPhongHoc.SelectedValue;
                    thisLHP.MaGiangVien = (int)cbSuaGV.SelectedValue;
                    thisLHP.NgayThi = dateSuaNgayThi.DateTime;
                    thisLHP.MaHocKy = (int)cbSuaHocKi.SelectedValue;
                    thisLHP.TenLopHocPhan = txtSuaTenLopHP.Text;
                    thisLHP.TongHV = int.Parse(lbSuaSiSo.Text);

                    context.SaveChanges();
                }
                #endregion


                using (var context = new QLDHV_model())
                {
                    dsLopHP = context.AD_QLLHP_DSLopHocPhan.ToList();
                }

                MessageBox.Show("Đã lưu thay đổi", "Thông báo");

                dgvDSLopHocPhan.DataSource = null;
                dgvDSLopHocPhan.DataSource = dsLopHP;

            }


        }
        private void btnSuaAddLopCN_Click(object sender, EventArgs e)
        {

            LopChuyenNganh templcn = dsLopCN[cbSuaLopCN.SelectedIndex];

            Add_LopCN_toGrid(templcn);
           
        }

        void Add_LopCN_toGrid(LopChuyenNganh templcn)
        {
            AD_QLLHP_SuaLopCN newitem = new AD_QLLHP_SuaLopCN();

            foreach (var item in ds_grid_LopCN_current)
            {
                if (item.MaLopChuyenNganh == templcn.MaLopChuyenNganh)
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

            ds_grid_LopCN_current.Add(newitem);

            LoadTongSiSo();

            gridControl1.DataSource = null;
            gridControl1.DataSource = ds_grid_LopCN_current;
        }


        private void btnThemDelAll_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            if(ds_grid_LopCN_current.Count >0) ds_grid_LopCN_current.Clear();
            lbThemSiSo.Text = "0";
        }

        int MaLopCN, MaGV;

        private void cbThemGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaGV = dsGiangVien[cbThemGV.SelectedIndex].MaGiangVien;

        }

        private void cbThemLopCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbThemLopCN.SelectedIndex;
            MaLopCN = dsLopCN[index].MaLopChuyenNganh;


        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.FocusedColumn == gridView1.Columns["fldXoa"])
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int index = e.RowHandle;
                    ds_grid_LopCN_current.RemoveAt(index);


                    MessageBox.Show("Xóa thành công");
                    gridControl1.DataSource = null;
                    gridControl1.DataSource = ds_grid_LopCN_current;
                    LoadTongSiSo();

                }
                return;
            }


        }








    }
}
