namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhNhan")]
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            PhieuKhams = new HashSet<PhieuKham>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaBN { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string ThanhNhan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKham> PhieuKhams { get; set; }
    }
}
