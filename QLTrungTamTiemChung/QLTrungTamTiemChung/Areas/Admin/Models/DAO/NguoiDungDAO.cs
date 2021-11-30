using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;
using PagedList;

namespace QLTrungTamTiemChung.Areas.Admin.Models.DAO
{
    public class NguoiDungDAO
    {
        private QLTiemChungDBContext context = null;
        public NguoiDungDAO()
        {
            context = new QLTiemChungDBContext();
        }
        public IEnumerable<NguoiDung> ListAll(String searchString, int page, int pageSize)
        {
            if (searchString != null)
            {
                List<NguoiDung> listKQ = context.NguoiDungs.Where(n => n.TenND.Contains(searchString)).ToList();
                return listKQ.OrderBy(x => x.MaND).ToPagedList(page, pageSize);
            }
            return (context.NguoiDungs.OrderBy(x => x.MaND).ToPagedList(page, pageSize));
        }
        public int Insert(NguoiDung user)
        {
            context.NguoiDungs.Add(user);
            context.SaveChanges();
            return user.MaND;
        }
        public NguoiDung GetById(int id)
        {
            return context.NguoiDungs.SingleOrDefault(x => x.MaND == id);
        }
        public bool Update(NguoiDung entity)
        {
            try
            {
                var user = context.NguoiDungs.Find(entity.MaND);
                user.TenND = entity.TenND;
                user.Email = entity.Email;
                user.MatKhau = entity.MatKhau;
                user.MaLoaiND = entity.MaLoaiND;

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
                var user = context.NguoiDungs.Find(id);
                context.NguoiDungs.Remove(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<LoaiNguoiDung> RoleDropDownList()
        {
            return context.LoaiNguoiDungs.ToList();
        }
    }
}