using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;
using PagedList;

namespace QLTrungTamTiemChung.Areas.Admin.Models.DAO
{
    public class NhanVienDAO
    {
        private QLTiemChungDBContext context = null;
        public NhanVienDAO()
        {
            context = new QLTiemChungDBContext();
        }
        public IEnumerable<NhanVien> ListAll(String searchString, int page, int pageSize)
        {
            if (searchString != null)
            {
                List<NhanVien> listKQ = context.NhanViens.Where(n => n.HoTen.Contains(searchString)).ToList();
                return listKQ.OrderBy(x => x.MaNV).ToPagedList(page, pageSize);
            }
            return (context.NhanViens.OrderBy(x => x.MaNV).ToPagedList(page, pageSize));
        }
        public int Insert(NhanVien nv)
        {
            context.NhanViens.Add(nv);
            context.SaveChanges();
            return nv.MaNV;
        }
        public NhanVien GetById(int id)
        {
            return context.NhanViens.SingleOrDefault(x => x.MaNV == id);
        }
        public bool Update(NhanVien entity)
        {
            try
            {
                var nv = context.NhanViens.Find(entity.MaNV);
                nv.HoTen = entity.HoTen;
                nv.Luong = entity.Luong;
                nv.ChucVu = entity.ChucVu;
                nv.PhongBan = entity.PhongBan;
                nv.NgaySinh = entity.NgaySinh;
                nv.GioiTinh = entity.GioiTinh;
                nv.DiaChi = entity.DiaChi;
                nv.MaCoSo = entity.MaCoSo;
                nv.MaND = entity.MaND;

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var nv = context.NhanViens.Find(id);
                context.NhanViens.Remove(nv);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<NguoiDung> UserDropDownList()
        {
            return context.NguoiDungs.ToList();
        }

        public List<CoSo> CoSoDropDownList()
        {
            return context.CoSoes.ToList();
        }
    }
}