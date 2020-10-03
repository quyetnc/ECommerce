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
    public class CustomerManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public CustomerManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: CustomerManager
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.KhachHang.Include(k => k.MaTaiKhoanNavigation);
            return View(await myDbContext.ToListAsync());
        }

        // GET: CustomerManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang
                .Include(k => k.MaTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaKhachHang == id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // GET: CustomerManager/Create
        public IActionResult Create()
        {
            ViewData["MaTaiKhoan"] = new SelectList(_context.TaiKhoan, "MaTaiKhoan", "MaTaiKhoan");
            ViewData["MaTinhThanh"] = new SelectList(_context.TinhThanh, "MaTinhThanh", "MaTinhThanh");
            return View();
        }

        // POST: CustomerManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKhachHang,TenKhachHang,Email,DiaChi,SoDt,MaTaiKhoan,MaTinhThanh")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaTaiKhoan"] = new SelectList(_context.TaiKhoan, "MaTaiKhoan", "MaTaiKhoan", khachHang.MaTaiKhoan);
            ViewData["MaTinhThanh"] = new SelectList(_context.TinhThanh, "MaTinhThanh", "MaTinhThanh", khachHang.MaTinhThanh);
            return View(khachHang);
        }

        // GET: CustomerManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang.FindAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            ViewData["MaTaiKhoan"] = new SelectList(_context.TaiKhoan, "MaTaiKhoan", "MaTaiKhoan", khachHang.MaTaiKhoan);
            ViewData["MaTinhThanh"] = new SelectList(_context.TinhThanh, "MaTinhThanh", "MaTinhThanh", khachHang.MaTinhThanh);
            return View(khachHang);
        }

        // POST: CustomerManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaKhachHang,TenKhachHang,Email,DiaChi,SoDt,MaTaiKhoan,MaTinhThanh")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachHang.MaKhachHang))
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
            ViewData["MaTaiKhoan"] = new SelectList(_context.TaiKhoan, "MaTaiKhoan", "MaTaiKhoan", khachHang.MaTaiKhoan);
            ViewData["MaTinhThanh"] = new SelectList(_context.TinhThanh, "MaTinhThanh", "MaTinhThanh", khachHang.MaTinhThanh);
            return View(khachHang);
        }

        // GET: CustomerManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang
                .Include(k => k.MaTaiKhoanNavigation)
                .FirstOrDefaultAsync(m => m.MaKhachHang == id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // POST: CustomerManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khachHang = await _context.KhachHang.FindAsync(id);
            _context.KhachHang.Remove(khachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangExists(int id)
        {
            return _context.KhachHang.Any(e => e.MaKhachHang == id);
        }
    }
}
