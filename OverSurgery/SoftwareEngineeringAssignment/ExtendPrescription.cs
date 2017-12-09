﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class ExtendPrescription : Form
    {
        Form f;
        Staff m_s;
        Patient m_p;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Medicine> medicineList = new List<Medicine>();
        List<DateTime> dt = new List<DateTime>();

        public ExtendPrescription(Staff p_Staff, Patient p_Patient)
        {
            InitializeComponent();
            m_s = p_Staff;
            m_p = p_Patient;
            loadPerscriptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void loadPerscriptions()
        {
            medicineList = instance.GetPrescriptions(m_p.getPatientID);
            lvDrugs.Clear();
            lvDrugs.Columns.Add("PatientID", 100);
            lvDrugs.Columns.Add("MecicineID", 100);
            lvDrugs.Columns.Add("Medicine", 200);
            lvDrugs.Columns.Add("Start Date", 100);
            lvDrugs.Columns.Add("End Date", 100);
            foreach (Medicine m in medicineList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m_p.getPatientID.ToString();
                lvi.SubItems.Add(m.getMedicineID.ToString());
                lvi.SubItems.Add(m.getMedicineName);
                lvi.SubItems.Add(m.getStartDate.ToShortDateString());
                lvi.SubItems.Add(m.getEndDate.ToShortDateString());
                lvDrugs.Items.Add(lvi);
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if ((txtDrugID != null) && (txtPatientID != null))
            {
                if (m_s.getType == "Doctor")
                {
                    DateTime dt = Convert.ToDateTime(calDate);
                    instance.ExecuteQuery("UPDATE 'MedicineLink' SET End Date = '" + instance.sanitize(dt.ToString("yyyy-MM-dd h:mm") + "WHERE 'MedicineId' = txtDrugID AND 'PatientID' = txtPatientID"));
                }
                

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
