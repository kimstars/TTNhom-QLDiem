namespace TTNhom_QLDiem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

<<<<<<< HEAD:TTNhom-QLDiem/Model/TTDHV.cs
    [Table("TTDHV")]
    public partial class TTDHV
=======
    public partial class AD_LopChuyenNganh
>>>>>>> QLDIEM̀̀-51 Đã thêm được lớp chuyên ngành nhưng chưa select để sửa được:TTNhom-QLDiem/Model/AD_LopChuyenNganh.cs
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
<<<<<<< HEAD:TTNhom-QLDiem/Model/TTDHV.cs
        public int MaHocVien { get; set; }

        [StringLength(70)]
        public string HoTenHV { get; set; }

        [StringLength(100)]
        public string TenHocPhan { get; set; }
=======
        public int MaLopChuyenNganh { get; set; }

        [StringLength(150)]
        public string TenLopChuyenNganh { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBoMon { get; set; }
>>>>>>> QLDIEM̀̀-51 Đã thêm được lớp chuyên ngành nhưng chưa select để sửa được:TTNhom-QLDiem/Model/AD_LopChuyenNganh.cs

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TenBoMon { get; set; }

        [StringLength(50)]
        public string TenKhoa { get; set; }

        [StringLength(70)]
        public string HoTenHV { get; set; }

<<<<<<< HEAD:TTNhom-QLDiem/Model/TTDHV.cs
        public double? DiemTK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(70)]
        public string HoTenGV { get; set; }

        [StringLength(20)]
        public string TenHocKy { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocKy { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGiangVien { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHocPhan { get; set; }
=======
        public int? MaLopTruong { get; set; }
>>>>>>> QLDIEM̀̀-51 Đã thêm được lớp chuyên ngành nhưng chưa select để sửa được:TTNhom-QLDiem/Model/AD_LopChuyenNganh.cs
    }
}
