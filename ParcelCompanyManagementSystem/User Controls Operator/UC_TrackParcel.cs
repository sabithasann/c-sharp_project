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
    public partial class UC_TrackParcel : UserControl
    {
        private DataAccess Da { get; set; }
        public UC_TrackParcel()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlMain.Hide();
        }

        private void ClearAll()
        {
            this.txtSenderName.Clear();
            this.txtSenderCellPhone.Clear();
            this.txtSenderAddress.Clear();
            this.txtMerchantID.Clear();
            this.txtReceiverName.Clear();
            this.txtReceiverCellPhone.Clear();
            this.txtReceiverAddress.Clear();
            this.txtReceiverAreaOfDelivery.Clear();
            this.txtReceiverRemarks.Clear();
            this.txtParcelType.Clear();
            this.txtAddedOn.Clear();
            this.txtLastUpdate.Clear();
            this.txtUpdatedByID.Clear();
            this.txtUpdatedByName.Clear();
            this.txtConditionalAmount.Clear();
            this.txtConditionalFees.Clear();
            this.txtDeliveryFees.Clear();
            this.txtAddedOn.Clear();
            this.txtEstimatedDeliveryDate.Clear();
            this.txtAdditionalRemarks.Clear();
            this.txtParcelStatus.Clear();
            this.pbParcelStatusImage.Image = null;
        }

        private bool IsDataValidToSearch()
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                this.pnlMain.Hide();
                return false;
            }
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
                var query = @"select m.MerchantName, m.MerchantCellPhone, m.MerchantAddress, p.MerchantID, p.ReceiverName, 
                            p.ReceiverCellPhone, p.ReceiverAddress, p.ReceiverAreaOfDelivery, p.ReceiverRemarks, p.ParcelType, 
                            p.ParcelEntryTime, p.ParcelLastUpdatedTime, p.EstimatedDeliveryDate, p.EmployeeID, e.EmployeeName, 
                            p.ConditionalAmount, p.ConditionalAmountFees, p.DeliveryFees, p.OperatorRemarks, p.ParcelStatus 
                            from Parcel p, Employee e, Merchant m where p.EmployeeID = e.EmployeeID and p.MerchantID = m.MerchantID and ParcelID = '" + this.txtSearch.Text.ToUpper() + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                this.pnlMain.Hide();

                if(dt.Rows.Count == 1)
                {
                    this.pnlMain.Show();

                    this.txtSenderName.Text = dt.Rows[0]["MerchantName"].ToString();
                    this.txtSenderCellPhone.Text = dt.Rows[0]["MerchantCellPhone"].ToString();
                    this.txtSenderAddress.Text = dt.Rows[0]["MerchantAddress"].ToString();
                    this.txtMerchantID.Text = dt.Rows[0]["MerchantID"].ToString();
                    this.txtReceiverName.Text = dt.Rows[0]["ReceiverName"].ToString();
                    this.txtReceiverCellPhone.Text = dt.Rows[0]["ReceiverCellPhone"].ToString();
                    this.txtReceiverAddress.Text = dt.Rows[0]["ReceiverAddress"].ToString();
                    this.txtReceiverAreaOfDelivery.Text = dt.Rows[0]["ReceiverAreaOfDelivery"].ToString();
                    this.txtReceiverRemarks.Text = dt.Rows[0]["ReceiverRemarks"].ToString();
                    this.txtParcelType.Text = dt.Rows[0]["ParcelType"].ToString();
                    this.txtLastUpdate.Text = dt.Rows[0]["ParcelLastUpdatedTime"].ToString();
                    this.txtUpdatedByID.Text = dt.Rows[0]["EmployeeID"].ToString();
                    this.txtUpdatedByName.Text = dt.Rows[0]["EmployeeName"].ToString();
                    this.txtAddedOn.Text = dt.Rows[0]["ParcelEntryTime"].ToString();
                    this.txtEstimatedDeliveryDate.Text = dt.Rows[0]["EstimatedDeliveryDate"].ToString();
                    this.txtConditionalAmount.Text = dt.Rows[0]["ConditionalAmount"].ToString();
                    this.txtConditionalFees.Text = dt.Rows[0]["ConditionalAmountFees"].ToString();
                    this.txtDeliveryFees.Text = dt.Rows[0]["DeliveryFees"].ToString();
                    this.txtAdditionalRemarks.Text = dt.Rows[0]["OperatorRemarks"].ToString();
                    this.txtParcelStatus.Text = dt.Rows[0]["ParcelStatus"].ToString();
                    this.pbParcelStatusImage.Image = Image.FromFile(@"D:\AIUB\Fall-22\OOP-2 (C#)\Project\ParcelCompanyManagementSystem\ParcelCompanyManagementSystem\images\" + this.txtParcelStatus.Text + ".gif");
                }
                else
                {
                    MessageBox.Show("Parcel '" + this.txtSearch.Text.ToUpper() + "' not found in system!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtSearch.Clear();
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
