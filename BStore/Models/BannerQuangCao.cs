using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    [Table("BannerQuangCao")]
    public class BannerQuangCao
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int MaBanner { get; set; }
        public string LinkBanner { get; set; }
        public string TitleBanner { get; set; }
        public string ContentBanner { get; set; }
    }
}
