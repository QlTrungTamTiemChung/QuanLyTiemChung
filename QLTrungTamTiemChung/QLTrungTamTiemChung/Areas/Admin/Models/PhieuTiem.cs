namespace QLTrungTamTiemChung.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuTiem")]
    public partial class PhieuTiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuTiem()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuTiem { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTiem { get; set; }

        public int? ChiPhi { get; set; }

        [StringLength(50)]
        public string LieuLuong { get; set; }

        public int? MaVX { get; set; }

        public int? MaBN { get; set; }

        public int? MaBS { get; set; }

        public virtual BacSi BacSi { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual Vacxin Vacxin { get; set; }
    }
}
