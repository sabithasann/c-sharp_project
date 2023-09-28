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
using ParcelCompanyManagementSystem.User_Controls_Accountant;

namespace ParcelCompanyManagementSystem.Forms
{
    public partial class Accountant : MetroForm
    {
        private Login Log { get; set; }
        private string UserName { get; set; }
        private DataAccess Da { get; set; }
        public Accountant()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            UC_AccountantHome accountantHome = new UC_AccountantHome();
            this.pnlAll.Controls.Add(accountantHome);
        }

        public Accountant(string userName, Login log) : this()
        {
            this.UserName = userName;
            this.Log = log;
            this.ShowWelcomeName();
        }

        private void ShowWelcomeName()
        {
            try
            {
                var query = "select * from Employee where EmployeeID = '" + this.UserName + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                this.lblName.Text = dt.Rows[0][1].ToString();
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
            UC_AccountantHome accountantHome = new UC_AccountantHome();
            this.pnlAll.Controls.Add(accountantHome);
        }


        private void btnEarnings_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnEarnings.Height;
            this.sidePanel.Top = this.btnEarnings.Top;
            
            this.pnlAll.Controls.Clear();
            UC_CompanyEarnings earnings = new UC_CompanyEarnings();
            this.pnlAll.Controls.Add(earnings);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnSettings.Height;
            this.sidePanel.Top = this.btnSettings.Top;
            
            this.pnlAll.Controls.Clear();
            UC_AccountantSettings accountantSettings = new UC_AccountantSettings(this.UserName);
            this.pnlAll.Controls.Add(accountantSettings);
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

        private void btnCashout_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnCashout.Height;
            this.sidePanel.Top = this.btnCashout.Top;

            this.pnlAll.Controls.Clear();
            User_Controls.UC_MerchantCashout merchCashout = new User_Controls.UC_MerchantCashout();
            this.pnlAll.Controls.Add(merchCashout);
        }

        private void Accountant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
