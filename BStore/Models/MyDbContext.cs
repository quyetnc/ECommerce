using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHangNetCoreNhom123.Models;
using BStore.Models.Paypal;

namespace BStore.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietGioHang> ChiTietGioHang { get; set; }
        public virtual DbSet<DanhGia> DanhGia { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<BannerQuangCao> BannerQuangCao { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiThucDon> LoaiThucDon { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieu { get; set; }
        public virtual DbSet<NongDo> NongDo { get; set; }
        public virtual DbSet<DungTich> DungTich { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TinhThanh> TinhThanh { get; set; }
        public virtual DbSet<ThucDon> ThucDon { get; set; }
        public virtual DbSet<USD> USD { get; set; }

    }
}
