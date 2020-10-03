using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaPhanQuyen { get; set; }
        public string Email { get; set; }
        public string AnhDaiDien { get; set; }
        public int DangHoatDong { get; set; }

        [ForeignKey("MaPhanQuyen")]
        public PhanQuyen MaPhanQuyenNavigation { get; set; }
        public ICollection<KhachHang> KhachHang { get; set; }
    }
}
