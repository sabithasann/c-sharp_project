using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ParcelCompanyManagementSystem.Forms;

namespace ParcelCompanyManagementSystem
{
    public partial class Login : MetroForm
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from Login where EmployeeID = '"+ this.txtUserName.Text +"' and Password = '"+ this.txtPassword.Text +"';";
                var dt = this.Da.ExecuteQueryTable(query);
                
                this.txtUserName.Clear();
                this.txtPassword.Clear();
                
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0]["EmployeeRank"].ToString() == "Manager")
                    {
                        new Manager(dt.Rows[0]["EmployeeID"].ToString(),this).Show();
                        this.Hide();
                    }

                    else if (dt.Rows[0]["EmployeeRank"].ToString() == "Operator")
                    {
                        new Operator(dt.Rows[0]["EmployeeID"].ToString(), this).Show();
                        this.Hide();
                    }

                    else if(dt.Rows[0]["EmployeeRank"].ToString() == "Accountant")
                    {
                        new Accountant(dt.Rows[0]["EmployeeID"].ToString(), this).Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("An error has been occured, please try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
