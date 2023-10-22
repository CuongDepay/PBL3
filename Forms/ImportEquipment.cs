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
    public partial class ImportEquipment : Form
    {
        public string IDthietbi { get; set; }
        public ImportEquipment(string ID)
        {
            IDthietbi = ID;
            InitializeComponent();
            GUI();
            show();
        }
        public void GUI()
        {
            txtIDthietbi.Text = IDthietbi;
            txtTenthietbi.Text = WareHouse_BLL.Instance.GetThietBiByID(IDthietbi).TenThietBi.ToString();
            txtLoaithietbi.Text = WareHouse_BLL.Instance.GetThietBiByID(IDthietbi).LoaiThietBi.ToString();
            txtNhasx.Text = WareHouse_BLL.Instance.GetThietBiByID(IDthietbi).NhaSX.ToString();
            txtIDthietbi.Enabled = false;
            txtTenthietbi.Enabled = false;
            txtLoaithietbi.Enabled = false;
            txtNhasx.Enabled = false;
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtSoluongnhap.Text == "" && txtGianhap.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                NhapKho nk = new NhapKho()
                {
                    STT = WareHouse_BLL.Instance.STTNhap(),
                    NgayNhap = DateTime.Now,
                    ID_ThietBi = IDthietbi,
                    SoLuongNhap = Convert.ToInt32(txtSoluongnhap.Text.ToString()),
                    GiaNhap = Convert.ToInt32(txtGianhap.Text.ToString()),
                };
                ThietBi tb = new ThietBi()
                {
                    ID_ThietBi = IDthietbi,
                    GiaNhap = Convert.ToInt32(txtGianhap.Text.ToString()),
                };
                KHO kh = new KHO()
                {
                    ID_ThietBi = IDthietbi,
                    TongSoLuongNhap = Convert.ToInt32(txtSoluongnhap.Text.ToString()),
                    SoLuongTonkho = Convert.ToInt32(txtSoluongnhap.Text.ToString()),
                };
                WareHouse_BLL.Instance.NhapVaokho(tb, kh, nk);
                show();
                this.Close();
            }
        }
        public void show()
        {
            dataGridView1.DataSource = WareHouse_BLL.Instance.showNhapkho(IDthietbi);
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoluongnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
