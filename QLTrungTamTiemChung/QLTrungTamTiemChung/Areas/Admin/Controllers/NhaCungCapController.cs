using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTrungTamTiemChung.Areas.Admin.Models.DAO;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;

namespace QLTrungTamTiemChung.Areas.Admin.Controllers
{
    public class NhaCungCapController : Controller
    {
        public ActionResult Index(String searchString, int page = 1, int pageSize = 10)
        {
            var NhaCungCapDAO = new NhaCungCapDAO();
            var NhaCungCapList = NhaCungCapDAO.ListAll(searchString, page, pageSize);
            ViewBag.searchString = searchString;
            return View(NhaCungCapList);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhaCungCap NhaCungCap)
        {
            if (ModelState.IsValid)
            {
                var dao = new NhaCungCapDAO();
                int id = dao.Insert(NhaCungCap);
                if (id > 0)
                {
                    TempData["thongbao"] = "Thêm mới thành công!";
                    return RedirectToAction("Index", "NhaCungCap");
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
            var dao = new NhaCungCapDAO();
            NhaCungCap NhaCungCap = dao.GetById(id);
            if (NhaCungCap == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(NhaCungCap);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(NhaCungCap NhaCungCap)
        {
            //Thêm vào CSDL
            if (ModelState.IsValid)
            {
                var dao = new NhaCungCapDAO();
                if (dao.Update(NhaCungCap) == true)
                {
                    TempData["thongbao"] = "Chỉnh sửa thành công!";
                    return RedirectToAction("Index", "NhaCungCap");
                }
                else
                {
                    TempData["thongbao"] = "Chỉnh sửa thất bại!!";
                }
            }
            return View(NhaCungCap);
        }
        public ActionResult Delete(int id)
        {
            var dao = new NhaCungCapDAO();
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