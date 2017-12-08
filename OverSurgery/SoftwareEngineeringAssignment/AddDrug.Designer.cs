namespace SoftwareEngineeringAssignment
{
    partial class AddDrug
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.lbldrugName = new System.Windows.Forms.Label();
            this.txtDrugDescription = new System.Windows.Forms.RichTextBox();
            this.lbldrugDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add drug";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(13, 54);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(163, 20);
            this.txtDrugName.TabIndex = 1;
            // 
            // lbldrugName
            // 
            this.lbldrugName.AutoSize = true;
            this.lbldrugName.Location = new System.Drawing.Point(13, 35);
            this.lbldrugName.Name = "lbldrugName";
            this.lbldrugName.Size = new System.Drawing.Size(61, 13);
            this.lbldrugName.TabIndex = 2;
            this.lbldrugName.Text = "Drug Name";
            // 
            // txtDrugDescription
            // 
            this.txtDrugDescription.Location = new System.Drawing.Point(12, 113);
            this.txtDrugDescription.Name = "txtDrugDescription";
            this.txtDrugDescription.Size = new System.Drawing.Size(286, 96);
            this.txtDrugDescription.TabIndex = 3;
            this.txtDrugDescription.Text = "";
            // 
            // lbldrugDescription
            // 
            this.lbldrugDescription.AutoSize = true;
            this.lbldrugDescription.Location = new System.Drawing.Point(13, 97);
            this.lbldrugDescription.Name = "lbldrugDescription";
            this.lbldrugDescription.Size = new System.Drawing.Size(82, 13);
            this.lbldrugDescription.TabIndex = 4;
            this.lbldrugDescription.Text = "drug description";
            // 
            // AddDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(310, 274);
            this.Controls.Add(this.lbldrugDescription);
            this.Controls.Add(this.txtDrugDescription);
            this.Controls.Add(this.lbldrugName);
            this.Controls.Add(this.txtDrugName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddDrug";
            this.Text = "AddDrug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label lbldrugName;
        private System.Windows.Forms.RichTextBox txtDrugDescription;
        private System.Windows.Forms.Label lbldrugDescription;
    }
}