using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("LoaiThucDon")]
    public class LoaiThucDon
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<ThucDon> ThucDon { get; set; }
    }
}
