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
            this.SuspendLayout();
            // 
            // labelSalesAssociateMsg
            // 
            this.labelSalesAssociateMsg.AutoSize = true;
            this.labelSalesAssociateMsg.Location = new System.Drawing.Point(137, 38);
            this.labelSalesAssociateMsg.Name = "labelSalesAssociateMsg";
            this.labelSalesAssociateMsg.Size = new System.Drawing.Size(108, 17);
            this.labelSalesAssociateMsg.TabIndex = 0;
            this.labelSalesAssociateMsg.Text = "Sales Associate";
            // 
            // SalesAssociateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSalesAssociateMsg);
            this.Name = "SalesAssociateForm";
            this.Text = "SalesAssociateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalesAssociateMsg;
    }
}