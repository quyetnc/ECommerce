﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class DanhGiaViewModel : DanhGia
    {
        public string AnhDaiDien { get; set; }
        public string TenTaiKhoan { get; set; }
        public string HinhAnh { get; set; }
        public string TenThucDon { get; set; }
        private readonly MyDbContext db;
        public DanhGiaViewModel() { }
        public DanhGiaViewModel(MyDbContext _db)
        {
            db = _db;
        }
        public List<DanhGiaViewModel> GetDsDanhGia()
        {
            var ds = (from dg in db.DanhGia
                      join tk in db.TaiKhoan
                         on dg.MaTaiKhoan equals tk.MaTaiKhoan
                      select new DanhGiaViewModel
                      {
                          MaDanhGia = dg.MaDanhGia,
                          MaThucDon = dg.MaThucDon,
                          MaTaiKhoan = dg.MaTaiKhoan,
                          LoiNhanXet = dg.LoiNhanXet,
                          AnhDaiDien = tk.AnhDaiDien,
                          TenTaiKhoan = tk.TenTaiKhoan,
                          NgayDanhGia = dg.NgayDanhGia
                      }).ToList();
            return ds;
        }
        public List<DanhGiaViewModel> GetDanhGiaByProduct(string product_id)
        {
            var ds = GetDsDanhGia().Where(x => x.MaThucDon == int.Parse(product_id)).ToList();
            return ds;
        }
        public DanhGiaViewModel GetDanhGiaById(string id)
        {
            var ds = GetDsDanhGia().Where(x => x.MaDanhGia == int.Parse(id)).SingleOrDefault();
            return ds;
        }
        public IEnumerable<DanhGiaViewModel> GetDanhGiaByAccount(string acc_id)
        {
            var ds = GetDsDanhGia().Where(x => x.MaTaiKhoan == int.Parse(acc_id));
            return ds;
        }
    }
}
