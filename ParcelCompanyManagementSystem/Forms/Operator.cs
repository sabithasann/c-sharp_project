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
using ParcelCompanyManagementSystem.User_Controls_Accountant;
using ParcelCompanyManagementSystem.User_Controls_Operator;

namespace ParcelCompanyManagementSystem.Forms
{
    public partial class Operator : MetroForm
    {
        private Login Log { get; set; }
        private string UserName { get; set; }
        private DataAccess Da { get; set; }
        public Operator()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.pnlAll.Controls.Clear();
            UC_OperatorHome operatorHome = new UC_OperatorHome();
            this.pnlAll.Controls.Add(operatorHome);
        }

        public Operator(string userName, Login log) : this()
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
            UC_OperatorHome operatorHome = new UC_OperatorHome();
            this.pnlAll.Controls.Add(operatorHome);
        }

        private void btnMerchant_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnMerchant.Height;
            this.sidePanel.Top = this.btnMerchant.Top;

            this.pnlAll.Controls.Clear();
            UC_Merchant Merchant = new UC_Merchant();
            this.pnlAll.Controls.Add(Merchant);
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnSettings.Height;
            this.sidePanel.Top = this.btnSettings.Top;

            this.pnlAll.Controls.Clear();
            UC_OperatorSettings settings = new UC_OperatorSettings(this.UserName);
            this.pnlAll.Controls.Add(settings);
        }

        private void btnAddParcel_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnAddParcel.Height;
            this.sidePanel.Top = this.btnAddParcel.Top;

            this.pnlAll.Controls.Clear();
            UC_AddParcel addParcel = new UC_AddParcel(this.UserName);
            this.pnlAll.Controls.Add(addParcel);
        }

        private void btnTrackParcel_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnTrackParcel.Height;
            this.sidePanel.Top = this.btnTrackParcel.Top;

            this.pnlAll.Controls.Clear();
            UC_TrackParcel trackParcel = new UC_TrackParcel();
            this.pnlAll.Controls.Add(trackParcel);
        }

        private void btnEditParcel_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnEditParcel.Height;
            this.sidePanel.Top = this.btnEditParcel.Top;

            this.pnlAll.Controls.Clear();
            UC_EditParcel editParcel = new UC_EditParcel(this.UserName);
            this.pnlAll.Controls.Add(editParcel);
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

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            this.sidePanel.Hide();
            this.pnlAll.Controls.Clear();
            UC_Profile profile = new UC_Profile(this.UserName);
            this.pnlAll.Controls.Add(profile);
        }

        private void btnSearchParcel_Click(object sender, EventArgs e)
        {
            this.sidePanel.Show();
            this.sidePanel.Height = this.btnSearchParcel.Height;
            this.sidePanel.Top = this.btnSearchParcel.Top;

            this.pnlAll.Controls.Clear();
            UC_SearchParcel searchParcel = new UC_SearchParcel();
            this.pnlAll.Controls.Add(searchParcel);
        }

        private void Operator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
