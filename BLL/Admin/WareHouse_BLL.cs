using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;

namespace PBL3.BLL.Admin
{
    public class WareHouse_BLL
    {
        NewDBPBL db = new NewDBPBL();
        private static WareHouse_BLL _Instance;
        public static WareHouse_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new WareHouse_BLL();
                }
                return _Instance;
            }
            private set { }
        }
        private WareHouse_BLL()
        {

        }
        public dynamic showAll()
        {
            return (db.ThietBis.Select(p => new { p.ID_ThietBi, p.TenThietBi, p.LoaiThietBi, p.NhaSX, p.GiaBan })).ToList();
        }
        public dynamic GetChiTietNhapKhoByID(string id)
        {
            return db.NhapKhoes.Where(p => p.ID_ThietBi == id).Select(p => new { p.STT, p.ID_ThietBi, p.KHO.ThietBi.TenThietBi, p.SoLuongNhap, p.NgayNhap, p.GiaNhap }).ToList();
        }
        public ThietBi GetThietBiByID(string ID)
        {
            return db.ThietBis.Find(ID);
        }
        public KHO GetKhoByID(string ID)
        {
            return db.KHOes.Find(ID);
        }
        public NhapKho GetNhapKhoByID(string ID)
        {
            return (NhapKho)db.NhapKhoes.Where(p => p.ID_ThietBi == ID);
        }
        public bool Check(string ID)
        {
            foreach (ThietBi i in db.ThietBis)
            {
                if (i.ID_ThietBi == ID)
                {
                    return true;
                }
            }
            return false;
        }
        public void UpdateKho(string id, int soluongban)
        {
            KHO uk = db.KHOes.Find(id);
            uk.SoLuongBan = uk.SoLuongBan + soluongban;
            uk.SoLuongTonkho = uk.SoLuongTonkho - soluongban;
            db.SaveChanges();
        }
        public void RefundKho(string id, int soluongban)
        {
            KHO uk = db.KHOes.Find(id);
            uk.SoLuongBan = uk.SoLuongBan - soluongban;
            uk.SoLuongTonkho = uk.SoLuongTonkho + soluongban;
            db.SaveChanges();
        }
        public List<ThietBiView> GetallThietbiView()
        {
            var l2 = from ThietBi tb in db.ThietBis.ToList()
                     join KHO k in db.KHOes on tb.ID_ThietBi equals k.ID_ThietBi
                     where tb.ID_ThietBi == k.ID_ThietBi
                     select new ThietBiView
                     {
                         ID_ThietBi = tb.ID_ThietBi,
                         TenThietBi = tb.TenThietBi,
                         NhaSX = tb.NhaSX,
                         LoaiThietBi = tb.LoaiThietBi,
                         GiaBan = (double)tb.GiaBan,
                         SoLuongTonKho = (int)k.SoLuongTonkho
                     };
            return l2.ToList();
        }
        public void Excute(ThietBi tb, KHO k)
        {
            if (Check(tb.ID_ThietBi))
            {
                ThietBi t = db.ThietBis.Find(tb.ID_ThietBi);
                t.TenThietBi = tb.TenThietBi;
                t.LoaiThietBi = tb.LoaiThietBi;
                t.NhaSX = tb.NhaSX;
                t.GiaBan = tb.GiaBan;
            }
            else
            {
                db.ThietBis.Add(tb);
                db.KHOes.Add(k);
            }
            db.SaveChanges();
        }
        public void NhapVaokho(ThietBi tb, KHO k, NhapKho nk)
        {
            ThietBi t = db.ThietBis.Find(tb.ID_ThietBi);
            t.GiaNhap = tb.GiaNhap;
            KHO kh = db.KHOes.Find(k.ID_ThietBi);
            if (t.LoaiThietBi == "Máy Tính")
            {
                if (kh.SoLuongTonkho < 10)
                {
                    if (k.TongSoLuongNhap > 100)
                    {
                        DialogResult result = MessageBox.Show("Số lượng nhập đã quá mức, bạn vẫn muốn nhập ?", "Hỏi Nhập Kho ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                            kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                            db.NhapKhoes.Add(nk);
                            db.SaveChanges();
                            MessageBox.Show("Đã nhập thành công!");
                        }
                    }
                    else
                    {
                        kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                        kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                        db.NhapKhoes.Add(nk);
                        db.SaveChanges();
                        MessageBox.Show("Đã nhập thành công!");
                    }
                }
                else
                if (10 <= kh.SoLuongTonkho && kh.SoLuongTonkho < 100)
                {
                    DialogResult result = MessageBox.Show("Số lượng trong kho vẫn còn, bạn vẫn muốn nhập ?", "Hỏi Nhập Kho ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                        kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                        db.NhapKhoes.Add(nk);
                        db.SaveChanges();
                        MessageBox.Show("Đã nhập thành công!");
                    }
                }
                else
                {
                    kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                    kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                    db.NhapKhoes.Add(nk);
                    db.SaveChanges();
                    MessageBox.Show("Đã nhập thành công!");
                }
            }
            else
            {
                if (kh.SoLuongTonkho < 20)
                {
                    if (k.TongSoLuongNhap > 200)
                    {
                        DialogResult result = MessageBox.Show("Số lượng nhập đã quá mức, bạn vẫn muốn nhập ?", "Gợi ý nhập kho !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                            kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                            db.NhapKhoes.Add(nk);
                            db.SaveChanges();
                            MessageBox.Show("Đã nhập thành công!");
                        }
                    }
                    else
                    {
                        kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                        kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                        db.NhapKhoes.Add(nk);
                        db.SaveChanges();
                        MessageBox.Show("Đã nhập thành công!");
                    }
                }
                else
                if (20 <= kh.SoLuongTonkho && kh.SoLuongTonkho < 200)
                {
                    DialogResult result = MessageBox.Show("Số lượng trong kho vẫn còn, bạn vẫn muốn nhập ?", "Gợi ý nhập kho!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                        kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                        db.NhapKhoes.Add(nk);
                        db.SaveChanges();
                        MessageBox.Show("Đã nhập thành công!");
                    }
                }
                else
                {
                    kh.TongSoLuongNhap = kh.TongSoLuongNhap + k.TongSoLuongNhap;
                    kh.SoLuongTonkho = kh.SoLuongTonkho + k.SoLuongTonkho;
                    db.NhapKhoes.Add(nk);
                    db.SaveChanges();
                    MessageBox.Show("Đã nhập thành công!");
                }
            }
        }
        public void Delete(string ID)
        {
            ThietBi tb = db.ThietBis.Find(ID);
            KHO kh = db.KHOes.Find(ID);
            db.ThietBis.Remove(tb);
            db.KHOes.Remove(kh);
            db.SaveChanges();
        }
        public dynamic showNhapkho(string Id)
        {
            return db.NhapKhoes.Where(p => p.ID_ThietBi == Id).Select(p => new { p.STT, p.ID_ThietBi, p.KHO.ThietBi.TenThietBi, p.SoLuongNhap, p.NgayNhap, p.GiaNhap }).ToList();
        }
        public int STTNhap()
        {
            int max = 0;
            foreach (NhapKho i in db.NhapKhoes)
            {
                if (i.STT > max)
                {
                    max = i.STT;
                }
            }
            return max + 1;
        }
        public dynamic searchNhapkho(DateTime st, DateTime end)
        {
            return db.NhapKhoes.Where(p => p.NgayNhap >= st && p.NgayNhap <= end).Select(p => new { p.STT, p.ID_ThietBi, p.KHO.ThietBi.TenThietBi, p.SoLuongNhap, p.NgayNhap, p.GiaNhap }).ToList();
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
        public dynamic search_byy(string loaithietbi, string t)
        {
            if (loaithietbi == "Tat ca")
            {
                var l2 = from ThietBi tb in db.ThietBis.ToList()
                         join KHO k in db.KHOes on tb.ID_ThietBi equals k.ID_ThietBi
                         where tb.ID_ThietBi == k.ID_ThietBi && tb.TenThietBi.Contains(t)
                         select new ThietBiView
                         {
                             ID_ThietBi = tb.ID_ThietBi,
                             TenThietBi = tb.TenThietBi,
                             NhaSX = tb.NhaSX,
                             LoaiThietBi = tb.LoaiThietBi,
                             GiaBan = (double)tb.GiaBan,
                             SoLuongTonKho = (int)k.SoLuongTonkho
                         };
                return l2.ToList();
            }
            else
            {
                var l2 = from ThietBi tb in db.ThietBis.ToList()
                         join KHO k in db.KHOes on tb.ID_ThietBi equals k.ID_ThietBi
                         where tb.ID_ThietBi == k.ID_ThietBi && tb.LoaiThietBi == loaithietbi && tb.TenThietBi.Contains(t)
                         select new ThietBiView
                         {
                             ID_ThietBi = tb.ID_ThietBi,
                             TenThietBi = tb.TenThietBi,
                             NhaSX = tb.NhaSX,
                             LoaiThietBi = tb.LoaiThietBi,
                             GiaBan = (double)tb.GiaBan,
                             SoLuongTonKho = (int)k.SoLuongTonkho
                         };
                return l2.ToList();
            }
        }
        public List<string> CBBLoaiTB()
        {
            List<string> list = new List<string>();
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
