using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BStore.Controllers
{
    public class DashBoardController : BaseController
    {
        private readonly MyDbContext db;
        public DashBoardController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            string day = DateTime.Now.ToString("yyyy-MM-dd"); ;
            var myDbContext = db.GioHang.Include(g => g.MaKhachHangNavigation);
            //string date = item.NgayDat.ToString();
            //date = date.Substring(0, 10);

            var dshd = myDbContext.Where(p => p.NgayDat.ToString().Substring(0, 10) == day);
            var dshdM = myDbContext.Where(p => p.NgayDat.Value.Month == Convert.ToInt32(DateTime.Now.Month));
            var dshdY = myDbContext.Where(p => p.NgayDat.Value.Year == Convert.ToInt32(DateTime.Now.Year));


            double totalDay = 0;
            double totalMonth = 0;
            double totalYear = 0;
            int count = 0;

            foreach (var item in dshdM)
            {
                totalYear += Convert.ToDouble(item.TongCong);
            }

            foreach (var item in dshdM)
            {
                totalMonth += Convert.ToDouble(item.TongCong);
            }

            foreach (var item in dshd)
            {
                totalDay += Convert.ToDouble(item.TongCong);
                if (item.TrangThai == 0)
                {
                    count++;
                }
            }
            ViewBag.TotalDay = totalDay;
            ViewBag.TotalMonth = totalMonth;
            ViewBag.TotalYear = totalYear;
            ViewBag.List = dshd;
            ViewBag.Count = count;

            var giohang = new OderViewModel();
            List<OrderDetailViewModel> listorder = new List<OrderDetailViewModel>();
            List<ChiTietGioHang> ctgiohang = db.ChiTietGioHang.ToList();
            foreach (var item in ctgiohang)
            {
                OrderDetailViewModel tmp = new OrderDetailViewModel();
                if (db.ThucDon.Find(item.MaThucDon).KhuyenMai > 0)
                {
                    tmp.gia = db.ThucDon.Find(item.MaThucDon).GiaKhuyenMai;
                }
                else
                {
                    tmp.gia = db.ThucDon.Find(item.MaThucDon).Gia;
                }
                tmp.masp = item.MaThucDon;
                tmp.soluong = item.SoLuong;
                tmp.thanhtien = tmp.gia * tmp.soluong;
                tmp.tensp = db.ThucDon.Find(item.MaThucDon).TenThucDon;
                tmp.id = item.MaCtgioHang;
                listorder.Add(tmp);
                //giohang.ctgiohangs.Add(tmp);
            }
            ThucDonViewModel dsThucDon = new ThucDonViewModel(db);
            //List<ThucDonViewModel> dsThucDon = new List<ThucDonViewModel>();
            var pro= dsThucDon.GetAllData().OrderByDescending(p => p.LuotMua).Take(4);
            
            ViewBag.ProductHot = dsThucDon.GetAllData().OrderByDescending(p => p.LuotXem).Take(3);
            ViewBag.ListProduct = listorder;
            return View();
        }

    }
}