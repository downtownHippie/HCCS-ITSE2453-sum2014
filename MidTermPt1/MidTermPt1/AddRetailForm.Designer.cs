namespace MidTermPt1
{
    partial class AddRetailForm
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxHomePhone = new System.Windows.Forms.TextBox();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(13, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(74, 17);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(105, 13);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(267, 25);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Tag = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(105, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(267, 25);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.Tag = "Last Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(13, 44);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 17);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(105, 75);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(267, 25);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Tag = "Email";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(13, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxHomePhone
            // 
            this.textBoxHomePhone.Location = new System.Drawing.Point(105, 106);
            this.textBoxHomePhone.Name = "textBoxHomePhone";
            this.textBoxHomePhone.Size = new System.Drawing.Size(267, 25);
            this.textBoxHomePhone.TabIndex = 3;
            this.textBoxHomePhone.Tag = "Home Phone";
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(13, 106);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(86, 17);
            this.labelHomePhone.TabIndex = 6;
            this.labelHomePhone.Text = "Home Phone:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(296, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(215, 138);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AddRetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 171);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxHomePhone);
            this.Controls.Add(this.labelHomePhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddRetailForm";
            this.Text = "Add Retail Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxHomePhone;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}
