namespace Hotel_Management_System
{
    partial class RoomsControl
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            RoomNum = new TextBox();
            txtPrice = new TextBox();
            cmbRoomType = new ComboBox();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvRooms = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(213, 19);
            label1.Name = "label1";
            label1.Size = new Size(235, 31);
            label1.TabIndex = 0;
            label1.Text = "Rooms Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 87);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 1;
            label2.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(351, 87);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 2;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 177);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(345, 177);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 4;
            label5.Text = "Status";
            // 
            // RoomNum
            // 
            RoomNum.Location = new Point(66, 126);
            RoomNum.Multiline = true;
            RoomNum.Name = "RoomNum";
            RoomNum.Size = new Size(263, 27);
            RoomNum.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(66, 211);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(256, 27);
            txtPrice.TabIndex = 6;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(351, 125);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(263, 28);
            cmbRoomType.TabIndex = 7;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(351, 210);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(263, 28);
            cmbStatus.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(65, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(164, 32);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 64, 64);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(266, 264);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(164, 32);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(450, 264);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 32);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(65, 340);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(569, 188);
            dgvRooms.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(65, 314);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 13;
            label6.Text = "Rooms List";
            // 
            // RoomsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 27, 38);
            Controls.Add(label6);
            Controls.Add(dgvRooms);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbStatus);
            Controls.Add(cmbRoomType);
            Controls.Add(txtPrice);
            Controls.Add(RoomNum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RoomsControl";
            Size = new Size(807, 555);
            Load += RoomsControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox RoomNum;
        private TextBox txtPrice;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvRooms;
        private Label label6;
    }
}
