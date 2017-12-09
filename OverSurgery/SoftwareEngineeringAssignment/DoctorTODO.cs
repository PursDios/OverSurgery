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
    public partial class DoctorTODO : Form
    {
        //Variables
        Form f; 
        Staff m_s; //static Details of the staff
        BusinessMetaLayer instance; //Operates as the link to the database
        List<Medicine> perscriptionList;//stores the list of the medicines
        List<Patient> patientList; //Stores the patients details
        /// <summary>
        /// This constructer will take the staff details from the previous form and set up the rest of the Form
        /// </summary>
        /// <param name="p_s">The staff details passed from the previous form</param>
        public DoctorTODO(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblDoctor.Text = m_s.getType;
            lblName.Text = "Staff ID: " + m_s.getStaffID;
            instance = BusinessMetaLayer.instance();


        }
        private void loadPerscriptions()
        {
            perscriptionList = instance.getExtentions();
            lvExtention.Clear();
            lvExtention.Columns.Add("Patient ID", 100);
            lvExtention.Columns.Add("Medicine ID", 100);
            lvExtention.Columns.Add("Medicine Name", 200);
            foreach (Medicine m in perscriptionList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.getMedicineID.ToString();
                lvi.Text = m.getMedicineName.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceptPrescription_Click(object sender, EventArgs e)
        {
            f = new AcceptExtention();
            f.ShowDialog();
            this.Show();
        }

        private void btnDeclinePrescription_Click(object sender, EventArgs e)
        {
            f = new DeclinePrescription();
            f.ShowDialog();
            this.Show();
        }
    }
}
