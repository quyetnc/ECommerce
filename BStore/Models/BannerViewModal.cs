using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class BannerViewModal : BannerQuangCao
    {

        private readonly MyDbContext db;
        public BannerViewModal() { }
        public BannerViewModal(MyDbContext _db)
        {
            db = _db;
        }


        public IEnumerable<BannerViewModal> GetAllData()
        {
            var dsBanner = (from bn in db.BannerQuangCao
                             orderby bn.MaBanner descending
                             select new BannerViewModal
                             {
                                 MaBanner = bn.MaBanner,
                                 LinkBanner = bn.LinkBanner,
                                 TitleBanner = bn.TitleBanner,
                                 ContentBanner = bn.ContentBanner
                             });

            return dsBanner;
        }
    }
}
