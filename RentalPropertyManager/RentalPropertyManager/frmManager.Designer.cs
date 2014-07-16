namespace RentalPropertyManager
{
    partial class frmManager
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
            this.listBoxOfProperties = new System.Windows.Forms.ListBox();
            this.buttonAddSingle = new System.Windows.Forms.Button();
            this.buttonAddMulti = new System.Windows.Forms.Button();
            this.buttonDetails = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEditProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOfProperties
            // 
            this.listBoxOfProperties.FormattingEnabled = true;
            this.listBoxOfProperties.ItemHeight = 17;
            this.listBoxOfProperties.Location = new System.Drawing.Point(15, 17);
            this.listBoxOfProperties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxOfProperties.Name = "listBoxOfProperties";
            this.listBoxOfProperties.Size = new System.Drawing.Size(304, 310);
            this.listBoxOfProperties.TabIndex = 0;
            // 
            // buttonAddSingle
            // 
            this.buttonAddSingle.Location = new System.Drawing.Point(326, 17);
            this.buttonAddSingle.Name = "buttonAddSingle";
            this.buttonAddSingle.Size = new System.Drawing.Size(180, 40);
            this.buttonAddSingle.TabIndex = 0;
            this.buttonAddSingle.Text = "Add Single Family Dwelling";
            this.buttonAddSingle.UseVisualStyleBackColor = true;
            this.buttonAddSingle.Click += new System.EventHandler(this.buttonAddSingle_Click);
            // 
            // buttonAddMulti
            // 
            this.buttonAddMulti.Location = new System.Drawing.Point(326, 65);
            this.buttonAddMulti.Name = "buttonAddMulti";
            this.buttonAddMulti.Size = new System.Drawing.Size(180, 40);
            this.buttonAddMulti.TabIndex = 1;
            this.buttonAddMulti.Text = "Add Multi Family Dwelling";
            this.buttonAddMulti.UseVisualStyleBackColor = true;
            this.buttonAddMulti.Click += new System.EventHandler(this.buttonAddMulti_Click);
            // 
            // buttonDetails
            // 
            this.buttonDetails.Location = new System.Drawing.Point(326, 161);
            this.buttonDetails.Name = "buttonDetails";
            this.buttonDetails.Size = new System.Drawing.Size(180, 40);
            this.buttonDetails.TabIndex = 2;
            this.buttonDetails.Text = "Property Details";
            this.buttonDetails.UseVisualStyleBackColor = true;
            this.buttonDetails.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(326, 209);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(180, 40);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove Property";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(326, 287);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 40);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEditProperty
            // 
            this.buttonEditProperty.Location = new System.Drawing.Point(326, 113);
            this.buttonEditProperty.Name = "buttonEditProperty";
            this.buttonEditProperty.Size = new System.Drawing.Size(180, 40);
            this.buttonEditProperty.TabIndex = 5;
            this.buttonEditProperty.Text = "Edit Property";
            this.buttonEditProperty.UseVisualStyleBackColor = true;
            this.buttonEditProperty.Click += new System.EventHandler(this.buttonEditProperty_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 344);
            this.Controls.Add(this.buttonEditProperty);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonDetails);
            this.Controls.Add(this.buttonAddMulti);
            this.Controls.Add(this.buttonAddSingle);
            this.Controls.Add(this.listBoxOfProperties);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmManager";
            this.Text = "Rental Property Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOfProperties;
        private System.Windows.Forms.Button buttonAddSingle;
        private System.Windows.Forms.Button buttonAddMulti;
        private System.Windows.Forms.Button buttonDetails;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonEditProperty;
    }
}

