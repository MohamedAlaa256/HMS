namespace Hotel_Management_System
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            btnUsers = new Button();
            pictureBox6 = new PictureBox();
            btnPayment = new Button();
            pictureBox4 = new PictureBox();
            btnCheckOut = new Button();
            pictureBox5 = new PictureBox();
            btnCheckIn = new Button();
            pictureBox3 = new PictureBox();
            btnGuests = new Button();
            pictureBox2 = new PictureBox();
            btnRooms = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            centerPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 17, 26);
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnCheckOut);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnCheckIn);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnGuests);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 562);
            panel1.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.users;
            pictureBox7.Location = new Point(33, 496);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(60, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(42, 52, 74);
            btnUsers.BackgroundImageLayout = ImageLayout.Zoom;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(99, 494);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(90, 41);
            btnUsers.TabIndex = 11;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(33, 439);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(60, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(42, 52, 74);
            btnPayment.BackgroundImageLayout = ImageLayout.Zoom;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(99, 437);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(90, 41);
            btnPayment.TabIndex = 9;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.check_out;
            pictureBox4.Location = new Point(33, 382);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(42, 52, 74);
            btnCheckOut.BackgroundImageLayout = ImageLayout.Zoom;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.ForeColor = Color.White;
            btnCheckOut.Location = new Point(99, 380);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(90, 41);
            btnCheckOut.TabIndex = 7;
            btnCheckOut.Text = "Check-out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.check_in_64;
            pictureBox5.Location = new Point(33, 325);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(42, 52, 74);
            btnCheckIn.BackgroundImageLayout = ImageLayout.Zoom;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(99, 323);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(90, 41);
            btnCheckIn.TabIndex = 5;
            btnCheckIn.Text = "Check-in";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.guest;
            pictureBox3.Location = new Point(33, 269);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnGuests
            // 
            btnGuests.BackColor = Color.FromArgb(42, 52, 74);
            btnGuests.BackgroundImageLayout = ImageLayout.Zoom;
            btnGuests.FlatStyle = FlatStyle.Flat;
            btnGuests.ForeColor = Color.White;
            btnGuests.Location = new Point(99, 267);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(90, 41);
            btnGuests.TabIndex = 3;
            btnGuests.Text = "Guests";
            btnGuests.UseVisualStyleBackColor = false;
            btnGuests.Click += btnGuests_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.room;
            pictureBox2.Location = new Point(33, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = Color.FromArgb(42, 52, 74);
            btnRooms.BackgroundImageLayout = ImageLayout.Zoom;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(99, 209);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(90, 41);
            btnRooms.TabIndex = 0;
            btnRooms.Text = "Rooms";
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 142);
            label1.Name = "label1";
            label1.Size = new Size(228, 23);
            label1.TabIndex = 1;
            label1.Text = "Hotel Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.HMS_Hotel_Hospitality_Logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // centerPanel
            // 
            centerPanel.BackColor = Color.FromArgb(22, 27, 38);
            centerPanel.Dock = DockStyle.Fill;
            centerPanel.Location = new Point(276, 0);
            centerPanel.Name = "centerPanel";
            centerPanel.Size = new Size(737, 562);
            centerPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 562);
            Controls.Add(centerPanel);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel centerPanel;
        private Button btnRooms;
        private PictureBox pictureBox6;
        private Button btnPayment;
        private PictureBox pictureBox4;
        private Button btnCheckOut;
        private PictureBox pictureBox5;
        private Button btnCheckIn;
        private PictureBox pictureBox3;
        private Button btnGuests;
        private PictureBox pictureBox2;
        private PictureBox pictureBox7;
        private Button btnUsers;
    }
}