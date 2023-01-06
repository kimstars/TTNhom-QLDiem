namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangVien")]
    public partial class GiangVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiangVien()
        {
            LopHocPhans = new HashSet<LopHocPhan>();
        }

        [Key]
        public int MaGiangVien { get; set; }

        [Required]
        [StringLength(70)]
        public string HoTenGV { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }
        [Required]
        [StringLength(70)]
        public string CapBac { get; set; }
        [Required]
        [StringLength(70)]
        public string ChucVu { get; set; }
      
        public DateTime NgaySinh { get; set; }
        public int MaBoMon { get; set; }

        public int? MaTK { get; set; }

        public virtual BoMon BoMon { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopHocPhan> LopHocPhans { get; set; }
    }
}
