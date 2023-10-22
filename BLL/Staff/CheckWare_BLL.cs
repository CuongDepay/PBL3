using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL.Staff
{
    public class CheckWare_BLL
    {
        NewDBPBL db = new NewDBPBL();
        private static CheckWare_BLL _Instance;
        public static CheckWare_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CheckWare_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private CheckWare_BLL()
        {

        }
        public dynamic showAll()
        {
            return (db.ThietBis.Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan })).ToList();
        }
        public ThietBi GetThietBiByID(string ID)
        {
            return db.ThietBis.Find(ID);
        }
        public KHO GetKhoByID(string ID)
        {
            return db.KHOes.Find(ID);
        }
        public List<string> CBBSort()
        {
            List<string> list = new List<string>();
            list.Add("Gia ban");
            list.Add("Ten thiet bi");
            return list;
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
        public dynamic sort_by(string loaithietbi, int index)
        {
            if (index == 0)
            {
                if (loaithietbi == "Tat ca")
                {
                    return (db.ThietBis.Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan }).OrderBy(p => p.GiaBan)).ToList();
                }
                else
                {
                    return (db.ThietBis.Where(p => p.LoaiThietBi == loaithietbi).Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan }).OrderBy(p => p.GiaBan)).ToList();
                }

            }
            else
            {
                if (loaithietbi == "Tat ca")
                {
                    return (db.ThietBis.Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan }).OrderBy(p => p.TenThietBi)).ToList();
                }
                else
                {
                    return (db.ThietBis.Where(p => p.LoaiThietBi == loaithietbi).Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan }).OrderBy(p => p.TenThietBi)).ToList();
                }

            }
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
