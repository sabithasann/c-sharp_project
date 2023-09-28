
namespace ParcelCompanyManagementSystem.User_Controls
{
    partial class UC_MerchantCashout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMerchantId = new MetroFramework.Controls.MetroTextBox();
            this.btnSearchMerchant = new System.Windows.Forms.Button();
            this.pnlSearchResults = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCashout = new System.Windows.Forms.Button();
            this.txtCashoutAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMerchantName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWalletAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMerchantId);
            this.panel1.Controls.Add(this.btnSearchMerchant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 55);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "*Please search first to Cashout.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMerchantId
            // 
            this.txtMerchantId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMerchantId.CustomButton.Image = null;
            this.txtMerchantId.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtMerchantId.CustomButton.Name = "";
            this.txtMerchantId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMerchantId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMerchantId.CustomButton.TabIndex = 1;
            this.txtMerchantId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMerchantId.CustomButton.UseSelectable = true;
            this.txtMerchantId.CustomButton.Visible = false;
            this.txtMerchantId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMerchantId.Lines = new string[0];
            this.txtMerchantId.Location = new System.Drawing.Point(551, 14);
            this.txtMerchantId.MaxLength = 32767;
            this.txtMerchantId.Name = "txtMerchantId";
            this.txtMerchantId.PasswordChar = '\0';
            this.txtMerchantId.PromptText = "Search by Merchant ID...";
            this.txtMerchantId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMerchantId.SelectedText = "";
            this.txtMerchantId.SelectionLength = 0;
            this.txtMerchantId.SelectionStart = 0;
            this.txtMerchantId.ShortcutsEnabled = true;
            this.txtMerchantId.Size = new System.Drawing.Size(165, 26);
            this.txtMerchantId.TabIndex = 0;
            this.txtMerchantId.UseSelectable = true;
            this.txtMerchantId.WaterMark = "Search by Merchant ID...";
            this.txtMerchantId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMerchantId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSearchMerchant
            // 
            this.btnSearchMerchant.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearchMerchant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMerchant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMerchant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMerchant.ForeColor = System.Drawing.Color.White;
            this.btnSearchMerchant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMerchant.Location = new System.Drawing.Point(722, 9);
            this.btnSearchMerchant.Name = "btnSearchMerchant";
            this.btnSearchMerchant.Size = new System.Drawing.Size(84, 37);
            this.btnSearchMerchant.TabIndex = 1;
            this.btnSearchMerchant.Text = "Search";
            this.btnSearchMerchant.UseVisualStyleBackColor = true;
            this.btnSearchMerchant.Click += new System.EventHandler(this.btnSearchMerchant_Click);
            // 
            // pnlSearchResults
            // 
            this.pnlSearchResults.Controls.Add(this.btnCancel);
            this.pnlSearchResults.Controls.Add(this.btnCashout);
            this.pnlSearchResults.Controls.Add(this.txtCashoutAmount);
            this.pnlSearchResults.Controls.Add(this.label5);
            this.pnlSearchResults.Controls.Add(this.lblMerchantName);
            this.pnlSearchResults.Controls.Add(this.label6);
            this.pnlSearchResults.Controls.Add(this.lblWalletAmount);
            this.pnlSearchResults.Controls.Add(this.label2);
            this.pnlSearchResults.Location = new System.Drawing.Point(0, 55);
            this.pnlSearchResults.Name = "pnlSearchResults";
            this.pnlSearchResults.Size = new System.Drawing.Size(827, 388);
            this.pnlSearchResults.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(257, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 47);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCashout
            // 
            this.btnCashout.FlatAppearance.BorderSize = 2;
            this.btnCashout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCashout.Location = new System.Drawing.Point(419, 287);
            this.btnCashout.Name = "btnCashout";
            this.btnCashout.Size = new System.Drawing.Size(145, 47);
            this.btnCashout.TabIndex = 1;
            this.btnCashout.Text = "Cashout";
            this.btnCashout.UseVisualStyleBackColor = true;
            this.btnCashout.Click += new System.EventHandler(this.btnCashout_Click);
            // 
            // txtCashoutAmount
            // 
            this.txtCashoutAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCashoutAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashoutAmount.Location = new System.Drawing.Point(327, 222);
            this.txtCashoutAmount.Name = "txtCashoutAmount";
            this.txtCashoutAmount.Size = new System.Drawing.Size(173, 29);
            this.txtCashoutAmount.TabIndex = 0;
            this.txtCashoutAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCashoutAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashoutAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(331, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cashout Amount";
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMerchantName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerchantName.Location = new System.Drawing.Point(104, 55);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(618, 29);
            this.lblMerchantName.TabIndex = 25;
            this.lblMerchantName.Text = "#NAME";
            this.lblMerchantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(336, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Merchant Name";
            // 
            // lblWalletAmount
            // 
            this.lblWalletAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWalletAmount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletAmount.Location = new System.Drawing.Point(313, 116);
            this.lblWalletAmount.Name = "lblWalletAmount";
            this.lblWalletAmount.Size = new System.Drawing.Size(200, 29);
            this.lblWalletAmount.TabIndex = 1;
            this.lblWalletAmount.Text = "#VAL";
            this.lblWalletAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(343, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wallet Amount";
            // 
            // UC_MerchantCashout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSearchResults);
            this.Controls.Add(this.panel1);
            this.Name = "UC_MerchantCashout";
            this.Size = new System.Drawing.Size(827, 443);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearchResults.ResumeLayout(false);
            this.pnlSearchResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchMerchant;
        private System.Windows.Forms.Panel pnlSearchResults;
        private System.Windows.Forms.Label lblWalletAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCashout;
        private System.Windows.Forms.TextBox txtCashoutAmount;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtMerchantId;
        private System.Windows.Forms.Label label11;
    }
}
