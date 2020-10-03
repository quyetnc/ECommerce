using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class NongDoViewModal : NongDo
    {
        private readonly MyDbContext db;
        public NongDoViewModal() { }
        public NongDoViewModal(MyDbContext _db)
        {
            db = _db;
        }
        public List<NongDoViewModal> GetNongDoThucDon()
        {
            var nongdothucdon = (from td in db.NongDo
                                     select new NongDoViewModal
                                     {
                                         MaNongDo = td.MaNongDo,
                                         NongDoValue = td.NongDoValue
                                     }).ToList();
            return nongdothucdon;
        }
    }
}
