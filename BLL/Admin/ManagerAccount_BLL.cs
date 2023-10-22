using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL.Admin
{
    public class ManagerAccount_BLL
    {
        NewDBPBL dl = new NewDBPBL();
        private static ManagerAccount_BLL _Instance;
        public static ManagerAccount_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ManagerAccount_BLL();
                }
                return _Instance;
            }
            set { }
        }
        public ManagerAccount_BLL() { }
        public List<TaiKhoan> GetALLTK()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            foreach (TaiKhoan i in dl.TaiKhoans)
            {
                list.Add(i);
            }
            return list;
        }
        public TaiKhoan GetTKByID(string id)
        {
            foreach (TaiKhoan i in dl.TaiKhoans)
            {
                if (i.ID_TK == id)
                {
                    return i;
                }
            }
            return null;
        }
        public List<string> GetIDNV()
        {
            List<string> list = new List<string>();
            foreach (NhanVien i in dl.NhanViens)
            {
                list.Add(i.ID_NV);
            }
            return list;
        }
        public bool Check(string id)
        {
            foreach (TaiKhoan i in dl.TaiKhoans)
            {
                if (id.Equals(i.ID_TK))
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(TaiKhoan t)
        {
            if (Check(t.ID_TK))
            {
            }
            else
            {
                dl.TaiKhoans.Add(t);
                dl.SaveChanges();
            }
        }
        public void Update(TaiKhoan t)
        {
            TaiKhoan tk = dl.TaiKhoans.Find(t.ID_TK);
            tk.TenTK = t.TenTK;
            tk.MatKhau = t.MatKhau;
            tk.ChucVu = t.ChucVu;
            tk.ID_NV = t.ID_NV;
            dl.SaveChanges();
        }
        public void Del(string ID)
        {
            TaiKhoan tk = dl.TaiKhoans.Find(ID);
            dl.TaiKhoans.Remove(tk);
            dl.SaveChanges();
        }
        public List<TaiKhoan> TimKiem(string txt)
        {
            var l = from p in dl.TaiKhoans where p.TenTK.Contains(txt) select p;
            return l.ToList();
        }
        public List<TaiKhoan> SapXep(string txt)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            if (txt == "ID_TK")
            {
                var l = from p in dl.TaiKhoans orderby p.ID_TK select p;
                list = l.ToList();
            }
            if (txt == "ChucVu")
            {
                var l = from p in dl.TaiKhoans orderby p.ChucVu select p;
                list = l.ToList();
            }
            if (txt == "TenTK")
            {
                var l = from p in dl.TaiKhoans orderby p.TenTK select p;
                list = l.ToList();
            }
            return list;
        }
        public List<string> GetIDNVInTK()
        {
            List<string> list = new List<string>();
            foreach (TaiKhoan i in dl.TaiKhoans)
            {
                list.Add(i.ID_NV);
            }
            return list;
        }
    }
}

