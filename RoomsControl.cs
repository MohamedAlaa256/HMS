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
    public partial class RoomsControl : UserControl
    {
        public RoomsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void RoomsControl_Load(object sender, EventArgs e)
        {
            dgvRooms.Columns.Clear();
            dgvRooms.Rows.Clear();

            dgvRooms.Columns.Add("RoomNumber", "Room Number");
            dgvRooms.Columns.Add("RoomType", "Room Type");
            dgvRooms.Columns.Add("Price", "Price");
            dgvRooms.Columns.Add("Availability", "Availability");

            dgvRooms.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RoomNum.Text) ||
                string.IsNullOrWhiteSpace(cmbRoomType.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter all required data.");
                return;
            }

            int roomNum;
            double price;

            if (!int.TryParse(RoomNum.Text, out roomNum) || roomNum <= 0)
            {
                MessageBox.Show("Room Number must be a valid positive number.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a valid positive number.");
                return;
            }

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                string existingNumber =
                    row.Cells["RoomNumber"].Value?.ToString() ?? string.Empty;

                if (existingNumber == roomNum.ToString())
                {
                    MessageBox.Show("A room with this number already exists.");
                    return;
                }
            }

            dgvRooms.Rows.Add(
                roomNum,
                cmbRoomType.Text,
                price,
                "Available"
            );

            MessageBox.Show("Room added successfully.");

            RoomNum.Clear();
            cmbRoomType.SelectedIndex = -1;
            txtPrice.Clear();

            RoomNum.Focus();
        }
    }
}
