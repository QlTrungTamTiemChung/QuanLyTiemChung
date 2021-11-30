namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BacSi")]
    public partial class BacSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BacSi()
        {
            PhieuKhams = new HashSet<PhieuKham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Mã bác sĩ")]
        public int MaBS { get; set; }


        [StringLength(50)]
        [DisplayName("Tên bác sĩ")]
        [Required(ErrorMessage = "Không được để trống tên bác sĩ")]
        public string HoTen { get; set; }


        [DisplayName("Lương")]
        [Required(ErrorMessage = "Không được để trống lương")]
        public int Luong { get; set; }

        [StringLength(50)]
        [DisplayName("Chức vụ")]
        [Required(ErrorMessage = "Không được để trống chức vụ")]
        public string ChucVu { get; set; }


        [StringLength(50)]
        [DisplayName("Phòng ban")]
        [Required(ErrorMessage = "Không được để trống phòng ban")]
        public string PhongBan { get; set; }


        [StringLength(50)]
        [DisplayName("Ngày sinh")]
        [Required(ErrorMessage = "Không được để trống ngày sinh")]
        public string NgaySinh { get; set; }


        [StringLength(10)]
        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Không được để trống giới tính")]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Không được để trống số điện thoại")]
        public string SDT { get; set; }


        [StringLength(250)]
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Không được để trống địa chỉ")]
        public string DiaChi { get; set; }


        [StringLength(50)]
        [DisplayName("Học hàm")]
        [Required(ErrorMessage = "Không được để trống địa chỉ")]
        public string HamHoc { get; set; }


        [DisplayName("Mã cơ sở")]
        [Required(ErrorMessage = "Không được để trống mã cơ sở")]
        public int MaCoSo { get; set; }

       
        [DisplayName("Mã người dùng")]
        [Required(ErrorMessage = "Không được để trống mã người dùng")]
        public int MaND { get; set; }

        public virtual CoSo CoSo { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKham> PhieuKhams { get; set; }
    }
}
