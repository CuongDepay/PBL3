using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL.Staff
{
    public class SaleHistory_BLL
    {
        NewDBPBL db = new NewDBPBL();
        private SaleHistory_BLL()
        {

        }
        private static SaleHistory_BLL _Instance;
        public static SaleHistory_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SaleHistory_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        public dynamic ShowAll()
        {
            return db.HoaDons.Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.SDT, p.NgayMuaHang, p.TongTien }).ToList();
        }
        public List<string> CBBSearch()
        {
            List<string> list = new List<string>();
            list.Add("Tất cả");
            list.Add("Tên khách hàng");
            list.Add("SDT");
            
            return list;
        }
        public List<string> CBBSort()
        {
            List<string> list = new List<string>();
            list.Add("Tên khách hàng");
            list.Add("Ngày mua hàng");
            list.Add("Tổng tiền");
            return list;
        }

        public HoaDon getHDByID(string ID)
        {
            return db.HoaDons.Find(ID);
        }
        public dynamic GetDetailBillByID(string ID)
        {
            return db.ChiTietHoaDons.Where(p => p.ID_HoaDon == ID)
            .Select(p => new { p.ThietBi.TenThietBi, p.ThietBi.NhaSX, p.ThietBi.LoaiThietBi, p.SoLuong/*, p.ThietBi.GiaNhap*/, p.ThietBi.GiaBan }).ToList();
        }
        public dynamic GetID_ThietBi(string ID)
        {
            return db.ChiTietHoaDons.Where(p => p.ID_HoaDon == ID)
            .Select(p => p.ID_ThietBi).ToList();
        }
        public KhachHang GetKHByPhone(string Phone)
        {
            KhachHang kh = db.KhachHangs.Find(Phone);
            if (kh != null)
            {
                return kh;
            }
            else
            {
                return null;
            }
        }
        public double GetPhanTramByID(string ID)
        {
            double value = 0;
            foreach ( KhuyenMai i in db.KhuyenMais)
            {
                if (i.ID_KhuyenMai == ID)
                {
                    value = Convert.ToDouble(i.PhanTram);
                }
            }
            return value;
        }
        public dynamic Sort(int index)
        {
            if (index == 0)
            {
                return (db.HoaDons.Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).OrderBy(p => p.TenKH)).ToList();
            }
            else if (index == 1)
            {
                return (db.HoaDons.Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).OrderBy(p => p.NgayMuaHang)).ToList();
            }
            else
            {
                return (db.HoaDons.Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).OrderBy(p => p.TongTien)).ToList();
            }

        }
        public dynamic Search(int index, string txt, DateTime begin, DateTime end) 
        {
            if (index == 0)
            {
                return db.HoaDons.Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).ToList(); ; 
            }
            else if (index == 1)
            {
                return db.HoaDons.Where(p => p.KhachHang.TenKH.Contains(txt) && p.NgayMuaHang >= begin && p.NgayMuaHang <= end).Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).ToList(); ;
            }
            else if (index == 2)
            {
                return db.HoaDons.Where(p => p.KhachHang.SDT.Contains(txt) && p.NgayMuaHang >= begin && p.NgayMuaHang <= end).Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).ToList();
            }
            else return db.HoaDons.Where(p => p.NgayMuaHang >= begin && p.NgayMuaHang <= end).Select(p => new { p.ID_HoaDon, p.KhachHang.TenKH, p.KhachHang.SDT, p.NgayMuaHang, p.TongTien }).ToList();
        }



    }
}
