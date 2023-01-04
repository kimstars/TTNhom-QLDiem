namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDiem")]
    public partial class PhieuDiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDiem()
        {
            ChiTietPhieuDiems = new HashSet<ChiTietPhieuDiem>();
        }

        [Key]
        public int MaPhieuDiem { get; set; }

        public int MaLopHocPhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuDiem> ChiTietPhieuDiems { get; set; }

        public virtual LopHocPhan LopHocPhan { get; set; }
    }
}
