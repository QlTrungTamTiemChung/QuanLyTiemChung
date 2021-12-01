using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTrungTamTiemChung.Areas.Admin.Models.DAO;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;

namespace QLTrungTamTiemChung.Areas.Admin.Controllers
{
    public class KhachHangController : Controller
    {
        public ActionResult Index(String searchString, int page = 1, int pageSize = 10)
        {
            var KhachHangDAO = new KhachHangDAO();
            var KhachHangList = KhachHangDAO.ListAll(searchString, page, pageSize);
            ViewBag.searchString = searchString;
            return View(KhachHangList);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BenhNhan KhachHang)
        {
            if (ModelState.IsValid)
            {
                var dao = new KhachHangDAO();
                int id = dao.Insert(KhachHang);
                if (id > 0)
                {
                    TempData["thongbao"] = "Thêm mới thành công!";
                    return RedirectToAction("Index", "KhachHang");
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
            var dao = new KhachHangDAO();
            BenhNhan KhachHang = dao.GetById(id);
            if (KhachHang == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(KhachHang);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(BenhNhan KhachHang)
        {
            //Thêm vào CSDL
            if (ModelState.IsValid)
            {
                var dao = new KhachHangDAO();
                if (dao.Update(KhachHang) == true)
                {
                    TempData["thongbao"] = "Chỉnh sửa thành công!";
                    return RedirectToAction("Index", "KhachHang");
                }
                else
                {
                    TempData["thongbao"] = "Chỉnh sửa thất bại!!";
                }
            }
            return View(KhachHang);
        }
        public ActionResult Delete(int id)
        {
            var dao = new KhachHangDAO();
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