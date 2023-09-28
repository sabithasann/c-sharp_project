using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ParcelCompanyManagementSystem.User_Controls_Accountant
{
    public partial class UC_AccountantSettings : UserControl
    {
        private DataAccess Da { get; set; }
        private string UserName { get; set; }
        public UC_AccountantSettings()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.pnlChangeMyPassword.Hide();
        }
        public UC_AccountantSettings(string userName) : this()
        {
            this.UserName = userName;
        }
        private void ClearAll()
        {
            this.txtOldPassword.Clear();
            this.txtNewPassword.Clear();
            this.txtConfirmPassword.Clear();
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrWhiteSpace(this.txtNewPassword.Text) || String.IsNullOrWhiteSpace(this.txtConfirmPassword.Text))
                return false;
            else
                return true;
        }

        private void btnChangeMyPassword_Click(object sender, EventArgs e)
        {
            this.pnlChangeMyPassword.Show();
            this.ClearAll();
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            this.pnlChangeMyPassword.Hide();
            this.ClearAll();
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
    }
}
