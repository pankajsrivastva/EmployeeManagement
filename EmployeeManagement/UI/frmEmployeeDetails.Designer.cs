namespace EmployeeManagement.UI
{
    partial class frmEmployeeDetails
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
            groupBox1 = new GroupBox();
            idLabel = new Label();
            updateButton = new Button();
            addressTextBox = new TextBox();
            designationTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 128, 0);
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(updateButton);
            groupBox1.Controls.Add(addressTextBox);
            groupBox1.Controls.Add(designationTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 352);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Information";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(594, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 28);
            idLabel.TabIndex = 14;
            idLabel.Visible = false;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(550, 235);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(108, 50);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(276, 176);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(382, 34);
            addressTextBox.TabIndex = 12;
            // 
            // designationTextBox
            // 
            designationTextBox.Location = new Point(276, 128);
            designationTextBox.Name = "designationTextBox";
            designationTextBox.Size = new Size(382, 34);
            designationTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 176);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 128);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 9;
            label2.Text = "Designation";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(276, 84);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(382, 34);
            nameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 87);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // frmEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 376);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEmployeeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEmployeeDetails";
            Load += frmEmployeeDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button updateButton;
        public TextBox addressTextBox;
        public TextBox designationTextBox;
        public Label label3;
        public Label label2;
        public TextBox nameTextBox;
        public Label label1;
        public Label idLabel;
    }
}