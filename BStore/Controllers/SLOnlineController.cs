using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BStore.Controllers
{
    public class SLOnlineController : Controller
    {
        private readonly MyDbContext _context;

        public SLOnlineController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult SL()
        {

            ViewBag.SLOnline = _context.TaiKhoan.Where(p => p.DangHoatDong == 1).ToList().Count();
            return PartialView("_SLOnline", ViewBag.SLOnline);
        }
    }
}