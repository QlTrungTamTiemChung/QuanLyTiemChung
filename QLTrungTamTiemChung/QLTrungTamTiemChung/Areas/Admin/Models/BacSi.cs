namespace QLTrungTamTiemChung.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BacSi")]
    public partial class BacSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacSi()
        {
            PhieuTiems = new HashSet<PhieuTiem>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBS { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public int? Luong { get; set; }

        public string ChucVu { get; set; }

        public string PhongBan { get; set; }

        [StringLength(50)]
        public string NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        public string DiaChi { get; set; }

        [StringLength(50)]
        public string HamHoc { get; set; }

        public int? MaCoSo { get; set; }

        public int? MaND { get; set; }

        public virtual CoSo CoSo { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTiem> PhieuTiems { get; set; }
    }
}
