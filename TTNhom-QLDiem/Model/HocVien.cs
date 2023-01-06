namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocVien")]
    public partial class HocVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocVien()
        {
            ChiTietPhieuDiems = new HashSet<ChiTietPhieuDiem>();
        }

        [Key]
        public int MaHocVien { get; set; }

        [StringLength(70)]
        public string HoTenHV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        public int MaLopChuyenNganh { get; set; }

        [StringLength(200)]
        public string QueQuan { get; set; }

        public int? MaTK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuDiem> ChiTietPhieuDiems { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        public virtual LopChuyenNganh LopChuyenNganh { get; set; }
    }
}
