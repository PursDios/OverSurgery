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
    public partial class AcceptExtention : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public AcceptExtention()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(calDate);
            instance.ExecuteQuery("UPDATE 'MedicineLink' SET End Date = '" + instance.sanitize(dt.ToString("yyyy-MM-dd h:mm") + ", 'Requests' WHERE 'MedicineId' = txtDrugID AND 'PatientID' = txtPatientID"));
        }
    }
}
