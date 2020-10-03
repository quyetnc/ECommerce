using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BStore.Controllers
{
    public class CartController : Controller
    {
        private readonly MyDbContext db;
        public CartController(MyDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            ViewBag.Cart = GetGioHang;
            ViewBag.Total = GetGioHang.Sum(x => x.SoLuong * x.GiaBan);
            return View();
        }
     public IActionResult History(int id)
        {
            var kq = (from gh in db.GioHang
                      join ctgh in db.ChiTietGioHang on gh.MaGioHang equals ctgh.MaGioHang
                      join td in db.ThucDon on ctgh.MaThucDon equals td.MaThucDon
                      select new OrderDetailViewModel
                      {
                          tensp = td.TenThucDon,
                          gia = td.GiaKhuyenMai,
                          soluong = ctgh.SoLuong,
                          ngaydat = gh.NgayDat,
                          thanhtien = gh.TongCong,
                          trangthai = gh.TrangThai,
                          matk = gh.MaTaiKhoan

                      }).Where(p => p.matk == id).ToList();

            ViewBag.ListOrder = kq;
            return View();

        }

        public IActionResult updateQuantity(int value, int id)
        {
            AddToCart(id);
            UpdateCart(id, value);

            ViewBag.Cart = GetGioHang;

            double gia = 0;
            int product_id = id;
            //lấy giỏ hàng đang có
            var gioHang = GetGioHang;
            //kiểm tra xem hàng đã có trong giỏ chưa
            //ThucDon item = db.ThucDon.SingleOrDefault(p => p.MaThucDon == product_id);
            ////nếu có
            //try
            //{
            //    gia = item.Gia;
            //}
            //catch(Exception e)
            //{

            //}
            


            var kq = GetGioHang.Sum(x => x.SoLuong * x.GiaBan);
            return Content(kq.ToString());
        }

        public List<CartItem> GetGioHang
        {
            get
            {
                List<CartItem> myCart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
                if (myCart == default(List<CartItem>))
                {
                    myCart = new List<CartItem>();
                }
                return myCart;
            }
        }

        public IActionResult AddToCart(int id)
        {
            int product_id = id;
            //lấy giỏ hàng đang có
            var gioHang = GetGioHang;
            //kiểm tra xem hàng đã có trong giỏ chưa
            CartItem item = gioHang.SingleOrDefault(p => p.MaThucDon == product_id);
            //nếu có
            if (item != null)
            {
                item.SoLuong++;//tăng số lượng
            }
            else
            {
                ThucDon hh = db.ThucDon.SingleOrDefault(p => p.MaThucDon == product_id);
                item = new CartItem
                {
                    MaThucDon = product_id,
                    SoLuong = 1,
                    TenThucDon = hh.TenThucDon,
                    HinhAnh = hh.HinhAnh,
                    GiaBan = hh.GiaKhuyenMai
                };
                gioHang.Add(item);
            }
            //lưu session
            SessionHelper.Set(HttpContext.Session, "cart", gioHang);
            var response = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            //chuyển tới trang giỏ hàng để xem
            return Json(response);
        }
        public IActionResult UpdateCart(int id, int quantity)
        {
            var gioHang = GetGioHang;
            CartItem item = gioHang.SingleOrDefault(p => p.MaThucDon == id);
            item.SoLuong = quantity;
            SessionHelper.Set(HttpContext.Session, "cart", gioHang);
            var response = item.SoLuong * item.GiaBan;
            return Json(response);
        }

        public IActionResult RemoveItem(int id)
        {
            var gioHang = GetGioHang;
            CartItem item = gioHang.SingleOrDefault(p => p.MaThucDon == id);
            gioHang.Remove(item);
            SessionHelper.Set(HttpContext.Session, "cart", gioHang);
            var response = true;
            return RedirectToAction("Index", "Cart");
        }
        public IActionResult GetTotal()
        {
            var gioHang = GetGioHang.Sum(x => x.SoLuong * x.GiaBan);
            return Json(gioHang);
        }

        public IActionResult LoadCartHidden()
        {
            var response = GetGioHang;
            return Json(response);
        }
    }
}