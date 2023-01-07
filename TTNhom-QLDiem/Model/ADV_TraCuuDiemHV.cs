namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADV_TraCuuDiemHV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocVien { get; set; }

        [StringLength(70)]
        public string HoTenHV { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(150)]
        public string TenLopChuyenNganh { get; set; }

        [StringLength(100)]
        public string TenHocPhan { get; set; }

        public double? DiemCC { get; set; }

        public double? DiemTX { get; set; }

        public double? DiemThi { get; set; }

        public double? DiemTK { get; set; }

        [StringLength(20)]
        public string TenHocKy { get; set; }
    }
}
