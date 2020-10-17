using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models.Paypal
{

    [Table("USD")]
    public class USD
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaUSD { get; set; }
        public double TyGiaUSD { get; set; }
    }
}
