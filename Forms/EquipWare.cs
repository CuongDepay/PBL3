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
using PBL3.Forms;
using PBL3.DTO;

namespace PBL3
{
    public partial class EquipWare : Form
    {
        public EquipWare()
        {
            InitializeComponent();
            cbbSort.Items.AddRange(WareHouse_BLL.Instance.CBBSort().ToArray());
            cbbSearch.Items.AddRange(WareHouse_BLL.Instance.CBBSearch().ToArray());
        }

        private void btnOut2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void show()
        {
            dataGridView1.DataSource = WareHouse_BLL.Instance.showAll();
        }
        private void butAddWare_Click(object sender, EventArgs e)
        {
            detailProduct f = new detailProduct("", 0);
            f.Show();
            f.d = new detailProduct.MyDel(show);

        }

        private void butUpWare_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string Id = dataGridView1.SelectedRows[0].Cells["ID_ThietBi"].Value.ToString();
                detailProduct f = new detailProduct(Id, 2);
                f.Show();
                f.d = new detailProduct.MyDel(show);

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void butSearchWare_Click(object sender, EventArgs e)
        {

            if (cbbSearch.SelectedIndex >= 0)
            {
                string cbbloaithietbi = cbbSearch.SelectedItem.ToString();
                dataGridView1.DataSource = WareHouse_BLL.Instance.search_by(cbbloaithietbi, txtSearch.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thuộc tính loại thiết bị");
            }

        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa thiết bị này!", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        WareHouse_BLL.Instance.Delete(row.Cells["ID_ThietBi"].Value.ToString());
                    }
                    show();
                }
            }
        }

        private void butAddE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string Id = dataGridView1.SelectedRows[0].Cells["ID_ThietBi"].Value.ToString();
                ImportEquipment f = new ImportEquipment(Id);
                f.Show();
            }
            else
            {
                MessageBox.Show("Error!");
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
                MessageBox.Show("Error!");
            }
        }
        private void butSort_Click(object sender, EventArgs e)
        {
            string l = cbbSearch.SelectedItem.ToString();
            int index = cbbSort.SelectedIndex;
            if (index >= 0)
            {
                dataGridView1.DataSource = WareHouse_BLL.Instance.sort_by(l, index);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID_ThietBi"].Value.ToString();
                KHO k = WareHouse_BLL.Instance.GetKhoByID(id);
                ThietBi tb = WareHouse_BLL.Instance.GetThietBiByID(id);
                if (tb.LoaiThietBi == "Máy Tính")
                {
                    if (k.SoLuongTonkho < 10)
                    {
                        DialogResult result = MessageBox.Show("Thiết bị này sắp hết, hãy nhập thêm vào kho!", "Gợi ý nhập kho !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ImportEquipment f = new ImportEquipment(id);
                            f.Show();
                        }
                    }
                }
                else
                {
                    if (k.SoLuongTonkho < 20)
                    {
                        DialogResult result = MessageBox.Show("Thiết bị này sắp hết, hãy nhập thêm vào kho!", "Gợi ý nhập kho ! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ImportEquipment f = new ImportEquipment(id);
                            f.Show();
                        }
                    }
                }
            }

        }

        private void cbbSearch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbSearch.SelectedIndex >= 0)
            {
                string cbbloaithietbi = cbbSearch.SelectedItem.ToString();
                dataGridView1.DataSource = WareHouse_BLL.Instance.search_by(cbbloaithietbi, "");
            }
        }
    }
}