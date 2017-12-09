namespace SoftwareEngineeringAssignment
{
    partial class Drugs
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
            this.lvDrugs = new System.Windows.Forms.ListView();
            this.clmDrugdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClmDrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDrugDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewDrug = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteDrug = new System.Windows.Forms.Button();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvDrugs
            // 
            this.lvDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDrugdID,
            this.ClmDrugName,
            this.clmDrugDescription});
            this.lvDrugs.Location = new System.Drawing.Point(10, 65);
            this.lvDrugs.Name = "lvDrugs";
            this.lvDrugs.Size = new System.Drawing.Size(375, 517);
            this.lvDrugs.TabIndex = 0;
            this.lvDrugs.UseCompatibleStateImageBehavior = false;
            this.lvDrugs.View = System.Windows.Forms.View.Details;
            // 
            // clmDrugdID
            // 
            this.clmDrugdID.Text = "Drug ID";
            // 
            // ClmDrugName
            // 
            this.ClmDrugName.Text = "Drug Name";
            // 
            // clmDrugDescription
            // 
            this.clmDrugDescription.Text = "Drug Description";
            // 
            // btnNewDrug
            // 
            this.btnNewDrug.Location = new System.Drawing.Point(388, 65);
            this.btnNewDrug.Name = "btnNewDrug";
            this.btnNewDrug.Size = new System.Drawing.Size(91, 34);
            this.btnNewDrug.TabIndex = 1;
            this.btnNewDrug.Text = "New Drug";
            this.btnNewDrug.UseVisualStyleBackColor = true;
            this.btnNewDrug.Click += new System.EventHandler(this.btnNewDrug_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteDrug
            // 
            this.btnDeleteDrug.Location = new System.Drawing.Point(387, 105);
            this.btnDeleteDrug.Name = "btnDeleteDrug";
            this.btnDeleteDrug.Size = new System.Drawing.Size(91, 38);
            this.btnDeleteDrug.TabIndex = 3;
            this.btnDeleteDrug.Text = "Delete Drug";
            this.btnDeleteDrug.UseVisualStyleBackColor = true;
            this.btnDeleteDrug.Click += new System.EventHandler(this.btnDeleteDrug_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoctor.Location = new System.Drawing.Point(12, 9);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(43, 15);
            this.lblDoctor.TabIndex = 21;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(437, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 15);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "StaffID: 0";
            // 
            // Drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(182)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(505, 600);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.btnDeleteDrug);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewDrug);
            this.Controls.Add(this.lvDrugs);
            this.Name = "Drugs";
            this.Text = "Drugs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDrugs;
        private System.Windows.Forms.ColumnHeader clmDrugdID;
        private System.Windows.Forms.ColumnHeader ClmDrugName;
        private System.Windows.Forms.ColumnHeader clmDrugDescription;
        private System.Windows.Forms.Button btnNewDrug;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteDrug;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblName;
    }
}