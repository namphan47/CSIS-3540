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
            this.SuspendLayout();
            // 
            // labelWelcomeMsg
            // 
            this.labelWelcomeMsg.AutoSize = true;
            this.labelWelcomeMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWelcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMsg.Location = new System.Drawing.Point(262, 60);
            this.labelWelcomeMsg.Name = "labelWelcomeMsg";
            this.labelWelcomeMsg.Size = new System.Drawing.Size(230, 19);
            this.labelWelcomeMsg.TabIndex = 0;
            this.labelWelcomeMsg.Text = "Welcome To WatchShop Store";
            // 
            // buttonSalesAssociate
            // 
            this.buttonSalesAssociate.Location = new System.Drawing.Point(128, 157);
            this.buttonSalesAssociate.Name = "buttonSalesAssociate";
            this.buttonSalesAssociate.Size = new System.Drawing.Size(140, 43);
            this.buttonSalesAssociate.TabIndex = 1;
            this.buttonSalesAssociate.Text = "SalesAssociate";
            this.buttonSalesAssociate.UseVisualStyleBackColor = true;
            // 
            // buttonManager
            // 
            this.buttonManager.Location = new System.Drawing.Point(327, 157);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(140, 43);
            this.buttonManager.TabIndex = 2;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(539, 157);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(140, 43);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // WatchShopMainFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonSalesAssociate);
            this.Controls.Add(this.labelWelcomeMsg);
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
    }
}

