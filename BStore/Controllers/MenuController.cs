using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BStore.Controllers
{
    public class MenuController : Controller
    {
        private readonly MyDbContext db;
        public MenuController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetAllData().Take(8);
            LoaiThucDonViewModel query_loaithucdon = new LoaiThucDonViewModel(db);
            ViewBag.ListCate = query_loaithucdon.GetLoaiThucDon();

            ThuongHieuViewModal query_thuonghieuthucdon = new ThuongHieuViewModal(db);
            ViewBag.ListBrand = query_thuonghieuthucdon.GetThuongHieuThucDon();

            NongDoViewModal query_nongdo = new NongDoViewModal(db);
            ViewBag.ListND = query_nongdo.GetNongDoThucDon();

            DungTichViewModal query_dungtich = new DungTichViewModal(db);
            ViewBag.ListDT = query_dungtich.GetDungTichThucDon();

            return View();
        }

        public IActionResult sortby(string value)
        {

            ThucDonViewModel dstd = new ThucDonViewModel(db);
            var td = dstd.GetAllData();

            if (value == ("Name"))
            {
                ViewBag.ListProduct = dstd.SortByName();
                return PartialView("_viewresultSortBy", ViewBag.ListProduct);
            }
            if (value == ("Price"))
            {
                ViewBag.ListProduct = td.OrderBy(p=>p.Gia);
                return PartialView("_viewresultSortBy", ViewBag.ListProduct);
            }
            ViewBag.ListProduct = td;
            return PartialView("_viewresultSortBy", ViewBag.ListProduct);
        }

        public IActionResult GetProductByPage(int page, int status)
        {
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            if (status == 1)
            {
                page = page + 1;
            }
            else
            {
                page = page - 1;
            }
            ViewBag.ListProduct = query_thucdon.GetDataByPage(page, 8);
            return PartialView("_resultCategory", ViewBag.ListProduct);
        }

        public IActionResult Search(string key)
        {
            //ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            //ViewBag.LoaiThucDon = query_thucdon.GetAllData().Where(p=>p.TenThucDon.Contains(key));

            var r = from td in db.ThucDon
                    join ltd in db.LoaiThucDon on td.MaLoai equals ltd.MaLoai
                    select new ThucDonViewModel()
                    {
                        MaThucDon = td.MaThucDon,
                        TenThucDon = td.TenThucDon,
                        HinhAnh = td.HinhAnh,
                        TenLoai = ltd.TenLoai,
                        MaLoai = td.MaLoai,
                        Gia = td.Gia,
                        KhuyenMai = td.KhuyenMai,
                        GetGiaKhuyenMai = td.GiaKhuyenMai,
                        MoTa = td.MoTa
                    };

            ViewBag.ListProduct = r.Where(p => p.TenThucDon.Contains(key)).ToList();
            return PartialView("_resultCategory", ViewBag.ListProduct);
        }

        public IActionResult getProductsByCate(string categoryID)
        {
            //return Content("Oke");
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetAllDataByCate(categoryID);

            return PartialView("_resultCategory", ViewBag.ListProduct);
        }

        public IActionResult getProductsByBrand(string brandsID)
        {
            //return Content("Oke");
            ViewBag.TMP = brandsID;
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetAllDataByBrand(brandsID);

            return PartialView("_resultCategory", ViewBag.ListProduct);
        }

        //public IActionResult getProductsByCateNavbar(string categoryID)
        //{
        //    ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
        //    ViewBag.ListProduct = query_thucdon.GetAllDataByCate(categoryID);
        //    return PartialView("_resultCategory", ViewBag.ListProduct);
        //}
    }
}