namespace WatchShopFormsApp
{
    partial class AdminDashboardForm
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
            this.updateInventoryButton = new System.Windows.Forms.Button();
            this.backUpDbButton = new System.Windows.Forms.Button();
            this.restroreDbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateInventoryButton
            // 
            this.updateInventoryButton.Location = new System.Drawing.Point(71, 137);
            this.updateInventoryButton.Name = "updateInventoryButton";
            this.updateInventoryButton.Size = new System.Drawing.Size(166, 53);
            this.updateInventoryButton.TabIndex = 0;
            this.updateInventoryButton.Text = "Update Inventory";
            this.updateInventoryButton.UseVisualStyleBackColor = true;
            // 
            // backUpDbButton
            // 
            this.backUpDbButton.Location = new System.Drawing.Point(302, 137);
            this.backUpDbButton.Name = "backUpDbButton";
            this.backUpDbButton.Size = new System.Drawing.Size(174, 53);
            this.backUpDbButton.TabIndex = 1;
            this.backUpDbButton.Text = "Backup Database";
            this.backUpDbButton.UseVisualStyleBackColor = true;
            // 
            // restroreDbButton
            // 
            this.restroreDbButton.Location = new System.Drawing.Point(553, 137);
            this.restroreDbButton.Name = "restroreDbButton";
            this.restroreDbButton.Size = new System.Drawing.Size(162, 53);
            this.restroreDbButton.TabIndex = 2;
            this.restroreDbButton.Text = "Restore Database";
            this.restroreDbButton.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restroreDbButton);
            this.Controls.Add(this.backUpDbButton);
            this.Controls.Add(this.updateInventoryButton);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateInventoryButton;
        private System.Windows.Forms.Button backUpDbButton;
        private System.Windows.Forms.Button restroreDbButton;
    }
}