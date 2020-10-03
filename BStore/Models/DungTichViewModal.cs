using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class DungTichViewModal : DungTich
    {
        private readonly MyDbContext db;
        public DungTichViewModal() { }
        public DungTichViewModal(MyDbContext _db)
        {
            db = _db;
        }
        public List<DungTichViewModal> GetDungTichThucDon()
        {
            var dungtichthucdon = (from dt in db.DungTich
                                     select new DungTichViewModal
                                     {
                                         MaDungTich = dt.MaDungTich,
                                         DungTichValue = dt.DungTichValue
                                     }).ToList();
            return dungtichthucdon;
        }
    }
}
