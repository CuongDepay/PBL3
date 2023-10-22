using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DoanhThuView
    {
        public string ID_ThietBi { get; set; }
        public string TenTB { get; set; }
        public string LoaiTB { get; set; }
        public string NhaSX { get; set; }
        public int SoLuongBan { get; set; }
        public double GiaNhap { get; set; }
        public double GiaBan { get; set; }
        public DateTime NgayMuaHang { get; set; }
    }
}
