namespace MidTermPt1
{
    partial class CustomerMaintenanceForm
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
            this.labelCustomers = new System.Windows.Forms.Label();
            this.buttonAddWholesale = new System.Windows.Forms.Button();
            this.buttonAddRetail = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Location = new System.Drawing.Point(14, 12);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(73, 17);
            this.labelCustomers.TabIndex = 0;
            this.labelCustomers.Text = "Customers:";
            // 
            // buttonAddWholesale
            // 
            this.buttonAddWholesale.Location = new System.Drawing.Point(370, 33);
            this.buttonAddWholesale.Name = "buttonAddWholesale";
            this.buttonAddWholesale.Size = new System.Drawing.Size(183, 30);
            this.buttonAddWholesale.TabIndex = 0;
            this.buttonAddWholesale.Text = "Add Wholesale";
            this.buttonAddWholesale.UseVisualStyleBackColor = true;
            this.buttonAddWholesale.Click += new System.EventHandler(this.buttonAddWholesale_Click);
            // 
            // buttonAddRetail
            // 
            this.buttonAddRetail.Location = new System.Drawing.Point(370, 69);
            this.buttonAddRetail.Name = "buttonAddRetail";
            this.buttonAddRetail.Size = new System.Drawing.Size(183, 30);
            this.buttonAddRetail.TabIndex = 1;
            this.buttonAddRetail.Text = "Add Retail";
            this.buttonAddRetail.UseVisualStyleBackColor = true;
            this.buttonAddRetail.Click += new System.EventHandler(this.buttonAddRetail_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(369, 105);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(183, 30);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(369, 141);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(183, 30);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 17;
            this.listBoxCustomers.Location = new System.Drawing.Point(13, 33);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(349, 259);
            this.listBoxCustomers.TabIndex = 6;
            // 
            // CustomerMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 308);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddRetail);
            this.Controls.Add(this.buttonAddWholesale);
            this.Controls.Add(this.labelCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerMaintenanceForm";
            this.Text = "Customer Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomers;
        private System.Windows.Forms.Button buttonAddWholesale;
        private System.Windows.Forms.Button buttonAddRetail;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxCustomers;
    }
}

