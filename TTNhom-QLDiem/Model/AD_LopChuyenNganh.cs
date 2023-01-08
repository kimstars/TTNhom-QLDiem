namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AD_LopChuyenNganh
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

        [StringLength(70)]
        public string HoTenHV { get; set; }

        public int? MaLopTruong { get; set; }
    }
}
