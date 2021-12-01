using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLTrungTamTiemChung.Areas.Admin.Models.DAO;
using QLTrungTamTiemChung.Areas.Admin.Models.EntityFramework;

namespace QLTrungTamTiemChung.Areas.Admin.Controllers
{
    public class NhanVienController : Controller
    {
        public ActionResult Index(String searchString, int page = 1, int pageSize = 10)
        {
            var NhanVienDAO = new NhanVienDAO();
            var NhanVienList = NhanVienDAO.ListAll(searchString, page, pageSize);
            ViewBag.searchString = searchString;
            return View(NhanVienList);
        }
        public void SetUserDropDownList(int? id = null)
        {
            var bsDAO = new NhanVienDAO();
            ViewBag.DanhSachNguoiDung = new SelectList(bsDAO.UserDropDownList(), "MaND", "Email", id);
        }

        public void SetCoSoDropDownList(int? id = null)
        {
            var bsDAO = new NhanVienDAO();
            ViewBag.DanhSachCoSo = new SelectList(bsDAO.CoSoDropDownList(), "MaCoSo", "TenCoSo", id);
        }

        public ActionResult Create()
        {
            SetUserDropDownList();
            SetCoSoDropDownList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NhanVien NhanVien)
        {
            if (ModelState.IsValid)
            {
                var dao = new NhanVienDAO();
                int id = dao.Insert(NhanVien);
                if (id > 0)
                {
                    TempData["thongbao"] = "Thêm mới thành công!";
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    TempData["thongbao"] = "Thêm mới thất bại";
                }
            }
            SetUserDropDownList();
            SetCoSoDropDownList();
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var dao = new NhanVienDAO();
            NhanVien NhanVien = dao.GetById(id);
            if (NhanVien == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            SetUserDropDownList(NhanVien.MaNV);
            SetCoSoDropDownList(NhanVien.MaCoSo);
            return View(NhanVien);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(NhanVien NhanVien)
        {
            //Thêm vào CSDL
            if (ModelState.IsValid)
            {
                var dao = new NhanVienDAO();
                if (dao.Update(NhanVien) == true)
                {
                    TempData["thongbao"] = "Chỉnh sửa thành công!";
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    TempData["thongbao"] = "Chỉnh sửa thất bại!!";
                }
            }
            SetUserDropDownList(NhanVien.MaNV);
            SetCoSoDropDownList(NhanVien.MaCoSo);
            return View(NhanVien);
        }
        public ActionResult Delete(int id)
        {
            var dao = new NhanVienDAO();
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