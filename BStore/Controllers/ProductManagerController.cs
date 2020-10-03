using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BStore.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BStore.Controllers
{
    public class ProductManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public ProductManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: ProductManager
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.ThucDon.Include(t => t.DungTichNavigation).Include(t => t.MaLoaiNavigation).Include(t => t.MaTHNavigation).Include(t => t.NongDoNavigation);
            return View(await myDbContext.ToListAsync());
        }

        // GET: ProductManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon
                .Include(t => t.DungTichNavigation)
                .Include(t => t.MaLoaiNavigation)
                .Include(t => t.MaTHNavigation)
                .Include(t => t.NongDoNavigation)
                .FirstOrDefaultAsync(m => m.MaThucDon == id);
            if (thucDon == null)
            {
                return NotFound();
            }

            return View(thucDon);
        }

        // GET: ProductManager/Create
        public IActionResult Create()
        {
            ViewData["MaDungTich"] = new SelectList(_context.DungTich, "MaDungTich", "DungTichValue");
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "TenLoai");
            ViewData["MaTH"] = new SelectList(_context.ThuongHieu, "MaTH", "TenTH");
            ViewData["MaNongDo"] = new SelectList(_context.NongDo, "MaNongDo", "NongDoValue");

            return View();
        }

        // POST: ProductManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ThucDon thucDon,IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                string s = "";
                if (Ffile != null)
                {
                    string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                    s = fileName;
                    thucDon.HinhAnh = s;
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "products", fileName);

                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        Ffile.CopyTo(file);
                    }
                }
                else
                {
                    thucDon.HinhAnh = "download.jpg";
                }
                _context.Add(thucDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaDungTich"] = new SelectList(_context.DungTich, "MaDungTich", "MaDungTich", thucDon.MaDungTich);
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "MaLoai", thucDon.MaLoai);
            ViewData["MaTH"] = new SelectList(_context.ThuongHieu, "MaTH", "MaTH", thucDon.MaTH);
            ViewData["MaNongDo"] = new SelectList(_context.NongDo, "MaNongDo", "MaNongDo", thucDon.MaNongDo);
            return View(thucDon);
        }

        // GET: ProductManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon.FindAsync(id);
            if (thucDon == null)
            {
                return NotFound();
            }
            ViewData["MaDungTich"] = new SelectList(_context.DungTich, "MaDungTich", "MaDungTich", thucDon.MaDungTich);
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "MaLoai", thucDon.MaLoai);
            ViewData["MaTH"] = new SelectList(_context.ThuongHieu, "MaTH", "MaTH", thucDon.MaTH);
            ViewData["MaNongDo"] = new SelectList(_context.NongDo, "MaNongDo", "MaNongDo", thucDon.MaNongDo);
            return View(thucDon);
        }

        // POST: ProductManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ThucDon thucDon,IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string s = "";
                    if (Ffile != null)
                    {
                        string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                        s = fileName;
                        thucDon.HinhAnh = s;
                        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "products", fileName);

                        using (var file = new FileStream(fullPath, FileMode.Create))
                        {
                            Ffile.CopyTo(file);
                        }
                    }
                    else
                    {
                        thucDon.HinhAnh = "download.jpg";
                    }
                    thucDon.MaThucDon = id;
                    _context.Update(thucDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThucDonExists(thucDon.MaThucDon))
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
            ViewData["MaDungTich"] = new SelectList(_context.DungTich, "MaDungTich", "MaDungTich", thucDon.MaDungTich);
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "MaLoai", thucDon.MaLoai);
            ViewData["MaTH"] = new SelectList(_context.ThuongHieu, "MaTH", "MaTH", thucDon.MaTH);
            ViewData["MaNongDo"] = new SelectList(_context.NongDo, "MaNongDo", "MaNongDo", thucDon.MaNongDo);
            return View(thucDon);
        }

        // GET: ProductManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon
                .Include(t => t.DungTichNavigation)
                .Include(t => t.MaLoaiNavigation)
                .Include(t => t.MaTHNavigation)
                .Include(t => t.NongDoNavigation)
                .FirstOrDefaultAsync(m => m.MaThucDon == id);
            if (thucDon == null)
            {
                return NotFound();
            }

            return View(thucDon);
        }

        // POST: ProductManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thucDon = await _context.ThucDon.FindAsync(id);
            _context.ThucDon.Remove(thucDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThucDonExists(int id)
        {
            return _context.ThucDon.Any(e => e.MaThucDon == id);
        }
    }
}
