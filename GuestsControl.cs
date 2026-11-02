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
    public partial class GuestsControl : UserControl
    {
        public GuestsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void GuestUserControl_Load(object sender, EventArgs e)
        {
            // Clear any default structures
            dgvGuests.Columns.Clear();
            dgvGuests.Rows.Clear();

            // Setup columns manually
            dgvGuests.Columns.Add("GuestID", "Guest ID");
            dgvGuests.Columns.Add("FullName", "Full Name");
            dgvGuests.Columns.Add("Phone", "Phone Number");
            dgvGuests.Columns.Add("Email", "Email Address");

            // Allow manual row insertions directly to the UI collection
            dgvGuests.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int guestID;
            if (string.IsNullOrWhiteSpace(txtGuestID.Text))
            {
                MessageBox.Show("Please enter a valid Guest ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuestID.Focus();
                return;
            }
            //validate that the Guest ID is a valid integer
            if (!int.TryParse(txtGuestID.Text, out guestID))
            {
                MessageBox.Show("Please enter a valid Guest ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuestID.Focus();
                return;
            }
            //validate that the guest name is not empty or whitespace
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter a valid Guest Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }
            //validate that the guest phone number is not empty or whitespace
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter a valid Phone Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }
            //validate that the guest email is not empty or whitespace
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Add the new guest to the DataGridView
            foreach (DataGridViewRow row in dgvGuests.Rows)
            {
                // Warning Fixed: Safely check for null cell values using ?. and ??
                string existingID = row.Cells["GuestID"].Value?.ToString() ?? string.Empty;
                if (existingID == guestID.ToString())
                {
                    MessageBox.Show("A guest with this ID already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            dgvGuests.Rows.Add(guestID, txtFullName.Text, txtPhone.Text, txtEmail.Text);
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGuests.CurrentRow == null)
            {
                MessageBox.Show("Please select a guest to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtGuestID.Text, out int guestID))
            {
                MessageBox.Show("Please enter a valid Guest ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGuestID.Focus();
                return;
            }
            DataGridViewRow currentRow = dgvGuests.CurrentRow;
            currentRow.Cells["GuestID"].Value = guestID;
            currentRow.Cells["FullName"].Value = txtFullName.Text;
            currentRow.Cells["Phone"].Value = txtPhone.Text;
            currentRow.Cells["Email"].Value = txtEmail.Text;

            MessageBox.Show("Guest information updated successfully.", "Edit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGuests.CurrentRow == null)
            {
                MessageBox.Show("Please select a guest to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgvGuests.Rows.Remove(dgvGuests.CurrentRow);
                MessageBox.Show("Guest deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }
        private void ClearInputs()
        {
            txtGuestID.Clear();
            txtFullName.Clear(); 
            txtPhone.Clear();
            txtEmail.Clear();
        }


    }
}
