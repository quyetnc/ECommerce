using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("DanhGia")]
    public class DanhGia
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key]
        public int MaDanhGia { get; set; }
        public int? MaTaiKhoan { get; set; }
        public int? MaThucDon { get; set; }
        public string LoiNhanXet { get; set; }
        public DateTime? NgayDanhGia { get; set; }
    }
}
