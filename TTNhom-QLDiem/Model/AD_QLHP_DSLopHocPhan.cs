namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AD_QLHP_DSLopHocPhan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLopHocPhan { get; set; }

        [StringLength(50)]
        public string TenLopHocPhan { get; set; }

        [StringLength(20)]
        public string TenHocKy { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenPhongHoc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(70)]
        public string HoTenGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThi { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocKy { get; set; }

        public int? MaPhongHoc { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGiangVien { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocPhan { get; set; }

        public int? TongHV { get; set; }
    }
}
