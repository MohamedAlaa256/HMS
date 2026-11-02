using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Management_System
{
    public partial class PaymentControl : UserControl
    {
        public PaymentControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (cmbGuestName.SelectedIndex == -1)
            {
                MessageBox.Show("Select a guest name", "Validation");
                cmbGuestName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount is required", "Validation");
                txtAmount.Focus();
                return;
            }

            double amount;
            if (!double.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Amount is not valid", "Validation");
                txtAmount.Focus();
                return;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select a method", "Validation");
                cmbPaymentMethod.Focus();
                return;
            }

            if (cmbPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Payment Status", "Validation");
                cmbPaymentStatus.Focus();
                return;
            }

            
            MessageBox.Show("Payment processed successfully", "Success");
        }
    }
}   
