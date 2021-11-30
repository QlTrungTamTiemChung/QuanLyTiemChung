namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vacxin")]
    public partial class Vacxin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vacxin()
        {
            CTKhoes = new HashSet<CTKho>();
            PhieuDangKies = new HashSet<PhieuDangKy>();
        }

        [Key]
        public int MaVX { get; set; }

        [StringLength(50)]
        public string TenVX { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string PhanLoai { get; set; }

        public int? DonGiaNhap { get; set; }

        public int? DonGiaBan { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public int? MaNCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKho> CTKhoes { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuDangKy> PhieuDangKies { get; set; }
    }
}
