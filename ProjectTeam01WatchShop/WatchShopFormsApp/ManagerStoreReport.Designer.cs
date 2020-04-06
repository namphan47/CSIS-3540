namespace WatchShopFormsApp
{
    partial class ManagerStoreReport
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
            this.managerStoreDataGridView = new System.Windows.Forms.DataGridView();
            this.totalTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalAmtBeforeTextBox = new System.Windows.Forms.TextBox();
            this.totalAmtAfterTextBox = new System.Windows.Forms.TextBox();
            this.totalTaxPaidLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managerStoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // managerStoreDataGridView
            // 
            this.managerStoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerStoreDataGridView.Location = new System.Drawing.Point(33, 26);
            this.managerStoreDataGridView.Name = "managerStoreDataGridView";
            this.managerStoreDataGridView.RowHeadersWidth = 51;
            this.managerStoreDataGridView.RowTemplate.Height = 24;
            this.managerStoreDataGridView.Size = new System.Drawing.Size(1306, 455);
            this.managerStoreDataGridView.TabIndex = 0;
            // 
            // totalTaxTextBox
            // 
            this.totalTaxTextBox.Location = new System.Drawing.Point(208, 571);
            this.totalTaxTextBox.Name = "totalTaxTextBox";
            this.totalTaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTaxTextBox.TabIndex = 1;
            // 
            // totalAmtBeforeTextBox
            // 
            this.totalAmtBeforeTextBox.Location = new System.Drawing.Point(688, 571);
            this.totalAmtBeforeTextBox.Name = "totalAmtBeforeTextBox";
            this.totalAmtBeforeTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalAmtBeforeTextBox.TabIndex = 2;
            // 
            // totalAmtAfterTextBox
            // 
            this.totalAmtAfterTextBox.Location = new System.Drawing.Point(1179, 571);
            this.totalAmtAfterTextBox.Name = "totalAmtAfterTextBox";
            this.totalAmtAfterTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalAmtAfterTextBox.TabIndex = 3;
            // 
            // totalTaxPaidLabel
            // 
            this.totalTaxPaidLabel.AutoSize = true;
            this.totalTaxPaidLabel.Location = new System.Drawing.Point(77, 571);
            this.totalTaxPaidLabel.Name = "totalTaxPaidLabel";
            this.totalTaxPaidLabel.Size = new System.Drawing.Size(99, 17);
            this.totalTaxPaidLabel.TabIndex = 4;
            this.totalTaxPaidLabel.Text = "Total Tax Paid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Amount Before Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(969, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Amount After Tax";
            // 
            // ManagerStoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 778);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTaxPaidLabel);
            this.Controls.Add(this.totalAmtAfterTextBox);
            this.Controls.Add(this.totalAmtBeforeTextBox);
            this.Controls.Add(this.totalTaxTextBox);
            this.Controls.Add(this.managerStoreDataGridView);
            this.Name = "ManagerStoreReport";
            this.Text = "ManagerStoreReport";
            ((System.ComponentModel.ISupportInitialize)(this.managerStoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView managerStoreDataGridView;
        private System.Windows.Forms.TextBox totalTaxTextBox;
        private System.Windows.Forms.TextBox totalAmtBeforeTextBox;
        private System.Windows.Forms.TextBox totalAmtAfterTextBox;
        private System.Windows.Forms.Label totalTaxPaidLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}