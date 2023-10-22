using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Admin;
using PBL3.DTO;

namespace PBL3.Forms
{
    public partial class Satistics : Form
    {
        public Satistics()
        {
            InitializeComponent();
            dateBeginDT.Value = DateTime.Today;
            dateEndDT.Value = DateTime.Now;
            butWeek.Select();
            cbbSortDT.Items.Add("Tên thiết bị");
            cbbSortDT.Items.Add("Số lượng bán");
            //LoadData();


        }
        private void LoadData()
        {        
                Statistics_BLL.Instance.GetNumberData(dateBeginDT.Value, dateEndDT.Value);
                txtTHD.Text = Statistics_BLL.Instance.TotalBill.ToString();
                txtTDT.Text = Statistics_BLL.Instance.TotalReveneu.ToString();
                txtTKH.Text = Statistics_BLL.Instance.TotalCustomer.ToString();
                txtTLN.Text = Statistics_BLL.Instance.TotalProfit.ToString();
                txtTSP.Text = Statistics_BLL.Instance.TotalProduct.ToString();
        }

        private void btnOutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butTC_Click(object sender, EventArgs e)
        {
            dateBeginDT.Value = DateTime.Today;
            dateEndDT.Value = DateTime.Now;
            dateBeginDT.Enabled = true;
            dateEndDT.Enabled = true;
            dataGridView1.DataSource = "";
            butXem.Visible = true;
        }

        private void butToday_Click(object sender, EventArgs e)
        {
            //bt_color(sender);
            dateBeginDT.Value = DateTime.Today;
            dateEndDT.Value = DateTime.Now;
            LoadData();
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, "", "");
        }

        private void butWeek_Click(object sender, EventArgs e)
        {
            //bt_color(sender);
            dateBeginDT.Value = DateTime.Today.AddDays(-7);
            dateEndDT.Value = DateTime.Now;
            LoadData();
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, "", "");
        }

        private void butMonth_Click(object sender, EventArgs e)
        {
            //bt_color(sender);
            dateBeginDT.Value = DateTime.Today.AddDays(-30);
            dateEndDT.Value = DateTime.Now;
            LoadData();
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, "", "");
        }

        private void butNam_Click(object sender, EventArgs e)
        {
            //bt_color(sender);
            dateBeginDT.Value = DateTime.Today.AddDays(-365);
            dateEndDT.Value = DateTime.Now;
            LoadData();
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, "", "");
        }

        private void butXem_Click(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, "", "");
        }

        private void butSearchDT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, txtSearchDT.Text, "");
        }

        private void butSortDT_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Statistics_BLL.Instance.GetDoanhThu(dateBeginDT.Value, dateEndDT.Value, txtSearchDT.Text, cbbSortDT.SelectedItem.ToString());
        }

   
    }
}
