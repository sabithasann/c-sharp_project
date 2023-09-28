using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ParcelCompanyManagementSystem.User_Controls_Operator
{
    public partial class UC_AddParcel : UserControl
    {
        private DataAccess Da { get; set; }
        private string NewID { get; set; }
        private string UserName { get; set; }

        public UC_AddParcel()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.pnlMain.Hide();
        }

        public UC_AddParcel(string userName) : this()
        {
            this.UserName = userName;
        }

        private void AutoIdGenerate()
        {
            try
            {
                var query = @"select ParcelID from Parcel order by ParcelID desc;";
                DataTable dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 0)
                {
                    var num = 0;
                    this.NewID = "P-" + (++num).ToString("d3");
                    
                }
                else
                {
                    string oldID = dt.Rows[0]["ParcelID"].ToString();
                    string[] temp = oldID.Split('-');
                    var num = Convert.ToInt32(temp[1]);
                    this.NewID = "P-" + (++num).ToString("d3");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool IsDataValidToSave()
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

        private void ClearAll()
        {
            this.txtSearch.Clear();
            this.txtName.Clear();
            this.txtCellPhone.Clear();
            this.txtAddress.Clear();
            this.cmbAreaOfDelivery.SelectedIndex = -1;
            this.txtRemarks.Clear();
            this.cmbParcelType.SelectedIndex = -1;
            this.nudConditionalAmount.Value = 0;
            this.cmbParcelStatus.SelectedIndex = -1;
            this.txtEstimatedDeliveryDate.Clear();
            this.lblDeliveryFees.Text = Convert.ToString(0);
            this.lblConditionalAmountFees.Text = Convert.ToString(0);
            this.lblTotalFees.Text = Convert.ToString(0);
            this.txtAdditionalRemarks.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSearch())
                {
                    MessageBox.Show("Please write the 'Merchant ID' first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var query = @"select MerchantID from Merchant where MerchantID = '" + this.txtSearch.Text.ToUpper() + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    this.pnlMain.Show();
                    this.txtSearch.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Merchant '" + this.txtSearch.Text.ToUpper() + "' not found in system! Add Merchant in the system or provide the proper Merchent ID.", "Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataValidToSave())
                {
                    MessageBox.Show("Please fill all the Data Field.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.AutoIdGenerate();

                DialogResult dialogResult = MessageBox.Show("Are you sure want to add this Parcel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = @"insert into Parcel values ('" + this.NewID + "','" + this.txtName.Text + @"',
                                '" + this.txtCellPhone.Text + "','" + this.txtAddress.Text + @"', 
                                '" + this.cmbAreaOfDelivery.Text + "', '" + this.txtRemarks.Text + @"', 
                                '" + this.cmbParcelType.Text + "', '" + this.txtEstimatedDeliveryDate.Text + @"', 
                                " + Convert.ToInt32(this.nudConditionalAmount.Text) + " , '" + this.cmbParcelStatus.Text + @"', 
                                " + Convert.ToInt32(this.lblDeliveryFees.Text) + @", 
                                " + Convert.ToDecimal(this.lblConditionalAmountFees.Text) + @", 
                                " + Convert.ToDecimal(this.lblTotalFees.Text) + ", '" + this.txtAdditionalRemarks.Text + @"', 
                                '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm") + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm") + @"', 
                                '" + this.txtSearch.Text.ToUpper() + "', '" + this.UserName + "');";

                    int count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Added properly.\nYour Parcel ID = " + this.NewID + "\nPlease, do remember it and use it for future business.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pnlMain.Hide();
                        this.ClearAll();
                        this.txtSearch.ReadOnly = false;
                    }
                    else
                        MessageBox.Show("Data insertion failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.pnlMain.Hide();
                this.ClearAll();
                this.txtSearch.ReadOnly = false;
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
