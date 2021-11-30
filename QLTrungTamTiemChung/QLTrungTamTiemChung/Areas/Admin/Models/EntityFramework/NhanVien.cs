namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuDangKies = new HashSet<PhieuDangKy>();
        }

        [Key]
        public int MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public string PhongBan { get; set; }

        public string ChucVu { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        public int? Luong { get; set; }

        [StringLength(50)]
        public string NgaySinh { get; set; }

        public string DiaChi { get; set; }

        public int? MaCoSo { get; set; }

        public int? MaND { get; set; }

        public virtual CoSo CoSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDangKy> PhieuDangKies { get; set; }
    }
}
