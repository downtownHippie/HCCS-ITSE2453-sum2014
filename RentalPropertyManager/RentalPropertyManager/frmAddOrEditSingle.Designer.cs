namespace RentalPropertyManager
{
    partial class frmAddOrEditSingle
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelYearBult = new System.Windows.Forms.Label();
            this.labelBuilder = new System.Windows.Forms.Label();
            this.lableSquareFeet = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.tbSquareFootage = new System.Windows.Forms.TextBox();
            this.tbBuilder = new System.Windows.Forms.TextBox();
            this.tbYearBulit = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbRent = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.cbGarage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(15, 17);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 17);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // labelYearBult
            // 
            this.labelYearBult.AutoSize = true;
            this.labelYearBult.Location = new System.Drawing.Point(15, 46);
            this.labelYearBult.Name = "labelYearBult";
            this.labelYearBult.Size = new System.Drawing.Size(62, 17);
            this.labelYearBult.TabIndex = 1;
            this.labelYearBult.Text = "Year Built";
            // 
            // labelBuilder
            // 
            this.labelBuilder.AutoSize = true;
            this.labelBuilder.Location = new System.Drawing.Point(15, 75);
            this.labelBuilder.Name = "labelBuilder";
            this.labelBuilder.Size = new System.Drawing.Size(48, 17);
            this.labelBuilder.TabIndex = 2;
            this.labelBuilder.Text = "Builder";
            // 
            // lableSquareFeet
            // 
            this.lableSquareFeet.AutoSize = true;
            this.lableSquareFeet.Location = new System.Drawing.Point(15, 104);
            this.lableSquareFeet.Name = "lableSquareFeet";
            this.lableSquareFeet.Size = new System.Drawing.Size(101, 17);
            this.lableSquareFeet.TabIndex = 3;
            this.lableSquareFeet.Text = "Square Footage";
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Location = new System.Drawing.Point(15, 135);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(34, 17);
            this.labelRent.TabIndex = 4;
            this.labelRent.Text = "Rent";
            // 
            // tbSquareFootage
            // 
            this.tbSquareFootage.Location = new System.Drawing.Point(126, 101);
            this.tbSquareFootage.Name = "tbSquareFootage";
            this.tbSquareFootage.Size = new System.Drawing.Size(273, 25);
            this.tbSquareFootage.TabIndex = 3;
            this.tbSquareFootage.Tag = "Square Footage";
            // 
            // tbBuilder
            // 
            this.tbBuilder.Location = new System.Drawing.Point(126, 72);
            this.tbBuilder.Name = "tbBuilder";
            this.tbBuilder.Size = new System.Drawing.Size(273, 25);
            this.tbBuilder.TabIndex = 2;
            this.tbBuilder.Tag = "Builder";
            // 
            // tbYearBulit
            // 
            this.tbYearBulit.Location = new System.Drawing.Point(126, 43);
            this.tbYearBulit.Name = "tbYearBulit";
            this.tbYearBulit.Size = new System.Drawing.Size(273, 25);
            this.tbYearBulit.TabIndex = 1;
            this.tbYearBulit.Tag = "Year Built";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(126, 14);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(273, 25);
            this.tbAddress.TabIndex = 0;
            this.tbAddress.Tag = "Address";
            // 
            // tbRent
            // 
            this.tbRent.Location = new System.Drawing.Point(126, 132);
            this.tbRent.Name = "tbRent";
            this.tbRent.Size = new System.Drawing.Size(273, 25);
            this.tbRent.TabIndex = 4;
            this.tbRent.Tag = "Rent";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(243, 172);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(324, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // cbGarage
            // 
            this.cbGarage.AutoSize = true;
            this.cbGarage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbGarage.Location = new System.Drawing.Point(15, 164);
            this.cbGarage.Name = "cbGarage";
            this.cbGarage.Size = new System.Drawing.Size(70, 21);
            this.cbGarage.TabIndex = 5;
            this.cbGarage.Tag = "";
            this.cbGarage.Text = "Garage";
            this.cbGarage.UseVisualStyleBackColor = true;
            // 
            // frmAddSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 207);
            this.Controls.Add(this.cbGarage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbRent);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbYearBulit);
            this.Controls.Add(this.tbBuilder);
            this.Controls.Add(this.tbSquareFootage);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.lableSquareFeet);
            this.Controls.Add(this.labelBuilder);
            this.Controls.Add(this.labelYearBult);
            this.Controls.Add(this.labelAddress);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddSingle";
            this.Text = "Add Single Family Dwelling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelYearBult;
        private System.Windows.Forms.Label labelBuilder;
        private System.Windows.Forms.Label lableSquareFeet;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.TextBox tbSquareFootage;
        private System.Windows.Forms.TextBox tbBuilder;
        private System.Windows.Forms.TextBox tbYearBulit;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbRent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox cbGarage;
    }
}
