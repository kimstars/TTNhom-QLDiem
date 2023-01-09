namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimKiemHVTheoHKy")]
    public partial class TimKiemHVTheoHKy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocVien { get; set; }

        [StringLength(70)]
        public string HoTenHV { get; set; }

        [StringLength(150)]
        public string TenLopChuyenNganh { get; set; }

        public double? DiemCC { get; set; }

        public double? DiemTX { get; set; }

        public double? DiemThi { get; set; }

        public double? DiemTK { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }
    }
}
