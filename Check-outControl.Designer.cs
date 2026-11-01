namespace Hotel_Management_System
{
    partial class Check_outControl
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
            btnConfirmCheckOut = new Button();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            cmbRoomNum = new ComboBox();
            cmbGuestName = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirmCheckOut
            // 
            btnConfirmCheckOut.BackColor = Color.FromArgb(192, 0, 0);
            btnConfirmCheckOut.FlatStyle = FlatStyle.Flat;
            btnConfirmCheckOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmCheckOut.ForeColor = Color.White;
            btnConfirmCheckOut.Location = new Point(65, 392);
            btnConfirmCheckOut.Name = "btnConfirmCheckOut";
            btnConfirmCheckOut.Size = new Size(526, 32);
            btnConfirmCheckOut.TabIndex = 27;
            btnConfirmCheckOut.Text = "Confirm Check-Out";
            btnConfirmCheckOut.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(65, 335);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(526, 27);
            dateTimePicker2.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(65, 306);
            label6.Name = "label6";
            label6.Size = new Size(133, 23);
            label6.TabIndex = 24;
            label6.Text = "Check-Out Date";
            // 
            // cmbRoomNum
            // 
            cmbRoomNum.FormattingEnabled = true;
            cmbRoomNum.Location = new Point(65, 247);
            cmbRoomNum.Name = "cmbRoomNum";
            cmbRoomNum.Size = new Size(526, 28);
            cmbRoomNum.TabIndex = 22;
            // 
            // cmbGuestName
            // 
            cmbGuestName.FormattingEnabled = true;
            cmbGuestName.Location = new Point(65, 162);
            cmbGuestName.Name = "cmbGuestName";
            cmbGuestName.Size = new Size(526, 28);
            cmbGuestName.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(65, 207);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 20;
            label5.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 122);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 19;
            label3.Text = "Guest Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(255, 29);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 18;
            label1.Text = "Guest Check-Out";
            // 
            // Check_outControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 27, 38);
            Controls.Add(btnConfirmCheckOut);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(cmbRoomNum);
            Controls.Add(cmbGuestName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Check_outControl";
            Size = new Size(807, 555);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmCheckOut;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private ComboBox cmbRoomNum;
        private ComboBox cmbGuestName;
        private Label label5;
        private Label label3;
        private Label label1;
    }
}
