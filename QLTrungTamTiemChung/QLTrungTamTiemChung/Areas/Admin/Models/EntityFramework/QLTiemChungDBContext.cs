using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework
{
    public partial class QLTiemChungDBContext : DbContext
    {
        public QLTiemChungDBContext()
            : base("name=QLTiemChungDBContext")
        {
        }

        public virtual DbSet<BacSi> BacSis { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<CoSo> CoSoes { get; set; }
        public virtual DbSet<CTKho> CTKhoes { get; set; }
        public virtual DbSet<CTPhieuNhap> CTPhieuNhaps { get; set; }
        public virtual DbSet<CTPhieuXuat> CTPhieuXuats { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<LoaiNguoiDung> LoaiNguoiDungs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDangKy> PhieuDangKies { get; set; }
        public virtual DbSet<PhieuKham> PhieuKhams { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<Vacxin> Vacxins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BacSi>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuNhap>()
                .Property(e => e.SoLuong)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuNhap>()
                .Property(e => e.DonGia)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuXuat>()
                .Property(e => e.SoLuong)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsFixedLength();
        }
    }
}
