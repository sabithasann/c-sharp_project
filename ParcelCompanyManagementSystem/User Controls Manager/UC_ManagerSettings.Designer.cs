namespace ParcelCompanyManagementSystem.User_Controls
{
    partial class UC_ManagerSettings
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
            this.pnlResetEmployeePassword = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelReset = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.pnlChangeMyPassword = new System.Windows.Forms.Panel();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnResetEmployeePassword = new System.Windows.Forms.Button();
            this.btnChangeMyPassword = new System.Windows.Forms.Button();
            this.pnlResetEmployeePassword.SuspendLayout();
            this.pnlChangeMyPassword.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResetEmployeePassword
            // 
            this.pnlResetEmployeePassword.BackColor = System.Drawing.Color.White;
            this.pnlResetEmployeePassword.Controls.Add(this.label1);
            this.pnlResetEmployeePassword.Controls.Add(this.btnCancelReset);
            this.pnlResetEmployeePassword.Controls.Add(this.btnReset);
            this.pnlResetEmployeePassword.Controls.Add(this.label6);
            this.pnlResetEmployeePassword.Controls.Add(this.txtEmployeeID);
            this.pnlResetEmployeePassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResetEmployeePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlResetEmployeePassword.Location = new System.Drawing.Point(354, 222);
            this.pnlResetEmployeePassword.Name = "pnlResetEmployeePassword";
            this.pnlResetEmployeePassword.Size = new System.Drawing.Size(473, 221);
            this.pnlResetEmployeePassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(241, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "[exact ID required]";
            // 
            // btnCancelReset
            // 
            this.btnCancelReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReset.FlatAppearance.BorderSize = 2;
            this.btnCancelReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReset.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelReset.Location = new System.Drawing.Point(81, 121);
            this.btnCancelReset.Name = "btnCancelReset";
            this.btnCancelReset.Size = new System.Drawing.Size(145, 34);
            this.btnCancelReset.TabIndex = 3;
            this.btnCancelReset.Text = "Cancel";
            this.btnCancelReset.UseVisualStyleBackColor = true;
            this.btnCancelReset.Click += new System.EventHandler(this.btnCancelReset_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Location = new System.Drawing.Point(250, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(71, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee ID:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(203, 33);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(199, 26);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // pnlChangeMyPassword
            // 
            this.pnlChangeMyPassword.BackColor = System.Drawing.Color.White;
            this.pnlChangeMyPassword.Controls.Add(this.btnCancelChange);
            this.pnlChangeMyPassword.Controls.Add(this.btnSave);
            this.pnlChangeMyPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlChangeMyPassword.Controls.Add(this.txtNewPassword);
            this.pnlChangeMyPassword.Controls.Add(this.txtOldPassword);
            this.pnlChangeMyPassword.Controls.Add(this.label5);
            this.pnlChangeMyPassword.Controls.Add(this.label4);
            this.pnlChangeMyPassword.Controls.Add(this.label3);
            this.pnlChangeMyPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChangeMyPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChangeMyPassword.Location = new System.Drawing.Point(354, 0);
            this.pnlChangeMyPassword.Name = "pnlChangeMyPassword";
            this.pnlChangeMyPassword.Size = new System.Drawing.Size(473, 221);
            this.pnlChangeMyPassword.TabIndex = 4;
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelChange.FlatAppearance.BorderSize = 2;
            this.btnCancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelChange.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChange.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelChange.Location = new System.Drawing.Point(76, 156);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(145, 34);
            this.btnCancelChange.TabIndex = 5;
            this.btnCancelChange.Text = "Cancel";
            this.btnCancelChange.UseVisualStyleBackColor = true;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(245, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(218, 95);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(199, 26);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(218, 59);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(199, 26);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(218, 19);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(199, 26);
            this.txtOldPassword.TabIndex = 1;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(51, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Password :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(78, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(86, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Old Password :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnResetEmployeePassword);
            this.panel3.Controls.Add(this.btnChangeMyPassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 443);
            this.panel3.TabIndex = 3;
            // 
            // btnResetEmployeePassword
            // 
            this.btnResetEmployeePassword.BackColor = System.Drawing.Color.DarkGray;
            this.btnResetEmployeePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEmployeePassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEmployeePassword.ForeColor = System.Drawing.Color.White;
            this.btnResetEmployeePassword.Location = new System.Drawing.Point(56, 120);
            this.btnResetEmployeePassword.Name = "btnResetEmployeePassword";
            this.btnResetEmployeePassword.Size = new System.Drawing.Size(240, 47);
            this.btnResetEmployeePassword.TabIndex = 1;
            this.btnResetEmployeePassword.Text = "Reset Employee Password";
            this.btnResetEmployeePassword.UseVisualStyleBackColor = false;
            this.btnResetEmployeePassword.Click += new System.EventHandler(this.btnResetEmployeePassword_Click);
            // 
            // btnChangeMyPassword
            // 
            this.btnChangeMyPassword.BackColor = System.Drawing.Color.DarkGray;
            this.btnChangeMyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMyPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMyPassword.ForeColor = System.Drawing.Color.White;
            this.btnChangeMyPassword.Location = new System.Drawing.Point(56, 22);
            this.btnChangeMyPassword.Name = "btnChangeMyPassword";
            this.btnChangeMyPassword.Size = new System.Drawing.Size(240, 47);
            this.btnChangeMyPassword.TabIndex = 0;
            this.btnChangeMyPassword.Text = "Change My Password";
            this.btnChangeMyPassword.UseVisualStyleBackColor = false;
            this.btnChangeMyPassword.Click += new System.EventHandler(this.btnChangeMyPassword_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResetEmployeePassword);
            this.Controls.Add(this.pnlChangeMyPassword);
            this.Controls.Add(this.panel3);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(827, 443);
            this.pnlResetEmployeePassword.ResumeLayout(false);
            this.pnlResetEmployeePassword.PerformLayout();
            this.pnlChangeMyPassword.ResumeLayout(false);
            this.pnlChangeMyPassword.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlResetEmployeePassword;
        private System.Windows.Forms.Button btnCancelReset;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Panel pnlChangeMyPassword;
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnResetEmployeePassword;
        private System.Windows.Forms.Button btnChangeMyPassword;
        private System.Windows.Forms.Label label1;
    }
}
