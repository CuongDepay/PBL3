using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.Forms;
using PBL3.BLL.Staff;
using PBL3.BLL.Admin;

namespace PBL3
{
    public partial class Reveneu : Form
    {
        public Reveneu()
        {
            InitializeComponent();
            cbbSearchRev.Items.AddRange((Reveneu_BLL.Instance.CBBSearch().ToArray()));
            cbbSortRev.Items.AddRange((Reveneu_BLL.Instance.CBBSort().ToArray()));
        }

        private void btnOut4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowDataGrid()
        {

            dataGridView1.DataSource = Reveneu_BLL.Instance.ShowAll();
        }


        private void butSortHis_Click(object sender, EventArgs e)
        {
            int index = cbbSortRev.SelectedIndex;
            if (index >= 0)
            {
                dataGridView1.DataSource = Reveneu_BLL.Instance.Sort(index);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thuộc tính sắp xếp!");
            }
        }

        private void butSearchRev_Click(object sender, EventArgs e)
        {
            int index = cbbSearchRev.SelectedIndex;
            string txt = txtSearchRev.Text;
            DateTime begin = dateBegin.Value;
            DateTime end = dateEnd.Value;
            dataGridView1.DataSource = Reveneu_BLL.Instance.Search(index, txt, begin, end);
        }

        private void butDelRev_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String s = "Bạn có muốn xóa ?";
                String s1 = "Delete";
                MessageBoxButtons ok = MessageBoxButtons.OKCancel;
                DialogResult d = MessageBox.Show(s, s1, ok);
                if (d == DialogResult.OK)
                {
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        string ID = i.Cells["ID_HoaDon"].Value.ToString();
                        Reveneu_BLL.Instance.Delete(ID);
                    }
                    ShowDataGrid();
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xóa!");
            }
        }

        private void butDetailBill_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID_HoaDon"].Value.ToString();
                DetailBill f = new DetailBill(ID);
                f.d = new DetailBill.Mydel(ShowDataGrid);
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xem!");
                ShowDataGrid();
            }

        }

    }
}

