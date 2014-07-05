namespace MidTermPt2
{
    partial class CloneCustomer
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
            this.textBoxInitialCustomer = new System.Windows.Forms.TextBox();
            this.labelCopies = new System.Windows.Forms.Label();
            this.textBoxNumCopies = new System.Windows.Forms.TextBox();
            this.buttonClone = new System.Windows.Forms.Button();
            this.listBoxClonedCustomers = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInitialCustomer
            // 
            this.textBoxInitialCustomer.Location = new System.Drawing.Point(15, 17);
            this.textBoxInitialCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInitialCustomer.Name = "textBoxInitialCustomer";
            this.textBoxInitialCustomer.ReadOnly = true;
            this.textBoxInitialCustomer.Size = new System.Drawing.Size(301, 25);
            this.textBoxInitialCustomer.TabIndex = 0;
            // 
            // labelCopies
            // 
            this.labelCopies.AutoSize = true;
            this.labelCopies.Location = new System.Drawing.Point(48, 58);
            this.labelCopies.Name = "labelCopies";
            this.labelCopies.Size = new System.Drawing.Size(48, 17);
            this.labelCopies.TabIndex = 1;
            this.labelCopies.Text = "Copies";
            // 
            // textBoxNumCopies
            // 
            this.textBoxNumCopies.Location = new System.Drawing.Point(101, 54);
            this.textBoxNumCopies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNumCopies.Name = "textBoxNumCopies";
            this.textBoxNumCopies.Size = new System.Drawing.Size(52, 25);
            this.textBoxNumCopies.TabIndex = 2;
            this.textBoxNumCopies.Tag = "Copies";
            // 
            // buttonClone
            // 
            this.buttonClone.Location = new System.Drawing.Point(158, 55);
            this.buttonClone.Name = "buttonClone";
            this.buttonClone.Size = new System.Drawing.Size(75, 23);
            this.buttonClone.TabIndex = 3;
            this.buttonClone.Text = "Clone";
            this.buttonClone.UseVisualStyleBackColor = true;
            this.buttonClone.Click += new System.EventHandler(this.buttonClone_Click);
            // 
            // listBoxClonedCustomers
            // 
            this.listBoxClonedCustomers.FormattingEnabled = true;
            this.listBoxClonedCustomers.ItemHeight = 17;
            this.listBoxClonedCustomers.Location = new System.Drawing.Point(15, 86);
            this.listBoxClonedCustomers.Name = "listBoxClonedCustomers";
            this.listBoxClonedCustomers.Size = new System.Drawing.Size(301, 191);
            this.listBoxClonedCustomers.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(366, 254);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CloneCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 290);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listBoxClonedCustomers);
            this.Controls.Add(this.buttonClone);
            this.Controls.Add(this.textBoxNumCopies);
            this.Controls.Add(this.labelCopies);
            this.Controls.Add(this.textBoxInitialCustomer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CloneCustomer";
            this.Text = "Clone Customer";
            this.Load += new System.EventHandler(this.CloneCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInitialCustomer;
        private System.Windows.Forms.Label labelCopies;
        private System.Windows.Forms.TextBox textBoxNumCopies;
        private System.Windows.Forms.Button buttonClone;
        private System.Windows.Forms.ListBox listBoxClonedCustomers;
        private System.Windows.Forms.Button buttonExit;
    }
}

