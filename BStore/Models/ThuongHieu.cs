using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("ThuongHieu")]
    public class ThuongHieu
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaTH { get; set; }
        public string TenTH { get; set; }

        public string HinhAnh { get; set; }
        public ICollection<ThucDon> ThucDon { get; set; }
    }
}
