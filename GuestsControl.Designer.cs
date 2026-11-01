namespace Hotel_Management_System
{
    partial class GuestsControl
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
            label2 = new Label();
            txtPhone = new TextBox();
            txtGuestID = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label5 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label6 = new Label();
            dgvRooms = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(229, 23);
            label2.Name = "label2";
            label2.Size = new Size(233, 31);
            label2.TabIndex = 1;
            label2.Text = "Guests Management";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(63, 223);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(256, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtGuestID
            // 
            txtGuestID.Location = new Point(63, 138);
            txtGuestID.Multiline = true;
            txtGuestID.Name = "txtGuestID";
            txtGuestID.Size = new Size(263, 27);
            txtGuestID.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(63, 189);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 8;
            label4.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 99);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 7;
            label1.Text = "Guest ID";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(363, 223);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(363, 138);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(263, 27);
            txtFullName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(363, 189);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(363, 99);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 11;
            label5.Text = "Full Name";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(462, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 32);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 64, 64);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(269, 279);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 32);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(70, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 32);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(69, 321);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 19;
            label6.Text = "Guests List";
            // 
            // dgvRooms
            // 
            dgvRooms.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(70, 347);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(569, 188);
            dgvRooms.TabIndex = 18;
            // 
            // GuestsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 27, 38);
            Controls.Add(label6);
            Controls.Add(dgvRooms);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(txtGuestID);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "GuestsControl";
            Size = new Size(807, 555);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtGuestID;
        private Label label4;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private Label label3;
        private Label label5;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label6;
        private DataGridView dgvRooms;
    }
}
