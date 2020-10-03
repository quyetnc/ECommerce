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
    public class UserManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public UserManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: UserManager
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.TaiKhoan.Include(t => t.MaPhanQuyenNavigation);
            ViewBag.listuser = myDbContext;
            return View(await myDbContext.ToListAsync());
        }

        // GET: UserManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .Include(t => t.MaPhanQuyenNavigation)
                .FirstOrDefaultAsync(m => m.MaTaiKhoan == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }
            if (taiKhoan.MaPhanQuyen == "1")
            {
                taiKhoan.MaPhanQuyen = "Admin";
            }
            else
            {
                taiKhoan.MaPhanQuyen = "User";
            }
            return View(taiKhoan);
        }

        // GET: UserManager/Create
        public IActionResult Create()
        {
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen");
            return View();
        }

        // POST: UserManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaiKhoan taiKhoan, IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                string s = "";
                if (Ffile != null)
                {
                    string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                    s = fileName;
                    taiKhoan.AnhDaiDien = s;
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "avatar", fileName);

                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        Ffile.CopyTo(file);
                    }
                }
                else
                {
                    taiKhoan.AnhDaiDien = "no-avatar.jpg";
                }
                
                _context.Add(taiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // GET: UserManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan == null)
            {
                return NotFound();
            }
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // POST: UserManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,TaiKhoan taiKhoan,IFormFile Ffile)
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
                        taiKhoan.AnhDaiDien = s;
                        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "avatar", fileName);

                        using (var file = new FileStream(fullPath, FileMode.Create))
                        {
                            Ffile.CopyTo(file);
                        }
                    }
                    else
                    {
                        taiKhoan.AnhDaiDien = "no-avatar.jpg";
                    }
                    taiKhoan.MaTaiKhoan = id;
                    _context.Update(taiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanExists(taiKhoan.MaTaiKhoan))
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
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // GET: UserManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: UserManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanExists(int id)
        {
            return _context.TaiKhoan.Any(e => e.MaTaiKhoan == id);
        }
    }
}
