namespace SoftwareEngineeringAssignment
{
    partial class DoctorTODO
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lvExtention = new System.Windows.Forms.ListView();
            this.clmPatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMedicineID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMedicineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeclinePrescription = new System.Windows.Forms.Button();
            this.btnAcceptPrescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(414, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoctor.Location = new System.Drawing.Point(11, 9);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 25;
            this.lblDoctor.Text = "Doctor";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(385, 334);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lvExtention
            // 
            this.lvExtention.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPatientID,
            this.clmMedicineID,
            this.clmMedicineName});
            this.lvExtention.Location = new System.Drawing.Point(13, 28);
            this.lvExtention.Name = "lvExtention";
            this.lvExtention.Size = new System.Drawing.Size(366, 339);
            this.lvExtention.TabIndex = 28;
            this.lvExtention.UseCompatibleStateImageBehavior = false;
            // 
            // clmPatientID
            // 
            this.clmPatientID.Text = "Patient ID";
            // 
            // clmMedicineID
            // 
            this.clmMedicineID.Text = "Medicine ID";
            // 
            // clmMedicineName
            // 
            this.clmMedicineName.Text = "Medicine Name";
            // 
            // btnDeclinePrescription
            // 
            this.btnDeclinePrescription.Location = new System.Drawing.Point(386, 287);
            this.btnDeclinePrescription.Name = "btnDeclinePrescription";
            this.btnDeclinePrescription.Size = new System.Drawing.Size(84, 41);
            this.btnDeclinePrescription.TabIndex = 29;
            this.btnDeclinePrescription.Text = "Decline Prescription";
            this.btnDeclinePrescription.UseVisualStyleBackColor = true;
            this.btnDeclinePrescription.Click += new System.EventHandler(this.btnDeclinePrescription_Click);
            // 
            // btnAcceptPrescription
            // 
            this.btnAcceptPrescription.Location = new System.Drawing.Point(386, 244);
            this.btnAcceptPrescription.Name = "btnAcceptPrescription";
            this.btnAcceptPrescription.Size = new System.Drawing.Size(84, 37);
            this.btnAcceptPrescription.TabIndex = 30;
            this.btnAcceptPrescription.Text = "Accept Prescription";
            this.btnAcceptPrescription.UseVisualStyleBackColor = true;
            this.btnAcceptPrescription.Click += new System.EventHandler(this.btnAcceptPrescription_Click);
            // 
            // DoctorTODO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Controls.Add(this.btnAcceptPrescription);
            this.Controls.Add(this.btnDeclinePrescription);
            this.Controls.Add(this.lvExtention);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDoctor);
            this.Name = "DoctorTODO";
            this.Text = "DoctorTODO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lvExtention;
        private System.Windows.Forms.Button btnDeclinePrescription;
        private System.Windows.Forms.Button btnAcceptPrescription;
        private System.Windows.Forms.ColumnHeader clmPatientID;
        private System.Windows.Forms.ColumnHeader clmMedicineID;
        private System.Windows.Forms.ColumnHeader clmMedicineName;
    }
}