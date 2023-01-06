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

        GiangVien.TTGiangVien TTGV = new GiangVien.TTGiangVien();
        public void LoadByAccessPermission(string accPer)
        {

            switch (accPer)
            {

                case "hv":

                    this.Text = "Học viên";
                    AccordionControlElement it11 = new AccordionControlElement(ElementStyle.Item) { Text = "Xem điểm quá trình" };
                    AccordionControlElement it12 = new AccordionControlElement(ElementStyle.Item) { Text = "Xem thông tin cá nhân"};
                

                    accordionControl1.Elements.AddRange(new AccordionControlElement[] { it11, it12 });
                    accordionControl1.AllowItemSelection = true;
                    accordionControl1.ExpandAll();




                    it11.Click += It11_Click;
                    it12.Click += It12_Click;


                    

                    //uc1.Dock = DockStyle.Fill;
                    //uc2.Dock = DockStyle.Fill;
                    

                    //showUsercontrol.Controls.AddRange(new Control[] { uc1 });
                    break;


                case "gv":
                    this.Text = "Giảng viên";
                    AccordionControlElement it21 = new AccordionControlElement(ElementStyle.Item) { Text = "Xem lịch thi" };
                    AccordionControlElement it22 = new AccordionControlElement(ElementStyle.Item) { Text = "Nhập điểm" };
                    AccordionControlElement it23 = new AccordionControlElement(ElementStyle.Item) { Text = "Danh sách lớp học" };
                    AccordionControlElement it24 = new AccordionControlElement(ElementStyle.Item) { Text = "Thông tin cá nhân" };


                    accordionControl1.Elements.AddRange(new AccordionControlElement[] { it21, it22,it23,it24 });
                    accordionControl1.AllowItemSelection = true;
                    accordionControl1.ExpandAll();




                    //it21.Click += It21_Click;
                    //it22.Click += It22_Click;
                    //it23.Click += It23_Click;
                    it24.Click += It24_Click;


                    //uc1.Dock = DockStyle.Fill;
                    //uc2.Dock = DockStyle.Fill;
                    TTGV.Dock = DockStyle.Fill;

                    showUsercontrol.Controls.AddRange(new Control[] { TTGV});

                    break;

                case "admin":

                    this.Text = "Quản trị viên";
                    AccordionControlElement it31 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý học viên" };
                    AccordionControlElement it32 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý giảng viên" };
                    AccordionControlElement it33 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý học phần" };
                    AccordionControlElement it34 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý lớp chuyên ngành" };
                    AccordionControlElement it35 = new AccordionControlElement(ElementStyle.Item) { Text = "Quản lý lớp học phần" };


                    accordionControl1.Elements.AddRange(new AccordionControlElement[] { it31, it32,it33,it35 });
                    accordionControl1.AllowItemSelection = true;
                    accordionControl1.ExpandAll();


                    //it1.Click += It1_Click;
                    //it2.Click += It2_Click;


                    //uc1.Dock = DockStyle.Fill;
                    //uc2.Dock = DockStyle.Fill;


                    //showUsercontrol.Controls.AddRange(new Control[] { uc1, uc2 });

                    break;

                default:
                    break;

            }



        }

        private void It12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void It11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void It24_Click(object sender, EventArgs e)
        {
            showUsercontrol.Controls.Clear();
            showUsercontrol.Controls.AddRange(new Control[] { TTGV });
            //throw new NotImplementedException();
        }
    }
}
