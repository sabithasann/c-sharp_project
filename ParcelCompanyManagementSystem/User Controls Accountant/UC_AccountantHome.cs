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
    public partial class UC_AccountantHome : UserControl
    {
        private DataAccess Da { get; set; }

        public UC_AccountantHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ChangeAccountantHomeDetails();
        }

        private void ChangeAccountantHomeDetails()
        {
            this.SetCompanyRevenueValue();
            this.SetMerchantCreditValue();
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
    }
}
