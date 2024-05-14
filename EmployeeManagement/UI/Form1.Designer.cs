namespace EmployeeManagement
{
    partial class frmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            employeeDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Designation = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            saveButton = new Button();
            addressTextBox = new TextBox();
            designationTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(employeeDataGridView);
            groupBox1.Controls.Add(saveButton);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(designationTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 487);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Information";
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Designation, Address });
            employeeDataGridView.ContextMenuStrip = contextMenuStrip1;
            employeeDataGridView.Location = new Point(30, 266);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.RowTemplate.Height = 29;
            employeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDataGridView.Size = new Size(721, 221);
            employeeDataGridView.TabIndex = 7;
            employeeDataGridView.RowHeaderMouseDoubleClick += employeeDataGridView_RowHeaderMouseDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Designation
            // 
            Designation.HeaderText = "Designation";
            Designation.MinimumWidth = 6;
            Designation.Name = "Designation";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(584, 196);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(108, 50);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(310, 137);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(382, 34);
            addressTextBox.TabIndex = 5;
            // 
            // designationTextBox
            // 
            designationTextBox.Location = new Point(310, 89);
            designationTextBox.Name = "designationTextBox";
            designationTextBox.Size = new Size(382, 34);
            designationTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 137);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 3;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 89);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 2;
            label2.Text = "Designation";
            label2.Click += label2_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(310, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(382, 34);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(groupBox1);
            Name = "frmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Entry";
            Load += frmEmployee_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox addressTextBox;
        private TextBox designationTextBox;
        private Label label3;
        private Label label2;
        private TextBox nameTextBox;
        private Label label1;
        private Button saveButton;
        private DataGridView employeeDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Designation;
        private DataGridViewTextBoxColumn Address;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
