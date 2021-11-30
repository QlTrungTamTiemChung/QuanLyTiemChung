using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTrungTamTiemChung.Areas.Admin.Models.DAO;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;

namespace QLTrungTamTiemChung.Areas.Admin.Controllers
{
    public class BacSiController : Controller
    {
        public ActionResult Index(String searchString, int page = 1, int pageSize = 10)
        {
            var BacSiDAO = new BacSiDAO();
            var BacSiList = BacSiDAO.ListAll(searchString, page, pageSize);
            ViewBag.searchString = searchString;
            return View(BacSiList);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BacSi BacSi)
        {
            if (ModelState.IsValid)
            {
                var dao = new BacSiDAO();
                int id = dao.Insert(BacSi);
                if (id > 0)
                {
                    TempData["thongbao"] = "Thêm mới bác sĩ thành công!";
                    return RedirectToAction("Index", "BacSi");
                }
                else
                {
                    TempData["thongbao"] = "Thêm bác sĩ thất bại";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new BacSiDAO();
            BacSi BacSi = dao.GetById(id);
            if (BacSi == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(BacSi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(BacSi BacSi)
        {
            //Thêm vào CSDL
            if (ModelState.IsValid)
            {
                var dao = new BacSiDAO();
                if (dao.Update(BacSi) == true)
                {
                    TempData["thongbao"] = "Chỉnh sửa thành công!";
                    return RedirectToAction("Index", "BacSi");
                }
                else
                {
                    TempData["thongbao"] = "Chỉnh sửa thất bại!!";
                }
            }
            return View(BacSi);
        }
        public ActionResult Delete(int id)
        {
            var dao = new BacSiDAO();
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