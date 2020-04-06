namespace WatchShopFormsApp
{
    partial class SalesReport
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
            this.salesReportDataGridView = new System.Windows.Forms.DataGridView();
            this.empNameListBox = new System.Windows.Forms.ListBox();
            this.brandNameListBox = new System.Windows.Forms.ListBox();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.totalTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountProductsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // salesReportDataGridView
            // 
            this.salesReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.salesReportDataGridView.Name = "salesReportDataGridView";
            this.salesReportDataGridView.RowHeadersWidth = 51;
            this.salesReportDataGridView.RowTemplate.Height = 24;
            this.salesReportDataGridView.Size = new System.Drawing.Size(1372, 413);
            this.salesReportDataGridView.TabIndex = 0;
            // 
            // empNameListBox
            // 
            this.empNameListBox.FormattingEnabled = true;
            this.empNameListBox.ItemHeight = 16;
            this.empNameListBox.Location = new System.Drawing.Point(433, 554);
            this.empNameListBox.Name = "empNameListBox";
            this.empNameListBox.Size = new System.Drawing.Size(120, 84);
            this.empNameListBox.TabIndex = 1;
            // 
            // brandNameListBox
            // 
            this.brandNameListBox.FormattingEnabled = true;
            this.brandNameListBox.ItemHeight = 16;
            this.brandNameListBox.Location = new System.Drawing.Point(872, 554);
            this.brandNameListBox.Name = "brandNameListBox";
            this.brandNameListBox.Size = new System.Drawing.Size(120, 84);
            this.brandNameListBox.TabIndex = 2;
            // 
            // totalQuantityTextBox
            // 
            this.totalQuantityTextBox.Location = new System.Drawing.Point(299, 460);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalQuantityTextBox.TabIndex = 3;
            // 
            // totalTransactionsTextBox
            // 
            this.totalTransactionsTextBox.Location = new System.Drawing.Point(735, 457);
            this.totalTransactionsTextBox.Name = "totalTransactionsTextBox";
            this.totalTransactionsTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTransactionsTextBox.TabIndex = 4;
            // 
            // totalAmountProductsTextBox
            // 
            this.totalAmountProductsTextBox.Location = new System.Drawing.Point(1241, 460);
            this.totalAmountProductsTextBox.Name = "totalAmountProductsTextBox";
            this.totalAmountProductsTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalAmountProductsTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Quantity Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1005, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Amount Of Products Sold";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1177, 577);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(106, 40);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 765);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAmountProductsTextBox);
            this.Controls.Add(this.totalTransactionsTextBox);
            this.Controls.Add(this.totalQuantityTextBox);
            this.Controls.Add(this.brandNameListBox);
            this.Controls.Add(this.empNameListBox);
            this.Controls.Add(this.salesReportDataGridView);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.salesReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView salesReportDataGridView;
        private System.Windows.Forms.ListBox empNameListBox;
        private System.Windows.Forms.ListBox brandNameListBox;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
        private System.Windows.Forms.TextBox totalTransactionsTextBox;
        private System.Windows.Forms.TextBox totalAmountProductsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
    }
}