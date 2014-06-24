namespace LinearSearchT
{
    partial class LinearSearch
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
            this.buttonCreateIntegers = new System.Windows.Forms.Button();
            this.buttonCreateDoubles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchTerm = new System.Windows.Forms.TextBox();
            this.labelValueFound = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCreateIntegers
            // 
            this.buttonCreateIntegers.Location = new System.Drawing.Point(13, 13);
            this.buttonCreateIntegers.Name = "buttonCreateIntegers";
            this.buttonCreateIntegers.Size = new System.Drawing.Size(154, 59);
            this.buttonCreateIntegers.TabIndex = 0;
            this.buttonCreateIntegers.Text = "Create Integers";
            this.buttonCreateIntegers.UseVisualStyleBackColor = true;
            this.buttonCreateIntegers.Click += new System.EventHandler(this.buttonCreateIntegers_Click);
            // 
            // buttonCreateDoubles
            // 
            this.buttonCreateDoubles.Location = new System.Drawing.Point(173, 13);
            this.buttonCreateDoubles.Name = "buttonCreateDoubles";
            this.buttonCreateDoubles.Size = new System.Drawing.Size(154, 59);
            this.buttonCreateDoubles.TabIndex = 1;
            this.buttonCreateDoubles.Text = "Create Doubles";
            this.buttonCreateDoubles.UseVisualStyleBackColor = true;
            this.buttonCreateDoubles.Click += new System.EventHandler(this.buttonCreateDoubles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Search Key:";
            // 
            // textBoxSearchTerm
            // 
            this.textBoxSearchTerm.Location = new System.Drawing.Point(129, 239);
            this.textBoxSearchTerm.Name = "textBoxSearchTerm";
            this.textBoxSearchTerm.Size = new System.Drawing.Size(198, 25);
            this.textBoxSearchTerm.TabIndex = 4;
            // 
            // labelValueFound
            // 
            this.labelValueFound.Location = new System.Drawing.Point(13, 283);
            this.labelValueFound.Name = "labelValueFound";
            this.labelValueFound.Size = new System.Drawing.Size(314, 26);
            this.labelValueFound.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(13, 313);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(314, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxList
            // 
            this.textBoxList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxList.Location = new System.Drawing.Point(16, 79);
            this.textBoxList.Multiline = true;
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxList.Size = new System.Drawing.Size(311, 154);
            this.textBoxList.TabIndex = 7;
            // 
            // LinearSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 346);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelValueFound);
            this.Controls.Add(this.textBoxSearchTerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateDoubles);
            this.Controls.Add(this.buttonCreateIntegers);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LinearSearch";
            this.Text = "Linear Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateIntegers;
        private System.Windows.Forms.Button buttonCreateDoubles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchTerm;
        private System.Windows.Forms.Label labelValueFound;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxList;
    }
}

