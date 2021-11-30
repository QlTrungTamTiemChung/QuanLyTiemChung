namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuXuat")]
    public partial class CTPhieuXuat
    {
        public int? MaKho { get; set; }

        public int? MaPhieuXuat { get; set; }

        public int? MaVX { get; set; }

        public int? DonGia { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        [Key]
        public int MaCTPhieuXuat { get; set; }

        public virtual Kho Kho { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }
    }
}
