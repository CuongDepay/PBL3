using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL.Staff
{
    public class Order_BLL
    {
        NewDBPBL db = new NewDBPBL();
        private static Order_BLL _Instance;
        public static Order_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Order_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private Order_BLL()
        {

        }

        public KHO GetKhoByID(string ID)
        {
            return db.KHOes.Find(ID);
        }
        public int GetSoluongtonkho(string ID)
        {
            int a = 0;
            foreach (KHO i in db.KHOes)
            {
                if (i.ID_ThietBi == ID)
                {
                    a = (int)i.SoLuongTonkho;
                }
            }
            return a;
        }
        public void Excute(HoaDon hd, ChiTietHoaDon detailhd)
        {
            db.HoaDons.Add(hd);
            db.ChiTietHoaDons.Add(detailhd);
            db.SaveChanges();
        }
        public ThietBi GetThietBiByID(string ID)
        {
            return db.ThietBis.Find(ID);
        }
        public void AddHoaDon(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }
        public void AddChitiethoadon(ChiTietHoaDon cthd)
        {
            db.ChiTietHoaDons.Add(cthd);
            db.SaveChanges();
        }

        public List<string> CBBSearch()
        {
            List<string> list = new List<string>();
            list.Add("Tat ca");
            foreach (ThietBi i in db.ThietBis)
            {
                list.Add(i.LoaiThietBi);
            }
            var distinctlist = list.Distinct().ToList();
            return distinctlist;
        }

        public int NhapIDHoadon()
        {
            int max = 1;
            foreach (HoaDon i in db.HoaDons)
            {
                if (i.ID_HoaDon != null)
                {
                    max = max + 1;
                }
            }
            return max;
        }
        public List<string> CBBSoDienThoai()
        {
            List<string> list = new List<string>();
            foreach (KhachHang i in db.KhachHangs)
            {
                list.Add(i.SDT);
            }
            return list;
        }
        public List<string> CBBIDKhuyenMai()
        {
            List<string> list = new List<string>();
            foreach (KhuyenMai i in db.KhuyenMais)
            {
                if ((i.NgayBatDau < DateTime.Now && DateTime.Now < i.NgayKetThuc) || i.PhanTram == 0)
                {
                    list.Add(i.ID_KhuyenMai);
                }

            }
            return list;
        }
        public dynamic search_by(string loaithietbi, string t)
        {
            if (loaithietbi == "Tat ca")
            {
                return (db.ThietBis.Where(p => p.TenThietBi.Contains(t)).Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan })).ToList();
            }
            else
            {
                return (db.ThietBis.Where(p => p.LoaiThietBi == loaithietbi && p.TenThietBi.Contains(t)).Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan })).ToList();
            }
        }

    }
}
