namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTDHV")]
    public partial class TTDHV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocVien { get; set; }

        [StringLength(70)]
        public string HoTenHV { get; set; }

        [StringLength(100)]
        public string TenHocPhan { get; set; }

        public double? DiemCC { get; set; }

        public double? DiemTX { get; set; }

        public double? DiemThi { get; set; }

        public double? DiemTK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(70)]
        public string HoTenGV { get; set; }

        [StringLength(20)]
        public string TenHocKy { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocKy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGiangVien { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocPhan { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLopHocPhan { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChiTietPhieuDiem { get; set; }

        [StringLength(150)]
        public string TenLopChuyenNganh { get; set; }
    }
}
