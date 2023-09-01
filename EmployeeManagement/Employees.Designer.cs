namespace EmployeeManagement
{
    partial class Employess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employess));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameTb = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txbDailySalary = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cbxGender = new ComboBox();
            cbxEmpDepartment = new ComboBox();
            dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtpJoinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            BtnDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1832, 156);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(607, 55);
            label1.Name = "label1";
            label1.Size = new Size(538, 45);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System 1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(1044, 247);
            label2.Name = "label2";
            label2.Size = new Size(189, 29);
            label2.TabIndex = 1;
            label2.Text = "Manage Employee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(69, 275);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 7;
            label3.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTb.Location = new Point(69, 303);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(303, 32);
            EmpNameTb.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(69, 348);
            label8.Name = "label8";
            label8.Size = new Size(151, 25);
            label8.TabIndex = 17;
            label8.Text = "Employee Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(69, 581);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 21;
            label4.Text = "Join Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(69, 496);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 19;
            label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(69, 422);
            label6.Name = "label6";
            label6.Size = new Size(188, 25);
            label6.TabIndex = 25;
            label6.Text = "Employee Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(69, 666);
            label7.Name = "label7";
            label7.Size = new Size(188, 25);
            label7.TabIndex = 23;
            label7.Text = "Employee Daily Salary";
            // 
            // txbDailySalary
            // 
            txbDailySalary.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbDailySalary.Location = new Point(69, 694);
            txbDailySalary.Name = "txbDailySalary";
            txbDailySalary.Size = new Size(303, 32);
            txbDailySalary.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 894);
            panel2.Name = "panel2";
            panel2.Size = new Size(1832, 25);
            panel2.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Male", "Female" });
            cbxGender.Location = new Point(69, 376);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(303, 33);
            cbxGender.TabIndex = 28;
            // 
            // cbxEmpDepartment
            // 
            cbxEmpDepartment.FormattingEnabled = true;
            cbxEmpDepartment.Items.AddRange(new object[] { "Male", "Female" });
            cbxEmpDepartment.Location = new Point(69, 450);
            cbxEmpDepartment.Name = "cbxEmpDepartment";
            cbxEmpDepartment.Size = new Size(303, 33);
            cbxEmpDepartment.TabIndex = 29;
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.ColumnHeadersHeight = 4;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.GridColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.Location = new Point(428, 294);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.RowTemplate.Height = 29;
            dgvEmployees.Size = new Size(1333, 432);
            dgvEmployees.TabIndex = 31;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvEmployees.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.ThemeStyle.HeaderStyle.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEmployees.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEmployees.ThemeStyle.HeaderStyle.Height = 4;
            dgvEmployees.ThemeStyle.ReadOnly = false;
            dgvEmployees.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ThemeStyle.RowsStyle.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvEmployees.ThemeStyle.RowsStyle.ForeColor = Color.White;
            dgvEmployees.ThemeStyle.RowsStyle.Height = 29;
            dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // dtpDOB
            // 
            dtpDOB.BackColor = SystemColors.Control;
            dtpDOB.Checked = true;
            dtpDOB.CustomizableEdges = customizableEdges1;
            dtpDOB.FillColor = Color.Teal;
            dtpDOB.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDOB.ForeColor = Color.White;
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(69, 524);
            dtpDOB.MaxDate = new DateTime(2023, 9, 1, 0, 0, 0, 0);
            dtpDOB.MinDate = new DateTime(1779, 1, 1, 0, 0, 0, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpDOB.Size = new Size(298, 45);
            dtpDOB.TabIndex = 32;
            dtpDOB.Value = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.BackColor = SystemColors.Control;
            dtpJoinDate.Checked = true;
            dtpJoinDate.CustomizableEdges = customizableEdges3;
            dtpJoinDate.FillColor = Color.Teal;
            dtpJoinDate.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpJoinDate.ForeColor = Color.White;
            dtpJoinDate.Format = DateTimePickerFormat.Short;
            dtpJoinDate.Location = new Point(69, 609);
            dtpJoinDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpJoinDate.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpJoinDate.Size = new Size(298, 45);
            dtpJoinDate.TabIndex = 33;
            dtpJoinDate.Value = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(88, 742);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 53);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PaleTurquoise;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnUpdate.Location = new Point(241, 742);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 53);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1401, 184);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 71;
            label9.Text = "Logout";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1337, 175);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 70;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(1239, 184);
            label10.Name = "label10";
            label10.Size = new Size(63, 25);
            label10.TabIndex = 69;
            label10.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1175, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 68;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(1034, 184);
            label11.Name = "label11";
            label11.Size = new Size(107, 25);
            label11.TabIndex = 67;
            label11.Text = "Department";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(970, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(833, 184);
            label12.Name = "label12";
            label12.Size = new Size(89, 25);
            label12.TabIndex = 65;
            label12.Text = "Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(778, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Red;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(1091, 755);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(94, 53);
            BtnDelete.TabIndex = 72;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Employess
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1832, 919);
            Controls.Add(BtnDelete);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(pictureBox4);
            Controls.Add(label11);
            Controls.Add(pictureBox3);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpJoinDate);
            Controls.Add(dtpDOB);
            Controls.Add(dgvEmployees);
            Controls.Add(cbxEmpDepartment);
            Controls.Add(cbxGender);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txbDailySalary);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Employess";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txbDailySalary;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox cbxGender;
        private ComboBox cbxEmpDepartment;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpJoinDate;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label9;
        private PictureBox pictureBox5;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label11;
        private PictureBox pictureBox3;
        private Label label12;
        private PictureBox pictureBox2;
        private Button BtnDelete;
    }
}