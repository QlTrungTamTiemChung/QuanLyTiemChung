namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTKho")]
    public partial class CTKho
    {
        public int? MaKho { get; set; }

        public int? MaVX { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string LoaiVX { get; set; }

        [Key]
        public int MaCTKho { get; set; }

        public virtual Kho Kho { get; set; }

        public virtual Vacxin Vacxin { get; set; }
    }
}
