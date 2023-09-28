using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelCompanyManagementSystem.User_Controls_Accountant
{
    public partial class UC_CompanyEarnings : UserControl
    {
        private DataAccess Da { get; set; }

        public UC_CompanyEarnings()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string query = "select p.ParcelID, p.MerchantID, m.MerchantName, p.ParcelType, p.DeliveryFees, p.ConditionalAmountFees, p.TotalFees, p.EmployeeID, e.EmployeeRank from Parcel p, Employee e, Merchant m where p.EmployeeID = e.EmployeeID and p.MerchantID = m.MerchantID and p.ParcelStatus = 'Delivered';")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);

                this.dgvAutoSearch.AutoGenerateColumns = false;
                this.dgvAutoSearch.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtAutoSearchBy.Clear();
            this.cmbSearchSelection.SelectedIndex = -1;
        }

        private void cmbSearchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtAutoSearchBy.Clear();
        }

        private void txtAutoSearchBy_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbSearchSelection.SelectedIndex != -1)
            {
                if (this.cmbSearchSelection.Text == "Employee ID")
                {
                    try
                    {
                        var query = "select p.ParcelID, p.MerchantID, m.MerchantName, p.ParcelType, p.DeliveryFees, p.ConditionalAmountFees, p.TotalFees, p.EmployeeID, e.EmployeeRank from Parcel p, Employee e, Merchant m where p.EmployeeID = e.EmployeeID and p.MerchantID = m.MerchantID and p.ParcelStatus = 'Delivered' and p.EmployeeID like '" + this.txtAutoSearchBy.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (this.cmbSearchSelection.Text == "Employee Rank")
                {
                    try
                    {

                        var query = "select p.ParcelID, p.MerchantID, m.MerchantName, p.ParcelType, p.DeliveryFees, p.ConditionalAmountFees, p.TotalFees, p.EmployeeID, e.EmployeeRank from Parcel p, Employee e, Merchant m where p.EmployeeID = e.EmployeeID and p.MerchantID = m.MerchantID and p.ParcelStatus = 'Delivered' and e.EmployeeRank like '" + this.txtAutoSearchBy.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.cmbSearchSelection.Text == "Merchant ID")
                {
                    try
                    {
                        var query = "select p.ParcelID, p.MerchantID, m.MerchantName, p.ParcelType, p.DeliveryFees, p.ConditionalAmountFees, p.TotalFees, p.EmployeeID, e.EmployeeRank from Parcel p, Employee e, Merchant m where p.EmployeeID = e.EmployeeID and p.MerchantID = m.MerchantID and p.ParcelStatus = 'Delivered' and p.MerchantID like '" + this.txtAutoSearchBy.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        var query = "select p.ParcelID, p.MerchantID, m.MerchantName, p.ParcelType, p.DeliveryFees, p.ConditionalAmountFees, p.TotalFees, p.EmployeeID, e.EmployeeRank from Parcel p, Employee e, Merchant m where p.EmployeeID = e.EmployeeID and p.MerchantID = m.MerchantID and p.ParcelStatus = 'Delivered' and p.ParcelType like '" + this.txtAutoSearchBy.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select the 'Search By' field first. (Merchant ID, Employee ID or, Employee Rank)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
