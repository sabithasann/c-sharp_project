using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelCompanyManagementSystem
{
    public partial class UC_Profile : UserControl
    {
        private DataAccess Da { get; set; }
        private string UserName { get; set; }

        public UC_Profile()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }

        public UC_Profile(string userName) : this()
        {
            this.UserName = userName;

            this.ClearAll();
            this.LoadProfile();
        }

        private void LoadProfile()
        {
            try
            {
                var queryLoadProfile = @"select * from Employee where EmployeeID = '"+ this.UserName+"';";
                var dt = this.Da.ExecuteQueryTable(queryLoadProfile);

                this.lblID.Text = dt.Rows[0]["EmployeeID"].ToString();
                this.lblName.Text = dt.Rows[0]["EmployeeName"].ToString();
                this.lblCellPhone.Text = dt.Rows[0]["EmployeeCellPhone"].ToString();
                this.lblAddress.Text = dt.Rows[0]["EmployeeAddress"].ToString();
                this.lblEmail.Text = dt.Rows[0]["EmployeeEmail"].ToString();
                this.lblMaritalStatus.Text = dt.Rows[0]["EmployeeMaritalStatus"].ToString();
                this.lblGender.Text = dt.Rows[0]["EmployeeGender"].ToString();
                this.lblBirthOfDate.Text = dt.Rows[0]["EmployeeBirthDate"].ToString();
                this.lblJoiningDate.Text = dt.Rows[0]["EmployeeJoinDate"].ToString();
                this.lblRank.Text = dt.Rows[0]["EmployeeRank"].ToString();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            this.lblID.Text = "EmployeeName";
            this.lblName.Text = "EmployeeName";
            this.lblCellPhone.Text = "EmployeeCellPhone";
            this.lblAddress.Text = "EmployeeAddress";
            this.lblEmail.Text = "EmployeeEmail";
            this.lblMaritalStatus.Text = "EmployeeMaritalStatus";
            this.lblGender.Text = "EmployeeGender";
            this.lblBirthOfDate.Text = "EmployeeBirthDate";
            this.lblJoiningDate.Text = "EmployeeJoinDate";
            this.lblRank.Text = "EmployeeRank";
        }
    }
}
