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
    public partial class Check_outControl : UserControl
    {
        public Check_outControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnConfirmCheckOut_Click(object sender, EventArgs e)
        {
            string guestName = cmbGuestName.Text.ToString();
            string roomNum = cmbRoomNum.Text.ToString();
            if (string.IsNullOrEmpty(guestName) || string.IsNullOrEmpty(roomNum))
            {
                MessageBox.Show("Please select a guest name and room number.");
                return;
            }
            else
            {
                // Perform check-out logic here
                MessageBox.Show($"Guest {guestName} has been checked out from room {roomNum}.", "Check-Out Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
