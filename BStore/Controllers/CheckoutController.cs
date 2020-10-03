using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BStore.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly MyDbContext db;
        public CheckoutController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.City = (from tt in db.TinhThanh select tt);
            var gioHang = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.Cart = gioHang;
            if (gioHang != null)
            {
                ViewBag.Total = gioHang.Sum(x => x.SoLuong * x.GiaBan);
            }
            else
            {
                ViewBag.Total = 0;
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(string account_id, string fullname, string address, string email, string tel, string city)
        {
            var gioHang = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            if (gioHang == null || gioHang.Count() == 0)
            {
                ViewBag.Success = false;
            }
            else
            {
                KhachHang newKh = new KhachHang();


                if (account_id != null)
                {
                    newKh.TenKhachHang = fullname;
                    newKh.DiaChi = address;
                    newKh.Email = email;
                    newKh.SoDt = tel;
                    newKh.MaTaiKhoan = Convert.ToInt32(account_id);
                    newKh.MaTinhThanh = int.Parse(city);
                    db.KhachHang.Add(newKh);
                    db.SaveChanges();
                }
                else
                {
                    newKh.TenKhachHang = fullname;
                    newKh.DiaChi = address;
                    newKh.Email = email;
                    newKh.SoDt = tel;
                    newKh.MaTinhThanh = int.Parse(city);
                    db.KhachHang.Add(newKh);
                    db.SaveChanges();
                }
                
               
                var totalMoneyy = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart").Sum(p=>p.SoLuong*p.GiaBan);
                
                GioHang newOrder = new GioHang
                {
                    MaKhachHang = newKh.MaKhachHang,
                    NgayDat = DateTime.Now,
                    TrangThai = 0,
                    TongCong = totalMoneyy
                };
                if (account_id != null)
                {
                    newOrder.MaTaiKhoan = int.Parse(account_id);
                }
                db.GioHang.Add(newOrder);
                db.SaveChanges();
                var cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
                foreach (var item in cart)
                {
                    ChiTietGioHang newDetail = new ChiTietGioHang
                    {
                        MaGioHang = newOrder.MaGioHang,
                        MaThucDon = item.MaThucDon,
                        SoLuong = item.SoLuong
                    };
                    var thucDon = db.ThucDon.Find(Convert.ToInt32(item.MaThucDon));
                    if (thucDon.LuotMua == null)
                    {
                        thucDon.LuotMua = item.SoLuong;
                    }
                    else
                    {
                        thucDon.LuotMua += item.SoLuong;
                    }

                    db.Update(thucDon);
                    db.SaveChanges();
                    db.ChiTietGioHang.Add(newDetail);
                    db.SaveChanges();
                }
                HttpContext.Session.Remove("cart");
                ViewBag.Success = true;
            }
            ViewBag.City = (from tt in db.TinhThanh select tt);
            gioHang = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.Cart = gioHang;
            if (gioHang != null)
            {
                ViewBag.Total = gioHang.Sum(x => x.SoLuong * x.GiaBan);
            }
            else
            {
                ViewBag.Total = 0;
            }
            return View("Index");
        }
    }
}