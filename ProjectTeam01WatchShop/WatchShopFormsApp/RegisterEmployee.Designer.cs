namespace WatchShopFormsApp
{
    partial class RegisterEmployee
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
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpAddress = new System.Windows.Forms.Label();
            this.labelEmpPassword = new System.Windows.Forms.Label();
            this.labelEmpRole = new System.Windows.Forms.Label();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.textBoxEmpAddress = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.listBoxEmpRole = new System.Windows.Forms.ListBox();
            this.checkBoxEmpActive = new System.Windows.Forms.CheckBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(79, 68);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(137, 17);
            this.labelEmpName.TabIndex = 0;
            this.labelEmpName.Text = "Employee Full Name";
            // 
            // labelEmpAddress
            // 
            this.labelEmpAddress.AutoSize = true;
            this.labelEmpAddress.Location = new System.Drawing.Point(79, 123);
            this.labelEmpAddress.Name = "labelEmpAddress";
            this.labelEmpAddress.Size = new System.Drawing.Size(126, 17);
            this.labelEmpAddress.TabIndex = 1;
            this.labelEmpAddress.Text = "Employee Address";
            // 
            // labelEmpPassword
            // 
            this.labelEmpPassword.AutoSize = true;
            this.labelEmpPassword.Location = new System.Drawing.Point(79, 184);
            this.labelEmpPassword.Name = "labelEmpPassword";
            this.labelEmpPassword.Size = new System.Drawing.Size(135, 17);
            this.labelEmpPassword.TabIndex = 2;
            this.labelEmpPassword.Text = "Employee Password";
            // 
            // labelEmpRole
            // 
            this.labelEmpRole.AutoSize = true;
            this.labelEmpRole.Location = new System.Drawing.Point(79, 245);
            this.labelEmpRole.Name = "labelEmpRole";
            this.labelEmpRole.Size = new System.Drawing.Size(146, 17);
            this.labelEmpRole.TabIndex = 3;
            this.labelEmpRole.Text = "Select Employee Role";
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(315, 68);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmpName.TabIndex = 5;
            // 
            // textBoxEmpAddress
            // 
            this.textBoxEmpAddress.Location = new System.Drawing.Point(315, 123);
            this.textBoxEmpAddress.Name = "textBoxEmpAddress";
            this.textBoxEmpAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmpAddress.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(315, 184);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // listBoxEmpRole
            // 
            this.listBoxEmpRole.FormattingEnabled = true;
            this.listBoxEmpRole.ItemHeight = 16;
            this.listBoxEmpRole.Location = new System.Drawing.Point(315, 235);
            this.listBoxEmpRole.Name = "listBoxEmpRole";
            this.listBoxEmpRole.Size = new System.Drawing.Size(120, 84);
            this.listBoxEmpRole.TabIndex = 8;
            // 
            // checkBoxEmpActive
            // 
            this.checkBoxEmpActive.AutoSize = true;
            this.checkBoxEmpActive.Location = new System.Drawing.Point(315, 352);
            this.checkBoxEmpActive.Name = "checkBoxEmpActive";
            this.checkBoxEmpActive.Size = new System.Drawing.Size(82, 21);
            this.checkBoxEmpActive.TabIndex = 9;
            this.checkBoxEmpActive.Text = "Is Active";
            this.checkBoxEmpActive.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(209, 390);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(103, 37);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Location = new System.Drawing.Point(536, 68);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.RowHeadersWidth = 51;
            this.dataGridViewDepartments.RowTemplate.Height = 24;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(879, 508);
            this.dataGridViewDepartments.TabIndex = 11;
            // 
            // RegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 754);
            this.Controls.Add(this.dataGridViewDepartments);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.checkBoxEmpActive);
            this.Controls.Add(this.listBoxEmpRole);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmpAddress);
            this.Controls.Add(this.textBoxEmpName);
            this.Controls.Add(this.labelEmpRole);
            this.Controls.Add(this.labelEmpPassword);
            this.Controls.Add(this.labelEmpAddress);
            this.Controls.Add(this.labelEmpName);
            this.Name = "RegisterEmployee";
            this.Text = "RegisterEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpAddress;
        private System.Windows.Forms.Label labelEmpPassword;
        private System.Windows.Forms.Label labelEmpRole;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.TextBox textBoxEmpAddress;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ListBox listBoxEmpRole;
        private System.Windows.Forms.CheckBox checkBoxEmpActive;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
    }
}