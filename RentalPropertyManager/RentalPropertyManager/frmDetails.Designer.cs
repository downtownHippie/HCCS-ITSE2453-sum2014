namespace RentalPropertyManager
{
    partial class frmDetails
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.lblBuilder = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblYearlyIncome = new System.Windows.Forms.Label();
            this.lblGarage = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(15, 13);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(257, 32);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Location = new System.Drawing.Point(12, 56);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(62, 17);
            this.lblYearBuilt.TabIndex = 1;
            this.lblYearBuilt.Text = "Year Built";
            // 
            // lblBuilder
            // 
            this.lblBuilder.AutoSize = true;
            this.lblBuilder.Location = new System.Drawing.Point(12, 84);
            this.lblBuilder.Name = "lblBuilder";
            this.lblBuilder.Size = new System.Drawing.Size(48, 17);
            this.lblBuilder.TabIndex = 2;
            this.lblBuilder.Text = "Builder";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 112);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(31, 17);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(12, 140);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(34, 17);
            this.lblRent.TabIndex = 4;
            this.lblRent.Text = "Rent";
            // 
            // lblYearlyIncome
            // 
            this.lblYearlyIncome.AutoSize = true;
            this.lblYearlyIncome.Location = new System.Drawing.Point(12, 168);
            this.lblYearlyIncome.Name = "lblYearlyIncome";
            this.lblYearlyIncome.Size = new System.Drawing.Size(89, 17);
            this.lblYearlyIncome.TabIndex = 5;
            this.lblYearlyIncome.Text = "Yearly Income";
            // 
            // lblGarage
            // 
            this.lblGarage.AutoSize = true;
            this.lblGarage.Location = new System.Drawing.Point(12, 196);
            this.lblGarage.Name = "lblGarage";
            this.lblGarage.Size = new System.Drawing.Size(51, 17);
            this.lblGarage.TabIndex = 6;
            this.lblGarage.Text = "Garage";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(105, 224);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // frmDetails
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lblGarage);
            this.Controls.Add(this.lblYearlyIncome);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblBuilder);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.lblAddress);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDetails";
            this.Text = "Property Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.Label lblBuilder;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblYearlyIncome;
        private System.Windows.Forms.Label lblGarage;
        private System.Windows.Forms.Button buttonClose;
    }
}