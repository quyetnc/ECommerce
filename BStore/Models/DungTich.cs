using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("DungTich")]
    public class DungTich
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaDungTich { get; set; }
        public int DungTichValue { get; set; }

        public ICollection<ThucDon> ThucDon { get; set; }
    }
}
