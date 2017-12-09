namespace SoftwareEngineeringAssignment
{
    partial class ExtendPrescription
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
            this.lblStaffType = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.lblDrugID = new System.Windows.Forms.Label();
            this.lvDrugs = new System.Windows.Forms.ListView();
            this.lblTime = new System.Windows.Forms.Label();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.cbIndex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(571, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStaffType.Location = new System.Drawing.Point(12, 9);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(57, 15);
            this.lblStaffType.TabIndex = 22;
            this.lblStaffType.Text = "StaffType";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(654, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(654, 210);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(85, 35);
            this.btnExtend.TabIndex = 28;
            this.btnExtend.Text = "Extend Presecription";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // lblDrugID
            // 
            this.lblDrugID.AutoSize = true;
            this.lblDrugID.Location = new System.Drawing.Point(409, 55);
            this.lblDrugID.Name = "lblDrugID";
            this.lblDrugID.Size = new System.Drawing.Size(47, 13);
            this.lblDrugID.TabIndex = 29;
            this.lblDrugID.Text = "Index ID";
            // 
            // lvDrugs
            // 
            this.lvDrugs.Location = new System.Drawing.Point(3, 52);
            this.lvDrugs.Name = "lvDrugs";
            this.lvDrugs.Size = new System.Drawing.Size(400, 193);
            this.lvDrugs.TabIndex = 30;
            this.lvDrugs.UseCompatibleStateImageBehavior = false;
            this.lvDrugs.View = System.Windows.Forms.View.Details;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(483, 97);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 13);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Extention Until";
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(415, 119);
            this.calDate.MaxSelectionCount = 1;
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 35;
            // 
            // cbIndex
            // 
            this.cbIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndex.FormattingEnabled = true;
            this.cbIndex.Location = new System.Drawing.Point(486, 52);
            this.cbIndex.Name = "cbIndex";
            this.cbIndex.Size = new System.Drawing.Size(121, 21);
            this.cbIndex.TabIndex = 36;
            // 
            // ExtendPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(746, 296);
            this.Controls.Add(this.cbIndex);
            this.Controls.Add(this.calDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lvDrugs);
            this.Controls.Add(this.lblDrugID);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStaffType);
            this.Name = "ExtendPrescription";
            this.Text = "ExtendPrescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Label lblDrugID;
        private System.Windows.Forms.ListView lvDrugs;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.ComboBox cbIndex;
    }
}