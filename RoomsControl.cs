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


        private List<Room> rooms = new List<Room>();
        public event Action<Room> RoomUpdated;
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
                    MessageBox.Show(" room with this number already exists.");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to edit.");
                return;
            }

            if (string.IsNullOrWhiteSpace(RoomNum.Text) ||
                string.IsNullOrWhiteSpace(cmbRoomType.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please enter all required data.");
                return;
            }

            double price;

            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than 0.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to save the changes?",
                "Confirm Edit",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            int index = dgvRooms.SelectedRows[0].Index;

            Room r = rooms[index];

            r.RoomNumber = RoomNum.Text.Trim();
            r.RoomType = cmbRoomType.Text.Trim();
            r.Price = price;
            r.Status = cmbStatus.Text.Trim();

            RoomUpdated?.Invoke(r);

            MessageBox.Show("Room updated successfully.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvRooms.CurrentRow?.Index ?? -1;
         

                if (index == -1 || index >= rooms.Count)
                {
                    MessageBox.Show("Please select a room to delete");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this room?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    rooms.RemoveAt(index);

                    dgvRooms.DataSource = null;
                    dgvRooms.DataSource = rooms;

                    MessageBox.Show("Room deleted successfully");
                }
            }

        }
    }

