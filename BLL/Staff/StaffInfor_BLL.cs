using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.BLL;
using PBL3.DTO;



namespace PBL3.BLL.Staff
{
    public class StaffInfor_BLL
    {
        NewDBPBL dl = new NewDBPBL();
        private static StaffInfor_BLL _Instance;
        public static StaffInfor_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StaffInfor_BLL();
                }
                return _Instance;
            }
            set { }
        }
        public StaffInfor_BLL() { }
    }
}