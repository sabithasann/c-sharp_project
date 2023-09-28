using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelCompanyManagementSystem.User_Controls_Operator
{
    public partial class UC_SearchParcel : UserControl
    {
        private DataAccess Da { get; set; }
        public UC_SearchParcel()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        private void PopulateGridView(string query = "select * from Parcel;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);

                this.dgvParcelDetails.AutoGenerateColumns = false;
                this.dgvParcelDetails.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtAutoSearch.Clear();
            this.cmbSearchSelection.SelectedIndex = -1;
        }

        private void cmbSearchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtAutoSearch.Clear();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.cmbSearchSelection.SelectedIndex != -1)
            {
                if (this.cmbSearchSelection.Text == "Merchant ID")
                {
                    try
                    {
                        var query = "select * from Parcel where MerchantID like '" + this.txtAutoSearch.Text.ToUpper() + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (this.cmbSearchSelection.Text == "Parcel Status")
                {
                    try
                    {
                        var query = "select * from Parcel where ParcelStatus like '" + this.txtAutoSearch.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.cmbSearchSelection.Text == "Parcel Type")
                {
                    try
                    {
                        var query = "select * from Parcel where ParcelType like '" + this.txtAutoSearch.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (this.cmbSearchSelection.Text == "Area of Delivery")
                {
                    try
                    {
                        var query = "select * from Parcel where ReceiverAreaOfDelivery like '" + this.txtAutoSearch.Text + "%';";
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
                        var query = "select * from Parcel where EmployeeID like '" + this.txtAutoSearch.Text + "%';";
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
                MessageBox.Show("Please, select the 'Search By' field first. (ID or, Rank)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
