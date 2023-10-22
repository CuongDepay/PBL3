using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.BLL.Admin
{

    public class Statistics_BLL
    {
        NewDBPBL db = new NewDBPBL();

        private static Statistics_BLL _Instance;
        public static Statistics_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Statistics_BLL();
                }
                return _Instance;
            }
            private set
            {

            }

        }
        private Statistics_BLL()
        {

        }
        private int Days;
        public DateTime dateEndDT;
        public DateTime dateBeginDT;
        public int TotalBill { get; set; }
        public double TotalReveneu { get; set; }
        public double TotalProfit { get; set; }
        public int TotalCustomer { get; set; }
        public int TotalProduct { get; set; }
        public List<KeyValuePair<string, int>> TopProducts { get; private set; }
        public struct RevenueByDate
        {
            public string Date { get; set; }
            public double Total { get; set; }
        }
        public List<RevenueByDate> TotalReveneuList { get; private set; }
        private List<HoaDon> GetOrder(DateTime x, DateTime y)
        {
            this.dateBeginDT = x;
            this.dateEndDT = y;
            var hd1 = db.HoaDons.Where(p => (p.NgayMuaHang > dateBeginDT) && (p.NgayMuaHang < dateEndDT)).Select(p => p).ToList();
            return hd1;
        }

        public void GetNumberData(DateTime x, DateTime y)
        {
            this.dateBeginDT = x;
            this.dateEndDT = y;
            TotalBill = GetOrder(dateBeginDT, dateEndDT).Count;
            TotalReveneu = 0;
            TotalProfit = 0;
            TotalProduct = 0;
            TotalCustomer = 0;
            double TotalImportPrice = 0;
            double ImportPrice;

            List<String> ListPhoneCustomer = new List<String>();
            foreach (HoaDon hd in GetOrder(dateBeginDT, dateEndDT))
            {
                ListPhoneCustomer.Add(hd.SDT);
                TotalReveneu += Convert.ToDouble(hd.TongTien.Value.ToString());
                foreach (ChiTietHoaDon i in GetChiTietHDbyID(hd.ID_HoaDon))
                {
                    TotalProduct += (int)(i.SoLuong);
                    ThietBi v = WareHouse_BLL.Instance.GetThietBiByID(i.ID_ThietBi);
                    ImportPrice = Convert.ToDouble(v.GiaNhap);
                    TotalImportPrice += ImportPrice * (int)(i.SoLuong);
                }
                TotalProfit = TotalReveneu - TotalImportPrice;
            }
            TotalCustomer = ListPhoneCustomer.Distinct().Count();
        }
        public List<ChiTietHoaDon> GetChiTietHDbyID(string ID)
        {
            return db.ChiTietHoaDons.Where(p => p.ID_HoaDon == ID).Select(p => p).ToList();
        }

        public List<DoanhThuView> GetDoanhThu(DateTime dateBegin, DateTime dateEnd, string txt, string cbb)
        {
            List<DoanhThuView> list = new List<DoanhThuView>();
            this.dateBeginDT = dateBegin;
            this.dateEndDT = dateEnd;
            if (cbb == "")
            {
                var l = from p in db.HoaDons
                        join t in db.ChiTietHoaDons
                        on p.ID_HoaDon equals t.ID_HoaDon
                        join r in db.ThietBis
                        on t.ID_ThietBi equals r.ID_ThietBi
                        where ((p.NgayMuaHang > dateBeginDT && p.NgayMuaHang < dateEndDT) && (r.TenThietBi.Contains(txt) || r.LoaiThietBi.Contains(txt)))
                        select new DoanhThuView
                        {
                            ID_ThietBi = r.ID_ThietBi,
                            TenTB = r.TenThietBi,
                            LoaiTB = r.LoaiThietBi,
                            NhaSX = r.NhaSX,
                            SoLuongBan = (int)(t.SoLuong),
                            NgayMuaHang = p.NgayMuaHang.Value,
                            GiaNhap = (double)(r.GiaNhap),
                            GiaBan = (double)(r.GiaBan),
                        };
                list = l.ToList();
            }
            else if (cbb == "Tên thiết bị")
            {
                var l = from p in db.HoaDons
                        join t in db.ChiTietHoaDons
                        on p.ID_HoaDon equals t.ID_HoaDon
                        join r in db.ThietBis
                        on t.ID_ThietBi equals r.ID_ThietBi
                        where ((p.NgayMuaHang > dateBeginDT && p.NgayMuaHang < dateEndDT) && (r.TenThietBi.Contains(txt) || r.LoaiThietBi.Contains(txt)))
                        orderby r.TenThietBi
                        select new DoanhThuView
                        {
                            ID_ThietBi = r.ID_ThietBi,
                            TenTB = r.TenThietBi,
                            LoaiTB = r.LoaiThietBi,
                            NhaSX = r.NhaSX,
                            SoLuongBan = (int)(t.SoLuong),
                            NgayMuaHang = p.NgayMuaHang.Value,
                            GiaNhap = (double)(r.GiaNhap),
                            GiaBan = (double)(r.GiaBan),
                        };
                list = l.ToList();
            }
            else if (cbb == "Số lượng bán")
            {
                var l = from p in db.HoaDons
                        join t in db.ChiTietHoaDons
                        on p.ID_HoaDon equals t.ID_HoaDon
                        join r in db.ThietBis
                        on t.ID_ThietBi equals r.ID_ThietBi
                        where ((p.NgayMuaHang > dateBeginDT && p.NgayMuaHang < dateEndDT) && (r.TenThietBi.Contains(txt) || r.LoaiThietBi.Contains(txt)))
                        orderby t.SoLuong
                        select new DoanhThuView
                        {
                            ID_ThietBi = r.ID_ThietBi,
                            TenTB = r.TenThietBi,
                            LoaiTB = r.LoaiThietBi,
                            NhaSX = r.NhaSX,
                            SoLuongBan = (int)(t.SoLuong),
                            NgayMuaHang = p.NgayMuaHang.Value,
                            GiaNhap = (double)(r.GiaNhap),
                            GiaBan = (double)(r.GiaBan),
                        };
                list = l.ToList();
            }
            return list;
        }
    }


}
