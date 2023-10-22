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
using PBL3.Forms;


namespace PBL3
{
    public partial class AdminForm : Form
    {
        public bool isExit = true;
        public event EventHandler Logout1;
        public AdminForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnOut_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        int LX, LY;
        private void btnMax_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRes.Visible = true;
            btnMax.Visible = false;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 750); 
            this.Location = new Point(LX, LY);
            btnRes.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void MainPanel(object Formh)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form fh = Formh as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(fh);
            this.panelMain.Tag = fh;
            fh.Show();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            MainPanel(new ManagerUser());
        }

        private void btnWare_Click(object sender, EventArgs e)
        {
            MainPanel(new EquipWare());
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            MainPanel(new Discount());
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Logout1(this, new EventArgs());
        }


        private void btnRev_Click_1(object sender, EventArgs e)
        {
            MainPanel(new Reveneu());
        }

        private void butStatistics_Click(object sender, EventArgs e)
        {
            MainPanel(new Satistics());
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            MainPanel(new Setting());
        }

    }
}