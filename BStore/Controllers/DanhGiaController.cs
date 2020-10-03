using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BStore.Controllers
{
    public class DanhGiaController : Controller
    {
        private readonly MyDbContext db;
        public DanhGiaController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult AddReview(string loiNX, string mTKhoan, string mThDon)
        {
            DanhGia dgianew = new DanhGia
            {
                MaTaiKhoan = Convert.ToInt32(mTKhoan),
                MaThucDon = Convert.ToInt32(mThDon),
                LoiNhanXet = loiNX,
                NgayDanhGia = DateTime.Now

            };
            db.DanhGia.Add(dgianew);
            db.SaveChanges();
            DanhGiaViewModel query_dg = new DanhGiaViewModel(db);
            ViewBag.s1 = loiNX;
            ViewBag.s2 = mTKhoan;
            ViewBag.s3 = mThDon;
            ViewBag.ListDanhGia = query_dg.GetDanhGiaByProduct(mThDon).OrderByDescending(x => x.MaDanhGia);
            return PartialView("_reviewresult", ViewBag.ListProduct);
        }
    }
}