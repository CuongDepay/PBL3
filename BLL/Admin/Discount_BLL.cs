using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.BLL.Admin
{
    public class Discount_BLL
    {
        private static Discount_BLL _Instance;
        public static Discount_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Discount_BLL();
                }
                return _Instance;
            }
            private set
            {
            }

        }
        private Discount_BLL() { }
        public dynamic SearchDiscount(int index, string s)
        {
            NewDBPBL db = new NewDBPBL();

            if (index == 1)
            {

                return (db.KhuyenMais.Where(p => p.ID_KhuyenMai.Contains(s)).Select(p => new { p.ID_KhuyenMai, p.TenKhuyenMai, p.PhanTram, p.NgayBatDau, p.NgayKetThuc })).ToList();
            }
            else if (index == 2)
            {

                return (db.KhuyenMais.Where(p => p.TenKhuyenMai.Contains(s)).Select(p => new { p.ID_KhuyenMai, p.TenKhuyenMai, p.PhanTram, p.NgayBatDau, p.NgayKetThuc })).ToList();
            }
            else
            {
                return (db.KhuyenMais.Select(p => new { p.ID_KhuyenMai, p.TenKhuyenMai, p.PhanTram, p.NgayBatDau, p.NgayKetThuc })).ToList();
            }

        }
        public KhuyenMai GetDiscount(string IDDIS)
        {
            NewDBPBL db = new NewDBPBL();
            return db.KhuyenMais.Find(IDDIS);
        }
        public bool Check(string s)
        {
            NewDBPBL db = new NewDBPBL();
            foreach (KhuyenMai i in db.KhuyenMais)
            {
                if (i.ID_KhuyenMai == s)
                {
                    return false;
                }
            }
            return true;
        }
        public void Add(KhuyenMai s)
        {
            if (Check(s.ID_KhuyenMai))
            {
                NewDBPBL db = new NewDBPBL();

                db.KhuyenMais.Add(s);
                db.SaveChanges();

            }
        }
        public void Update(KhuyenMai s)
        {
            NewDBPBL db = new NewDBPBL();
            KhuyenMai d = db.KhuyenMais.Find(s.ID_KhuyenMai);
            d.TenKhuyenMai = s.TenKhuyenMai;
            d.PhanTram = s.PhanTram;
            d.NgayBatDau = s.NgayBatDau;
            d.NgayKetThuc = s.NgayKetThuc;
            db.SaveChanges();
        }
        public void ExcuteDB(KhuyenMai s)
        {
            if (Check(s.ID_KhuyenMai))
            {
                Add(s);
            }
            else
            {
                Update(s);
            }
        }
        public void Del(string ID)
        {
            NewDBPBL db = new NewDBPBL();
            KhuyenMai d = db.KhuyenMais.Find(ID);
            db.KhuyenMais.Remove(d);
            db.SaveChanges();

        }
        //Sap xep
        public List<string> CBB()
        {
            List<string> list = new List<string>();
            list.Add("Tat ca");
            list.Add("ID");
            list.Add("Ten Khuyen Mai");
            return list;
        }
        public List<string> CBB_sort()
        {
            List<string> list = new List<string>();
            list.Add("% Giam ");
            list.Add("Ngày bắt đầu");
            list.Add("Ngày kết thúc");
            return list;
        }
        public dynamic SortBy(int index)
        {
            NewDBPBL db = new NewDBPBL();
            if (index == 0)
            {
                return (
               from p in db.KhuyenMais
               orderby p.PhanTram
               select new { p.ID_KhuyenMai, p.TenKhuyenMai, p.PhanTram, p.NgayBatDau, p.NgayKetThuc }
               ).ToList();
            }
            else if (index == 1)
            {
                return (
                              from p in db.KhuyenMais
                              orderby p.NgayBatDau
                              select new { p.ID_KhuyenMai, p.TenKhuyenMai, p.PhanTram, p.NgayBatDau, p.NgayKetThuc }).ToList();

            }
            else
            {
                return (
                              from p in db.KhuyenMais
                              orderby p.NgayKetThuc
                              select new { p.ID_KhuyenMai, p.TenKhuyenMai, p.PhanTram, p.NgayBatDau, p.NgayKetThuc }).ToList();

            }
        }

    }
}