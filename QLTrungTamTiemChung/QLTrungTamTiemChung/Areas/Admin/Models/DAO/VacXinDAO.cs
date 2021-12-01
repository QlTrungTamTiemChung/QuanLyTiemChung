using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;
using PagedList;

namespace QLTrungTamTiemChung.Areas.Admin.Models.DAO
{
    public class VacXinDAO
    {
        private QLTiemChungDBContext context = null;
        public VacXinDAO()
        {
            context = new QLTiemChungDBContext();
        }
        public IEnumerable<Vacxin> ListAll(String searchString, int page, int pageSize)
        {
            if (searchString != null)
            {
                List<Vacxin> listKQ = context.Vacxins.Where(n => n.TenVX.Contains(searchString)).ToList();
                return listKQ.OrderBy(x => x.MaVX).ToPagedList(page, pageSize);
            }
            return (context.Vacxins.OrderBy(x => x.MaVX).ToPagedList(page, pageSize));
        }
        public int Insert(Vacxin bs)
        {
            context.Vacxins.Add(bs);
            context.SaveChanges();
            return bs.MaVX;
        }
        public Vacxin GetById(int id)
        {
            return context.Vacxins.SingleOrDefault(x => x.MaVX == id);
        }
        public bool Update(Vacxin entity)
        {
            try
            {
                var bs = context.Vacxins.Find(entity.MaVX);
                bs.TenVX = entity.TenVX;
                bs.SoLuong = entity.SoLuong;
                bs.PhanLoai = entity.PhanLoai;
                bs.DonGiaNhap = entity.DonGiaNhap;
                bs.DonGiaBan = entity.DonGiaBan;
                bs.DonViTinh = entity.DonViTinh;
                bs.MaNCC = entity.MaNCC;

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
                var bs = context.Vacxins.Find(id);
                context.Vacxins.Remove(bs);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<NhaCungCap> NCCDropDownList()
        {
            return context.NhaCungCaps.ToList();
        }
    }
}