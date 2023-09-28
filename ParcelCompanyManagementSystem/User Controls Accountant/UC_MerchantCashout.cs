using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelCompanyManagementSystem;

namespace ParcelCompanyManagementSystem.User_Controls
{
    public partial class UC_MerchantCashout : UserControl
    {
        private DataAccess Da { get; set; }
        public UC_MerchantCashout()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlSearchResults.Hide();
        }

        private void ClearAll()
        {
            this.pnlSearchResults.Visible = false;
            this.lblMerchantName.Text = "#NAME";
            this.lblWalletAmount.Text = "#VAL";
            this.txtMerchantId.Clear();
            this.txtCashoutAmount.Clear();
        }

        private void ShowSearchResults(double merchantWallet)
        {
            if (merchantWallet > 0)
            {
                this.pnlSearchResults.Show();
                this.txtMerchantId.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("" + this.lblMerchantName.Text + "[Merchant ID: " + this.txtMerchantId.Text.ToUpper() + "] has no wallet amount to withdrawl!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearAll();
            }
        }

        private bool IsDataValidToSearch()
        {
            if (String.IsNullOrWhiteSpace(this.txtMerchantId.Text))
            {
                this.pnlSearchResults.Hide();
                return false;
            }
            else
                return true;
        }

        private void PerformCashout()
        {
            try
            {
                decimal remainingWalletBalance = Convert.ToDecimal(this.lblWalletAmount.Text) - Convert.ToDecimal(this.txtCashoutAmount.Text);
                var queryUpdateMerchantWallet = @"update Merchant set MerchantWallet = " + remainingWalletBalance + " where MerchantID = '" + this.txtMerchantId.Text.ToUpper() + "'";
                int count = this.Da.ExecuteDMLQuery(queryUpdateMerchantWallet);

                if (count == 1)
                {
                    MessageBox.Show("" + this.txtCashoutAmount.Text + "TK cashed out from the wallet of '" + this.lblMerchantName.Text + "' successfully!\nRemaining wallet balance = "+ remainingWalletBalance +"", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Cashout was not successful! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMerchant_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSearch())
                {
                    MessageBox.Show("Please write the 'Merchant ID' first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var query = @"select MerchantID, MerchantName, MerchantWallet from Merchant where MerchantID = '"+ this.txtMerchantId.Text.ToUpper()+"';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    this.lblMerchantName.Text = dt.Rows[0]["MerchantName"].ToString();
                    this.lblWalletAmount.Text = dt.Rows[0]["MerchantWallet"].ToString();
                    this.ShowSearchResults(Convert.ToDouble(this.lblWalletAmount.Text));
                }
                else
                    MessageBox.Show("Merchant ID " + this.txtMerchantId.Text + " not found! Search by a valid Merchant ID!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCashout_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(this.lblWalletAmount.Text) >= Convert.ToDecimal(this.txtCashoutAmount.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to cashout "+ this.txtCashoutAmount.Text +"TK?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.PerformCashout();
                    this.pnlSearchResults.Hide();
                    this.txtMerchantId.Clear();
                    this.txtMerchantId.ReadOnly = false;
                }
            }
            else
                MessageBox.Show("You cannot cashout "+ this.txtCashoutAmount.Text +"TK as Merchant does not have that much wallet amount!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtMerchantId.ReadOnly = false;
            this.pnlSearchResults.Hide();
            this.ClearAll();
        }

        private void txtCashoutAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
