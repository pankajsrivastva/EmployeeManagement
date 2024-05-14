using EmployeeManagement.Manager;
using EmployeeManagement.Models;
using EmployeeManagement.UI;
using System.Drawing.Text;

namespace EmployeeManagement
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        EmployeeManager _employeeManager = new EmployeeManager();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
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
                employee.Name = nameTextBox.Text;
                employee.Designation = designationTextBox.Text;
                employee.Address = addressTextBox.Text;

                if (_employeeManager.Add(employee))
                {
                    MessageBox.Show("Employee has been saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Employee saved Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            nameTextBox.Text = String.Empty;
            designationTextBox.Clear();
            addressTextBox.Clear();
            LoadData();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            var employees = _employeeManager.GetAll();
            employeeDataGridView.Rows.Clear();
            foreach (var employee in employees)
            {
                employeeDataGridView.Rows.Add(employee.iD, employee.Name, employee.Designation, employee.Address);
            }
        }

        private void employeeDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = employeeDataGridView.SelectedRows[0];
                frmEmployeeDetails frm = new frmEmployeeDetails(this);
                /*this.Hide();
                frmEmployeeDetails.Show();*/
                frm.idLabel.Text = dr.Cells[0].Value.ToString();
                frm.nameTextBox.Text = dr.Cells[1].Value.ToString();
                frm.designationTextBox.Text = dr.Cells[2].Value.ToString();
                frm.addressTextBox.Text = dr.Cells[3].Value.ToString();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = employeeDataGridView.SelectedRows[0];
                if (MessageBox.Show("Do you Want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) ;
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _employeeManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Employee has been removed.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); 
                    }
                    else
                    {
                        MessageBox.Show("Employee removed Failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
