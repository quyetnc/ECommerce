using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class OrderDetailViewModel
    {
        public int id { get; set; }
        public int? masp { get; set; }
        public string tensp { get; set; }
        public int? soluong { get; set; }
        public double? gia { get; set; }
        public double? thanhtien { get; set; }
        public DateTime? ngaydat { get; set; }
        public int? trangthai { get; set; }
        public int? matk { get; set; }
    }
}
