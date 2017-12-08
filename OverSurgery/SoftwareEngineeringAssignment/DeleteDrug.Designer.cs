namespace SoftwareEngineeringAssignment
{
    partial class DeleteDrug
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
            this.txtDrugID = new System.Windows.Forms.TextBox();
            this.lbldrugID = new System.Windows.Forms.Label();
            this.btnDeleteDrug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(12, 29);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(100, 20);
            this.txtDrugID.TabIndex = 0;
            // 
            // lbldrugID
            // 
            this.lbldrugID.AutoSize = true;
            this.lbldrugID.Location = new System.Drawing.Point(13, 13);
            this.lbldrugID.Name = "lbldrugID";
            this.lbldrugID.Size = new System.Drawing.Size(44, 13);
            this.lbldrugID.TabIndex = 1;
            this.lbldrugID.Text = "Drug ID";
            // 
            // btnDeleteDrug
            // 
            this.btnDeleteDrug.Location = new System.Drawing.Point(12, 56);
            this.btnDeleteDrug.Name = "btnDeleteDrug";
            this.btnDeleteDrug.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteDrug.TabIndex = 2;
            this.btnDeleteDrug.Text = "Delete Drug";
            this.btnDeleteDrug.UseVisualStyleBackColor = true;
            this.btnDeleteDrug.Click += new System.EventHandler(this.btnDeleteDrug_Click);
            // 
            // DeleteDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(129, 109);
            this.Controls.Add(this.btnDeleteDrug);
            this.Controls.Add(this.lbldrugID);
            this.Controls.Add(this.txtDrugID);
            this.Name = "DeleteDrug";
            this.Text = "DeleteDrug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrugID;
        private System.Windows.Forms.Label lbldrugID;
        private System.Windows.Forms.Button btnDeleteDrug;
    }
}