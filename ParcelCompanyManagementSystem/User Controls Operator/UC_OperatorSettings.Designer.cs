namespace ParcelCompanyManagementSystem.User_Controls_Operator
{
    partial class UC_OperatorSettings
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
            this.btnChangeMyPassword = new System.Windows.Forms.Button();
            this.pnlChangeMyPassword = new System.Windows.Forms.Panel();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlChangeMyPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeMyPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 109);
            this.panel1.TabIndex = 0;
            // 
            // btnChangeMyPassword
            // 
            this.btnChangeMyPassword.BackColor = System.Drawing.Color.DarkGray;
            this.btnChangeMyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMyPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMyPassword.ForeColor = System.Drawing.Color.White;
            this.btnChangeMyPassword.Location = new System.Drawing.Point(292, 36);
            this.btnChangeMyPassword.Name = "btnChangeMyPassword";
            this.btnChangeMyPassword.Size = new System.Drawing.Size(240, 47);
            this.btnChangeMyPassword.TabIndex = 1;
            this.btnChangeMyPassword.Text = "Change My Password";
            this.btnChangeMyPassword.UseVisualStyleBackColor = false;
            this.btnChangeMyPassword.Click += new System.EventHandler(this.btnChangeMyPassword_Click);
            // 
            // pnlChangeMyPassword
            // 
            this.pnlChangeMyPassword.Controls.Add(this.btnCancelChange);
            this.pnlChangeMyPassword.Controls.Add(this.btnSave);
            this.pnlChangeMyPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlChangeMyPassword.Controls.Add(this.txtNewPassword);
            this.pnlChangeMyPassword.Controls.Add(this.txtOldPassword);
            this.pnlChangeMyPassword.Controls.Add(this.label5);
            this.pnlChangeMyPassword.Controls.Add(this.label4);
            this.pnlChangeMyPassword.Controls.Add(this.label3);
            this.pnlChangeMyPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChangeMyPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChangeMyPassword.Location = new System.Drawing.Point(0, 107);
            this.pnlChangeMyPassword.Name = "pnlChangeMyPassword";
            this.pnlChangeMyPassword.Size = new System.Drawing.Size(827, 336);
            this.pnlChangeMyPassword.TabIndex = 2;
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelChange.FlatAppearance.BorderSize = 2;
            this.btnCancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelChange.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChange.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelChange.Location = new System.Drawing.Point(253, 168);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(145, 34);
            this.btnCancelChange.TabIndex = 13;
            this.btnCancelChange.Text = "Cancel";
            this.btnCancelChange.UseVisualStyleBackColor = true;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(422, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Location = new System.Drawing.Point(391, 107);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(199, 26);
            this.txtConfirmPassword.TabIndex = 11;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.Location = new System.Drawing.Point(391, 71);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(199, 26);
            this.txtNewPassword.TabIndex = 10;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOldPassword.Location = new System.Drawing.Point(391, 31);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(199, 26);
            this.txtOldPassword.TabIndex = 9;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(224, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirm Password :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(251, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(259, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Old Password :";
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlChangeMyPassword);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(827, 443);
            this.panel1.ResumeLayout(false);
            this.pnlChangeMyPassword.ResumeLayout(false);
            this.pnlChangeMyPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangeMyPassword;
        private System.Windows.Forms.Panel pnlChangeMyPassword;
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
