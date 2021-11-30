namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            BacSis = new HashSet<BacSi>();
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã người dùng")]
        public int MaND { get; set; }

        [StringLength(50)]
        [DisplayName("Tên người dùng")]
        [Required(ErrorMessage = "Không được để trống tên người dùng")]
        public string TenND { get; set; }

        [StringLength(100)]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Không được để trống email")]
        public string Email { get; set; }

        [StringLength(100)]
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Không được để trống mật khẩu")]
        public string MatKhau { get; set; }


        [DisplayName("Vai trò")]
        [Required(ErrorMessage = "Không được để trống vai trò")]
        public int MaLoaiND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BacSi> BacSis { get; set; }

        public virtual LoaiNguoiDung LoaiNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
