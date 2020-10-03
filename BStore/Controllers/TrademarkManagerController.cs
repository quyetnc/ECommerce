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
    public class TrademarkManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public TrademarkManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: TrademarkManager
        public async Task<IActionResult> Index()
        {
            return View(await _context.ThuongHieu.ToListAsync());
        }

        // GET: TrademarkManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thuongHieu = await _context.ThuongHieu
                .FirstOrDefaultAsync(m => m.MaTH == id);
            if (thuongHieu == null)
            {
                return NotFound();
            }

            return View(thuongHieu);
        }

        // GET: TrademarkManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TrademarkManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ThuongHieu thuongHieu,IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                string s = "";
                if (Ffile != null)
                {
                    string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                    s = fileName;
                    thuongHieu.HinhAnh = s;
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "trademark", fileName);

                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        Ffile.CopyTo(file);
                    }
                }
                _context.Add(thuongHieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thuongHieu);
        }

        // GET: TrademarkManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thuongHieu = await _context.ThuongHieu.FindAsync(id);
            if (thuongHieu == null)
            {
                return NotFound();
            }
            return View(thuongHieu);
        }

        // POST: TrademarkManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,ThuongHieu thuongHieu,IFormFile Ffile)
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
                        thuongHieu.HinhAnh = s;
                        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "trademark", fileName);

                        using (var file = new FileStream(fullPath, FileMode.Create))
                        {
                            Ffile.CopyTo(file);
                        }
                    }
                    thuongHieu.MaTH = id;
                    _context.Update(thuongHieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThuongHieuExists(thuongHieu.MaTH))
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
            return View(thuongHieu);
        }

        // GET: TrademarkManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thuongHieu = await _context.ThuongHieu.FindAsync(id);
            _context.ThuongHieu.Remove(thuongHieu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: TrademarkManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thuongHieu = await _context.ThuongHieu.FindAsync(id);
            _context.ThuongHieu.Remove(thuongHieu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThuongHieuExists(int id)
        {
            return _context.ThuongHieu.Any(e => e.MaTH == id);
        }
    }
}
