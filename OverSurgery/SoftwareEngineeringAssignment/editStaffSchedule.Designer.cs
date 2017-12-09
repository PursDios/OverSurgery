namespace SoftwareEngineeringAssignment
{
    partial class editStaffSchedule
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
            this.LstStaffSchedule = new System.Windows.Forms.ListView();
            this.clmStaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMonday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTuesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmWednesday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cllmThursday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFriday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSaturday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSunday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstStaffSchedule
            // 
            this.LstStaffSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStaffID,
            this.clmFirstName,
            this.clmLastName,
            this.clmMonday,
            this.clmTuesday,
            this.clmWednesday,
            this.cllmThursday,
            this.clmFriday,
            this.clmSaturday,
            this.clmSunday});
            this.LstStaffSchedule.Location = new System.Drawing.Point(12, 43);
            this.LstStaffSchedule.Name = "LstStaffSchedule";
            this.LstStaffSchedule.Size = new System.Drawing.Size(951, 335);
            this.LstStaffSchedule.TabIndex = 59;
            this.LstStaffSchedule.UseCompatibleStateImageBehavior = false;
            this.LstStaffSchedule.View = System.Windows.Forms.View.Details;
            // 
            // clmStaffID
            // 
            this.clmStaffID.Text = "Staff ID";
            // 
            // clmFirstName
            // 
            this.clmFirstName.Text = "First Name";
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Last Name";
            // 
            // clmMonday
            // 
            this.clmMonday.Text = "Monday";
            // 
            // clmTuesday
            // 
            this.clmTuesday.Text = "Tuesday";
            // 
            // clmWednesday
            // 
            this.clmWednesday.Text = "Wednesday";
            // 
            // cllmThursday
            // 
            this.cllmThursday.Text = "Thursday";
            // 
            // clmFriday
            // 
            this.clmFriday.Text = "Friday";
            // 
            // clmSaturday
            // 
            this.clmSaturday.Text = "Saturday";
            // 
            // clmSunday
            // 
            this.clmSunday.Text = "Sundqay";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 29);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(910, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 57;
            this.lblName.Text = "StaffID: 0";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblManager.Location = new System.Drawing.Point(11, 9);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(57, 15);
            this.lblManager.TabIndex = 56;
            this.lblManager.Text = "Manager";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(883, 434);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 29);
            this.btnEdit.TabIndex = 60;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(907, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "StaffID: 0";
            // 
            // editStaffSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(976, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.LstStaffSchedule);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblManager);
            this.Name = "editStaffSchedule";
            this.Text = "editStaffSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstStaffSchedule;
        private System.Windows.Forms.ColumnHeader clmStaffID;
        private System.Windows.Forms.ColumnHeader clmFirstName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmMonday;
        private System.Windows.Forms.ColumnHeader clmTuesday;
        private System.Windows.Forms.ColumnHeader clmWednesday;
        private System.Windows.Forms.ColumnHeader cllmThursday;
        private System.Windows.Forms.ColumnHeader clmFriday;
        private System.Windows.Forms.ColumnHeader clmSaturday;
        private System.Windows.Forms.ColumnHeader clmSunday;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
    }
}