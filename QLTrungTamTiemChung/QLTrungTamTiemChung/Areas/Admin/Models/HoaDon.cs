namespace QLTrungTamTiemChung.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        public int? ChiPhiKham { get; set; }

        public int? ChiPhiTiem { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        public int? MaNV { get; set; }

        public int? MaPhieuTiem { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhieuTiem PhieuTiem { get; set; }
    }
}
