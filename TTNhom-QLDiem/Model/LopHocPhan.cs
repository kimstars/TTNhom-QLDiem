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

        public int MaHocKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThi { get; set; }

        public int? MaPhongHoc { get; set; }

        [StringLength(50)]
        public string TenLopHocPhan { get; set; }

        public int? TongHV { get; set; }

        public virtual GiangVien GiangVien { get; set; }

        public virtual HocKy HocKy { get; set; }

        public virtual HocPhan HocPhan { get; set; }

        public virtual PhongHoc PhongHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDiem> PhieuDiems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopChuyenNganh> LopChuyenNganhs { get; set; }
    }
}
