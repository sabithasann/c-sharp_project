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
    public partial class UC_AddMerchant : UserControl
    {
        private DataAccess Da { get; set; }
        private string NewID { get; set; }

        public UC_AddMerchant()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void AutoIdGenerate()
        {
            try
            {
                var query = @"select MerchantID from Merchant order by MerchantID desc;";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 0)
                {
                    var num = 0;
                    this.NewID = "MR-" + (++num).ToString("d3");

                }
                else
                {
                    string oldID = dt.Rows[0]["MerchantID"].ToString();
                    string[] temp = oldID.Split('-');
                    var num = Convert.ToInt32(temp[1]);
                    this.NewID = "MR-" + (++num).ToString("d3");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            this.txtName.Clear();
            this.txtCellPhone.Clear();
            this.txtAddress.Clear();
            this.txtEmail.Clear();
        }

        private bool IsDataValidToSave()
        {
            if (String.IsNullOrWhiteSpace(this.txtName.Text) || String.IsNullOrWhiteSpace(this.txtCellPhone.Text) ||
                String.IsNullOrWhiteSpace(this.txtAddress.Text) || String.IsNullOrWhiteSpace(this.txtEmail.Text))
                return false;
            else
                return true;
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

                DialogResult dialogResult = MessageBox.Show("Are you sure want to add this Merchant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var queryMerchant = @"insert into Merchant values('" + this.NewID + @"',
                                        '" + this.txtName.Text + "','" + this.txtCellPhone.Text + @"',
                                        '" + this.txtAddress.Text + "','" + this.txtEmail.Text + "','" + this.dtpRegistrationDate.Text + "',0);";

                    int count = this.Da.ExecuteDMLQuery(queryMerchant);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Added properly.\nYour Username = " + this.NewID + "\nPlease, do remember this for future business.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearAll();
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
