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
using PBL3.DTO;



namespace PBL3
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            cbbSapXep.Items.Add("TenKH");
            cbbSapXep.Items.Add("DiaChi");
        }
        private void btnOut9_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void Reset()
        {
            txtTenKH.Text = "";
            txtSDT.Enabled = true;
            txtSDT.Text = "";
            txtDC.Text = "";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string sdt = dataGridView1.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtSDT.Text = sdt;
                txtSDT.Enabled = false;
                txtTenKH.Text = Customer_BLL.Instance.GetKHBySDT(sdt).TenKH;
                txtDC.Text = Customer_BLL.Instance.GetKHBySDT(sdt).DiaChi;
            }
        }

        private void butXem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customer_BLL.Instance.GetALLKH();
        }


        private void butThem_Click_1(object sender, EventArgs e)
        {
            if (txtSDT.Text != ""&& txtTenKH.Text != "")
            {
                KhachHang kh = new KhachHang()
                {
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDC.Text
                };
                Customer_BLL.Instance.Them(kh);
                Reset();
                dataGridView1.DataSource = Customer_BLL.Instance.GetALLKH();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin khách hàng cần thêm!");
            }
        }

        private void butSua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                KhachHang kh = new KhachHang()
                {
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDC.Text
                };
                Customer_BLL.Instance.Sua(kh);
                Reset();
                dataGridView1.DataSource = Customer_BLL.Instance.GetALLKH();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần chỉnh sửa!");
            }
        }



        private void butXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    string sdt = r.Cells["SDT"].Value.ToString();
                    Customer_BLL.Instance.Xoa(sdt);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần xóa!");
            }
            Reset();
            dataGridView1.DataSource = Customer_BLL.Instance.GetALLKH();



        }

        private void butTKiem_Click_1(object sender, EventArgs e)
        {
            string txt = txtTKiem.Text;
            dataGridView1.DataSource = Customer_BLL.Instance.TimKiem(txt);
            txtTKiem.Text = "";
        }

        private void butSapXep_Click_1(object sender, EventArgs e)
        {
            string txt = cbbSapXep.SelectedItem.ToString();
            dataGridView1.DataSource = Customer_BLL.Instance.SapXep(txt);
            cbbSapXep.Text = "";
        }


        private void butLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            dataGridView1.DataSource = Customer_BLL.Instance.GetALLKH();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void butThem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}