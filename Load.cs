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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int starpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starpoint += 1;
            Loading.Start();
            if (starpoint > 10)
            {
                LogIn login = new LogIn();
                Loading.Stop();
                timer1.Stop();
                this.Hide();
                login.Show();
            }

        }

    }
}
