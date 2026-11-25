using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace Hotel_Management_System
{
    public partial class UsersControl : UserControl
    {
        public UsersControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            label2.Text = "Users Management";

            txtUsername.Multiline = false;
            txtFullName.Multiline = false;
            txtPassword.Multiline = false;
            txtPassword.UseSystemPasswordChar = true;

            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Admin", "Receptionist" });

            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("FullName", "Full Name");
            dgvUsers.Columns.Add("Role", "Role");
            dgvUsers.Columns.Add("Password", "Password");
            dgvUsers.Columns["Password"].Visible = false;
            dgvUsers.ReadOnly = true;
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.MultiSelect = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsers.CellClick += dgvUsers_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void dgvUsers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
            txtUsername.Text = (string)row.Cells["Username"].Value;
            txtFullName.Text = (string)row.Cells["FullName"].Value;
            cmbRole.SelectedItem = row.Cells["Role"].Value;
            txtPassword.Clear();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (!IsValid(true, null)) return;

            dgvUsers.Rows.Add(txtUsername.Text.Trim(), txtFullName.Text.Trim(), cmbRole.Text, txtPassword.Text);
            ClearForm();
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? row = SelectedRow();
            if (row == null)
            {
                Fail("Click a user in the list first.", dgvUsers);
                return;
            }
            if (!IsValid(false, row)) return;

            row.Cells["Username"].Value = txtUsername.Text.Trim();
            row.Cells["FullName"].Value = txtFullName.Text.Trim();
            row.Cells["Role"].Value = cmbRole.Text;
            if (txtPassword.Text.Length > 0)
            {
                row.Cells["Password"].Value = txtPassword.Text;
            }
            ClearForm();
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            DataGridViewRow? row = SelectedRow();
            if (row == null)
            {
                Fail("Click a user in the list first.", dgvUsers);
                return;
            }

            DialogResult answer = MessageBox.Show($"Delete user '{row.Cells["Username"].Value}'?", "Users",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            dgvUsers.Rows.Remove(row);
            ClearForm();
        }

        private bool IsValid(bool passwordRequired, DataGridViewRow? editing)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (!Regex.IsMatch(username, @"^[A-Za-z][A-Za-z0-9._]{2,19}$"))
                return Fail("Username must be 3 to 20 characters, start with a letter, and use only letters, numbers, dots, and underscores.", txtUsername);

            bool taken = dgvUsers.Rows.Cast<DataGridViewRow>().Any(r =>
                r != editing && string.Equals((string)r.Cells["Username"].Value, username, StringComparison.OrdinalIgnoreCase));
            if (taken)
                return Fail("That username is already taken.", txtUsername);

            if (!Regex.IsMatch(txtFullName.Text.Trim(), @"^[\p{L} .'-]{2,50}$"))
                return Fail("Full name must be 2 to 50 characters, using only letters, spaces, dots, hyphens, and apostrophes.", txtFullName);

            if (cmbRole.SelectedIndex == -1)
                return Fail("Choose a role.", cmbRole);

            bool checkPassword = passwordRequired || password.Length > 0;
            if (checkPassword && !Regex.IsMatch(password, @"^(?=.*\p{L})(?=.*\d)\S{8,}$"))
                return Fail("Password must be at least 8 characters with a letter and a number, and no spaces.", txtPassword);

            return true;
        }

        private DataGridViewRow? SelectedRow()
        {
            return dgvUsers.SelectedRows.Count > 0 ? dgvUsers.SelectedRows[0] : null;
        }

        private bool Fail(string message, Control field)
        {
            MessageBox.Show(message, "Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            field.Focus();
            (field as TextBox)?.SelectAll();
            return false;
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtFullName.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            dgvUsers.ClearSelection();
        }
    }
}
