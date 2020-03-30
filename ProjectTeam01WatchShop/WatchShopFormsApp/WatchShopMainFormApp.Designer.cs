namespace WatchShopFormsApp
{
    partial class WatchShopMainFormApp
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
            this.labelWelcomeMsg = new System.Windows.Forms.Label();
            this.buttonSalesAssociate = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcomeMsg
            // 
            this.labelWelcomeMsg.AutoSize = true;
            this.labelWelcomeMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMsg.Location = new System.Drawing.Point(196, 49);
            this.labelWelcomeMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcomeMsg.Name = "labelWelcomeMsg";
            this.labelWelcomeMsg.Size = new System.Drawing.Size(184, 15);
            this.labelWelcomeMsg.TabIndex = 0;
            this.labelWelcomeMsg.Text = "Welcome To WatchShop Store";
            // 
            // buttonSalesAssociate
            // 
            this.buttonSalesAssociate.Location = new System.Drawing.Point(96, 128);
            this.buttonSalesAssociate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalesAssociate.Name = "buttonSalesAssociate";
            this.buttonSalesAssociate.Size = new System.Drawing.Size(105, 35);
            this.buttonSalesAssociate.TabIndex = 1;
            this.buttonSalesAssociate.Text = "SalesAssociate";
            this.buttonSalesAssociate.UseVisualStyleBackColor = true;
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(245, 128);
            this.buttonManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(105, 35);
            this.buttonManager.TabIndex = 2;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(404, 128);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(105, 35);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonStore
            // 
            this.buttonStore.Location = new System.Drawing.Point(245, 215);
            this.buttonStore.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(105, 35);
            this.buttonStore.TabIndex = 4;
            this.buttonStore.Text = "Store";
            this.buttonStore.UseVisualStyleBackColor = true;
            // 
            // WatchShopMainFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonSalesAssociate);
            this.Controls.Add(this.labelWelcomeMsg);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WatchShopMainFormApp";
            this.Text = "WatchShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeMsg;
        private System.Windows.Forms.Button buttonSalesAssociate;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonStore;
    }
}

