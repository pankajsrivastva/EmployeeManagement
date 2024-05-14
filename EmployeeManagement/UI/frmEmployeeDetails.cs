using EmployeeManagement.Manager;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace EmployeeManagement.UI
{
    public partial class frmEmployeeDetails : Form
    {
       
        frmEmployee frm;
        public frmEmployeeDetails(frmEmployee frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        EmployeeManager _employeeManager = new EmployeeManager();

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Please enter Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(designationTextBox.Text))
                {
                    MessageBox.Show("Please enter Designation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(addressTextBox.Text))
                {
                    MessageBox.Show("Please enter Address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nameTextBox.Focus();
                    return;
                }
                Employee employee = new Employee();
                employee.iD = Convert.ToInt32(idLabel.Text);
                employee.Name = nameTextBox.Text;
                employee.Designation = designationTextBox.Text;
                employee.Address = addressTextBox.Text;
                var status = _employeeManager.Update(employee);
                if (status)
                {
                    MessageBox.Show("Employee has been Modified", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadData();
                }
                else
                {
                    MessageBox.Show("Employee Modification Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
