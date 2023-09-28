namespace ParcelCompanyManagementSystem.User_Controls_Operator
{
    partial class UC_AddParcel
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nudConditionalAmount = new System.Windows.Forms.NumericUpDown();
            this.txtEstimatedDeliveryDate = new System.Windows.Forms.TextBox();
            this.cmbParcelStatus = new System.Windows.Forms.ComboBox();
            this.cmbParcelType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAdditionalRemarks = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAreaOfDelivery = new System.Windows.Forms.ComboBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConditionalAmountFees = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblDeliveryFees = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConditionalAmount)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.DarkGray;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(827, 55);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(722, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(551, 14);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Merchant ID...";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(165, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Merchant ID...";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "*Please search the Merchant first to Add Parcel.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.txtAdditionalRemarks);
            this.pnlMain.Controls.Add(this.panel5);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.label19);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lblConditionalAmountFees);
            this.pnlMain.Controls.Add(this.lblTotalFees);
            this.pnlMain.Controls.Add(this.lblDeliveryFees);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.label17);
            this.pnlMain.Controls.Add(this.label13);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 55);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(827, 507);
            this.pnlMain.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nudConditionalAmount);
            this.panel6.Controls.Add(this.txtEstimatedDeliveryDate);
            this.panel6.Controls.Add(this.cmbParcelStatus);
            this.panel6.Controls.Add(this.cmbParcelType);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(0, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(825, 88);
            this.panel6.TabIndex = 79;
            // 
            // nudConditionalAmount
            // 
            this.nudConditionalAmount.Location = new System.Drawing.Point(576, 13);
            this.nudConditionalAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudConditionalAmount.Name = "nudConditionalAmount";
            this.nudConditionalAmount.Size = new System.Drawing.Size(188, 26);
            this.nudConditionalAmount.TabIndex = 1;
            this.nudConditionalAmount.ValueChanged += new System.EventHandler(this.nudConditionalAmount_ValueChanged);
            // 
            // txtEstimatedDeliveryDate
            // 
            this.txtEstimatedDeliveryDate.BackColor = System.Drawing.Color.White;
            this.txtEstimatedDeliveryDate.Location = new System.Drawing.Point(606, 50);
            this.txtEstimatedDeliveryDate.Name = "txtEstimatedDeliveryDate";
            this.txtEstimatedDeliveryDate.ReadOnly = true;
            this.txtEstimatedDeliveryDate.Size = new System.Drawing.Size(158, 26);
            this.txtEstimatedDeliveryDate.TabIndex = 3;
            // 
            // cmbParcelStatus
            // 
            this.cmbParcelStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelStatus.FormattingEnabled = true;
            this.cmbParcelStatus.Items.AddRange(new object[] {
            "Awaiting pickup",
            "Received at station"});
            this.cmbParcelStatus.Location = new System.Drawing.Point(184, 50);
            this.cmbParcelStatus.Name = "cmbParcelStatus";
            this.cmbParcelStatus.Size = new System.Drawing.Size(193, 26);
            this.cmbParcelStatus.TabIndex = 2;
            // 
            // cmbParcelType
            // 
            this.cmbParcelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelType.FormattingEnabled = true;
            this.cmbParcelType.Items.AddRange(new object[] {
            "Documents",
            "Documents (Express)",
            "Light Package",
            "Medium Package",
            "Heavy Package",
            "Extra Heavy Package"});
            this.cmbParcelType.Location = new System.Drawing.Point(184, 13);
            this.cmbParcelType.Name = "cmbParcelType";
            this.cmbParcelType.Size = new System.Drawing.Size(193, 26);
            this.cmbParcelType.TabIndex = 0;
            this.cmbParcelType.SelectedIndexChanged += new System.EventHandler(this.cmbParcelType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(404, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 19);
            this.label8.TabIndex = 79;
            this.label8.Text = "Estimated Delivery Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(404, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 19);
            this.label9.TabIndex = 80;
            this.label9.Text = "Conditional Amount:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(60, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 81;
            this.label10.Text = "Parcel Status:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(72, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 82;
            this.label14.Text = "Parcel Type:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(488, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 47);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(652, 439);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAdditionalRemarks
            // 
            this.txtAdditionalRemarks.Location = new System.Drawing.Point(200, 375);
            this.txtAdditionalRemarks.Name = "txtAdditionalRemarks";
            this.txtAdditionalRemarks.Size = new System.Drawing.Size(597, 26);
            this.txtAdditionalRemarks.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(0, 341);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 4);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(0, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 27);
            this.panel4.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(340, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "CHARGE DETAILS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(0, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 27);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(340, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "PARCEL DETAILS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(30, 378);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 19);
            this.label19.TabIndex = 74;
            this.label19.Text = "Additional Remarks:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbAreaOfDelivery);
            this.panel1.Controls.Add(this.txtCellPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 121);
            this.panel1.TabIndex = 1;
            // 
            // cmbAreaOfDelivery
            // 
            this.cmbAreaOfDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaOfDelivery.FormattingEnabled = true;
            this.cmbAreaOfDelivery.Items.AddRange(new object[] {
            "Agargao",
            "Ahmed Nagar",
            "Bangla College",
            "Ibrahimpur",
            "Kafrul",
            "Kallanpur",
            "Kazipara",
            "Mirpur 1",
            "Mirpur 10",
            "Mirpur 11",
            "Mirpur 12",
            "Mirpur 13",
            "Mirpur 14",
            "Mirpur 15",
            "Mirpur 16",
            "Mirpur 2",
            "Mirpur 3",
            "Mirpur 4",
            "Mirpur 5",
            "Mirpur 6",
            "Mirpur 60 Feet",
            "Mirpur 7",
            "Mirpur 8",
            "Mirpur 9",
            "Mirpur Botanical Garden",
            "Mirpur Cantonment",
            "Mirpur Ceramic",
            "Mirpur Colony",
            "Mirpur DOHS",
            "Mirpur Darus Salam",
            "Mirpur Zoo",
            "Monipur",
            "Paikpara",
            "Pirerbagh",
            "Rupnagar",
            "Shenpara Parbota",
            "Shewrapara",
            "Tolarbagh"});
            this.cmbAreaOfDelivery.Location = new System.Drawing.Point(173, 83);
            this.cmbAreaOfDelivery.Name = "cmbAreaOfDelivery";
            this.cmbAreaOfDelivery.Size = new System.Drawing.Size(204, 26);
            this.cmbAreaOfDelivery.TabIndex = 3;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(635, 11);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(158, 26);
            this.txtCellPhone.TabIndex = 1;
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(530, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "Cell Phone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(173, 46);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(620, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(30, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Area of Delivery:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(390, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 74;
            this.label6.Text = "Remarks:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(86, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(479, 83);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(314, 26);
            this.txtRemarks.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(345, 26);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(106, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 27);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEIVER DETAILS";
            // 
            // lblConditionalAmountFees
            // 
            this.lblConditionalAmountFees.AutoSize = true;
            this.lblConditionalAmountFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConditionalAmountFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditionalAmountFees.ForeColor = System.Drawing.Color.Black;
            this.lblConditionalAmountFees.Location = new System.Drawing.Point(495, 304);
            this.lblConditionalAmountFees.Name = "lblConditionalAmountFees";
            this.lblConditionalAmountFees.Size = new System.Drawing.Size(55, 20);
            this.lblConditionalAmountFees.TabIndex = 74;
            this.lblConditionalAmountFees.Text = "0         ";
            this.lblConditionalAmountFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.BackColor = System.Drawing.Color.DarkGray;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.White;
            this.lblTotalFees.Location = new System.Drawing.Point(688, 305);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(56, 21);
            this.lblTotalFees.TabIndex = 74;
            this.lblTotalFees.Text = "0         ";
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeliveryFees
            // 
            this.lblDeliveryFees.AutoSize = true;
            this.lblDeliveryFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveryFees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryFees.ForeColor = System.Drawing.Color.Black;
            this.lblDeliveryFees.Location = new System.Drawing.Point(188, 304);
            this.lblDeliveryFees.Name = "lblDeliveryFees";
            this.lblDeliveryFees.Size = new System.Drawing.Size(59, 20);
            this.lblDeliveryFees.TabIndex = 74;
            this.lblDeliveryFees.Text = "0          ";
            this.lblDeliveryFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(281, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 19);
            this.label15.TabIndex = 74;
            this.label15.Text = "Conditional Amount Fees:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gray;
            this.label17.Location = new System.Drawing.Point(588, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 19);
            this.label17.TabIndex = 74;
            this.label17.Text = "Total Fees:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(63, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 19);
            this.label13.TabIndex = 74;
            this.label13.Text = "Delivery Fees:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_AddParcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSearch);
            this.Name = "UC_AddParcel";
            this.Size = new System.Drawing.Size(827, 562);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConditionalAmount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAdditionalRemarks;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAreaOfDelivery;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConditionalAmountFees;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblDeliveryFees;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nudConditionalAmount;
        private System.Windows.Forms.TextBox txtEstimatedDeliveryDate;
        private System.Windows.Forms.ComboBox cmbParcelStatus;
        private System.Windows.Forms.ComboBox cmbParcelType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
    }
}
