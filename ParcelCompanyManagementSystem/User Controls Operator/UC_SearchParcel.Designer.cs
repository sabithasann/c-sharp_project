namespace ParcelCompanyManagementSystem.User_Controls_Operator
{
    partial class UC_SearchParcel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchSelection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvParcelDetails = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ParcelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverCellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverAreaOfDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiverRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionalAmountFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelEntryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParcelLastUpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.cmbSearchSelection);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 55);
            this.panel1.TabIndex = 3;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAutoSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(635, 16);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(182, 26);
            this.txtAutoSearch.TabIndex = 5;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // cmbSearchSelection
            // 
            this.cmbSearchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchSelection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchSelection.FormattingEnabled = true;
            this.cmbSearchSelection.Items.AddRange(new object[] {
            "Merchant ID",
            "Parcel Status",
            "Parcel Type",
            "Area of Delivery",
            "Employee ID"});
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
            // dgvParcelDetails
            // 
            this.dgvParcelDetails.AllowUserToAddRows = false;
            this.dgvParcelDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParcelDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvParcelDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvParcelDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParcelDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParcelID,
            this.MerchantID,
            this.ReceiverName,
            this.ReceiverCellPhone,
            this.ReceiverAddress,
            this.ReceiverAreaOfDelivery,
            this.ReceiverRemarks,
            this.ParcelType,
            this.EstimatedDeliveryDate,
            this.ConditionalAmount,
            this.ParcelStatus,
            this.DeliveryFees,
            this.ConditionalAmountFees,
            this.TotalFees,
            this.OperatorRemarks,
            this.ParcelEntryTime,
            this.ParcelLastUpdatedTime,
            this.EmployeeID});
            this.dgvParcelDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParcelDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParcelDetails.EnableHeadersVisualStyles = false;
            this.dgvParcelDetails.GridColor = System.Drawing.Color.DarkGray;
            this.dgvParcelDetails.Location = new System.Drawing.Point(0, 55);
            this.dgvParcelDetails.Name = "dgvParcelDetails";
            this.dgvParcelDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParcelDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvParcelDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParcelDetails.Size = new System.Drawing.Size(827, 429);
            this.dgvParcelDetails.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Purple;
            this.btnRefresh.Location = new System.Drawing.Point(672, 501);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 47);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // ReceiverName
            // 
            this.ReceiverName.DataPropertyName = "ReceiverName";
            this.ReceiverName.HeaderText = "Receiver Name";
            this.ReceiverName.Name = "ReceiverName";
            this.ReceiverName.ReadOnly = true;
            this.ReceiverName.Width = 150;
            // 
            // ReceiverCellPhone
            // 
            this.ReceiverCellPhone.DataPropertyName = "ReceiverCellPhone";
            this.ReceiverCellPhone.HeaderText = "Receiver Cell Phone";
            this.ReceiverCellPhone.Name = "ReceiverCellPhone";
            this.ReceiverCellPhone.ReadOnly = true;
            // 
            // ReceiverAddress
            // 
            this.ReceiverAddress.DataPropertyName = "ReceiverAddress";
            this.ReceiverAddress.FillWeight = 25.38071F;
            this.ReceiverAddress.HeaderText = "Receiver Address";
            this.ReceiverAddress.Name = "ReceiverAddress";
            this.ReceiverAddress.ReadOnly = true;
            this.ReceiverAddress.Width = 190;
            // 
            // ReceiverAreaOfDelivery
            // 
            this.ReceiverAreaOfDelivery.DataPropertyName = "ReceiverAreaOfDelivery";
            this.ReceiverAreaOfDelivery.FillWeight = 25.38071F;
            this.ReceiverAreaOfDelivery.HeaderText = "Area Of Delivery";
            this.ReceiverAreaOfDelivery.Name = "ReceiverAreaOfDelivery";
            this.ReceiverAreaOfDelivery.ReadOnly = true;
            // 
            // ReceiverRemarks
            // 
            this.ReceiverRemarks.DataPropertyName = "ReceiverRemarks";
            this.ReceiverRemarks.FillWeight = 25.38071F;
            this.ReceiverRemarks.HeaderText = "Receiver Remarks";
            this.ReceiverRemarks.Name = "ReceiverRemarks";
            this.ReceiverRemarks.ReadOnly = true;
            this.ReceiverRemarks.Width = 150;
            // 
            // ParcelType
            // 
            this.ParcelType.DataPropertyName = "ParcelType";
            this.ParcelType.FillWeight = 25.38071F;
            this.ParcelType.HeaderText = "Parcel Type";
            this.ParcelType.Name = "ParcelType";
            this.ParcelType.ReadOnly = true;
            this.ParcelType.Width = 120;
            // 
            // EstimatedDeliveryDate
            // 
            this.EstimatedDeliveryDate.DataPropertyName = "EstimatedDeliveryDate";
            this.EstimatedDeliveryDate.FillWeight = 25.38071F;
            this.EstimatedDeliveryDate.HeaderText = "Estimated Delivery Date";
            this.EstimatedDeliveryDate.Name = "EstimatedDeliveryDate";
            this.EstimatedDeliveryDate.ReadOnly = true;
            // 
            // ConditionalAmount
            // 
            this.ConditionalAmount.DataPropertyName = "ConditionalAmount";
            this.ConditionalAmount.HeaderText = "Conditional Amount";
            this.ConditionalAmount.Name = "ConditionalAmount";
            this.ConditionalAmount.ReadOnly = true;
            this.ConditionalAmount.Width = 80;
            // 
            // ParcelStatus
            // 
            this.ParcelStatus.DataPropertyName = "ParcelStatus";
            this.ParcelStatus.HeaderText = "Parcel Status";
            this.ParcelStatus.Name = "ParcelStatus";
            this.ParcelStatus.ReadOnly = true;
            this.ParcelStatus.Width = 130;
            // 
            // DeliveryFees
            // 
            this.DeliveryFees.DataPropertyName = "DeliveryFees";
            this.DeliveryFees.HeaderText = "Delivery Fees";
            this.DeliveryFees.Name = "DeliveryFees";
            this.DeliveryFees.ReadOnly = true;
            // 
            // ConditionalAmountFees
            // 
            this.ConditionalAmountFees.DataPropertyName = "ConditionalAmountFees";
            this.ConditionalAmountFees.HeaderText = "Conditional Amount Fees";
            this.ConditionalAmountFees.Name = "ConditionalAmountFees";
            this.ConditionalAmountFees.ReadOnly = true;
            // 
            // TotalFees
            // 
            this.TotalFees.DataPropertyName = "TotalFees";
            this.TotalFees.HeaderText = "Total Fees";
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.ReadOnly = true;
            // 
            // OperatorRemarks
            // 
            this.OperatorRemarks.DataPropertyName = "OperatorRemarks";
            this.OperatorRemarks.HeaderText = "Operator Remarks";
            this.OperatorRemarks.Name = "OperatorRemarks";
            this.OperatorRemarks.ReadOnly = true;
            this.OperatorRemarks.Width = 150;
            // 
            // ParcelEntryTime
            // 
            this.ParcelEntryTime.DataPropertyName = "ParcelEntryTime";
            this.ParcelEntryTime.HeaderText = "Parcel Entry Time";
            this.ParcelEntryTime.Name = "ParcelEntryTime";
            this.ParcelEntryTime.ReadOnly = true;
            // 
            // ParcelLastUpdatedTime
            // 
            this.ParcelLastUpdatedTime.DataPropertyName = "ParcelLastUpdatedTime";
            this.ParcelLastUpdatedTime.HeaderText = "Parcel Last Updated Time";
            this.ParcelLastUpdatedTime.Name = "ParcelLastUpdatedTime";
            this.ParcelLastUpdatedTime.ReadOnly = true;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Width = 90;
            // 
            // UC_SearchParcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvParcelDetails);
            this.Controls.Add(this.panel1);
            this.Name = "UC_SearchParcel";
            this.Size = new System.Drawing.Size(827, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.ComboBox cmbSearchSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvParcelDetails;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverCellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverAreaOfDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiverRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionalAmountFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelEntryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParcelLastUpdatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
    }
}
