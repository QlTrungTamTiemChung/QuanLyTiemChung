using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTrungTamTiemChung.Areas.Admin.Models.DAO;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;

namespace QLTrungTamTiemChung.Areas.Admin.Controllers
{
    public class VacXinController : Controller
    {
        public ActionResult Index(String searchString, int page = 1, int pageSize = 10)
        {
            var VacXinDAO = new VacXinDAO();
            var VacXinList = VacXinDAO.ListAll(searchString, page, pageSize);
            ViewBag.searchString = searchString;
            return View(VacXinList);
        }
        public void SetNCCDropDownList(int? id = null)
        {
            var bsDAO = new VacXinDAO();
            ViewBag.DanhSachNCC = new SelectList(bsDAO.NCCDropDownList(), "MaNCC", "TenNCC", id);
        }

        public ActionResult Create()
        {
            SetNCCDropDownList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vacxin VacXin)
        {
            if (ModelState.IsValid)
            {
                var dao = new VacXinDAO();
                int id = dao.Insert(VacXin);
                if (id > 0)
                {
                    TempData["thongbao"] = "Thêm mới thành công!";
                    return RedirectToAction("Index", "VacXin");
                }
                else
                {
                    TempData["thongbao"] = "Thêm mới thất bại";
                }
            }
            SetNCCDropDownList();
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new VacXinDAO();
            Vacxin VacXin = dao.GetById(id);
            if (VacXin == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            SetNCCDropDownList(VacXin.MaNCC);
            return View(VacXin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Vacxin VacXin)
        {
            //Thêm vào CSDL
            if (ModelState.IsValid)
            {
                var dao = new VacXinDAO();
                if (dao.Update(VacXin) == true)
                {
                    TempData["thongbao"] = "Chỉnh sửa thành công!";
                    return RedirectToAction("Index", "VacXin");
                }
                else
                {
                    TempData["thongbao"] = "Chỉnh sửa thất bại!!";
                }
            }
            SetNCCDropDownList(VacXin.MaNCC);
            return View(VacXin);
        }
        public ActionResult Delete(int id)
        {
            var dao = new VacXinDAO();
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