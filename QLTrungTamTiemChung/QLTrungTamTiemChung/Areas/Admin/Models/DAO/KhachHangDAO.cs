using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;
using PagedList;

namespace QLTrungTamTiemChung.Areas.Admin.Models.DAO
{
    public class KhachHangDAO
    {
        private QLTiemChungDBContext context = null;
        public KhachHangDAO()
        {
            context = new QLTiemChungDBContext();
        }
        public IEnumerable<BenhNhan> ListAll(String searchString, int page, int pageSize)
        {
            if (searchString != null)
            {
                List<BenhNhan> listKQ = context.BenhNhans.Where(n => n.HoTen.Contains(searchString)).ToList();
                return listKQ.OrderBy(x => x.MaBN).ToPagedList(page, pageSize);
            }
            return (context.BenhNhans.OrderBy(x => x.MaBN).ToPagedList(page, pageSize));
        }
        public int Insert(BenhNhan bs)
        {
            context.BenhNhans.Add(bs);
            context.SaveChanges();
            return bs.MaBN;
        }
        public BenhNhan GetById(int id)
        {
            return context.BenhNhans.SingleOrDefault(x => x.MaBN == id);
        }
        public bool Update(BenhNhan entity)
        {
            try
            {
                var khach = context.BenhNhans.Find(entity.MaBN);
                khach.HoTen = entity.HoTen;
                khach.DiaChi = entity.DiaChi;
                khach.SDT = entity.SDT;
                khach.ThanhNhan = entity.ThanhNhan;

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
                var bs = context.BenhNhans.Find(id);
                context.BenhNhans.Remove(bs);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}