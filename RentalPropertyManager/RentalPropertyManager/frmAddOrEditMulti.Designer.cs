namespace RentalPropertyManager
{
    partial class frmAddOrEditMulti
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
            this.labelNumUnits = new System.Windows.Forms.Label();
            this.labelPricePer = new System.Windows.Forms.Label();
            this.tbNumUnits = new System.Windows.Forms.TextBox();
            this.tbBuilder = new System.Windows.Forms.TextBox();
            this.tbYearBulit = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPricePer = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 17);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 17);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // labelYearBult
            // 
            this.labelYearBult.AutoSize = true;
            this.labelYearBult.Location = new System.Drawing.Point(12, 46);
            this.labelYearBult.Name = "labelYearBult";
            this.labelYearBult.Size = new System.Drawing.Size(62, 17);
            this.labelYearBult.TabIndex = 1;
            this.labelYearBult.Text = "Year Built";
            // 
            // labelBuilder
            // 
            this.labelBuilder.AutoSize = true;
            this.labelBuilder.Location = new System.Drawing.Point(12, 75);
            this.labelBuilder.Name = "labelBuilder";
            this.labelBuilder.Size = new System.Drawing.Size(48, 17);
            this.labelBuilder.TabIndex = 2;
            this.labelBuilder.Text = "Builder";
            // 
            // labelNumUnits
            // 
            this.labelNumUnits.AutoSize = true;
            this.labelNumUnits.Location = new System.Drawing.Point(12, 104);
            this.labelNumUnits.Name = "labelNumUnits";
            this.labelNumUnits.Size = new System.Drawing.Size(105, 17);
            this.labelNumUnits.TabIndex = 3;
            this.labelNumUnits.Text = "Number of Units";
            // 
            // labelPricePer
            // 
            this.labelPricePer.AutoSize = true;
            this.labelPricePer.Location = new System.Drawing.Point(12, 135);
            this.labelPricePer.Name = "labelPricePer";
            this.labelPricePer.Size = new System.Drawing.Size(86, 17);
            this.labelPricePer.TabIndex = 4;
            this.labelPricePer.Text = "Price Per Unit";
            // 
            // tbNumUnits
            // 
            this.tbNumUnits.Location = new System.Drawing.Point(126, 101);
            this.tbNumUnits.Name = "tbNumUnits";
            this.tbNumUnits.Size = new System.Drawing.Size(273, 25);
            this.tbNumUnits.TabIndex = 3;
            this.tbNumUnits.Tag = "Number of Units";
            // 
            // tbBuilder
            // 
            this.tbBuilder.Location = new System.Drawing.Point(126, 72);
            this.tbBuilder.Name = "tbBuilder";
            this.tbBuilder.Size = new System.Drawing.Size(273, 25);
            this.tbBuilder.TabIndex = 2;
            this.tbBuilder.Tag = "Year Built";
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
            // tbPricePer
            // 
            this.tbPricePer.Location = new System.Drawing.Point(126, 132);
            this.tbPricePer.Name = "tbPricePer";
            this.tbPricePer.Size = new System.Drawing.Size(273, 25);
            this.tbPricePer.TabIndex = 4;
            this.tbPricePer.Tag = "Price Per Unit";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(243, 172);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(324, 172);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // frmAddMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 207);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tbPricePer);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbYearBulit);
            this.Controls.Add(this.tbBuilder);
            this.Controls.Add(this.tbNumUnits);
            this.Controls.Add(this.labelPricePer);
            this.Controls.Add(this.labelNumUnits);
            this.Controls.Add(this.labelBuilder);
            this.Controls.Add(this.labelYearBult);
            this.Controls.Add(this.labelAddress);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddMulti";
            this.Text = "Add Multi Family Dwelling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelYearBult;
        private System.Windows.Forms.Label labelBuilder;
        private System.Windows.Forms.Label labelNumUnits;
        private System.Windows.Forms.Label labelPricePer;
        private System.Windows.Forms.TextBox tbNumUnits;
        private System.Windows.Forms.TextBox tbBuilder;
        private System.Windows.Forms.TextBox tbYearBulit;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPricePer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}