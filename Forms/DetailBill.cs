using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Staff;
using PBL3.BLL.Admin;
using PBL3.DTO;

namespace PBL3.Forms
{
    public partial class DetailBill : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public string ID { get; set; }
        public int index;
        public DetailBill(string m)
        {
            InitializeComponent();
            ID = m;
            GUI();
        }
        public void GUI()
        {
            /*Loi*/
            HoaDon s = SaleHistory_BLL.Instance.getHDByID(ID);
            txtIDHDRev.Text = s.ID_HoaDon;
            txtDateRev.Text = s.NgayMuaHang.ToString();
            txtIDKMRev.Text = s.ID_KhuyenMai;
            txtIDNVRev.Text = s.ID_NV;

            if (SaleHistory_BLL.Instance.GetKHByPhone(s.SDT) != null)
            {
                txtTKHRev.Text = SaleHistory_BLL.Instance.GetKHByPhone(s.SDT).TenKH;
            }
            else
            {
                txtTKHRev.Text = "Khách Hàng đã bị xóa !";
            }
            if (ManagerUser_BLL.Instance.GetNVByID(s.ID_NV) != null)
            {
                txtNameRev.Text = ManagerUser_BLL.Instance.GetNVByID(s.ID_NV).TenNV;
            }
            else
            {
                txtNameRev.Text = "Nhân viên đã bị xóa !";
            }
            txtKMRev.Text = SaleHistory_BLL.Instance.GetPhanTramByID(s.ID_KhuyenMai).ToString() + "%";
            txtTotalRev.Text = s.TongTien.ToString() + " VND";
            dataGridView1.DataSource = Reveneu_BLL.Instance.GetDetailBillByID(ID);
        }
        }

    }


