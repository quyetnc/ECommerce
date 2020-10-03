using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("TinhThanh")]
    public class TinhThanh
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity),Key]
        public int MaTinhThanh { get; set; }
        public string TenTinhThanh { get; set; }
    }
}
