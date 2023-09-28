using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelCompanyManagementSystem.User_Controls
{
    public partial class UC_EditEmployee : UserControl
    {
        private DataAccess Da { get; set; }

        public UC_EditEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlSingleEmployeeDetails.Hide();
        }

        private bool IsDataValidToSearch()
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                this.pnlSingleEmployeeDetails.Hide();
                return false;
            }    
            else
                return true;
        }

        private bool IsDataValidToUpdate()
        {
            if (String.IsNullOrWhiteSpace(this.txtName.Text) || String.IsNullOrWhiteSpace(this.txtCellPhone.Text) ||
                String.IsNullOrWhiteSpace(this.txtAddress.Text) || String.IsNullOrWhiteSpace(this.txtEmail.Text) ||
                String.IsNullOrWhiteSpace(this.cmbMaritalStatus.Text) || String.IsNullOrWhiteSpace(this.cmbGender.Text) ||
                String.IsNullOrWhiteSpace(this.cmbRank.Text))
                return false;
            else
                return true;
        }

        private bool IsDataValidToUpdateManager()
        {
            if (String.IsNullOrWhiteSpace(this.txtName.Text) || String.IsNullOrWhiteSpace(this.txtCellPhone.Text) ||
                String.IsNullOrWhiteSpace(this.txtAddress.Text) || String.IsNullOrWhiteSpace(this.txtEmail.Text) ||
                String.IsNullOrWhiteSpace(this.cmbMaritalStatus.Text) || String.IsNullOrWhiteSpace(this.cmbGender.Text))
                return false;
            else
                return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSearch())
                {
                    MessageBox.Show("Please write the 'Employee ID' first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var queryShow = "select * from Employee where EmployeeID = '"+ this.txtSearch.Text.ToUpper() +"';";
                var dtShow = this.Da.ExecuteQueryTable(queryShow);

                this.pnlSingleEmployeeDetails.Hide();

                if (dtShow.Rows.Count == 1)
                {
                    this.pnlSingleEmployeeDetails.Show();
                    this.txtSearch.ReadOnly = true;

                    var query = "select * from Login where EmployeeID = '" + this.txtSearch.Text.ToUpper() + "';";
                    var dt = this.Da.ExecuteQueryTable(query);

                    if (dt.Rows[0]["EmployeeRank"].ToString() == "Manager")
                    {
                        this.lblRank.Hide();
                        this.cmbRank.Hide();

                        this.txtName.Text = dtShow.Rows[0]["EmployeeName"].ToString();
                        this.txtCellPhone.Text = dtShow.Rows[0]["EmployeeCellPhone"].ToString();
                        this.txtAddress.Text = dtShow.Rows[0]["EmployeeAddress"].ToString();
                        this.txtEmail.Text = dtShow.Rows[0]["EmployeeEmail"].ToString();
                        this.cmbMaritalStatus.Text = dtShow.Rows[0]["EmployeeMaritalStatus"].ToString();
                        this.cmbGender.Text = dtShow.Rows[0]["EmployeeGender"].ToString();
                        this.dtpBirthDate.Text = dtShow.Rows[0]["EmployeeBirthDate"].ToString();
                        this.dtpJoinDate.Text = dtShow.Rows[0]["EmployeeJoinDate"].ToString();
                    }
                    else
                    {
                        this.lblRank.Show();
                        this.cmbRank.Show();

                        this.txtName.Text = dtShow.Rows[0]["EmployeeName"].ToString();
                        this.txtCellPhone.Text = dtShow.Rows[0]["EmployeeCellPhone"].ToString();
                        this.txtAddress.Text = dtShow.Rows[0]["EmployeeAddress"].ToString();
                        this.txtEmail.Text = dtShow.Rows[0]["EmployeeEmail"].ToString();
                        this.cmbMaritalStatus.Text = dtShow.Rows[0]["EmployeeMaritalStatus"].ToString();
                        this.cmbGender.Text = dtShow.Rows[0]["EmployeeGender"].ToString();
                        this.dtpBirthDate.Text = dtShow.Rows[0]["EmployeeBirthDate"].ToString();
                        this.dtpJoinDate.Text = dtShow.Rows[0]["EmployeeJoinDate"].ToString();
                        this.cmbRank.Text = dtShow.Rows[0]["EmployeeRank"].ToString();
                    }
                        
                }
                else
                {
                    MessageBox.Show("Employee '" + this.txtSearch.Text.ToUpper() + "' not found in system!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from Login where EmployeeID = '" + this.txtSearch.Text.ToUpper() + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                DialogResult dialogResult;

                if (dt.Rows[0]["EmployeeRank"].ToString() == "Manager")
                {
                    if (!IsDataValidToUpdateManager())
                    {
                        MessageBox.Show("Please fill all the Data Field.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    dialogResult = MessageBox.Show("Are you sure want to Update your information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var queryUpdate = @"update Employee 
                                  set EmployeeName = '" + this.txtName.Text + @"', 
                                  EmployeeCellPhone = '" + this.txtCellPhone.Text + @"',
                                  EmployeeAddress = '" + this.txtAddress.Text + @"', 
                                  EmployeeEmail = '" + this.txtEmail.Text + @"', 
                                  EmployeeMaritalStatus ='" + this.cmbMaritalStatus.Text + @"', 
                                  EmployeeGender = '" + this.cmbGender.Text + @"', 
                                  EmployeeBirthDate = '" + this.dtpBirthDate.Text + @"', 
                                  EmployeeJoinDate = '" + this.dtpJoinDate.Text + @"' where EmployeeID = '" + this.txtSearch.Text.ToUpper() + "';";

                        int count = this.Da.ExecuteDMLQuery(queryUpdate);

                        if (count == 1)
                        {
                            MessageBox.Show("Data Updated properly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.pnlSingleEmployeeDetails.Hide();
                            this.txtSearch.Clear();
                            this.txtSearch.ReadOnly = false;
                        }
                        else
                            MessageBox.Show("Data Update failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!IsDataValidToUpdate())
                    {
                        MessageBox.Show("Please fill all the Data Field.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dialogResult = MessageBox.Show("Are you sure want to Update this '"+ this.txtSearch.Text.ToUpper()+"' Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var queryUpdate = @"update Employee 
                                  set EmployeeName = '" + this.txtName.Text + @"', 
                                  EmployeeCellPhone = '" + this.txtCellPhone.Text + @"',
                                  EmployeeAddress = '" + this.txtAddress.Text + @"', 
                                  EmployeeEmail = '" + this.txtEmail.Text + @"', 
                                  EmployeeMaritalStatus ='" + this.cmbMaritalStatus.Text + @"', 
                                  EmployeeGender = '" + this.cmbGender.Text + @"', 
                                  EmployeeBirthDate = '" + this.dtpBirthDate.Text + @"', 
                                  EmployeeJoinDate = '" + this.dtpJoinDate.Text + @"', 
                                  EmployeeRank = '" + this.cmbRank.Text + "' where EmployeeID = '" + this.txtSearch.Text.ToUpper() + "';";

                        int count = this.Da.ExecuteDMLQuery(queryUpdate);

                        if (count == 1)
                        {
                            MessageBox.Show("Data Updated properly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.pnlSingleEmployeeDetails.Hide();
                            this.txtSearch.Clear();
                            this.txtSearch.ReadOnly = false;
                        }
                        else
                        {
                            MessageBox.Show("Data Update failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from Login where EmployeeID = '"+ this.txtSearch.Text.ToUpper() +"';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows[0]["EmployeeRank"].ToString() == "Manager")
                {
                    MessageBox.Show("You can't Delete a Manager.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.pnlSingleEmployeeDetails.Hide();
                    this.txtSearch.Clear();
                    this.txtSearch.ReadOnly = false;
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete this '"+ this.txtSearch.Text.ToUpper()+"' Employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var queryEmployee = @"delete from Employee where EmployeeID = '" + this.txtSearch.Text.ToUpper() + "';";
                    var queryLogin = @"delete from Login where EmployeeID = '"+ this.txtSearch.Text.ToUpper() + "';";

                    int count = this.Da.ExecuteDMLQuery(queryEmployee);
                    count += this.Da.ExecuteDMLQuery(queryLogin);

                    if (count == 2)
                    {
                        MessageBox.Show("Data Deleted properly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pnlSingleEmployeeDetails.Hide();
                        this.txtSearch.Clear();
                        this.txtSearch.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Data Deletion failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.pnlSingleEmployeeDetails.Hide();
            this.txtSearch.Clear();
            this.txtSearch.ReadOnly = false;
        }

        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
