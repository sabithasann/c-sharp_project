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
    public partial class UC_EditParcel : UserControl
    {
        private DataAccess Da { get; set; }

        private string UserName { get; set; }

        public UC_EditParcel()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlMain.Hide();
        }

        public UC_EditParcel(string userName) : this()
        {
            this.UserName = userName;
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

        private bool IsDataValidToUpdate()
        {
            if (String.IsNullOrEmpty(this.txtName.Text) ||
            String.IsNullOrEmpty(this.txtCellPhone.Text) ||
            String.IsNullOrEmpty(this.txtAddress.Text) ||
            String.IsNullOrEmpty(this.cmbAreaOfDelivery.Text) ||
            String.IsNullOrEmpty(this.cmbParcelType.Text) ||
            String.IsNullOrEmpty(this.nudConditionalAmount.Text) ||
            String.IsNullOrEmpty(this.cmbParcelStatus.Text))
                return false;
            else
                return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSearch())
                {
                    MessageBox.Show("Please write the 'Parcel ID' first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var query = @"select * from Parcel where ParcelID = '"+ this.txtSearch.Text.ToUpper()+"';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1 && dt.Rows[0]["ParcelStatus"].ToString() == "Delivered")
                {
                    MessageBox.Show("" + this.txtSearch.Text.ToUpper() + " is delivered! You cannot Update or Delete of a delivered product.","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dt.Rows.Count == 1)
                {
                    this.pnlMain.Show();
                    this.txtSearch.ReadOnly = true;

                    this.txtName.Text = dt.Rows[0]["ReceiverName"].ToString();
                    this.txtCellPhone.Text =dt.Rows[0]["ReceiverCellPhone"].ToString();
                    this.txtAddress.Text =dt.Rows[0]["ReceiverAddress"].ToString();
                    this.cmbAreaOfDelivery.Text =dt.Rows[0]["ReceiverAreaOfDelivery"].ToString();
                    this.txtRemarks.Text =dt.Rows[0]["ReceiverRemarks"].ToString();
                    this.cmbParcelType.Text =dt.Rows[0]["ParcelType"].ToString();
                    this.nudConditionalAmount.Text =dt.Rows[0]["ConditionalAmount"].ToString();
                    this.cmbParcelStatus.Text =dt.Rows[0]["ParcelStatus"].ToString();

                    string deliveryDate = dt.Rows[0]["EstimatedDeliveryDate"].ToString();
                    string[] temp = deliveryDate.Split(' ');
                    this.txtEstimatedDeliveryDate.Text = temp[0];

                    this.lblDeliveryFees.Text =dt.Rows[0]["DeliveryFees"].ToString();
                    this.lblConditionalAmountFees.Text =dt.Rows[0]["ConditionalAmountFees"].ToString();
                    this.lblTotalFees.Text =dt.Rows[0]["TotalFees"].ToString();
                    this.txtAdditionalRemarks.Text =dt.Rows[0]["OperatorRemarks"].ToString();

                    if (this.cmbParcelStatus.Text == "Out for delivery")
                    {
                        this.nudConditionalAmount.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Parcel '" + this.txtSearch.Text.ToUpper() + "' not found in system!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToUpdate())
                {
                    MessageBox.Show("Please fill all the Data Field.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Update this '" + this.txtSearch.Text.ToUpper() + "' Merchant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = @"update Parcel set ReceiverName = '"+ this.txtName.Text + @"', 
                                ReceiverCellPhone = "+ this.txtCellPhone.Text + @", 
                                ReceiverAddress = '"+ this.txtAddress.Text + @"', 
                                ReceiverAreaOfDelivery = '"+ this.cmbAreaOfDelivery.Text + @"', 
                                ReceiverRemarks = '"+ this.txtRemarks.Text + @"', 
                                ParcelType = '"+ this.cmbParcelType.Text + @"', 
                                EstimatedDeliveryDate = '"+ this.txtEstimatedDeliveryDate.Text + @"', 
                                ConditionalAmount = '"+ this.nudConditionalAmount.Text + @"', 
                                ParcelStatus = '"+ this.cmbParcelStatus.Text + @"', 
                                DeliveryFees = '"+ this.lblDeliveryFees.Text + @"', 
                                ConditionalAmountFees = '"+ this.lblConditionalAmountFees.Text + @"', 
                                TotalFees = '"+ this.lblTotalFees.Text + @"', 
                                EmployeeID = '"+ this.UserName + @"', 
                                OperatorRemarks = '"+ this.txtAdditionalRemarks.Text + @"', 
                                ParcelLastUpdatedTime = '"+ DateTime.Now.ToString("MM/dd/yyyy HH:mm") + @"'  
                                where ParcelID = '" + this.txtSearch.Text.ToUpper() + "';";

                    int count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated properly.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.UpdateMerchantWallet();
                        this.pnlMain.Hide();
                        this.txtSearch.Clear();
                        this.txtSearch.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Data Update failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete this '" + this.txtSearch.Text.ToUpper() + "' Merchant?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = @"delete from Parcel where ParcelID = '" + this.txtSearch.Text.ToUpper() + "';";

                    int count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Deleted properly.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pnlMain.Hide();
                        this.txtSearch.Clear();
                        this.txtSearch.ReadOnly = false;
                    }
                    else 
                    { 
                        MessageBox.Show("Data Deletion failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeliveryFeesSetter()
        {
            if (this.cmbParcelType.Text == "Documents")
                this.lblDeliveryFees.Text = "25";

            else if (this.cmbParcelType.Text == "Documents (Express)")
                this.lblDeliveryFees.Text = "100";

            else if (this.cmbParcelType.Text == "Light Package")
                this.lblDeliveryFees.Text = "40";

            else if (this.cmbParcelType.Text == "Medium Package")
                this.lblDeliveryFees.Text = "70";

            else if (this.cmbParcelType.Text == "Heavy Package")
                this.lblDeliveryFees.Text = "100";

            else if (this.cmbParcelType.Text == "Extra Heavy Package")
                this.lblDeliveryFees.Text = "200";

            else
                this.lblDeliveryFees.Text = "0";
        }

        private void DeliveryDateGenerator()
        {
            if (this.cmbParcelType.Text == "Documents (Express)")
            {
                string deliveryDt = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");
                string[] temp = deliveryDt.Split(' ');
                this.txtEstimatedDeliveryDate.Text = temp[0];
            }
            else if (this.cmbParcelType.Text == "Extra Heavy Package")
            {
                string deliveryDt = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");
                string[] temp = deliveryDt.Split(' ');
                this.txtEstimatedDeliveryDate.Text = temp[0];
            }
            else
            {
                string deliveryDt = DateTime.Now.AddDays(2).ToString("MM/dd/yyyy");
                string[] temp = deliveryDt.Split(' ');
                this.txtEstimatedDeliveryDate.Text = temp[0];
            }
        }

        private void ConditionalAmountFeesSetter()
        {
            if (this.nudConditionalAmount.Value <= 1000)
            {
                this.lblConditionalAmountFees.Text = "10";
            }
            else
            {
                this.lblConditionalAmountFees.Text = Convert.ToString(Convert.ToDouble(this.nudConditionalAmount.Value) * 0.01);
            }

        }

        private void nudConditionalAmount_ValueChanged(object sender, EventArgs e)
        {
            this.ConditionalAmountFeesSetter();
            this.lblTotalFees.Text = Convert.ToString(Convert.ToDouble(this.lblDeliveryFees.Text) + Convert.ToDouble(this.lblConditionalAmountFees.Text));
        }

        private void cmbParcelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DeliveryFeesSetter();
            this.DeliveryDateGenerator();
            this.lblTotalFees.Text = Convert.ToString(Convert.ToDouble(this.lblDeliveryFees.Text) + Convert.ToDouble(this.lblConditionalAmountFees.Text));
        }

        private void UpdateMerchantWallet()
        {
            if (this.cmbParcelStatus.Text == "Delivered" && Convert.ToDouble(this.nudConditionalAmount.Text) > 0)
            {
                try
                {
                    var sqlToGrabOldMerchantWallet = @"select p.MerchantID, m.MerchantWallet from Parcel p, 
                                                       Merchant m where p.MerchantID = m.MerchantID and p.ParcelID = '" + this.txtSearch.Text.ToUpper() + "';";
                    var dtOldMerchantWallet = this.Da.ExecuteQueryTable(sqlToGrabOldMerchantWallet);

                    var sqlToStoreNewMerchantWallet = @"update Merchant set MerchantWallet = " + (Convert.ToDecimal(dtOldMerchantWallet.Rows[0]["MerchantWallet"]) + (this.nudConditionalAmount.Value - (Convert.ToDecimal(this.lblConditionalAmountFees.Text)))) + " where MerchantID = '" + dtOldMerchantWallet.Rows[0]["MerchantID"] + "';";
                    
                    int completionCount = this.Da.ExecuteDMLQuery(sqlToStoreNewMerchantWallet);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.pnlMain.Hide();
            this.txtSearch.Clear();
            this.txtSearch.ReadOnly = false;
        }

        private void UC_EditParcel_Leave(object sender, EventArgs e)
        {
            this.pnlMain.Hide();
            this.txtSearch.Clear();
            this.txtSearch.ReadOnly = false;
        }

        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
