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


namespace PBL3
{
    public partial class SalesHistory : Form
    {
        public SalesHistory()
        {
            InitializeComponent();
            cbbSearchHis.Items.AddRange((SaleHistory_BLL.Instance.CBBSearch().ToArray()));
            cbbSortHis.Items.AddRange((SaleHistory_BLL.Instance.CBBSort().ToArray()));
        }
        public void ShowDataGrid()
        {

            dataGridView1.DataSource = SaleHistory_BLL.Instance.ShowAll();
        }


        private void btnOut10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butViewHis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string ID = dataGridView1.SelectedRows[0].Cells["ID_HoaDon"].Value.ToString();
                detailHistory f = new detailHistory(ID);
                f.d = new detailHistory.Mydel(ShowDataGrid);
                f.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xem!");
                ShowDataGrid();
            }
        }

        private void butSearchHis_Click(object sender, EventArgs e)
        {
            int index = cbbSearchHis.SelectedIndex;
            string txt = txtSearchHis.Text;
            DateTime begin = dateBeginHis.Value;
            DateTime end = dateEndHis.Value;
            dataGridView1.DataSource = SaleHistory_BLL.Instance.Search(index, txt, begin, end);
        }

        private void butSortHis_Click(object sender, EventArgs e)
        {
            int index = cbbSortHis.SelectedIndex;
            if (index >= 0)
            {
                dataGridView1.DataSource = SaleHistory_BLL.Instance.Sort(index);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thuộc tính sắp xếp!");
            }
        }
    }
}
