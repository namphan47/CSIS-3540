namespace WatchShopFormsApp
{
    partial class SalesAssociateForm
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
            this.labelSalesAssociateMsg = new System.Windows.Forms.Label();
            this.updateEmpPerDetailsButton = new System.Windows.Forms.Button();
            this.salesPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSalesAssociateMsg
            // 
            this.labelSalesAssociateMsg.AutoSize = true;
            this.labelSalesAssociateMsg.Location = new System.Drawing.Point(298, 50);
            this.labelSalesAssociateMsg.Name = "labelSalesAssociateMsg";
            this.labelSalesAssociateMsg.Size = new System.Drawing.Size(108, 17);
            this.labelSalesAssociateMsg.TabIndex = 0;
            this.labelSalesAssociateMsg.Text = "Sales Associate";
            // 
            // updateEmpPerDetailsButton
            // 
            this.updateEmpPerDetailsButton.Location = new System.Drawing.Point(133, 145);
            this.updateEmpPerDetailsButton.Name = "updateEmpPerDetailsButton";
            this.updateEmpPerDetailsButton.Size = new System.Drawing.Size(159, 69);
            this.updateEmpPerDetailsButton.TabIndex = 1;
            this.updateEmpPerDetailsButton.Text = "Update Personal Details";
            this.updateEmpPerDetailsButton.UseVisualStyleBackColor = true;
            // 
            // salesPersonButton
            // 
            this.salesPersonButton.Location = new System.Drawing.Point(471, 145);
            this.salesPersonButton.Name = "salesPersonButton";
            this.salesPersonButton.Size = new System.Drawing.Size(159, 69);
            this.salesPersonButton.TabIndex = 2;
            this.salesPersonButton.Text = "Sales Report";
            this.salesPersonButton.UseVisualStyleBackColor = true;
            // 
            // SalesAssociateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salesPersonButton);
            this.Controls.Add(this.updateEmpPerDetailsButton);
            this.Controls.Add(this.labelSalesAssociateMsg);
            this.Name = "SalesAssociateForm";
            this.Text = "SalesAssociateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalesAssociateMsg;
        private System.Windows.Forms.Button updateEmpPerDetailsButton;
        private System.Windows.Forms.Button salesPersonButton;
    }
}