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
    public partial class UC_OperatorHome : UserControl
    {
        private DataAccess Da { get; set; }

        public UC_OperatorHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ChangeOperatorHomeDetails();
        }

        private void ChangeOperatorHomeDetails()
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
            this.SetDeliverTodayNumber();
            this.SetDeliverTomorrowNumber();
            this.SetExpressDeliveryDocumentNumber();
        }

        private string SqlNumberCounter(string query)
        {
            var sql = query;
            var ds = this.Da.ExecuteQuery(sql);
            string count = Convert.ToString(ds.Tables[0].Rows.Count);
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
                var sqlToFindFailedToDeliverNumber = @"select * from Parcel where ParcelStatus = 'Failed to deliver';";
                this.lblFailedToDeliver.Text = this.SqlNumberCounter(sqlToFindFailedToDeliverNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDeliverTodayNumber()
        {
            try
            {
                var sqlToFindDeliverTodayNumber = @"select * from Parcel where ParcelStatus = 'Ready for delivery' and EstimatedDeliveryDate = '" + DateTime.Now.ToShortDateString() +"';";
                this.lblDeliverToday.Text = this.SqlNumberCounter(sqlToFindDeliverTodayNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDeliverTomorrowNumber()
        {
            try
            {
                var sqlToFindDeliverTomorrowNumber = @"select * from Parcel where ParcelStatus = 'Ready for delivery' and EstimatedDeliveryDate = '" + DateTime.Now.AddDays(1).ToShortDateString() + "';";
                this.lblDeliveryTomorrow.Text = this.SqlNumberCounter(sqlToFindDeliverTomorrowNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetExpressDeliveryDocumentNumber()
        {
            try
            {
                var sqlToFindExpressDeliveryDocumentNumber = @"select * from Parcel where ParcelType = 'Documents (Express)';";
                this.lblExpressDeliveryDocuments.Text = this.SqlNumberCounter(sqlToFindExpressDeliveryDocumentNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
