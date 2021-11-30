using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTrungTamTiemChung.Areas.Admin.Models.DAO;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;

namespace QLTrungTamTiemChung.Areas.Admin.Controllers
{
    public class NguoiDungController : Controller
    {
        public ActionResult Index(String searchString, int page = 1, int pageSize = 10)
        {
            var NguoiDungDAO = new NguoiDungDAO();
            var NguoiDungList = NguoiDungDAO.ListAll(searchString, page, pageSize);
            ViewBag.searchString = searchString;
            return View(NguoiDungList);
        }
        public void SetRoleDropDownList(int? id = null)
        {
            var userDAO = new NguoiDungDAO();
            ViewBag.DanhSachVaiTro = new SelectList(userDAO.RoleDropDownList(), "MaLoaiND", "TenLoaiND", id);
        }

        public ActionResult Create()
        {
            SetRoleDropDownList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NguoiDung NguoiDung)
        {
            if (ModelState.IsValid)
            {
                var dao = new NguoiDungDAO();
                int id = dao.Insert(NguoiDung);
                if (id > 0)
                {
                    TempData["thongbao"] = "Thêm mới thành công!";
                    return RedirectToAction("Index", "NguoiDung");
                }
                else
                {
                    TempData["thongbao"] = "Thêm mới thất bại";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new NguoiDungDAO();
            NguoiDung NguoiDung = dao.GetById(id);
            if (NguoiDung == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            SetRoleDropDownList(NguoiDung.MaND);
            return View(NguoiDung);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(NguoiDung NguoiDung)
        {
            //Thêm vào CSDL
            if (ModelState.IsValid)
            {
                var dao = new NguoiDungDAO();
                if (dao.Update(NguoiDung) == true)
                {
                    TempData["thongbao"] = "Chỉnh sửa thành công!";
                    return RedirectToAction("Index", "NguoiDung");
                }
                else
                {
                    TempData["thongbao"] = "Chỉnh sửa thất bại!!";
                }
            }
            return View(NguoiDung);
        }
        public ActionResult Delete(int id)
        {
            var dao = new NguoiDungDAO();
            if (dao.Delete(id) == true)
            {
                TempData["thongbao"] = "Xóa thành công!";
            }
            else
            {
                TempData["thongbao"] = "Xóa thất bại!!";
            }
            return RedirectToAction("Index");
        }
    }
}