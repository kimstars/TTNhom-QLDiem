namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_LopChuyenNganh
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLopChuyenNganh { get; set; }

        [StringLength(150)]
        public string TenLopChuyenNganh { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBoMon { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TenBoMon { get; set; }

        [StringLength(50)]
        public string TenKhoa { get; set; }

        public int? TongHV { get; set; }

        [StringLength(100)]
        public string TenHocPhan { get; set; }

        [StringLength(100)]
        public string TenLopHocPhan { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGiangVien { get; set; }

        [StringLength(20)]
        public string TenHocKy { get; set; }
    }
}
