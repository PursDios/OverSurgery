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
    public partial class AddDrug : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public AddDrug()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDrugName.Text != "")
            {
                instance.ExecuteQuery("INSERT INTO Medicine (MedicineID, MedicineName) VALUES(NULL, '" + instance.sanitize(txtDrugName.Text) + "');");
                this.Close();
            }
        }
    }
}
