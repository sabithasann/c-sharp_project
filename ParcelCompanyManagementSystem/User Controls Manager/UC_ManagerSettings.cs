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
    public partial class UC_ManagerSettings : UserControl
    {
        private DataAccess Da { get; set; }
        private string UserName { get; set; }
        private string NewPassword { get; set; }

        private static Random random = new Random();

        public UC_ManagerSettings()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.pnlChangeMyPassword.Hide();
            this.pnlResetEmployeePassword.Hide();
        }

        public UC_ManagerSettings(string username) : this()
        {
            this.UserName = username;
        }

        private void btnChangeMyPassword_Click(object sender, EventArgs e)
        {
            this.pnlChangeMyPassword.Show();
            this.pnlResetEmployeePassword.Hide();
            this.ClearAll();
            this.pnlChangeMyPassword.Dock = DockStyle.Top;
        }

        private void btnResetEmployeePassword_Click(object sender, EventArgs e)
        {
            this.pnlResetEmployeePassword.Show();
            this.pnlChangeMyPassword.Hide();
            this.ClearAll();
            this.pnlResetEmployeePassword.Dock = DockStyle.Top;
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            this.pnlChangeMyPassword.Hide();
            this.pnlResetEmployeePassword.Hide();
            this.ClearAll();
        }

        private void btnCancelReset_Click(object sender, EventArgs e)
        {
            this.pnlChangeMyPassword.Hide();
            this.pnlResetEmployeePassword.Hide();
            this.ClearAll();
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrWhiteSpace(this.txtNewPassword.Text) || String.IsNullOrWhiteSpace(this.txtConfirmPassword.Text))
                return false;
            else
                return true;
        }

        private bool IsValidToReset()
        {
            if (String.IsNullOrWhiteSpace(this.txtEmployeeID.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtOldPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmPassword.Clear();
            this.txtEmployeeID.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var queryCheck = @"select * from Login where EmployeeID = '" + this.UserName + "' and Password = '" + this.txtOldPassword.Text + "';";
                var dt = this.Da.ExecuteQueryTable(queryCheck);

                if (dt.Rows.Count == 1)
                {
                    if ((this.txtNewPassword.Text == this.txtConfirmPassword.Text) && this.IsValidToSave())
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure want to Change the Password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var queryChange = @"update Login set Password = '" + this.txtNewPassword.Text + "' where EmployeeID = '" + this.UserName + "';";
                            int count = this.Da.ExecuteDMLQuery(queryChange);

                            if (count == 1)
                            {
                                MessageBox.Show("Password Changed properly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.pnlChangeMyPassword.Hide();
                                this.pnlResetEmployeePassword.Hide();
                            }
                            else
                                MessageBox.Show("Password Change failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("New Password and Confirm Password didn't match or, Empty.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtNewPassword.Clear();
                        this.txtConfirmPassword.Clear();
                    }
                    

                }
                else
                {
                    MessageBox.Show("Wrong Password!! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ClearAll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoPasswordGenerate()
        {
            this.NewPassword = Convert.ToString(random.Next(1000, 99999));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToReset())
                {
                    MessageBox.Show("Please write the Employee ID first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.AutoPasswordGenerate();

                DialogResult dialogResult = MessageBox.Show("Are you sure want to Reset the Password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var queryCheck = @"select * from Login where EmployeeID = '" + this.txtEmployeeID.Text + "';";
                    var dt = this.Da.ExecuteQueryTable(queryCheck);

                    if (dt.Rows.Count == 1)
                    {
                        var queryChange = @"update Login set Password = '" + this.NewPassword + "' where EmployeeID = '" + this.txtEmployeeID.Text + "';";
                        int count = this.Da.ExecuteDMLQuery(queryChange);

                        if (count == 1)
                        {
                            MessageBox.Show("Password Reset properly.\nYour New Password = " + this.NewPassword + "\nPlease, do remember it and use it for future login.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearAll();
                        }
                        else
                            MessageBox.Show("Password Reset failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Employee not found!! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.ClearAll();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
