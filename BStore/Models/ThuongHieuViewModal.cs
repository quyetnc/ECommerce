using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class ThuongHieuViewModal : ThuongHieu
    {
        private readonly MyDbContext db;
        public ThuongHieuViewModal() { }
        public ThuongHieuViewModal(MyDbContext _db)
        {
            db = _db;
        }
        public List<ThuongHieuViewModal> GetThuongHieuThucDon()
        {
            var thuonghieuthucdon = (from td in db.ThuongHieu
                               select new ThuongHieuViewModal
                               {
                                   MaTH = td.MaTH,
                                   TenTH = td.TenTH,
                                   HinhAnh = td.HinhAnh
                               }).ToList();
            return thuonghieuthucdon;
        }
    }
}
