using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL.Staff
{
    public class Customer_BLL
    {
        NewDBPBL dl = new NewDBPBL();
        private static Customer_BLL _Instance;
        public static Customer_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Customer_BLL();
                }
                return _Instance;
            }
            set { }
        }
        public Customer_BLL() { }
        public List<KhachHang> GetALLKH()
        {
            List<KhachHang> list = new List<KhachHang>();
            foreach (KhachHang i in dl.KhachHangs)
            {
                list.Add(i);
            }
            return list;
        }
        public KhachHang GetKHBySDT(string sdt)
        {
            foreach (KhachHang i in dl.KhachHangs)
            {
                if (i.SDT == sdt)
                {
                    return i;
                }
            }
            return null;
        }
        public bool Check(string sdt)
        {
            foreach (KhachHang k in GetALLKH())
            {
                if (k.SDT == sdt)
                    return true;
            }
            return false;
        }
        public void Them(KhachHang i)
        {
            if (Check(i.SDT))
            {
            }
            else
            {
                dl.KhachHangs.Add(i);
                dl.SaveChanges();
            }
        }
        public void Sua(KhachHang i)
        {
            if (Check(i.SDT))
            {
                KhachHang kh = dl.KhachHangs.Find(i.SDT);
                kh.TenKH = i.TenKH;
                kh.DiaChi = i.DiaChi;
                dl.SaveChanges();
            }
        }
        public void Xoa(string sdt)
        {
            KhachHang kh = dl.KhachHangs.Find(sdt);
            dl.KhachHangs.Remove(kh);
            dl.SaveChanges();
        }
        public List<KhachHang> TimKiem(string txt)
        {
            var l = from p in dl.KhachHangs where p.TenKH.Contains(txt) select p;
            return l.ToList();
        }
        public List<KhachHang> SapXep(string txt)
        {
            List<KhachHang> l = new List<KhachHang>();
            if (txt == "TenKH")
            {
                var l1 = from p in dl.KhachHangs orderby p.TenKH select p;
                l = l1.ToList();
            }
            if (txt == "DiaChi")
            {
                var l2 = from p in dl.KhachHangs orderby p.DiaChi select p;
                l = l2.ToList();
            }
            return l;
        }
    }
}
