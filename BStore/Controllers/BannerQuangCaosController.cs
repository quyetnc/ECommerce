using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BStore.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace BStore.Controllers
{
    public class BannerQuangCaosController : BaseController
    {
        private readonly MyDbContext _context;

        public BannerQuangCaosController(MyDbContext context)
        {
            _context = context;
        }

        // GET: BannerQuangCaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.BannerQuangCao.ToListAsync());
        }

        // GET: BannerQuangCaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bannerQuangCao = await _context.BannerQuangCao
                .FirstOrDefaultAsync(m => m.MaBanner == id);
            if (bannerQuangCao == null)
            {
                return NotFound();
            }

            return View(bannerQuangCao);
        }

        // GET: BannerQuangCaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BannerQuangCaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( BannerQuangCao bannerQuangCao,IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                string s = "";
                if (Ffile != null)
                {
                    string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                    s = fileName;
                    bannerQuangCao.LinkBanner = s;
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "banner", fileName);

                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        Ffile.CopyTo(file);
                    }
                }
                else
                {
                    bannerQuangCao.LinkBanner = "macdinh.jpg";
                }
                _context.Add(bannerQuangCao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bannerQuangCao);
        }

        // GET: BannerQuangCaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bannerQuangCao = await _context.BannerQuangCao.FindAsync(id);
            if (bannerQuangCao == null)
            {
                return NotFound();
            }
            return View(bannerQuangCao);
        }

        // POST: BannerQuangCaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,BannerQuangCao bannerQuangCao,IFormFile Ffile)
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
                        bannerQuangCao.LinkBanner = s;
                        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "banner", fileName);

                        using (var file = new FileStream(fullPath, FileMode.Create))
                        {
                            Ffile.CopyTo(file);
                        }
                    }
                    else
                    {
                        bannerQuangCao.LinkBanner = "macdinh.jpg";
                    }
                    bannerQuangCao.MaBanner = id;
                    _context.Update(bannerQuangCao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannerQuangCaoExists(bannerQuangCao.MaBanner))
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
            return View(bannerQuangCao);
        }

        // GET: BannerQuangCaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bannerQuangCao = await _context.BannerQuangCao.FindAsync(id);
            _context.BannerQuangCao.Remove(bannerQuangCao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: BannerQuangCaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bannerQuangCao = await _context.BannerQuangCao.FindAsync(id);
            _context.BannerQuangCao.Remove(bannerQuangCao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BannerQuangCaoExists(int id)
        {
            return _context.BannerQuangCao.Any(e => e.MaBanner == id);
        }
    }
}
