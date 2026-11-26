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
    public partial class Check_inControl : UserControl
    {
        public Check_inControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnConfirmCheckIn_Click(object sender, EventArgs e)
        {   //el selected hena .text 34an mafe4 database (for testing only) bas el mafrod teb2a .selecteditem? 
            string guestName = cmbGuestName.Text.ToString();
            string roomNumber = cmbRoomNum.Text.ToString();

            if (string.IsNullOrEmpty(guestName) || string.IsNullOrEmpty(roomNumber))
            {
                MessageBox.Show("Please select a guest and a room number.");
                return;
            }

            DateTime checkInDate = dateTimePicker1.Value;
            DateTime checkOutDate = dateTimePicker2.Value;
            if (checkOutDate <= checkInDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Here you would typically save the check-in information to a database or perform other actions.
                MessageBox.Show($"Guest {guestName} has been checked into room {roomNumber} from {checkInDate.ToShortDateString()} to {checkOutDate.ToShortDateString()}.", "Check-In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
