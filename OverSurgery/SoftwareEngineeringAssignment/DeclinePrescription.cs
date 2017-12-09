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
    public partial class DeclinePrescription : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public DeclinePrescription()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            instance.ExecuteQuery("UPDATE 'MedicineLink' SET 'requestextention = no' WHERE 'MedicineId' = txtDrugID AND 'PatientID' = txtPatientID");
        }
    }
}
