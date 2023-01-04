namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocPhan")]
    public partial class HocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocPhan()
        {
            LopHocPhans = new HashSet<LopHocPhan>();
        }

        [Key]
        public int MaHocPhan { get; set; }

        [StringLength(100)]
        public string TenHocPhan { get; set; }

        public int? DonViHocTrinh { get; set; }

        public int? SoTiet { get; set; }

        public int? SoTC { get; set; }

        [StringLength(50)]
        public string HinhThucThi { get; set; }

        public int MaBoMon { get; set; }

        public virtual BoMon BoMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
