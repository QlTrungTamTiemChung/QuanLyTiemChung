namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuKham")]
    public partial class PhieuKham
    {
        public int? MaBN { get; set; }

        public int? MaBS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKham { get; set; }

        [StringLength(20)]
        public string TrangThaiCoTheTiem { get; set; }

        [StringLength(20)]
        public string XacNhanDuocTiem { get; set; }

        [Key]
        public int MaPhieuKham { get; set; }

        public virtual BacSi BacSi { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
    }
}
