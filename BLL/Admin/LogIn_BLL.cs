using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL.Admin
{
    public class LogIn_BLL
    {
        private static LogIn_BLL _Instance;
        public static LogIn_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LogIn_BLL();
                }
                return _Instance;
            }
            set { }
        }
        public LogIn_BLL() { }
        NewDBPBL dl = new NewDBPBL();
        public TaiKhoan GetTKByUserNameAndPass(string username, string pass)
        {
            foreach (TaiKhoan i in dl.TaiKhoans)
            {
                if (i.TenTK == username && i.MatKhau == pass)
                {
                    return i;
                }
            }
            return null;
        }
        public bool CheckAdminUser(TaiKhoan i)
        {
            if (i.ChucVu == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}

