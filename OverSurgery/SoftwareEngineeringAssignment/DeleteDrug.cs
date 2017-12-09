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
        List<Medicine> medicineList = new List<Medicine>();
        public DeleteDrug()
        {
            InitializeComponent();
            medicineList = instance.getAllMedicine();
        }

        private void btnDeleteDrug_Click(object sender, EventArgs e)
        {
            if (txtDrugID.Text != "")
            {
                int num=0;
                bool exists = false;
                Int32.TryParse(txtDrugID.Text, out num);
                if (num != 0)
                {
                    foreach(Medicine m in medicineList)
                    {
                        if(num == m.getMedicineID)
                        {
                            exists = true;
                        }
                    }
                    if (exists)
                    {
                        instance.ExecuteQuery("DELETE FROM Medicine WHERE MedicineID =" + instance.sanitize(txtDrugID.Text) + ";");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("DrugID does not exist", "Invalid DrugID");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input, Please enter a valid DrugID", "Invalid Input");
                }
            }
            else
            {
                MessageBox.Show("Please insert a DrugID","Enter a DrugID");
            }
        }
    }
}
