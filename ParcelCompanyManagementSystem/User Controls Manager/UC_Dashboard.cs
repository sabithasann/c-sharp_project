using ParcelCompanyManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelCompanyManagementSystem.User_Controls
{
    public partial class UC_Dashboard : UserControl
    {
        private DataAccess Da { get; set; }

        UC_AddEmployee ucAddEmployee = new UC_AddEmployee();

        public UC_Dashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
            this.PopulateGridView();
            this.pnlCancel.Hide();
        }

        private void PopulateGridView(string query = "select * from Employee;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(query);

                this.dgvEmployeeDetails.AutoGenerateColumns = false;
                this.dgvEmployeeDetails.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.pnlGridView.Controls.Clear();
            this.pnlGridView.Controls.Add(ucAddEmployee);
            this.pnlCancel.Show();
            this.pnlRefresh.Hide();
            this.lblSearchBy.Hide();
            this.cmbSearchSelection.Hide();
            this.txtAutoSearch.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.pnlGridView.Controls.Clear();
                this.pnlCancel.Hide();
                this.pnlGridView.Controls.Add(dgvEmployeeDetails);
                this.pnlRefresh.Show();
                this.lblSearchBy.Show();
                this.cmbSearchSelection.Show();
                this.txtAutoSearch.Show();
                this.PopulateGridView();
                this.txtAutoSearch.Clear();
                this.cmbSearchSelection.SelectedIndex = -1;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtAutoSearch.Clear();
            this.cmbSearchSelection.SelectedIndex = -1;
        }

        private void cmbSearchSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.txtAutoSearch.Clear();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            if(this.cmbSearchSelection.SelectedIndex != -1)
            {
                if(this.cmbSearchSelection.Text == "ID")
                {
                    try
                    {
                        var query = "select * from Employee where EmployeeID like '" + this.txtAutoSearch.Text.ToUpper() + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message,"Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    try
                    {
                        var query = "select * from Employee where EmployeeRank like '" + this.txtAutoSearch.Text + "%';";
                        this.PopulateGridView(query);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error has been occured, please try again later.\n" + exc.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select the 'Search By' field first. (ID or, Rank)" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
