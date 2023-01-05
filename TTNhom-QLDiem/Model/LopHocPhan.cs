namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHocPhan")]
    public partial class LopHocPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHocPhan()
        {
            PhieuDiems = new HashSet<PhieuDiem>();
            LopChuyenNganhs = new HashSet<LopChuyenNganh>();
        }

        [Key]
        public int MaLopHocPhan { get; set; }

        public int MaGiangVien { get; set; }

        public int MaHocPhan { get; set; }

        public int MaHocKi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThi { get; set; }

        [StringLength(20)]
        public string PhongHoc { get; set; }

        public virtual GiangVien GiangVien { get; set; }

        public virtual HocKi HocKi { get; set; }

        public virtual HocPhan HocPhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDiem> PhieuDiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopChuyenNganh> LopChuyenNganhs { get; set; }
    }
}