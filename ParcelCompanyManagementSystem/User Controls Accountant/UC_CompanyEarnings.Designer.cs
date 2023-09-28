
namespace ParcelCompanyManagementSystem.User_Controls_Accountant
{
    partial class UC_CompanyEarnings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAutoSearch = new System.Windows.Forms.DataGridView();
            this.ParcelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionalAmountFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearchBy = new System.Windows.Forms.TextBox();
            this.cmbSearchSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.btnRefresh);
            this.pnlGridView.Controls.Add(this.dgvAutoSearch);
            this.pnlGridView.Location = new System.Drawing.Point(0, 55);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(827, 388);
            this.pnlGridView.TabIndex = 0;
            this.pnlGridView.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Purple;
            this.btnRefresh.Location = new System.Drawing.Point(672, 337);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 47);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAutoSearch
            // 
            this.dgvAutoSearch.AllowUserToAddRows = false;
            this.dgvAutoSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutoSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutoSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutoSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAutoSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutoSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutoSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParcelID,
            this.MerchantID,
            this.MerchantName,
            this.ParcelType,
            this.DeliveryFees,
            this.ConditionalAmountFees,
            this.TotalFees,
            this.EmployeeID,
            this.EmployeeRank});
            this.dgvAutoSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutoSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAutoSearch.EnableHeadersVisualStyles = false;
            this.dgvAutoSearch.GridColor = System.Drawing.Color.DarkGray;
            this.dgvAutoSearch.Location = new System.Drawing.Point(0, 0);
            this.dgvAutoSearch.Name = "dgvAutoSearch";
            this.dgvAutoSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutoSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAutoSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutoSearch.Size = new System.Drawing.Size(827, 332);
            this.dgvAutoSearch.TabIndex = 1;
            // 
            // ParcelID
            // 
            this.ParcelID.DataPropertyName = "ParcelID";
            this.ParcelID.FillWeight = 395.9391F;
            this.ParcelID.HeaderText = "Parcel ID";
            this.ParcelID.Name = "ParcelID";
            this.ParcelID.ReadOnly = true;
            this.ParcelID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ParcelID.Width = 70;
            // 
            // MerchantID
            // 
            this.MerchantID.DataPropertyName = "MerchantID";
            this.MerchantID.FillWeight = 401.0151F;
            this.MerchantID.HeaderText = "Merchant ID";
            this.MerchantID.Name = "MerchantID";
            this.MerchantID.ReadOnly = true;
            this.MerchantID.Width = 70;
            // 
            // MerchantName
            // 
            this.MerchantName.DataPropertyName = "MerchantName";
            this.MerchantName.HeaderText = "Merchant Name";
            this.MerchantName.Name = "MerchantName";
            this.MerchantName.ReadOnly = true;
            this.MerchantName.Width = 150;
            // 
            // ParcelType
            // 
            this.ParcelType.DataPropertyName = "ParcelType";
            this.ParcelType.HeaderText = "Parcel Type";
            this.ParcelType.Name = "ParcelType";
            this.ParcelType.ReadOnly = true;
            this.ParcelType.Width = 134;
            // 
            // DeliveryFees
            // 
            this.DeliveryFees.DataPropertyName = "DeliveryFees";
            this.DeliveryFees.FillWeight = 25.38071F;
            this.DeliveryFees.HeaderText = "Delivery Fees";
            this.DeliveryFees.Name = "DeliveryFees";
            this.DeliveryFees.ReadOnly = true;
            this.DeliveryFees.Width = 70;
            // 
            // ConditionalAmountFees
            // 
            this.ConditionalAmountFees.DataPropertyName = "ConditionalAmountFees";
            this.ConditionalAmountFees.FillWeight = 25.38071F;
            this.ConditionalAmountFees.HeaderText = "Conditional Amount Fees";
            this.ConditionalAmountFees.Name = "ConditionalAmountFees";
            this.ConditionalAmountFees.ReadOnly = true;
            this.ConditionalAmountFees.Width = 70;
            // 
            // TotalFees
            // 
            this.TotalFees.DataPropertyName = "TotalFees";
            this.TotalFees.FillWeight = 25.38071F;
            this.TotalFees.HeaderText = "Total Earnings";
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.ReadOnly = true;
            this.TotalFees.Width = 70;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.FillWeight = 25.38071F;
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 70;
            // 
            // EmployeeRank
            // 
            this.EmployeeRank.DataPropertyName = "EmployeeRank";
            this.EmployeeRank.FillWeight = 25.38071F;
            this.EmployeeRank.HeaderText = "Employee Rank";
            this.EmployeeRank.Name = "EmployeeRank";
            this.EmployeeRank.ReadOnly = true;
            this.EmployeeRank.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtAutoSearchBy);
            this.panel1.Controls.Add(this.cmbSearchSelection);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 55);
            this.panel1.TabIndex = 2;
            // 
            // txtAutoSearchBy
            // 
            this.txtAutoSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAutoSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearchBy.Location = new System.Drawing.Point(635, 16);
            this.txtAutoSearchBy.Name = "txtAutoSearchBy";
            this.txtAutoSearchBy.Size = new System.Drawing.Size(182, 26);
            this.txtAutoSearchBy.TabIndex = 5;
            this.txtAutoSearchBy.TextChanged += new System.EventHandler(this.txtAutoSearchBy_TextChanged);
            // 
            // cmbSearchSelection
            // 
            this.cmbSearchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchSelection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchSelection.FormattingEnabled = true;
            this.cmbSearchSelection.Items.AddRange(new object[] {
            "Merchant ID",
            "Employee ID",
            "Employee Rank",
            "Parcel Type"});
            this.cmbSearchSelection.Location = new System.Drawing.Point(488, 16);
            this.cmbSearchSelection.Name = "cmbSearchSelection";
            this.cmbSearchSelection.Size = new System.Drawing.Size(141, 26);
            this.cmbSearchSelection.TabIndex = 4;
            this.cmbSearchSelection.SelectedIndexChanged += new System.EventHandler(this.cmbSearchSelection_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(388, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by:";
            // 
            // UC_CompanyEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGridView);
            this.Name = "UC_CompanyEarnings";
            this.Size = new System.Drawing.Size(827, 443);
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAutoSearchBy;
        private System.Windows.Forms.ComboBox cmbSearchSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAutoSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionalAmountFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeRank;
    }
}
