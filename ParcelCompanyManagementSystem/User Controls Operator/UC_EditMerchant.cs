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
    public partial class UC_EditMerchant : UserControl
    {
        private DataAccess Da { get; set; }
        public UC_EditMerchant()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlSingleMerchantDetails.Hide();
        }

        private bool IsDataValidToSearch()
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text))
            {
                this.pnlSingleMerchantDetails.Hide();
                return false;
            }
            else
                return true;
        }
        private bool IsDataValidToUpdate()
        {
            if (String.IsNullOrWhiteSpace(this.txtName.Text) || String.IsNullOrWhiteSpace(this.txtCellPhone.Text) ||
                String.IsNullOrWhiteSpace(this.txtAddress.Text) || String.IsNullOrWhiteSpace(this.txtEmail.Text))
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
                    MessageBox.Show("Please write the 'User ID' first.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var query = "select * from Merchant where MerchantID = '" + this.txtSearch.Text.ToUpper() + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                this.pnlSingleMerchantDetails.Hide();

                if (dt.Rows.Count == 1)
                {
                    this.pnlSingleMerchantDetails.Show();
                    this.txtSearch.ReadOnly = true;

                    this.txtName.Text = dt.Rows[0]["MerchantName"].ToString();
                    this.txtCellPhone.Text = dt.Rows[0]["MerchantCellPhone"].ToString();
                    this.txtAddress.Text = dt.Rows[0]["MerchantAddress"].ToString();
                    this.txtEmail.Text = dt.Rows[0]["MerchantEmail"].ToString();
                    this.dtpRegistrationDate.Text = dt.Rows[0]["MerchantRegistrationDate"].ToString();
                }
                else
                {
                    MessageBox.Show("Merchant '" + this.txtSearch.Text.ToUpper() + "' not found in system!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                DialogResult dialogResult = MessageBox.Show("Are you sure want to Update this '"+ this.txtSearch.Text.ToUpper()+"' Merchant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = @"update Merchant 
                                  set MerchantName = '" + this.txtName.Text + @"', 
                                  MerchantCellPhone = '" + this.txtCellPhone.Text + @"',
                                  MerchantAddress = '" + this.txtAddress.Text + @"', 
                                  MerchantEmail = '" + this.txtEmail.Text + @"',
                                  MerchantRegistrationDate = '" + this.dtpRegistrationDate.Text + @"' where MerchantID = '" + this.txtSearch.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated properly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pnlSingleMerchantDetails.Hide();
                        this.txtSearch.Clear();
                        this.txtSearch.ReadOnly = false;
                    }
                    else
                        MessageBox.Show("Data Update failed! Please, try again later.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete this '"+ this.txtSearch.Text.ToUpper()+"' Merchant?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    var query = @"delete from Merchant where MerchantID = '" + this.txtSearch.Text + "';";

                    int count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Deleted properly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pnlSingleMerchantDetails.Hide();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.pnlSingleMerchantDetails.Hide();
            this.txtSearch.Clear();
            this.txtSearch.ReadOnly = false;
        }

        private void UC_EditMerchant_Leave(object sender, EventArgs e)
        {
            this.pnlSingleMerchantDetails.Hide();
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
