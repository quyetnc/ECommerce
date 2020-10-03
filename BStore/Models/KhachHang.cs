using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string SoDt { get; set; }
        public int? MaTaiKhoan { get; set; }
        public int? MaTinhThanh { get; set; }

        [ForeignKey("MaTaiKhoan")]
        public TaiKhoan MaTaiKhoanNavigation { get; set; }
        public ICollection<GioHang> GioHang { get; set; }
    }
}
