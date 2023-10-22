using PBL3.BLL.Staff;
using PBL3.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Setting2 : Form
    {
        public Setting2()
        {
            InitializeComponent();
            cbbsort.Items.AddRange(CheckWare_BLL.Instance.CBBSort().ToArray());
            cbbloaithietbi.Items.AddRange(CheckWare_BLL.Instance.CBBSearch().ToArray());
        }

        private void btnOut11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void show()
        {
            dataGridView1.DataSource = CheckWare_BLL.Instance.showAll();
        }

        private void butSearchWare_Click(object sender, EventArgs e)
        {
            if (cbbloaithietbi.SelectedIndex >= 0)
            {
                string se = cbbloaithietbi.SelectedItem.ToString();
                dataGridView1.DataSource = CheckWare_BLL.Instance.search_by(se, txtSearch.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính loại thiết bị");
            }
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            string l = cbbloaithietbi.SelectedItem.ToString();
            int index = cbbsort.SelectedIndex;
            if (index >= 0)
            {
                dataGridView1.DataSource = CheckWare_BLL.Instance.sort_by(l, index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính!");
            }
        }

        private void butView_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string Id = dataGridView1.SelectedRows[0].Cells["ID_ThietBi"].Value.ToString();
                detailProduct f = new detailProduct(Id, 1);
                f.Show();
                f.d = new detailProduct.MyDel(show);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính! ");
            }
        }

        private void cbbloaithietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaithietbi.SelectedIndex >= 0)
            {
                string se = cbbloaithietbi.SelectedItem.ToString();
                dataGridView1.DataSource = CheckWare_BLL.Instance.search_by(se, "");
            }
        }
    }
}
