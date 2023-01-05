using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TTNhom_QLDiem.Model
{
    public partial class QLDHV_model : DbContext
    {
        public QLDHV_model()
            : base("name=QLDHV_model")
        {
        }

        public virtual DbSet<BoMon> BoMons { get; set; }
        public virtual DbSet<ChiTietPhieuDiem> ChiTietPhieuDiems { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<HocKi> HocKis { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<HocVien> HocViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LopChuyenNganh> LopChuyenNganhs { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public virtual DbSet<PhieuDiem> PhieuDiems { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoMon>()
                .HasMany(e => e.GiangViens)
                .WithRequired(e => e.BoMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoMon>()
                .HasMany(e => e.HocPhans)
                .WithRequired(e => e.BoMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BoMon>()
                .HasMany(e => e.LopChuyenNganhs)
                .WithRequired(e => e.BoMon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiangVien>()
                .HasMany(e => e.LopHocPhans)
                .WithRequired(e => e.GiangVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocKi>()
                .Property(e => e.TenHocKy)
                .IsUnicode(false);

            modelBuilder.Entity<HocKi>()
                .HasMany(e => e.LopHocPhans)
                .WithRequired(e => e.HocKi)
                .HasForeignKey(e => e.MaHocKi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocPhan>()
                .HasMany(e => e.LopHocPhans)
                .WithRequired(e => e.HocPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocVien>()
                .HasMany(e => e.ChiTietPhieuDiems)
                .WithRequired(e => e.HocVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LopChuyenNganh>()
                .HasMany(e => e.HocViens)
                .WithRequired(e => e.LopChuyenNganh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LopChuyenNganh>()
                .HasMany(e => e.LopHocPhans)
                .WithMany(e => e.LopChuyenNganhs)
                .Map(m => m.ToTable("LopHP_CN").MapLeftKey("MaLopChuyenNganh").MapRightKey("MaLopHocPhan"));

            modelBuilder.Entity<LopHocPhan>()
                .HasMany(e => e.PhieuDiems)
                .WithRequired(e => e.LopHocPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDiem>()
                .HasMany(e => e.ChiTietPhieuDiems)
                .WithRequired(e => e.PhieuDiem)
                .HasForeignKey(e => e.MaHocVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Quyen)
                .IsUnicode(false);
        }
    }
}