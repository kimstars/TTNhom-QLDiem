namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocKi")]
    public partial class HocKi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocKi()
        {
            LopHocPhans = new HashSet<LopHocPhan>();
        }

        [Key]
        public int MaHocKy { get; set; }

        [StringLength(20)]
        public string TenHocKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
