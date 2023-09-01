namespace EmployeeManagement
{
    partial class Departments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            EditBtn = new Button();
            AddBtn = new Button();
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            DepNameTb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            lblEmployeeList = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.PaleTurquoise;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.Black;
            EditBtn.ImageAlign = ContentAlignment.TopCenter;
            EditBtn.Location = new Point(248, 522);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(94, 53);
            EditBtn.TabIndex = 54;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(95, 522);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(94, 53);
            AddBtn.TabIndex = 53;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DepList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DepList.ColumnHeadersHeight = 25;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle3;
            DepList.GridColor = Color.FromArgb(231, 229, 255);
            DepList.Location = new Point(443, 369);
            DepList.Name = "DepList";
            DepList.ReadOnly = true;
            DepList.RowHeadersVisible = false;
            DepList.RowHeadersWidth = 51;
            DepList.RowTemplate.Height = 29;
            DepList.Size = new Size(1333, 627);
            DepList.TabIndex = 50;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepList.ThemeStyle.BackColor = Color.White;
            DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 25;
            DepList.ThemeStyle.ReadOnly = true;
            DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.RowsStyle.ForeColor = Color.White;
            DepList.ThemeStyle.RowsStyle.Height = 29;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 327);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1035);
            panel2.Name = "panel2";
            panel2.Size = new Size(1832, 25);
            panel2.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(70, 428);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 39;
            label3.Text = "Department Name";
            // 
            // DepNameTb
            // 
            DepNameTb.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepNameTb.Location = new Point(70, 467);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(298, 32);
            DepNameTb.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(974, 275);
            label2.Name = "label2";
            label2.Size = new Size(222, 29);
            label2.TabIndex = 37;
            label2.Text = "Manage Departments";
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
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1832, 156);
            panel1.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(1006, 327);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 55;
            label4.Text = "Department List";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(663, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // lblEmployeeList
            // 
            lblEmployeeList.AutoSize = true;
            lblEmployeeList.Cursor = Cursors.Hand;
            lblEmployeeList.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeList.ForeColor = Color.Teal;
            lblEmployeeList.Location = new Point(718, 184);
            lblEmployeeList.Name = "lblEmployeeList";
            lblEmployeeList.Size = new Size(89, 25);
            lblEmployeeList.TabIndex = 57;
            lblEmployeeList.Text = "Employee";
            lblEmployeeList.Click += lblEmployeeList_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(919, 184);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 59;
            label6.Text = "Department";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(855, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(1124, 184);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 61;
            label7.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1060, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 60;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(1286, 184);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 63;
            label8.Text = "Logout";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1222, 175);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 62;
            pictureBox5.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PaleVioletRed;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(158, 602);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 53);
            btnDelete.TabIndex = 64;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1832, 1060);
            Controls.Add(btnDelete);
            Controls.Add(label8);
            Controls.Add(pictureBox5);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(lblEmployeeList);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(DepNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private TextBox DepNameTb;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
        private Label lblEmployeeList;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label8;
        private PictureBox pictureBox5;
        private Button btnDelete;
    }
}