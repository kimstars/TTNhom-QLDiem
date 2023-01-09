namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_DSLopChuyenNganh_HV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLopChuyenNganh { get; set; }

        [StringLength(150)]
        public string TenLopChuyenNganh { get; set; }

        public int? TongHV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBoMon { get; set; }
    }
}
