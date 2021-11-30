namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDangKy")]
    public partial class PhieuDangKy
    {
        public int? MaBN { get; set; }

        public int? MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        public int? MaVX { get; set; }

        [Key]
        public int MaPhieuDangKy { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Vacxin Vacxin { get; set; }
    }
}
