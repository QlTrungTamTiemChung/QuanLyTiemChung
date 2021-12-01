using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;
using PagedList;

namespace QLTrungTamTiemChung.Areas.Admin.Models.DAO
{
    public class BacSiDAO
    {
        private QLTiemChungDBContext context = null;
        public BacSiDAO()
        {
            context = new QLTiemChungDBContext();
        }
        public IEnumerable<BacSi> ListAll(String searchString, int page, int pageSize)
        {
            if (searchString != null)
            {
                List<BacSi> listKQ = context.BacSis.Where(n => n.HoTen.Contains(searchString)).ToList();
                return listKQ.OrderBy(x => x.MaBS).ToPagedList(page, pageSize);
            }
            return (context.BacSis.OrderBy(x => x.MaBS).ToPagedList(page, pageSize));
        }
        public int Insert(BacSi bs)
        {
            context.BacSis.Add(bs);
            context.SaveChanges();
            return bs.MaBS;
        }
        public BacSi GetById(int id)
        {
            return context.BacSis.SingleOrDefault(x => x.MaBS == id);
        }
        public bool Update(BacSi entity)
        {
            try
            {
                var bs = context.BacSis.Find(entity.MaBS);
                bs.HoTen = entity.HoTen;
                bs.Luong = entity.Luong;
                bs.ChucVu = entity.ChucVu;
                bs.PhongBan = entity.PhongBan;
                bs.NgaySinh = entity.NgaySinh;
                bs.GioiTinh = entity.GioiTinh;
                bs.SDT = entity.SDT;
                bs.DiaChi = entity.DiaChi;
                bs.HamHoc = entity.HamHoc;
                bs.MaCoSo = entity.MaCoSo;
                bs.MaND = entity.MaND;

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
                var bs = context.BacSis.Find(id);
                context.BacSis.Remove(bs);
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