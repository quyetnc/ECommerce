using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BStore.Models;

namespace BStore.Controllers
{
    public class OrderManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public OrderManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: OrderManager
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.GioHang.Include(g => g.MaKhachHangNavigation);
            return View(await myDbContext.ToListAsync());
        }

        // GET: OrderManager/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var giohang = new OderViewModel();
            List<ChiTietGioHang> ctgiohang = _context.ChiTietGioHang.Where(p=>p.MaGioHang==id).ToList();
            foreach (var item in ctgiohang)
            {
                OrderDetailViewModel tmp = new OrderDetailViewModel();
                if (_context.ThucDon.Find(item.MaThucDon).KhuyenMai > 0)
                {
                    tmp.gia = _context.ThucDon.Find(item.MaThucDon).GiaKhuyenMai;
                }
                else {
                    tmp.gia = _context.ThucDon.Find(item.MaThucDon).Gia;
                }
                tmp.masp = item.MaThucDon;
                tmp.soluong = item.SoLuong;
                tmp.thanhtien = tmp.gia * tmp.soluong;
                tmp.tensp = _context.ThucDon.Find(item.MaThucDon).TenThucDon;
                tmp.id = item.MaCtgioHang;
                giohang.ctgiohangs.Add(tmp);
            }
            giohang.giohang = _context.GioHang.Find(id);
            if (giohang.giohang == null)
            {
                return NotFound();
            }

            return View(giohang);
        }
        public IActionResult ChangedStatus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            GioHang order = _context.GioHang.Find(id);
            order.TrangThai = 1;
            _context.Update(order);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioHang = await _context.GioHang.FindAsync(id);
            if (gioHang == null)
            {
                return NotFound();
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KhachHang, "MaKhachHang", "MaKhachHang", gioHang.MaKhachHang);
            return View(gioHang);
        }

        // POST: OrderManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaGioHang,MaKhachHang,TongCong,NgayDat,TrangThai,MaTaiKhoan")] GioHang gioHang)
        {
            if (id != gioHang.MaGioHang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gioHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GioHangExists(gioHang.MaGioHang))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KhachHang, "MaKhachHang", "MaKhachHang", gioHang.MaKhachHang);
            return View(gioHang);
        }

        // GET: OrderManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                ViewBag.StatusDelete = true;
                var gioHang = await _context.GioHang.FindAsync(id);
                _context.GioHang.Remove(gioHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
              
                List<ChiTietGioHang> ctgh = new List<ChiTietGioHang>();
                ctgh = _context.ChiTietGioHang.Where(p => p.MaGioHang == id).ToList();

                _context.ChiTietGioHang.RemoveRange(ctgh);
                _context.SaveChanges();


                //var gioHang = await _context.GioHang.FindAsync(id);
                //_context.GioHang.Remove(gioHang);
                //await _context.SaveChangesAsync();
                //ViewBag.StatusDelete = false;
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: OrderManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gioHang = await _context.GioHang.FindAsync(id);
            _context.GioHang.Remove(gioHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GioHangExists(int id)
        {
            return _context.GioHang.Any(e => e.MaGioHang == id);
        }
    }
}
