using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadPage(UserControl page)
        {
            centerPanel.Controls.Clear();

            page.Dock = DockStyle.Fill;

            centerPanel.Controls.Add(page);
            page.BringToFront();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            LoadPage(new RoomsControl());
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            LoadPage(new GuestsControl());
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            LoadPage(new Check_inControl());
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            LoadPage(new Check_outControl());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            LoadPage(new PaymentControl());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadPage(new UsersControl());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
