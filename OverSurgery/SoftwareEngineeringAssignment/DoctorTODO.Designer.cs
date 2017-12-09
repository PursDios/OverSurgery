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
            this.txtExtentionID = new System.Windows.Forms.TextBox();
            this.lblExtentionID = new System.Windows.Forms.Label();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(1600, 9);
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
            this.btnExit.Location = new System.Drawing.Point(1572, 342);
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
            this.lvExtention.Size = new System.Drawing.Size(1546, 343);
            this.lvExtention.TabIndex = 28;
            this.lvExtention.UseCompatibleStateImageBehavior = false;
            this.lvExtention.View = System.Windows.Forms.View.Details;
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
            this.btnDeclinePrescription.Location = new System.Drawing.Point(1572, 295);
            this.btnDeclinePrescription.Name = "btnDeclinePrescription";
            this.btnDeclinePrescription.Size = new System.Drawing.Size(84, 41);
            this.btnDeclinePrescription.TabIndex = 29;
            this.btnDeclinePrescription.Text = "Decline Prescription";
            this.btnDeclinePrescription.UseVisualStyleBackColor = true;
            this.btnDeclinePrescription.Click += new System.EventHandler(this.btnDeclinePrescription_Click);
            // 
            // btnAcceptPrescription
            // 
            this.btnAcceptPrescription.Location = new System.Drawing.Point(1572, 252);
            this.btnAcceptPrescription.Name = "btnAcceptPrescription";
            this.btnAcceptPrescription.Size = new System.Drawing.Size(84, 37);
            this.btnAcceptPrescription.TabIndex = 30;
            this.btnAcceptPrescription.Text = "Accept Prescription";
            this.btnAcceptPrescription.UseVisualStyleBackColor = true;
            this.btnAcceptPrescription.Click += new System.EventHandler(this.btnAcceptPrescription_Click);
            // 
            // txtExtentionID
            // 
            this.txtExtentionID.Location = new System.Drawing.Point(1572, 226);
            this.txtExtentionID.Name = "txtExtentionID";
            this.txtExtentionID.Size = new System.Drawing.Size(84, 20);
            this.txtExtentionID.TabIndex = 31;
            // 
            // lblExtentionID
            // 
            this.lblExtentionID.AutoSize = true;
            this.lblExtentionID.Location = new System.Drawing.Point(1583, 210);
            this.lblExtentionID.Name = "lblExtentionID";
            this.lblExtentionID.Size = new System.Drawing.Size(62, 13);
            this.lblExtentionID.TabIndex = 32;
            this.lblExtentionID.Text = "ExtentionID";
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Location = new System.Drawing.Point(1572, 81);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(84, 23);
            this.btnViewPatient.TabIndex = 33;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(1572, 55);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(84, 20);
            this.txtPatientID.TabIndex = 34;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(1583, 39);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(51, 13);
            this.lblPatientID.TabIndex = 35;
            this.lblPatientID.Text = "PatientID";
            // 
            // DoctorTODO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1668, 390);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnViewPatient);
            this.Controls.Add(this.lblExtentionID);
            this.Controls.Add(this.txtExtentionID);
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
        private System.Windows.Forms.TextBox txtExtentionID;
        private System.Windows.Forms.Label lblExtentionID;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblPatientID;
    }
}