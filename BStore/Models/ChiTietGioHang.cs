using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("ChiTietGioHang")]
    public class ChiTietGioHang
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaCtgioHang { get; set; }
        public int? MaGioHang { get; set; }
        public int? MaThucDon { get; set; }
        public int? SoLuong { get; set; }

        [ForeignKey("MaGioHang")]
        public GioHang MaGioHangNavigation { get; set; }
        [ForeignKey("MaThucDon")]
        public ThucDon MaThucDonNavigation { get; set; }
    }
}
