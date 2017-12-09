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
    public partial class editStaffSchedule : Form
    {
        Form f;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Rota> RotaList = new List<Rota>();
        Staff m_s;
        /// <summary>
        /// View the staff schedule.
        /// </summary>
        public editStaffSchedule(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;
            lblManager.Text = m_s.getType;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            RotaList = instance.getStaffSchedule();
            loadSchedule();
        }
        private void loadSchedule()
        {
            LstStaffSchedule.Clear();
            LstStaffSchedule.Columns.Add("Staff ID", 100);
            LstStaffSchedule.Columns.Add("First Name", 200);
            LstStaffSchedule.Columns.Add("Last Name", 200);
            LstStaffSchedule.Columns.Add("Monday", 100);
            LstStaffSchedule.Columns.Add("Tuesday", 100);
            LstStaffSchedule.Columns.Add("Wednesday", 100);
            LstStaffSchedule.Columns.Add("Thursday", 100);
            LstStaffSchedule.Columns.Add("Friday", 100);
            LstStaffSchedule.Columns.Add("Saturday", 100);
            LstStaffSchedule.Columns.Add("Sunday", 100);

            foreach (Rota s in RotaList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.getStaffID.ToString();
                lvi.SubItems.Add(s.getFirstName);
                lvi.SubItems.Add(s.getLastName);
                lvi.SubItems.Add(s.getMonday);
                lvi.SubItems.Add(s.getTuesday);
                lvi.SubItems.Add(s.getWednesday);
                lvi.SubItems.Add(s.getThursday);
                lvi.SubItems.Add(s.getFriday);
                lvi.SubItems.Add(s.getSaturday);
                lvi.SubItems.Add(s.getSunday);
                LstStaffSchedule.Items.Add(lvi);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            f = new editStaff();
            f.ShowDialog();
        }
    }
}
