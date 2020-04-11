namespace WatchShopFormsApp
{
    partial class UpdateEmpPersonalDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.upEmpEmailTextBox = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.upPhnNoTextBox = new System.Windows.Forms.TextBox();
            this.labelPhnNo = new System.Windows.Forms.Label();
            this.updateEmpButton = new System.Windows.Forms.Button();
            this.upPasswordTextBox = new System.Windows.Forms.TextBox();
            this.upEmpAddressTextBox = new System.Windows.Forms.TextBox();
            this.labelEmpPassword = new System.Windows.Forms.Label();
            this.labelEmpAddress = new System.Windows.Forms.Label();
            this.getEmpDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upEmpEmailTextBox
            // 
            this.upEmpEmailTextBox.Location = new System.Drawing.Point(755, 110);
            this.upEmpEmailTextBox.Name = "upEmpEmailTextBox";
            this.upEmpEmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.upEmpEmailTextBox.TabIndex = 39;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(545, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(108, 17);
            this.labelEmail.TabIndex = 38;
            this.labelEmail.Text = "Employee Email";
            // 
            // upPhnNoTextBox
            // 
            this.upPhnNoTextBox.Location = new System.Drawing.Point(781, 397);
            this.upPhnNoTextBox.Name = "upPhnNoTextBox";
            this.upPhnNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.upPhnNoTextBox.TabIndex = 37;
            // 
            // labelPhnNo
            // 
            this.labelPhnNo.AutoSize = true;
            this.labelPhnNo.Location = new System.Drawing.Point(545, 402);
            this.labelPhnNo.Name = "labelPhnNo";
            this.labelPhnNo.Size = new System.Drawing.Size(137, 17);
            this.labelPhnNo.TabIndex = 36;
            this.labelPhnNo.Text = "Employee Phone No";
            // 
            // updateEmpButton
            // 
            this.updateEmpButton.Location = new System.Drawing.Point(653, 475);
            this.updateEmpButton.Name = "updateEmpButton";
            this.updateEmpButton.Size = new System.Drawing.Size(169, 48);
            this.updateEmpButton.TabIndex = 35;
            this.updateEmpButton.Text = "Update Employee";
            this.updateEmpButton.UseVisualStyleBackColor = true;
            // 
            // upPasswordTextBox
            // 
            this.upPasswordTextBox.Location = new System.Drawing.Point(755, 160);
            this.upPasswordTextBox.Name = "upPasswordTextBox";
            this.upPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.upPasswordTextBox.TabIndex = 34;
            // 
            // upEmpAddressTextBox
            // 
            this.upEmpAddressTextBox.Location = new System.Drawing.Point(781, 325);
            this.upEmpAddressTextBox.Name = "upEmpAddressTextBox";
            this.upEmpAddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.upEmpAddressTextBox.TabIndex = 33;
            // 
            // labelEmpPassword
            // 
            this.labelEmpPassword.AutoSize = true;
            this.labelEmpPassword.Location = new System.Drawing.Point(545, 160);
            this.labelEmpPassword.Name = "labelEmpPassword";
            this.labelEmpPassword.Size = new System.Drawing.Size(135, 17);
            this.labelEmpPassword.TabIndex = 31;
            this.labelEmpPassword.Text = "Employee Password";
            // 
            // labelEmpAddress
            // 
            this.labelEmpAddress.AutoSize = true;
            this.labelEmpAddress.Location = new System.Drawing.Point(545, 325);
            this.labelEmpAddress.Name = "labelEmpAddress";
            this.labelEmpAddress.Size = new System.Drawing.Size(126, 17);
            this.labelEmpAddress.TabIndex = 30;
            this.labelEmpAddress.Text = "Employee Address";
            // 
            // getEmpDetailsButton
            // 
            this.getEmpDetailsButton.Location = new System.Drawing.Point(653, 222);
            this.getEmpDetailsButton.Name = "getEmpDetailsButton";
            this.getEmpDetailsButton.Size = new System.Drawing.Size(169, 40);
            this.getEmpDetailsButton.TabIndex = 40;
            this.getEmpDetailsButton.Text = "Get Employee Details";
            this.getEmpDetailsButton.UseVisualStyleBackColor = true;
            // 
            // UpdateEmpPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 789);
            this.Controls.Add(this.getEmpDetailsButton);
            this.Controls.Add(this.upEmpEmailTextBox);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.upPhnNoTextBox);
            this.Controls.Add(this.labelPhnNo);
            this.Controls.Add(this.updateEmpButton);
            this.Controls.Add(this.upPasswordTextBox);
            this.Controls.Add(this.upEmpAddressTextBox);
            this.Controls.Add(this.labelEmpPassword);
            this.Controls.Add(this.labelEmpAddress);
            this.Name = "UpdateEmpPersonalDetails";
            this.Text = "UpdateEmpPersonalDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upEmpEmailTextBox;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox upPhnNoTextBox;
        private System.Windows.Forms.Label labelPhnNo;
        private System.Windows.Forms.Button updateEmpButton;
        private System.Windows.Forms.TextBox upPasswordTextBox;
        private System.Windows.Forms.TextBox upEmpAddressTextBox;
        private System.Windows.Forms.Label labelEmpPassword;
        private System.Windows.Forms.Label labelEmpAddress;
        private System.Windows.Forms.Button getEmpDetailsButton;
    }
}