using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("PhanQuyen")]
    public class PhanQuyen
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key]
        public string MaPhanQuyen { get; set; }
        public string QuyenHan { get; set; }

        public ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
