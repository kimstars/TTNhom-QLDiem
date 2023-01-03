
namespace TTNhom_QLDiem.GUI
{
    partial class formchung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formchung));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.doimk = new DevExpress.XtraBars.BarButtonItem();
            this.Themtk = new DevExpress.XtraBars.BarButtonItem();
            this.DSHV = new DevExpress.XtraBars.BarButtonItem();
            this.QuanLyGV = new DevExpress.XtraBars.BarButtonItem();
            this.HocPhan = new DevExpress.XtraBars.BarButtonItem();
            this.QuanLyLopHP = new DevExpress.XtraBars.BarButtonItem();
            this.NhapDlan1 = new DevExpress.XtraBars.BarButtonItem();
            this.DiemHocLai = new DevExpress.XtraBars.BarButtonItem();
            this.DiemThiLai = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QLyNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.HocVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GiangVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.QlyDiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelchung = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.dangxuat,
            this.doimk,
            this.Themtk,
            this.DSHV,
            this.QuanLyGV,
            this.HocPhan,
            this.QuanLyLopHP,
            this.NhapDlan1,
            this.DiemHocLai,
            this.DiemThiLai});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.QLyNghiepVu});
            this.ribbon.Size = new System.Drawing.Size(1375, 195);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // dangxuat
            // 
            this.dangxuat.Caption = "Đăng Xuất";
            this.dangxuat.Id = 2;
            this.dangxuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("dangxuat.ImageOptions.SvgImage")));
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dangxuat_ItemClick);
            // 
            // doimk
            // 
            this.doimk.Caption = "Đổi Mật Khẩu";
            this.doimk.Id = 3;
            this.doimk.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("doimk.ImageOptions.SvgImage")));
            this.doimk.Name = "doimk";
            this.doimk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.doimk_ItemClick);
            // 
            // Themtk
            // 
            this.Themtk.Caption = "Thêm Tài Khoản";
            this.Themtk.Id = 4;
            this.Themtk.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Themtk.ImageOptions.SvgImage")));
            this.Themtk.Name = "Themtk";
            // 
            // DSHV
            // 
            this.DSHV.Caption = "Quản Lý Học Viên";
            this.DSHV.Id = 5;
            this.DSHV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DSHV.ImageOptions.SvgImage")));
            this.DSHV.Name = "DSHV";
            // 
            // QuanLyGV
            // 
            this.QuanLyGV.Caption = "Quản Lý Giảng Viên";
            this.QuanLyGV.Id = 6;
            this.QuanLyGV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("QuanLyGV.ImageOptions.SvgImage")));
            this.QuanLyGV.Name = "QuanLyGV";
            // 
            // HocPhan
            // 
            this.HocPhan.Caption = "Quản Lý Học Phần";
            this.HocPhan.Id = 8;
            this.HocPhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("HocPhan.ImageOptions.SvgImage")));
            this.HocPhan.Name = "HocPhan";
            // 
            // QuanLyLopHP
            // 
            this.QuanLyLopHP.Caption = "Quản Lý Lớp Học Phần";
            this.QuanLyLopHP.Id = 9;
            this.QuanLyLopHP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("QuanLyLopHP.ImageOptions.SvgImage")));
            this.QuanLyLopHP.Name = "QuanLyLopHP";
            // 
            // NhapDlan1
            // 
            this.NhapDlan1.Caption = "Điểm Thi Lần 1";
            this.NhapDlan1.Id = 10;
            this.NhapDlan1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NhapDlan1.ImageOptions.SvgImage")));
            this.NhapDlan1.Name = "NhapDlan1";
            // 
            // DiemHocLai
            // 
            this.DiemHocLai.Caption = "Điểm Học Lại";
            this.DiemHocLai.Id = 11;
            this.DiemHocLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DiemHocLai.ImageOptions.SvgImage")));
            this.DiemHocLai.Name = "DiemHocLai";
            // 
            // DiemThiLai
            // 
            this.DiemThiLai.Caption = "Điểm Thi Lại";
            this.DiemThiLai.Id = 12;
            this.DiemThiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DiemThiLai.ImageOptions.SvgImage")));
            this.DiemThiLai.Name = "DiemThiLai";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.dangxuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.doimk);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.Themtk);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Phân Quyền";
            // 
            // QLyNghiepVu
            // 
            this.QLyNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.HocVien,
            this.GiangVien,
            this.ribbonPageGroup5,
            this.QlyDiem});
            this.QLyNghiepVu.Name = "QLyNghiepVu";
            this.QLyNghiepVu.Text = "Quản Lý Nghiệp Vụ";
            // 
            // HocVien
            // 
            this.HocVien.ItemLinks.Add(this.DSHV);
            this.HocVien.Name = "HocVien";
            this.HocVien.Text = "Học Viên";
            // 
            // GiangVien
            // 
            this.GiangVien.ItemLinks.Add(this.QuanLyGV);
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.Text = "Giảng Viên";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.HocPhan);
            this.ribbonPageGroup5.ItemLinks.Add(this.QuanLyLopHP);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Lớp và Học Phần";
            // 
            // QlyDiem
            // 
            this.QlyDiem.ItemLinks.Add(this.NhapDlan1);
            this.QlyDiem.ItemLinks.Add(this.DiemHocLai);
            this.QlyDiem.ItemLinks.Add(this.DiemThiLai);
            this.QlyDiem.Name = "QlyDiem";
            this.QlyDiem.Text = "Quản Lý Điểm";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 886);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1375, 30);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hệ Thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ Thống";
            // 
            // panelchung
            // 
            this.panelchung.Location = new System.Drawing.Point(0, 201);
            this.panelchung.Name = "panelchung";
            this.panelchung.Size = new System.Drawing.Size(1375, 679);
            this.panelchung.TabIndex = 3;
            // 
            // formchung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 916);
            this.Controls.Add(this.panelchung);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "formchung";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "formchung";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem dangxuat;
        private DevExpress.XtraBars.BarButtonItem doimk;
        private DevExpress.XtraBars.BarButtonItem Themtk;
        private DevExpress.XtraBars.BarButtonItem DSHV;
        private DevExpress.XtraBars.BarButtonItem QuanLyGV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage QLyNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup HocVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GiangVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem HocPhan;
        private DevExpress.XtraBars.BarButtonItem QuanLyLopHP;
        private DevExpress.XtraBars.BarButtonItem NhapDlan1;
        private DevExpress.XtraBars.BarButtonItem DiemHocLai;
        private DevExpress.XtraBars.BarButtonItem DiemThiLai;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup QlyDiem;
        private System.Windows.Forms.Panel panelchung;
    }
}