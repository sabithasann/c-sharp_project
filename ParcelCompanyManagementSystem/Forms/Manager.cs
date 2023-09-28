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
using ParcelCompanyManagementSystem.User_Controls;
using ParcelCompanyManagementSystem.User_Controls_Manager;

namespace ParcelCompanyManagementSystem
{
    public partial class Manager : MetroForm
    {
        private Login Log { get; set; }
        private string UserName { get; set; }
        private DataAccess Da { get; set; }
        public Manager()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.pnlAll.Controls.Clear();
            UC_ManagerHome managerHome = new UC_ManagerHome();
            this.pnlAll.Controls.Add(managerHome);
        }

        public Manager(string userName, Login log) : this()
        {
            this.UserName = userName;
            this.Log = log;
            this.ShowWelcomeName();
        }

        private void ShowWelcomeName()
        {
            try
            {
                var query = "select * from Employee where EmployeeID = '"+ this.UserName +"';";
                var dt = this.Da.ExecuteQueryTable(query);

                this.lblName.Text = dt.Rows[0]["EmployeeName"].ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnHome.Height;
            this.sidePanel.Top = this.btnHome.Top;

            this.pnlAll.Controls.Clear();
            UC_ManagerHome managerHome = new UC_ManagerHome();
            this.pnlAll.Controls.Add(managerHome);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnDashboard.Height;
            this.sidePanel.Top = this.btnDashboard.Top;

            this.pnlAll.Controls.Clear();
            UC_Dashboard DashBoard = new UC_Dashboard();
            this.pnlAll.Controls.Add(DashBoard);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnEditEmployee.Height;
            this.sidePanel.Top = this.btnEditEmployee.Top;

            this.pnlAll.Controls.Clear();
            UC_EditEmployee editEmployee = new UC_EditEmployee();
            this.pnlAll.Controls.Add(editEmployee);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnSettings.Height;
            this.sidePanel.Top = this.btnSettings.Top;

            this.pnlAll.Controls.Clear();
            UC_ManagerSettings settings = new UC_ManagerSettings(this.UserName);
            this.pnlAll.Controls.Add(settings);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnAbout.Height;
            this.sidePanel.Top = this.btnAbout.Top;
            
            this.pnlAll.Controls.Clear();
            UC_About about = new UC_About();
            this.pnlAll.Controls.Add(about);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to Log Out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                this.Log.Show();
            }
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            this.sidePanel.Hide();
            this.pnlAll.Controls.Clear();
            UC_Profile profile = new UC_Profile(this.UserName);
            this.pnlAll.Controls.Add(profile);
        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
