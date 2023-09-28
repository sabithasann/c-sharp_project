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
    public partial class UC_Merchant : UserControl
    {
        private DataAccess Da { get; set; }

        UC_AddMerchant ucAddMerchant = new UC_AddMerchant();
        UC_EditMerchant ucEditMerchant = new UC_EditMerchant();

        public UC_Merchant()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.pnlCancel.Hide();
        }

        private void PopulateGridView(string query = "select * from Merchant;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);

                this.dgvMerchantDetails.AutoGenerateColumns = false;
                this.dgvMerchantDetails.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.btnDashboard.FlatAppearance.BorderSize = 1;
            this.btnAddMerchant.FlatAppearance.BorderSize = 0;
            this.btnEditMerchant.FlatAppearance.BorderSize = 0;

            this.pnlGridView.Controls.Clear();
            this.pnlCancel.Hide();
            this.pnlGridView.Controls.Add(dgvMerchantDetails);
            this.pnlRefresh.Show();
            this.PopulateGridView();
            this.txtAutoSearch.Clear();
            this.lblSearchByID.Show();
            this.txtAutoSearch.Show();
        }

        private void btnAddMerchant_Click(object sender, EventArgs e)
        {
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnAddMerchant.FlatAppearance.BorderSize = 1;
            this.btnEditMerchant.FlatAppearance.BorderSize = 0;

            this.pnlGridView.Controls.Clear();
            this.pnlGridView.Controls.Add(ucAddMerchant);
            this.pnlCancel.Show();
            this.pnlRefresh.Hide();
            this.lblSearchByID.Hide();
            this.txtAutoSearch.Hide();
            this.txtAutoSearch.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.btnDashboard.FlatAppearance.BorderSize = 0;
                this.btnAddMerchant.FlatAppearance.BorderSize = 0;
                this.btnEditMerchant.FlatAppearance.BorderSize = 0;

                this.pnlGridView.Controls.Clear();
                this.pnlCancel.Hide();
                this.pnlGridView.Controls.Add(dgvMerchantDetails);
                this.pnlRefresh.Show();
                this.PopulateGridView();
                this.lblSearchByID.Show();
                this.txtAutoSearch.Show();
                this.txtAutoSearch.Clear();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnAddMerchant.FlatAppearance.BorderSize = 0;
            this.btnEditMerchant.FlatAppearance.BorderSize = 0;

            this.PopulateGridView();
            this.lblSearchByID.Show();
            this.txtAutoSearch.Show();
            this.txtAutoSearch.Clear();
        }

        private void btnEditMerchant_Click(object sender, EventArgs e)
        {
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnAddMerchant.FlatAppearance.BorderSize = 0;
            this.btnEditMerchant.FlatAppearance.BorderSize = 1;

            this.pnlGridView.Controls.Clear();
            this.pnlGridView.Controls.Add(ucEditMerchant);
            this.pnlCancel.Show();
            this.pnlRefresh.Hide();
            this.lblSearchByID.Hide();
            this.txtAutoSearch.Hide();
            this.txtAutoSearch.Clear();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.pnlGridView.Controls.Clear();
                this.pnlCancel.Hide();
                this.pnlGridView.Controls.Add(dgvMerchantDetails);
                this.pnlRefresh.Show();
                this.PopulateGridView();

                var query = "select * from Merchant where MerchantID like '" + this.txtAutoSearch.Text.ToUpper() + "%';";
                this.PopulateGridView(query);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
