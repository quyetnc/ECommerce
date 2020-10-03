using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BStore.Models;

namespace BStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext db;
        public HomeController(MyDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            BannerViewModal bnQuangCao = new BannerViewModal(db);
            ViewBag.ListBanner = bnQuangCao.GetAllData().Take(3);
            

            ThucDonViewModel dsThucDon = new ThucDonViewModel(db);
            ViewBag.ListProduct = dsThucDon.GetAllData().Where(x => x.KhuyenMai == 0).Take(4);
            ViewBag.ListDiscount = dsThucDon.GetAllData().Where(x => x.KhuyenMai != 0).Take(4);
            ViewBag.ListProductHot = dsThucDon.GetAllData().OrderByDescending(p => p.LuotMua).Take(4);
            ViewBag.ListProductViews = dsThucDon.GetAllData().OrderByDescending(p => p.LuotXem).Take(4);
            ViewBag.ListProductFULL = dsThucDon.GetAllData();

            ThuongHieuViewModal dsThuongHieu = new ThuongHieuViewModal(db);
            ViewBag.ThuongHieu = dsThuongHieu.GetThuongHieuThucDon();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
