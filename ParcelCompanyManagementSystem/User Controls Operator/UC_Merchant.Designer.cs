namespace ParcelCompanyManagementSystem.User_Controls_Operator
{
    partial class UC_Merchant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Merchant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchByID = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnAddMerchant = new System.Windows.Forms.Button();
            this.btnEditMerchant = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dgvMerchantDetails = new System.Windows.Forms.DataGridView();
            this.MerchantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantCellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MerchantRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerchantDetails)).BeginInit();
            this.pnlCancel.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblSearchByID);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.btnAddMerchant);
            this.panel1.Controls.Add(this.btnEditMerchant);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 55);
            this.panel1.TabIndex = 0;
            // 
            // lblSearchByID
            // 
            this.lblSearchByID.AutoSize = true;
            this.lblSearchByID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByID.ForeColor = System.Drawing.Color.White;
            this.lblSearchByID.Location = new System.Drawing.Point(534, 18);
            this.lblSearchByID.Name = "lblSearchByID";
            this.lblSearchByID.Size = new System.Drawing.Size(112, 19);
            this.lblSearchByID.TabIndex = 6;
            this.lblSearchByID.Text = "Search by ID:";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAutoSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(649, 15);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(159, 26);
            this.txtAutoSearch.TabIndex = 5;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnAddMerchant
            // 
            this.btnAddMerchant.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddMerchant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMerchant.FlatAppearance.BorderSize = 0;
            this.btnAddMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMerchant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMerchant.ForeColor = System.Drawing.Color.White;
            this.btnAddMerchant.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMerchant.Image")));
            this.btnAddMerchant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMerchant.Location = new System.Drawing.Point(154, 6);
            this.btnAddMerchant.Name = "btnAddMerchant";
            this.btnAddMerchant.Size = new System.Drawing.Size(165, 43);
            this.btnAddMerchant.TabIndex = 1;
            this.btnAddMerchant.Text = "         Add Merchant";
            this.btnAddMerchant.UseVisualStyleBackColor = false;
            this.btnAddMerchant.Click += new System.EventHandler(this.btnAddMerchant_Click);
            // 
            // btnEditMerchant
            // 
            this.btnEditMerchant.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditMerchant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMerchant.FlatAppearance.BorderSize = 0;
            this.btnEditMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMerchant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMerchant.ForeColor = System.Drawing.Color.White;
            this.btnEditMerchant.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMerchant.Image")));
            this.btnEditMerchant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMerchant.Location = new System.Drawing.Point(326, 6);
            this.btnEditMerchant.Name = "btnEditMerchant";
            this.btnEditMerchant.Size = new System.Drawing.Size(165, 43);
            this.btnEditMerchant.TabIndex = 4;
            this.btnEditMerchant.Text = "          Edit Merchant";
            this.btnEditMerchant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMerchant.UseVisualStyleBackColor = false;
            this.btnEditMerchant.Click += new System.EventHandler(this.btnEditMerchant_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(5, 6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(143, 43);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "         Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnlGridView
            // 
            this.pnlGridView.BackColor = System.Drawing.Color.White;
            this.pnlGridView.Controls.Add(this.dgvMerchantDetails);
            this.pnlGridView.Location = new System.Drawing.Point(0, 55);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(827, 323);
            this.pnlGridView.TabIndex = 1;
            // 
            // dgvMerchantDetails
            // 
            this.dgvMerchantDetails.AllowUserToAddRows = false;
            this.dgvMerchantDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMerchantDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMerchantDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvMerchantDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMerchantDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMerchantDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMerchantDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMerchantDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MerchantID,
            this.MerchantName,
            this.MerchantCellPhone,
            this.MerchantAddress,
            this.MerchantEmail,
            this.MerchantRegistrationDate});
            this.dgvMerchantDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMerchantDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMerchantDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMerchantDetails.EnableHeadersVisualStyles = false;
            this.dgvMerchantDetails.GridColor = System.Drawing.Color.DarkGray;
            this.dgvMerchantDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvMerchantDetails.Name = "dgvMerchantDetails";
            this.dgvMerchantDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMerchantDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMerchantDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMerchantDetails.Size = new System.Drawing.Size(827, 323);
            this.dgvMerchantDetails.TabIndex = 1;
            // 
            // MerchantID
            // 
            this.MerchantID.DataPropertyName = "MerchantID";
            this.MerchantID.FillWeight = 395.9391F;
            this.MerchantID.HeaderText = "User Name/ID";
            this.MerchantID.Name = "MerchantID";
            this.MerchantID.ReadOnly = true;
            this.MerchantID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MerchantID.Width = 80;
            // 
            // MerchantName
            // 
            this.MerchantName.DataPropertyName = "MerchantName";
            this.MerchantName.FillWeight = 401.0151F;
            this.MerchantName.HeaderText = "Name";
            this.MerchantName.Name = "MerchantName";
            this.MerchantName.ReadOnly = true;
            this.MerchantName.Width = 150;
            // 
            // MerchantCellPhone
            // 
            this.MerchantCellPhone.DataPropertyName = "MerchantCellPhone";
            this.MerchantCellPhone.FillWeight = 25.38071F;
            this.MerchantCellPhone.HeaderText = "Cell Phone";
            this.MerchantCellPhone.Name = "MerchantCellPhone";
            this.MerchantCellPhone.ReadOnly = true;
            // 
            // MerchantAddress
            // 
            this.MerchantAddress.DataPropertyName = "MerchantAddress";
            this.MerchantAddress.FillWeight = 25.38071F;
            this.MerchantAddress.HeaderText = "Address";
            this.MerchantAddress.Name = "MerchantAddress";
            this.MerchantAddress.ReadOnly = true;
            this.MerchantAddress.Width = 170;
            // 
            // MerchantEmail
            // 
            this.MerchantEmail.DataPropertyName = "MerchantEmail";
            this.MerchantEmail.FillWeight = 25.38071F;
            this.MerchantEmail.HeaderText = "Email Address";
            this.MerchantEmail.Name = "MerchantEmail";
            this.MerchantEmail.ReadOnly = true;
            this.MerchantEmail.Width = 170;
            // 
            // MerchantRegistrationDate
            // 
            this.MerchantRegistrationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MerchantRegistrationDate.DataPropertyName = "MerchantRegistrationDate";
            this.MerchantRegistrationDate.FillWeight = 25.38071F;
            this.MerchantRegistrationDate.HeaderText = "Registration Date";
            this.MerchantRegistrationDate.Name = "MerchantRegistrationDate";
            this.MerchantRegistrationDate.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(68, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 47);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlCancel
            // 
            this.pnlCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Location = new System.Drawing.Point(531, 381);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(293, 59);
            this.pnlCancel.TabIndex = 3;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Location = new System.Drawing.Point(3, 381);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(293, 59);
            this.pnlRefresh.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Purple;
            this.btnRefresh.Location = new System.Drawing.Point(79, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 47);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_Merchant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRefresh);
            this.Controls.Add(this.pnlCancel);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Merchant";
            this.Size = new System.Drawing.Size(827, 443);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMerchantDetails)).EndInit();
            this.pnlCancel.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnEditMerchant;
        private System.Windows.Forms.Button btnAddMerchant;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMerchantDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantCellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MerchantRegistrationDate;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblSearchByID;
    }
}
