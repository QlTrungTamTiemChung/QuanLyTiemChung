using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;
using PagedList;

namespace QLTrungTamTiemChung.Areas.Admin.Models.DAO
{
    public class NhaCungCapDAO
    {
        private QLTiemChungDBContext context = null;
        public NhaCungCapDAO()
        {
            context = new QLTiemChungDBContext();
        }
        public IEnumerable<NhaCungCap> ListAll(String searchString, int page, int pageSize)
        {
            if (searchString != null)
            {
                List<NhaCungCap> listKQ = context.NhaCungCaps.Where(n => n.TenNCC.Contains(searchString)).ToList();
                return listKQ.OrderBy(x => x.MaNCC).ToPagedList(page, pageSize);
            }
            return (context.NhaCungCaps.OrderBy(x => x.MaNCC).ToPagedList(page, pageSize));
        }
        public int Insert(NhaCungCap bs)
        {
            context.NhaCungCaps.Add(bs);
            context.SaveChanges();
            return bs.MaNCC;
        }
        public NhaCungCap GetById(int id)
        {
            return context.NhaCungCaps.SingleOrDefault(x => x.MaNCC == id);
        }
        public bool Update(NhaCungCap entity)
        {
            try
            {
                var bs = context.NhaCungCaps.Find(entity.MaNCC);
                bs.TenNCC = entity.TenNCC;
                bs.DiaChi = entity.DiaChi;
                bs.SDT = entity.SDT;

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
                var bs = context.NhaCungCaps.Find(id);
                context.NhaCungCaps.Remove(bs);
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