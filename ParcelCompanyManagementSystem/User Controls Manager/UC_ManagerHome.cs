using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelCompanyManagementSystem.User_Controls_Manager
{
    public partial class UC_ManagerHome : UserControl
    {
        private DataAccess Da { get; set; }

        public UC_ManagerHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ChangeManagerHomeDetails();
        }

        private void ChangeManagerHomeDetails()
        {
            this.SetTotalParcelNumber();
            this.SetAwaitingPickupNumber();
            this.SetReceivedAtStationNumber();
            this.SetSortingParcelsNumber();
            this.SetWaitingforDeliveryNumber();
            this.SetAtDeliveryQueueNumber();
            this.SetOutForDeliveryNumber();
            this.SetDeliveredNumber();
            this.SetFailedToDeliverNumber();
            this.SetCompanyRevenueValue();
            this.SetMerchantCreditValue();
            this.SetOperatorNumber();
            this.SetAccountantNumber();
        }

        private string SqlNumberCounter(string query)
        {
                var sql = query;
                var dt = this.Da.ExecuteQueryTable(sql);
                string count = Convert.ToString(dt.Rows.Count);
                return count;
        }

        private void SetTotalParcelNumber()
        {
            try
            {
                var sqlToFindTotalParcelNumber = @"select * from Parcel";
                this.lblTotalParcels.Text = this.SqlNumberCounter(sqlToFindTotalParcelNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetAwaitingPickupNumber()
        {
            try
            {
                var sqlToFindAwaitingPickup = @"select * from Parcel where ParcelStatus = 'Awaiting pickup';";
                this.lblAwaitingPickup.Text = this.SqlNumberCounter(sqlToFindAwaitingPickup);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetReceivedAtStationNumber()
        {
            try
            {
                var sqlToFindReceivedAtStationNumber = @"select * from Parcel where ParcelStatus = 'Received at station';";
                this.lblReceivedAtStation.Text = this.SqlNumberCounter(sqlToFindReceivedAtStationNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetSortingParcelsNumber()
        {
            try
            {
                var sqlToFindSortingParcelsNumber = @"select * from Parcel where ParcelStatus = 'Sorting parcel';";
                this.lblSortingParcels.Text = this.SqlNumberCounter(sqlToFindSortingParcelsNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetWaitingforDeliveryNumber()
        {
            try
            {
                var sqlToFindWaitingforDeliveryNumber = @"select * from Parcel where ParcelStatus = 'Waiting for delivery';";
                this.lblWaitingForDelivery.Text = this.SqlNumberCounter(sqlToFindWaitingforDeliveryNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetAtDeliveryQueueNumber()
        {
            try
            {
                var sqlToFindAtDeliveryQueueNumber = @"select * from Parcel where ParcelStatus = 'Ready for delivery';";
                this.lblAtDeliveryQueue.Text = this.SqlNumberCounter(sqlToFindAtDeliveryQueueNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetOutForDeliveryNumber()
        {
            try
            {
                var sqlToFindOutForDeliveryNumber = @"select * from Parcel where ParcelStatus = 'Out for delivery';";
                this.lblOutforDelivery.Text = this.SqlNumberCounter(sqlToFindOutForDeliveryNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDeliveredNumber()
        {
            try
            {
                var sqlToDeliveredNumber = @"select * from Parcel where ParcelStatus = 'Delivered';";
                this.lblDelivered.Text = this.SqlNumberCounter(sqlToDeliveredNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFailedToDeliverNumber()
        {
            try
            {
                var sqlToFindFailedToDeliverNumber = @"select * from Parcel where ParcelStatus = 'Failed to Deliver';";
                this.lblFailedToDeliver.Text = this.SqlNumberCounter(sqlToFindFailedToDeliverNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCompanyRevenueValue()
        {
            try
            {
                var sqlToCompanyRevenueValue = @"select isnull(sum(TotalFees),0) from Parcel where ParcelStatus = 'Delivered';";
                var companyRevenue = this.Da.ExecuteQueryTable(sqlToCompanyRevenueValue);
                this.lblCompanyRevenue.Text = Convert.ToString(companyRevenue.Rows[0][0].ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetMerchantCreditValue()
        {
            try
            {
                var sqlToFindMerchantCreditValue = @"select isnull(sum(MerchantWallet),0) from Merchant;";
                var merchantCredit = this.Da.ExecuteQueryTable(sqlToFindMerchantCreditValue);
                this.lblMerchantCredit.Text = Convert.ToString(merchantCredit.Rows[0][0].ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetOperatorNumber()
        {
            try
            {
                var sqlToFindOperatorNumber = @"select * from Employee where EmployeeRank = 'Operator';";
                this.lblOperator.Text = this.SqlNumberCounter(sqlToFindOperatorNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetAccountantNumber()
        {
            try
            {
                var sqlToAccountantNumber = @"select * from Employee where EmployeeRank = 'Accountant';";
                this.lblAccountant.Text = this.SqlNumberCounter(sqlToAccountantNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
