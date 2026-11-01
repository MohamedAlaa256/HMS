namespace Hotel_Management_System
{
    partial class Check_inControl
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
            label1 = new Label();
            cmbRoomNum = new ComboBox();
            cmbGuestName = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnConfirmCheckIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 34);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 1;
            label1.Text = "Guest Check-In";
            // 
            // cmbRoomNum
            // 
            cmbRoomNum.FormattingEnabled = true;
            cmbRoomNum.Location = new Point(63, 254);
            cmbRoomNum.Name = "cmbRoomNum";
            cmbRoomNum.Size = new Size(526, 28);
            cmbRoomNum.TabIndex = 12;
            // 
            // cmbGuestName
            // 
            cmbGuestName.FormattingEnabled = true;
            cmbGuestName.Location = new Point(63, 169);
            cmbGuestName.Name = "cmbGuestName";
            cmbGuestName.Size = new Size(526, 28);
            cmbGuestName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(63, 214);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 10;
            label5.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 129);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 9;
            label3.Text = "Guest Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 307);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 13;
            label4.Text = "Check-In Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(339, 307);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 14;
            label6.Text = "Check-Out Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 342);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(339, 342);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 16;
            // 
            // btnConfirmCheckIn
            // 
            btnConfirmCheckIn.BackColor = Color.Green;
            btnConfirmCheckIn.FlatStyle = FlatStyle.Flat;
            btnConfirmCheckIn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmCheckIn.ForeColor = Color.White;
            btnConfirmCheckIn.Location = new Point(63, 399);
            btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            btnConfirmCheckIn.Size = new Size(526, 32);
            btnConfirmCheckIn.TabIndex = 17;
            btnConfirmCheckIn.Text = "Confirm Check-In";
            btnConfirmCheckIn.UseVisualStyleBackColor = false;
            // 
            // Check_inControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 27, 38);
            Controls.Add(btnConfirmCheckIn);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cmbRoomNum);
            Controls.Add(cmbGuestName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Check_inControl";
            Size = new Size(807, 555);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbRoomNum;
        private ComboBox cmbGuestName;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnConfirmCheckIn;
    }
}
