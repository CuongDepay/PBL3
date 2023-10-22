using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL.Admin;
using PBL3.DTO;


namespace PBL3
{
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
            cbbSearchDis.Items.AddRange((Discount_BLL.Instance.CBB().ToArray()));
            cbbSortDis.Items.AddRange((Discount_BLL.Instance.CBB_sort().ToArray()));
            GUI3();
        }

        public object[] ID_KhuyenMai { get; internal set; }
        public void Show(int id, string txt)
        {
            dataGridView1.DataSource = Discount_BLL.Instance.SearchDiscount(id, txt);
        }
        private void butSearchDis_Click(object sender, EventArgs e)
        {
            int index = cbbSearchDis.SelectedIndex;
            if (index >= 0)

            {
                Show(index, txtSearch.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính để tìm kiếm!");
            }
        }


        public void GUI(string ID)
        {
            txtID.Text = (Discount_BLL.Instance.GetDiscount(ID)).ID_KhuyenMai.ToString();
            txtName.Text = (Discount_BLL.Instance.GetDiscount(ID)).TenKhuyenMai.ToString();
            txtPercent.Text = (Discount_BLL.Instance.GetDiscount(ID)).PhanTram.ToString();
            dateTimePicker1.Value = Convert.ToDateTime((Discount_BLL.Instance.GetDiscount(ID)).NgayBatDau.ToString());
            dateTimePicker2.Value = Convert.ToDateTime((Discount_BLL.Instance.GetDiscount(ID)).NgayKetThuc.ToString());
        }
        public void Reset()
        {
            txtID.Text = "";
            txtPercent.Text = "";
            txtName.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
        public void GUI2()
        {
            txtPercent.Enabled = true;
            txtName.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            //   btn_ok.Enabled = true;
        }
        public void GUI3()
        {
            txtID.Enabled = false;
            txtPercent.Enabled = false;
            txtName.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            //   btn_ok.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID_KhuyenMai"].Value.ToString();
                GUI(ID);
                GUI3();
            }
        }
        private KhuyenMai GetKhuyenMai()
        {
            try
            {
                KhuyenMai c = new KhuyenMai()
                {
                    ID_KhuyenMai = txtID.Text.ToString(),
                    TenKhuyenMai = txtName.Text.ToString(),
                    PhanTram = Convert.ToInt32(txtPercent.Text.ToString()),
                    NgayBatDau = dateTimePicker1.Value,
                    NgayKetThuc = dateTimePicker2.Value,
                };
                return c;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!");
                return null;
            }
        }

        private void butUpDis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID_KhuyenMai"].Value.ToString();
                txtID.Enabled = false;
                GUI(ID);
                GUI2();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần chỉnh sửa!");
            }
        }

        private void butDelDis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    list.Add(i.Cells["ID_KhuyenMai"].Value.ToString());

                }
                foreach (string s in list)
                {
                    Discount_BLL.Instance.Del(s);
                }
                Show(0, " ");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi cần xóa!");
            }
        }

        private void butSortDis_Click_1(object sender, EventArgs e)
        {
            int index = cbbSortDis.SelectedIndex;
            if (index >= 0)
            {
                dataGridView1.DataSource = Discount_BLL.Instance.SortBy(index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính để sắp xếp!");
            }
        }

        private void butAddDis_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            Reset();
            butDone.Enabled = true;
            GUI2();
        }
        private void butDone_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtPercent.Text != "")
            {
                if (GetKhuyenMai() != null)
                {
                    Discount_BLL.Instance.ExcuteDB(GetKhuyenMai());
                    Show(0, "");
                    GUI3();
                }

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
        private void butReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPercent.Text = "";
            txtName.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }
        private void btnOut3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
