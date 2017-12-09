namespace SoftwareEngineeringAssignment
{
    partial class AcceptExtention
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
            this.lblDrugName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.lblconfirmDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDrugID
            // 
            this.txtDrugID.Location = new System.Drawing.Point(13, 27);
            this.txtDrugID.Name = "txtDrugID";
            this.txtDrugID.Size = new System.Drawing.Size(100, 20);
            this.txtDrugID.TabIndex = 0;
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.lblDrugName.Location = new System.Drawing.Point(13, 8);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(44, 13);
            this.lblDrugName.TabIndex = 1;
            this.lblDrugName.Text = "Drug ID";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(13, 54);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(54, 13);
            this.lblPatientID.TabIndex = 2;
            this.lblPatientID.Text = "Patient ID";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(13, 82);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtPatientID.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(164, 305);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(12, 131);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 36;
            // 
            // lblconfirmDate
            // 
            this.lblconfirmDate.AutoSize = true;
            this.lblconfirmDate.Location = new System.Drawing.Point(12, 109);
            this.lblconfirmDate.Name = "lblconfirmDate";
            this.lblconfirmDate.Size = new System.Drawing.Size(68, 13);
            this.lblconfirmDate.TabIndex = 37;
            this.lblconfirmDate.Text = "Confirm Date";
            // 
            // AcceptExtention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(252, 345);
            this.Controls.Add(this.lblconfirmDate);
            this.Controls.Add(this.calDate);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblDrugName);
            this.Controls.Add(this.txtDrugID);
            this.Name = "AcceptExtention";
            this.Text = "AcceptExtention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDrugID;
        private System.Windows.Forms.Label lblDrugName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.Label lblconfirmDate;
    }
}