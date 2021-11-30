namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuNhap")]
    public partial class CTPhieuNhap
    {
        public int? MaKho { get; set; }

        public int? MaPhieuNhap { get; set; }

        public int? MaVX { get; set; }

        [StringLength(250)]
        public string SoLo { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [StringLength(10)]
        public string DonGia { get; set; }

        [Key]
        public int MaCTPhieuNhap { get; set; }

        public virtual Kho Kho { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
