namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AD_QLLHP_DSHocPhan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocPhan { get; set; }

        [StringLength(100)]
        public string TenHocPhan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenBoMon { get; set; }

        public int? DonViHocTrinh { get; set; }

        public int? SoTiet { get; set; }

        public int? SoTC { get; set; }

        [StringLength(50)]
        public string HinhThucThi { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBoMon { get; set; }
    }
}
