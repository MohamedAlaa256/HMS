namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Username validation
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Enter your username.", txtUsername);
                return;
            }

            if (username.Length < 3)
            {
                ShowError("Username must be at least 3 characters.", txtUsername);
                return;
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Enter your password.", txtPassword);
                return;
            }

            if (password.Length < 8)
            {
                ShowError("Password must be at least 8 characters.", txtPassword);
                return;
            }

            if (!password.Any(char.IsLetter) || !password.Any(char.IsDigit))
            {
                ShowError("Password must contain at least one letter and one number.", txtPassword);
                return;
            }

            // Open Main Form
            MainForm frm = new MainForm();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Username";

            AcceptButton = button1;
        }

        // Display validation errors
        private void ShowError(string message, TextBox field)
        {
            MessageBox.Show(message,"Login",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            field.Focus();
            field.SelectAll();
        }
    }
}