using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BStore.Controllers
{
    public class InfomationProductController : Controller
    {
        private readonly MyDbContext db;
        public InfomationProductController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string id)
        {
            ThucDonViewModel query = new ThucDonViewModel(db);
            var td = query.GetDataById(id);

            var thucDon = db.ThucDon.Find(Convert.ToInt32(id));
            if (thucDon.LuotXem == null)
            {
                thucDon.LuotXem = 1;
            }
            else
            {
                thucDon.LuotXem++;
            }

            db.Update(thucDon);
            db.SaveChanges();
            ViewBag.CungLoai = query.GetAllDataByCate(td.MaLoai.ToString()).Take(3);
            DanhGiaViewModel query_dg = new DanhGiaViewModel(db);
            ViewBag.ListDanhGia = query_dg.GetDanhGiaByProduct(id).OrderByDescending(x => x.MaDanhGia);
            ViewBag.ThucDon = td;
            return View();
        }
    }
}