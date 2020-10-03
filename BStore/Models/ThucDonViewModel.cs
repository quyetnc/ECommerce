using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BStore.Models
{
    public class ThucDonViewModel : ThucDon
    {
        public string TenLoai { get; set; }

        public string TenThuongHieu { get; set; }
        public double? GetGiaKhuyenMai { get; set; }

        public double? NongDo { get; set; }

        public int? DungTich { get; set; }

        private readonly MyDbContext db;
        public ThucDonViewModel() { }
        public ThucDonViewModel(MyDbContext _db)
        {
            db = _db;
        }

        public IEnumerable<ThucDonViewModel> GetAllData()
        {
            var dsThucDon = (from td in db.ThucDon
                             join ltd in db.LoaiThucDon
                             on td.MaLoai equals ltd.MaLoai
                             //orderby td.MaThucDon descending
                             select new ThucDonViewModel
                             {
                                 MaThucDon = td.MaThucDon,
                                 TenThucDon = td.TenThucDon,
                                 HinhAnh = td.HinhAnh,
                                 TenLoai = ltd.TenLoai,
                                 MaLoai = td.MaLoai,
                                 Gia = td.Gia,
                                 KhuyenMai = td.KhuyenMai,
                                 GetGiaKhuyenMai = td.GiaKhuyenMai,
                                 MoTa = td.MoTa,
                                 LuotMua = td.LuotMua,
                                 LuotXem = td.LuotXem
                             });

            return dsThucDon;
        }

        public IEnumerable<ThucDonViewModel> GetAllDataWithBrand()
        {
            var dsThucDon = (from td in db.ThucDon
                             join th in db.ThuongHieu
                             on td.MaTH equals th.MaTH
                             join ltd in db.LoaiThucDon on td.MaLoai equals ltd.MaLoai
                             orderby td.MaTH descending
                             select new ThucDonViewModel
                             {
                                 MaThucDon = td.MaThucDon,
                                 TenThucDon = td.TenThucDon,
                                 HinhAnh = td.HinhAnh,
                                 TenLoai = ltd.TenLoai,
                                 MaLoai = td.MaLoai,
                                 Gia = td.Gia,
                                 KhuyenMai = td.KhuyenMai,
                                 GetGiaKhuyenMai = td.GiaKhuyenMai,
                                 MoTa = td.MoTa,
                                 MaTH = th.MaTH,
                                 TenThuongHieu = th.TenTH
                             });

            return dsThucDon;
        }


        public IEnumerable<ThucDonViewModel> SortByName()
        {
            var dsThucDon = (from td in db.ThucDon
                             join ltd in db.LoaiThucDon
                             on td.MaLoai equals ltd.MaLoai
                             join th in db.ThuongHieu
                             on td.MaTH equals th.MaTH
                             orderby td.TenThucDon
                             select new ThucDonViewModel
                             {
                                 MaThucDon = td.MaThucDon,
                                 TenThucDon = td.TenThucDon,
                                 HinhAnh = td.HinhAnh,
                                 TenLoai = ltd.TenLoai,
                                 MaLoai = td.MaLoai,
                                 Gia = td.Gia,
                                 KhuyenMai = td.KhuyenMai,
                                 GetGiaKhuyenMai = td.GiaKhuyenMai,
                                 MoTa = td.MoTa
                             }).Take(6);

            return dsThucDon;
        }

        public IEnumerable<ThucDonViewModel> GetAllDataByCate(string MaLoai)
        {
            var dsThucdon = Enumerable.Empty<ThucDonViewModel>();
            if (MaLoai == "0")
            {
                dsThucdon = GetAllData();
            }
            else
            {
                dsThucdon = GetAllData().Where(self => self.MaLoai.ToString().Equals(MaLoai));
            }

            return dsThucdon;
        }
        public IEnumerable<ThucDonViewModel> GetAllDataByBrand(string MaTH)
        {
            var dsThucdon = Enumerable.Empty<ThucDonViewModel>();
            if (MaTH == "0")
            {
                dsThucdon = GetAllDataWithBrand();
            }
            else
            {
                dsThucdon = GetAllDataWithBrand().Where(self => self.MaTH.ToString().Equals(MaTH));
            }

            return dsThucdon;
        }

        public ThucDonViewModel GetDataById(string id)
        {
            var thucdon = (from td in db.ThucDon
                           where td.MaThucDon == int.Parse(id)
                           join ltd in db.LoaiThucDon
                           on td.MaLoai equals ltd.MaLoai
                           join th in db.ThuongHieu
                            on td.MaTH equals th.MaTH
                           join nd in db.NongDo
                          on td.MaNongDo equals nd.MaNongDo
                           join dt in db.DungTich
                            on td.MaDungTich equals dt.MaDungTich
                           select new ThucDonViewModel
                           {
                               MaThucDon = td.MaThucDon,
                               TenThucDon = td.TenThucDon,
                               HinhAnh = td.HinhAnh,
                               TenLoai = ltd.TenLoai,
                               MaLoai = td.MaLoai,
                               Gia = td.Gia,
                               KhuyenMai = td.KhuyenMai,
                               GetGiaKhuyenMai = td.GiaKhuyenMai,
                               MoTa = td.MoTa,
                               TenThuongHieu = th.TenTH,
                               NongDo = nd.NongDoValue,
                               DungTich = dt.DungTichValue,
                               MoreInfo = td.MoreInfo
                           }).FirstOrDefault();
            return thucdon;
        }
        public IEnumerable<ThucDonViewModel> GetDataByPage(int page, int limit = 6)
        {
            var offset = (page - 1) * limit;
            var dsThucDon = (from td in db.ThucDon
                             join ltd in db.LoaiThucDon
                             on td.MaLoai equals ltd.MaLoai
                             select new ThucDonViewModel
                             {
                                 MaThucDon = td.MaThucDon,
                                 TenThucDon = td.TenThucDon,
                                 HinhAnh = td.HinhAnh,
                                 TenLoai = ltd.TenLoai,
                                 MaLoai = td.MaLoai,
                                 Gia = td.Gia,
                                 KhuyenMai = td.KhuyenMai,
                                 GetGiaKhuyenMai = td.GiaKhuyenMai,
                                 MoTa = td.MoTa
                             })
                             .Skip(offset)
                             .Take(limit);

            return dsThucDon;
        }
        public IEnumerable<ThucDonViewModel> GetAllDataWithFilter(string maloai, string sapxep)
        {
            var dsThucDon = (from td in db.ThucDon
                             join ltd in db.LoaiThucDon
                             on td.MaLoai equals ltd.MaLoai
                             select new ThucDonViewModel
                             {
                                 MaThucDon = td.MaThucDon,
                                 TenThucDon = td.TenThucDon,
                                 HinhAnh = td.HinhAnh,
                                 TenLoai = ltd.TenLoai,
                                 MaLoai = td.MaLoai,
                                 Gia = td.Gia,
                                 KhuyenMai = td.KhuyenMai,
                                 GetGiaKhuyenMai = td.GiaKhuyenMai,
                                 MoTa = td.MoTa
                             });
            dsThucDon = (maloai == "0") ? dsThucDon : dsThucDon.Where(x => x.MaLoai.ToString().Equals(maloai));
            if (sapxep == "0")
            {
                dsThucDon = dsThucDon;
            }
            else if (sapxep == "1")
            {
                dsThucDon = dsThucDon.OrderBy(x => x.GiaKhuyenMai);
            }
            else if (sapxep == "2")
            {
                dsThucDon = dsThucDon.OrderByDescending(x => x.MaThucDon);
            }
            else
            {
                dsThucDon = dsThucDon.Where(x => (x.KhuyenMai != 0));
            }
            return dsThucDon;
        }
        public IEnumerable<ThucDonViewModel> GetAllDataWithFilterByPage(int page, int limit, string maloai, string sapxep)
        {

            var offset = (page - 1) * limit;
            var dsThucDon = GetAllDataWithFilter(maloai, sapxep).Skip(offset).Take(limit);
            return dsThucDon;
        }
        public IEnumerable<ThucDonViewModel> GetDataWithCateByPage(string MaLoai, int page, int limit = 7)
        {
            var offset = (page - 1) * limit;
            var dsThucDon = (from td in db.ThucDon
                             join ltd in db.LoaiThucDon
                             on td.MaLoai equals ltd.MaLoai
                             orderby td.MaThucDon descending
                             select new ThucDonViewModel
                             {
                                 MaThucDon = td.MaThucDon,
                                 TenThucDon = td.TenThucDon,
                                 HinhAnh = td.HinhAnh,
                                 TenLoai = ltd.TenLoai,
                                 MaLoai = td.MaLoai,
                                 Gia = td.Gia,
                                 KhuyenMai = td.KhuyenMai,
                                 MoTa = td.MoTa
                             });

            if (MaLoai != "0")
            {
                dsThucDon = dsThucDon.Where(self => self.MaLoai.ToString().Equals(MaLoai)).Skip(offset).Take(limit);
            }
            else
            {
                dsThucDon = dsThucDon.Skip(offset).Take(limit);
            }
            return dsThucDon;
        }
        //------------------------------------------
        public IEnumerable<ThucDonViewModel> GetDataByName(string keyword)
        {
            keyword = keyword.ToLower();
            var dsThucDon = GetAllData().Where(self => self.TenThucDon.ToLower().Contains(keyword));
            return dsThucDon;
        }
        public IEnumerable<ThucDonViewModel> GetDataByNameWithPage(string keyword, int page, int limit = 7)
        {
            var offset = (page - 1) * limit;
            keyword = keyword.ToLower();
            var dsThucDon = GetAllData().Where(self => self.TenThucDon.ToLower().Contains(keyword)).Skip(offset).Take(limit);
            return dsThucDon;
        }
        public bool DeleteThucDonById(String id)
        {
            if (db.ThucDon.Find(int.Parse(id)) != null)
            {
                db.ThucDon.Remove(db.ThucDon.Find(int.Parse(id)));
                db.SaveChanges();
                return true;
            }
            return false;
            //return new ThucDonViewModel(db).GetDsThucDon();
        }

        public bool InsertThucDon(ThucDon nv)
        {
            if (nv != null)
            {
                db.ThucDon.Add(nv);
                db.SaveChanges();
                return true;
            }
            return false;
            //return new ThucDonViewModel(db).GetDsThucDon();
        }
        public bool EditThucDon(ThucDon ThucDon)
        {
            //Edit bằng id nghe
            ThucDon nv = db.ThucDon.Find(ThucDon.MaThucDon);
            if (nv != null)
            {
                db.Entry(nv).CurrentValues.SetValues(ThucDon);
                db.SaveChanges();
                return true;
            }
            return false;
            //return new ThucDonViewModel(db).GetDsThucDon();
        }

    }
}
