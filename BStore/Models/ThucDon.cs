using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("ThucDon")]
    public class ThucDon
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaThucDon { get; set; }
        public string TenThucDon { get; set; }
        public string HinhAnh { get; set; }
        public int? MaLoai { get; set; }
        public int? MaTH { get; set; }
        public double? Gia { get; set; }
        public int? KhuyenMai { get; set; }
        public int? MaNongDo { get; set; }
        public int? MaDungTich { get; set; }
        public string MoTa { get; set; }
        public string MoreInfo {get; set;}
        public double? GiaKhuyenMai => Gia * (100 - KhuyenMai) / 100;//Gia - Gia/100*KhuyenMai => Gia*()

        public int? LuotXem { get; set; }
        public int? LuotMua { get; set; }

        [ForeignKey("MaNongDo")]
        public NongDo NongDoNavigation { get; set; }
        [ForeignKey("MaDungTich")]
        public DungTich DungTichNavigation { get; set; }
        [ForeignKey("MaLoai")]
        public LoaiThucDon MaLoaiNavigation { get; set; }

        [ForeignKey("MaTH")]
        public ThuongHieu MaTHNavigation { get; set; }
        public ICollection<ChiTietGioHang> ChiTietGioHang { get; set; }
    }
}
