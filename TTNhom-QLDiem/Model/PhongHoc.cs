namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongHoc")]
    public partial class PhongHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongHoc()
        {
            LopHocPhans = new HashSet<LopHocPhan>();
        }

        [Key]
        public int MaPhongHoc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenPhongHoc { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaDiem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
