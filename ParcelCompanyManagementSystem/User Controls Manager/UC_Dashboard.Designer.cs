namespace ParcelCompanyManagementSystem.User_Controls
{
    partial class UC_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchSelection = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeMaritalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeJoinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.pnlRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.pnlCancel.SuspendLayout();
            this.pnlRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.cmbSearchSelection);
            this.panel1.Controls.Add(this.lblSearchBy);
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 55);
            this.panel1.TabIndex = 0;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAutoSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(635, 15);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(182, 26);
            this.txtAutoSearch.TabIndex = 2;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // cmbSearchSelection
            // 
            this.cmbSearchSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchSelection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchSelection.FormattingEnabled = true;
            this.cmbSearchSelection.Items.AddRange(new object[] {
            "ID",
            "Rank"});
            this.cmbSearchSelection.Location = new System.Drawing.Point(488, 15);
            this.cmbSearchSelection.Name = "cmbSearchSelection";
            this.cmbSearchSelection.Size = new System.Drawing.Size(141, 26);
            this.cmbSearchSelection.TabIndex = 1;
            this.cmbSearchSelection.SelectedIndexChanged += new System.EventHandler(this.cmbSearchSelection_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.White;
            this.lblSearchBy.Location = new System.Drawing.Point(388, 18);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(92, 19);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search by:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(8, 6);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(165, 43);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "         Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.dgvEmployeeDetails);
            this.pnlGridView.Location = new System.Drawing.Point(0, 55);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(827, 323);
            this.pnlGridView.TabIndex = 1;
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.AllowUserToAddRows = false;
            this.dgvEmployeeDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeCellPhone,
            this.EmployeeAddress,
            this.EmployeeEmail,
            this.EmployeeMaritalStatus,
            this.EmployeeGender,
            this.EmployeeBirthDate,
            this.EmployeeJoinDate,
            this.EmployeeRank});
            this.dgvEmployeeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeDetails.EnableHeadersVisualStyles = false;
            this.dgvEmployeeDetails.GridColor = System.Drawing.Color.DarkGray;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(827, 323);
            this.dgvEmployeeDetails.TabIndex = 0;
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.FillWeight = 395.9391F;
            this.EmployeeID.HeaderText = "User Name/ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeID.Width = 70;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.FillWeight = 401.0151F;
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Width = 120;
            // 
            // EmployeeCellPhone
            // 
            this.EmployeeCellPhone.DataPropertyName = "EmployeeCellPhone";
            this.EmployeeCellPhone.FillWeight = 25.38071F;
            this.EmployeeCellPhone.HeaderText = "Cell Phone";
            this.EmployeeCellPhone.Name = "EmployeeCellPhone";
            this.EmployeeCellPhone.ReadOnly = true;
            this.EmployeeCellPhone.Width = 90;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.DataPropertyName = "EmployeeAddress";
            this.EmployeeAddress.FillWeight = 25.38071F;
            this.EmployeeAddress.HeaderText = "Address";
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.ReadOnly = true;
            // 
            // EmployeeEmail
            // 
            this.EmployeeEmail.DataPropertyName = "EmployeeEmail";
            this.EmployeeEmail.FillWeight = 25.38071F;
            this.EmployeeEmail.HeaderText = "Email Address";
            this.EmployeeEmail.Name = "EmployeeEmail";
            this.EmployeeEmail.ReadOnly = true;
            this.EmployeeEmail.Width = 160;
            // 
            // EmployeeMaritalStatus
            // 
            this.EmployeeMaritalStatus.DataPropertyName = "EmployeeMaritalStatus";
            this.EmployeeMaritalStatus.FillWeight = 25.38071F;
            this.EmployeeMaritalStatus.HeaderText = "Marital Status";
            this.EmployeeMaritalStatus.Name = "EmployeeMaritalStatus";
            this.EmployeeMaritalStatus.ReadOnly = true;
            this.EmployeeMaritalStatus.Width = 70;
            // 
            // EmployeeGender
            // 
            this.EmployeeGender.DataPropertyName = "EmployeeGender";
            this.EmployeeGender.FillWeight = 25.38071F;
            this.EmployeeGender.HeaderText = "Gender";
            this.EmployeeGender.Name = "EmployeeGender";
            this.EmployeeGender.ReadOnly = true;
            this.EmployeeGender.Width = 60;
            // 
            // EmployeeBirthDate
            // 
            this.EmployeeBirthDate.DataPropertyName = "EmployeeBirthDate";
            this.EmployeeBirthDate.FillWeight = 25.38071F;
            this.EmployeeBirthDate.HeaderText = "Birth Date";
            this.EmployeeBirthDate.Name = "EmployeeBirthDate";
            this.EmployeeBirthDate.ReadOnly = true;
            this.EmployeeBirthDate.Width = 80;
            // 
            // EmployeeJoinDate
            // 
            this.EmployeeJoinDate.DataPropertyName = "EmployeeJoinDate";
            this.EmployeeJoinDate.FillWeight = 25.38071F;
            this.EmployeeJoinDate.HeaderText = "Join Date";
            this.EmployeeJoinDate.Name = "EmployeeJoinDate";
            this.EmployeeJoinDate.ReadOnly = true;
            this.EmployeeJoinDate.Width = 80;
            // 
            // EmployeeRank
            // 
            this.EmployeeRank.DataPropertyName = "EmployeeRank";
            this.EmployeeRank.FillWeight = 25.38071F;
            this.EmployeeRank.HeaderText = "Rank";
            this.EmployeeRank.Name = "EmployeeRank";
            this.EmployeeRank.ReadOnly = true;
            this.EmployeeRank.Width = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(66, 9);
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
            this.pnlCancel.TabIndex = 2;
            // 
            // pnlRefresh
            // 
            this.pnlRefresh.Controls.Add(this.btnRefresh);
            this.pnlRefresh.Location = new System.Drawing.Point(3, 381);
            this.pnlRefresh.Name = "pnlRefresh";
            this.pnlRefresh.Size = new System.Drawing.Size(293, 59);
            this.pnlRefresh.TabIndex = 3;
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
            // UC_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRefresh);
            this.Controls.Add(this.pnlCancel);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(827, 443);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.pnlCancel.ResumeLayout(false);
            this.pnlRefresh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.ComboBox cmbSearchSelection;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeMaritalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeJoinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeRank;
        private System.Windows.Forms.Panel pnlRefresh;
        private System.Windows.Forms.Button btnRefresh;
    }
}
