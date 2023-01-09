using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TTNhom_QLDiem.GUI
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }


        bool logout;
        public static int MaID;


        public MainForm(int maid, string accPer)
        {
            InitializeComponent();
            LoadByAccessPermission(accPer);
            logout = false;
            MaID = maid;
        }

        public MainForm(string accPer)
        {
            InitializeComponent();
            logout = false;
            LoadByAccessPermission(accPer);

        }




        //HocVien.QLyHV uc1 = new HocVien.QLyHV();
        HocVien.TTHocVien TTHV = new HocVien.TTHocVien();

        HocVien.HV_Diem uc11;
        HocVien.TTHocVien uc12;

        GiangVien.GV_NhapDiemCC_TX uc21;
        GiangVien.GV_NhapDiemThi uc22;
        GiangVien.XemDSHocVien uc23;
        GiangVien.TTGiangVien uc24;



        Admin.QuanLyHocVien uc31;
        Admin.QuanLyGiangVien uc32;
        Admin.QuanLyHocPhan uc33;
        Admin.QuanLyLopChuyenNganh uc34;
        Admin.QuanLyLopHocPhan uc35;

        Admin.ADGV_TraCuuDiemThi uc36;
        Admin.QuanLyTaiKhoan uc37;


        DoiMK ucDMK;

        public void LoadByAccessPermission(string accPer)
        {
            ucDMK = new DoiMK(accPer);

            switch (accPer)
            {

                case "hv":

                    this.Text = "Học viên";
                    AccordionControlElement it11 = new AccordionControlElement(ElementStyle.Item) { Text = "Xem điểm quá trình" };
                    AccordionControlElement it12 = new AccordionControlElement(ElementStyle.Item) { Text = "Xem thông tin cá nhân" };
                    AccordionControlElement it13 = new AccordionControlElement(ElementStyle.Item) { Text = "Đổi mật khẩu" };


                    accordionControl1.Elements.AddRange(new AccordionControlElement[] { it11, it12, it13 });
                    accordionControl1.AllowItemSelection = true;
                    accordionControl1.ExpandAll();


                    it11.Click += It11_Click;
                    it12.Click += It12_Click;
                    it13.Click += ItMK_Click;


                    uc11 = new HocVien.HV_Diem();
                    uc12 = new HocVien.TTHocVien();

                    uc11.Dock = DockStyle.Fill;
                    uc12.Dock = DockStyle.Fill;
                    ucDMK.Dock = DockStyle.Fill;


                    showUsercontrol.Controls.AddRange(new Control[] { uc11, uc12, ucDMK });
                    break;


                case "gv":
                    this.Text = "Giảng viên";
                    AccordionControlElement it21 = new AccordionControlElement(ElementStyle.Item) { Text = "Nhập điểm CC-TX" };
                    AccordionControlElement it22 = new AccordionControlElement(ElementStyle.Item) { Text = "Nhập điểm thi" };
                    AccordionControlElement it23 = new AccordionControlElement(ElementStyle.Item) { Text = "Danh sách học viên" };
                    AccordionControlElement it24 = new AccordionControlElement(ElementStyle.Item) { Text = "Thông tin cá nhân" };
                    AccordionControlElement it25 = new AccordionControlElement(ElementStyle.Item) { Text = "Tra Cứu Điểm HV" };
                    AccordionControlElement it26 = new AccordionControlElement(ElementStyle.Item) { Text = "Đổi mật khẩu" };


                    accordionControl1.Elements.AddRange(new AccordionControlElement[] { it21, it22, it23, it24, it25, it26 });
                    accordionControl1.AllowItemSelection = true;
                    accordionControl1.ExpandAll();




                    it21.Click += It21_Click;
                    it22.Click += It22_Click;
                    it23.Click += It23_Click;
                    it24.Click += It24_Click;
                    it25.Click += It25_Click;
                    it26.Click += ItMK_Click;

                    uc21 = new GiangVien.GV_NhapDiemCC_TX();
                    uc22 = new GiangVien.GV_NhapDiemThi();
                    uc23 = new GiangVien.XemDSHocVien();
                    uc24 = new GiangVien.TTGiangVien();
                    uc36 = new Admin.ADGV_TraCuuDiemThi();


                    uc21.Dock = DockStyle.Fill;
                    uc22.Dock = DockStyle.Fill;
                    uc24.Dock = DockStyle.Fill;
                    uc36.Dock = DockStyle.Fill;
                    ucDMK.Dock = DockStyle.Fill;

                    showUsercontrol.Controls.AddRange(new Control[] { uc21, uc22,uc23, uc24, uc36, ucDMK });

                    break;

                case "admin":

                    this.Text = "Quản trị viên";
                    AccordionControlElement it31 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý học viên" };
                    AccordionControlElement it36 = new AccordionControlElement(ElementStyle.Item) { Text = "Tra Cứu Điểm HV" };
                    AccordionControlElement it32 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý giảng viên" };
                    AccordionControlElement it33 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý học phần" };
                    AccordionControlElement it34 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý lớp chuyên ngành" };
                    AccordionControlElement it35 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý lớp học phần" };
                    AccordionControlElement it38 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý tài khoản" };
                    AccordionControlElement it37 = new AccordionControlElement(ElementStyle.Item) { Text = "Đổi mật khẩu" };


                    accordionControl1.Elements.AddRange(new AccordionControlElement[] { it31, it36, it32, it33, it35, it38, it37 });
                    accordionControl1.AllowItemSelection = true;
                    accordionControl1.ExpandAll();


                    it31.Click += It31_Click;
                    it32.Click += It32_Click;
                    it33.Click += It33_Click;
                    it34.Click += It34_Click;
                    it35.Click += It35_Click;
                    it36.Click += It25_Click;
                    it37.Click += ItMK_Click;
                    it38.Click += It38_Click;

                    uc36 = new Admin.ADGV_TraCuuDiemThi();
                    uc31 = new Admin.QuanLyHocVien();
                    uc32 = new Admin.QuanLyGiangVien();
                    uc33 = new Admin.QuanLyHocPhan();
                    uc34 = new Admin.QuanLyLopChuyenNganh();
                    uc35 = new Admin.QuanLyLopHocPhan();
                    uc37 = new Admin.QuanLyTaiKhoan();

                    uc31.Dock = DockStyle.Fill;
                    uc32.Dock = DockStyle.Fill;
                    uc33.Dock = DockStyle.Fill;
                    uc34.Dock = DockStyle.Fill;
                    uc35.Dock = DockStyle.Fill;
                    uc36.Dock = DockStyle.Fill;
                    ucDMK.Dock = DockStyle.Fill;
                    uc37.Dock = DockStyle.Fill;
                    

                    showUsercontrol.Controls.AddRange(new Control[] { uc31, uc32, uc33, uc34, uc35, uc36, uc37, ucDMK });

                    break;

                default:
                    break;

            }



        }

        private void It38_Click(object sender, EventArgs e)
        {
            uc37.BringToFront();
        }

        private void ItMK_Click(object sender, EventArgs e)
        {
            ucDMK.BringToFront();
        }

        private void It23_Click(object sender, EventArgs e)
        {
            uc23.BringToFront();
        }

        private void It22_Click(object sender, EventArgs e)
        {
            uc22.BringToFront();

        }

        private void It21_Click(object sender, EventArgs e)
        {
            uc21.BringToFront();
        }

        private void It35_Click(object sender, EventArgs e)
        {
            uc35.BringToFront();

        }

        private void It34_Click(object sender, EventArgs e)
        {
            uc34.BringToFront();

        }

        private void It33_Click(object sender, EventArgs e)
        {
            uc33.BringToFront();

        }

        private void It32_Click(object sender, EventArgs e)
        {
            uc32.BringToFront();

        }

        private void It31_Click(object sender, EventArgs e)
        {
            uc31.BringToFront();

        }

        private void It12_Click(object sender, EventArgs e)
        {
            uc12.BringToFront();

        }

        private void It11_Click(object sender, EventArgs e)
        {
            uc11.BringToFront();

        }
        private void It24_Click(object sender, EventArgs e)
        {
            uc24.BringToFront();
        }
        private void It25_Click(object sender, EventArgs e)
        {
            uc36.BringToFront();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout = true;
            this.Close();
        }
    }
}
