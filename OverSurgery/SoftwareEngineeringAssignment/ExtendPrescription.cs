using System;
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

        public ExtendPrescription(Staff p_Staff, Patient p_Patient)
        {
            InitializeComponent();
            m_s = p_Staff;
            m_p = p_Patient;
            medicineList = instance.GetPrescriptions(m_p.getPatientID);
            LoadCombo();
            loadPerscriptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void LoadCombo()
        {
            int i = 1;
            foreach(Medicine m in medicineList)
            {
                cbIndex.Items.Add(i);
                i++;
            }
        }
        private void loadPerscriptions()
        {
            int i=1;
            
            lvDrugs.Clear();
            lvDrugs.Columns.Add("Index", 100);
            lvDrugs.Columns.Add("PatientID", 100);
            lvDrugs.Columns.Add("MecicineID", 100);
            lvDrugs.Columns.Add("Medicine", 200);
            lvDrugs.Columns.Add("Start Date", 100);
            lvDrugs.Columns.Add("End Date", 100);
            foreach (Medicine m in medicineList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.ToString();
                lvi.SubItems.Add(m_p.getPatientID.ToString());
                lvi.SubItems.Add(m.getMedicineID.ToString());
                lvi.SubItems.Add(m.getMedicineName);
                lvi.SubItems.Add(m.getStartDate.ToShortDateString());
                lvi.SubItems.Add(m.getEndDate.ToShortDateString());
                lvDrugs.Items.Add(lvi);
                i++;
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            int IndexNum = -99;
            if (cbIndex.Text != "")
            {
                DateTime dt = calDate.SelectionStart;
                IndexNum = int.Parse(cbIndex.Text);
                IndexNum--;
                instance.ExecuteQuery("INSERT INTO ExtensionRequests (ExtensionID, PatientID, FirstName, LastName, MedicineName, StartDate, EndDate, NewEndDate) VALUES(NULL, " + m_p.getPatientID + ", '" + m_p.getFirstName + "', '" + m_p.getLastName + "', '" + medicineList[IndexNum].getMedicineName + "', '" + medicineList[IndexNum].getStartDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + medicineList[IndexNum].getEndDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + dt.ToString("yyyy-MM-dd HH:mm:ss") + "');");
                MessageBox.Show("A request has been made", "Request Made");
            }
            else
            {
                MessageBox.Show("IndexNum Cannot be empty", "IndexNum is empty");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
