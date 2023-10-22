using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PBL3.DTO;



namespace PBL3.BLL.Admin
{
    public class ManagerUser_BLL
    {
        NewDBPBL dl = new NewDBPBL();
        private static ManagerUser_BLL _Instance;
        public static ManagerUser_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ManagerUser_BLL();
                }
                return _Instance;
            }
            set { }
        }
        public ManagerUser_BLL() { }
        public List<NhanVien> GetALLNV()
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach (NhanVien i in dl.NhanViens)
            {
                list.Add(i);
            }
            return list;
        }
        public NhanVien GetNVByID(string id)
        {
            foreach (NhanVien i in dl.NhanViens)
            {
                if (i.ID_NV == id)
                {
                    return i;
                }
            }
            return null;
        }
        public bool Check(string id)
        {
            foreach (NhanVien i in dl.NhanViens)
            {
                if (i.ID_NV.Equals(id))
                    return true;
            }
            return false;
        }
        public void ThemvaSua(NhanVien i)
        {
            if (Check(i.ID_NV))
            {
                NhanVien nv = dl.NhanViens.Find(i.ID_NV);
                nv.TenNV = i.TenNV;
                nv.NgaySinh = i.NgaySinh;
                nv.GioiTinh = i.GioiTinh;
                nv.DiaChi = i.DiaChi;
                nv.SDT = i.SDT;
                nv.Anh_NV = i.Anh_NV;
                dl.SaveChanges();
            }
            else
            {
                dl.NhanViens.Add(i);
                dl.SaveChanges();
            }
        }
        public void XoaNV(string id)
        {
            NhanVien nv = dl.NhanViens.Find(id);
            dl.NhanViens.Remove(nv);
            dl.SaveChanges();
        }
        public List<NhanVien> TimKiem(string txt)
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                var l = from p in dl.NhanViens
                        where p.TenNV.Contains(txt)
                        select p;
                list = l.ToList();
            }
            catch (Exception)
            {
            }
            return list;
        }
        public List<NhanVien> SapXep(string txt)
        {
            List<NhanVien> list = new List<NhanVien>();
            if (txt == "ID nhân viên")
            {
                var l = from p in dl.NhanViens
                        orderby p.ID_NV
                        select p;
                list = l.ToList();
            }
            if (txt == "Tên nhân viên")
            {
                var l = from p in dl.NhanViens
                        orderby p.TenNV
                        select p;
                list = l.ToList();
            }
            if (txt == "Địa chỉ")
            {
                var l = from p in dl.NhanViens
                        orderby p.DiaChi
                        select p;
                list = l.ToList();
            }
            return list;
        }
    }
}