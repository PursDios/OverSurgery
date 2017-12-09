namespace SoftwareEngineeringAssignment
{
    partial class DeclinePrescription
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
            this.lblconfirmDate = new System.Windows.Forms.Label();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblDrugName = new System.Windows.Forms.Label();
            this.txtDrugID = new System.Windows.Forms.TextBox();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblconfirmDate
            // 
            this.lblconfirmDate.AutoSize = true;
            this.lblconfirmDate.Location = new System.Drawing.Point(6, 93);
            this.lblconfirmDate.Name = "lblconfirmDate";
            this.lblconfirmDate.Size = new System.Drawing.Size(68, 13);
            this.lblconfirmDate.TabIndex = 44;
            this.lblconfirmDate.Text = "Confirm Date";
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(8, 115);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 43;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(160, 289);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 42;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(8, 70);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtPatientID.TabIndex = 41;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(9, 54);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(54, 13);
            this.lblPatientID.TabIndex = 40;
            this.lblPatientID.Text = "Patient ID";
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.Location = new System.Drawing.Point(30, -29);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(44, 13);
            this.lblDrugName.TabIndex = 39;
            this.lblDrugName.Text = "Drug ID";
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(9, 27);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(100, 20);
            this.txtDrugID.TabIndex = 38;
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Location = new System.Drawing.Point(9, 8);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(50, 13);
            this.lblMedicineID.TabIndex = 45;
            this.lblMedicineID.Text = "Medicine";
            // 
            // DeclinePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(246, 326);
            this.Controls.Add(this.lblMedicineID);
            this.Controls.Add(this.lblconfirmDate);
            this.Controls.Add(this.calDate);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblDrugName);
            this.Controls.Add(this.txtDrugID);
            this.Name = "DeclinePrescription";
            this.Text = "DeclinePrescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconfirmDate;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblDrugName;
        private System.Windows.Forms.TextBox txtDrugID;
        private System.Windows.Forms.Label lblMedicineID;
    }
}