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
    public partial class editStaff : Form
    {
        List<Rota> RotaList = new List<Rota>();
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        public editStaff()
        {
            InitializeComponent();
            RotaList = instance.getStaffSchedule();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool exists = false;
            int StaffID=0;
            try
            {
                StaffID = int.Parse(txtStaffID.Text);
            }
            catch
            {
                MessageBox.Show("Please Enter a valid StaffID","Invalid StaffID Input");
            }
            if (StaffID != 0)
            {
                if (cmbFriday.Text != "" && cmbMonday.Text != "" && cmbSaturday.Text != "" && cmbSunday.Text != "" && cmbThursday.Text != "" && cmbTuesday.Text != "" && cmbWednesday.Text != "")
                {
                    foreach(Rota r in RotaList)
                    {
                        if(r.getStaffID == StaffID)
                        {
                            exists = true;
                        }
                    }
                    if (exists)
                    {
                        instance.ExecuteQuery("UPDATE Rota SET Monday = '" + cmbMonday.Text + "' , Tuesday = '" + cmbTuesday.Text + "' , Wednesday = '" + cmbWednesday.Text + "' , Thursday = '" + cmbThursday.Text + "' , Friday = '" + cmbFriday.Text + "' , Saturday = '" + cmbSaturday.Text + "' , Sunday = '" + cmbSunday.Text + "' WHERE StaffID = " + StaffID + ";");
                        MessageBox.Show("Record has been updated", "Record Updated");
                    }
                    else
                    {
                        instance.ExecuteQuery("INSERT INTO Rota (StaffID, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday) VALUES(" + StaffID + ", '" + cmbMonday.Text + "', '" + cmbTuesday.Text + "', '" + cmbWednesday.Text + "', '" + cmbThursday.Text + "', '" + cmbFriday.Text + "', '" + cmbSaturday.Text + "', '" + cmbSunday.Text + "');");
                        MessageBox.Show("A new record has been added", "New record added");
                    }
                }
                else
                {
                    MessageBox.Show("You have missed one or more days on the staff schedule please double check every day has a value", "Missing Information");
                }
            }
        }
    }
}
