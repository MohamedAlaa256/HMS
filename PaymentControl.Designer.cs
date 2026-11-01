namespace Hotel_Management_System
{
    partial class PaymentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPayment = new Button();
            cmbPaymentMethod = new ComboBox();
            cmbGuestName = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtAmount = new TextBox();
            label2 = new Label();
            cmbPaymentStatus = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Green;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(64, 480);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(526, 32);
            btnPayment.TabIndex = 35;
            btnPayment.Text = "Process Payment";
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(64, 335);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(526, 28);
            cmbPaymentMethod.TabIndex = 32;
            // 
            // cmbGuestName
            // 
            cmbGuestName.FormattingEnabled = true;
            cmbGuestName.Location = new Point(64, 163);
            cmbGuestName.Name = "cmbGuestName";
            cmbGuestName.Size = new Size(526, 28);
            cmbGuestName.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(64, 296);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 30;
            label5.Text = "Payment Method";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 123);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 29;
            label3.Text = "Guest Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(254, 30);
            label1.Name = "label1";
            label1.Size = new Size(228, 31);
            label1.TabIndex = 28;
            label1.Text = "Payment Processing";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(64, 251);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(526, 27);
            txtAmount.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 206);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 36;
            label2.Text = "Amount";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(64, 423);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(526, 28);
            cmbPaymentStatus.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(64, 384);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 38;
            label4.Text = "Payment Status";
            // 
            // PaymentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 27, 38);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label4);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(btnPayment);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(cmbGuestName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PaymentControl";
            Size = new Size(807, 555);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPayment;
        private ComboBox cmbPaymentMethod;
        private ComboBox cmbGuestName;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtAmount;
        private Label label2;
        private ComboBox cmbPaymentStatus;
        private Label label4;
    }
}
