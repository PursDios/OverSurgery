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
    public partial class DeleteDrug : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public DeleteDrug()
        {
            InitializeComponent();
        }

        private void btnDeleteDrug_Click(object sender, EventArgs e)
        {
            if (txtDrugID != null)
            {
                instance.ExecuteQuery("DELETE FROM Medicine WHERE MedicineID =" + txtDrugID + ";");
                this.Close();
            }
        }
    }
}
