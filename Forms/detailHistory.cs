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


namespace PBL3
{
    public partial class detailHistory : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public string ID { get; set; }
        public int index;
        public detailHistory(string m)
        {
            InitializeComponent();
            ID = m;
            GUI();
        }
        public void GUI()
        {
            HoaDon s = SaleHistory_BLL.Instance.getHDByID(ID);
            txt_IDHD.Text = s.ID_HoaDon;
            txtNgay.Text = s.NgayMuaHang.ToString();
            if (SaleHistory_BLL.Instance.GetKHByPhone(s.SDT) != null)
            {
                txtTenKH.Text = SaleHistory_BLL.Instance.GetKHByPhone(s.SDT).TenKH;
            }
            else
            {
                txtTenKH.Text = "Khách Hàng này đã bị xóa! ";
            }
            if (ManagerUser_BLL.Instance.GetNVByID(s.ID_NV) != null)
            {
                txt_NV.Text = ManagerUser_BLL.Instance.GetNVByID(s.ID_NV).TenNV;            
            }
            else
            {
                txt_NV.Text = "Nhân viên này đã bị xóa!";
            }
            txtPhantram.Text = SaleHistory_BLL.Instance.GetPhanTramByID(s.ID_KhuyenMai).ToString() + "%";
            txtTotal.Text = s.TongTien.ToString() + " VND";
            dataGridView1.DataSource = SaleHistory_BLL.Instance.GetDetailBillByID(ID);
        }

        private void butSalesHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
