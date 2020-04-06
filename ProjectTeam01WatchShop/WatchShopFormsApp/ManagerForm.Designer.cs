namespace WatchShopFormsApp
{
    partial class ManagerForm
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
            this.registerEmployeeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportGenerationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerEmployeeBtn
            // 
            this.registerEmployeeBtn.Location = new System.Drawing.Point(119, 149);
            this.registerEmployeeBtn.Name = "registerEmployeeBtn";
            this.registerEmployeeBtn.Size = new System.Drawing.Size(142, 53);
            this.registerEmployeeBtn.TabIndex = 0;
            this.registerEmployeeBtn.Text = "Employee Management";
            this.registerEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Screen";
            // 
            // reportGenerationBtn
            // 
            this.reportGenerationBtn.Location = new System.Drawing.Point(452, 149);
            this.reportGenerationBtn.Name = "reportGenerationBtn";
            this.reportGenerationBtn.Size = new System.Drawing.Size(134, 53);
            this.reportGenerationBtn.TabIndex = 2;
            this.reportGenerationBtn.Text = "Report Generation";
            this.reportGenerationBtn.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportGenerationBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerEmployeeBtn);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerEmployeeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportGenerationBtn;
    }
}