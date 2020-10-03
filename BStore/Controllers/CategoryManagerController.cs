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
    public class CategoryManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public CategoryManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: CategoryManager
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiThucDon.ToListAsync());
        }

        // GET: CategoryManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiThucDon = await _context.LoaiThucDon
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            if (loaiThucDon == null)
            {
                return NotFound();
            }

            return View(loaiThucDon);
        }

        // GET: CategoryManager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoryManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoaiThucDon loaiThucDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiThucDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiThucDon);
        }

        // GET: CategoryManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiThucDon = await _context.LoaiThucDon.FindAsync(id);
            if (loaiThucDon == null)
            {
                return NotFound();
            }
            return View(loaiThucDon);
        }

        // POST: CategoryManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaLoai,TenLoai")] LoaiThucDon loaiThucDon)
        {
            if (id != loaiThucDon.MaLoai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiThucDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiThucDonExists(loaiThucDon.MaLoai))
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
            return View(loaiThucDon);
        }

        // GET: CategoryManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var loaiThucDon = await _context.LoaiThucDon.FindAsync(id);
            _context.LoaiThucDon.Remove(loaiThucDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: CategoryManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiThucDon = await _context.LoaiThucDon.FindAsync(id);
            _context.LoaiThucDon.Remove(loaiThucDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiThucDonExists(int id)
        {
            return _context.LoaiThucDon.Any(e => e.MaLoai == id);
        }
    }
}
