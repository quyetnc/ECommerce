using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("NongDo")]
    public class NongDo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaNongDo { get; set; }
        public double NongDoValue { get; set; }

        public ICollection<ThucDon> ThucDon { get; set; }
    }
}
