namespace Hotel_Management_System
{
    partial class UsersControl
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
            label6 = new Label();
            dgvUsers = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(64, 318);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 33;
            label6.Text = "Users List";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(65, 344);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(569, 188);
            dgvUsers.TabIndex = 32;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(457, 276);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 32);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 64, 64);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(264, 276);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 32);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(65, 276);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 32);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(358, 135);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 27);
            txtPassword.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(358, 186);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 26;
            label3.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(358, 96);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 25;
            label5.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(65, 220);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(256, 27);
            txtFullName.TabIndex = 24;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(58, 135);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 27);
            txtUsername.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 186);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 22;
            label4.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 96);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 21;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(224, 20);
            label2.Name = "label2";
            label2.Size = new Size(233, 31);
            label2.TabIndex = 20;
            label2.Text = "Guests Management";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(358, 220);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(263, 28);
            cmbRole.TabIndex = 40;
            // 
            // UsersControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 27, 38);
            Controls.Add(cmbRole);
            Controls.Add(label6);
            Controls.Add(dgvUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "UsersControl";
            Size = new Size(807, 555);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView dgvUsers;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtPassword;
        private Label label3;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private Label label4;
        private Label label1;
        private Label label2;
        private ComboBox cmbRole;
    }
}
