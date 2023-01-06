namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuDiem")]
    public partial class ChiTietPhieuDiem
    {
        [Key]
        public int MaChiTietPhieuDiem { get; set; }

        public double? DiemCC { get; set; }

        public double? DiemTX { get; set; }

        public double? DiemThi { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public int MaHocVien { get; set; }

        public int MaPhieuDiem { get; set; }

        public virtual HocVien HocVien { get; set; }

        public virtual PhieuDiem PhieuDiem { get; set; }
    }
}
