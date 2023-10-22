using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PBL3
{
    public partial class Form2 : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public string id { get; set; }
        public Form2(string m)
        {
            InitializeComponent();
            id = m;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AddFormInPanel(object Forminpanel)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form fh = Forminpanel as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        private void butStaffInfor_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new FormStaffInfor(id));
        }


        private void butOrder_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Order(id));
        }
        int LX, LY;
        private void iconmin_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 750);
            this.Location = new Point(LX, LY);
            iconmin.Visible = false;
            iconmax.Visible = true;
        }
        private void iconmax_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmin.Visible = true;
            iconmax.Visible = false;
        }

        private void iconminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void butSalesHistory_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new SalesHistory());
        }

        private void butManageCustomer_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Customer());
        }

        private void butSetting_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Setting2());
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void iconclose_Click_1(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
    }
}
