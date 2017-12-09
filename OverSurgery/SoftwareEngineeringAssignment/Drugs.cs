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
    public partial class Drugs : Form
    {
        Form f;
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Medicine> medList;
        Staff m_s;
        public Drugs(Staff p_s)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            m_s = p_s;
            lblDoctor.Text = m_s.getType;
            lblName.Text = "StaffID: " + m_s.getStaffID;
            loadDugs();
        }
        private void loadDugs()
        {
            medList = instance.getAllMedicine();
            lvDrugs.Clear();
            lvDrugs.Columns.Add("DrugID", 100);
            lvDrugs.Columns.Add("DrugName", 300);
            foreach(Medicine m in medList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = m.getMedicineID.ToString();
                lvi.SubItems.Add(m.getMedicineName);
                lvDrugs.Items.Add(lvi);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewDrug_Click(object sender, EventArgs e)
        {
            f = new AddDrug();
            f.ShowDialog();
            loadDugs();
        }

        private void btnDeleteDrug_Click(object sender, EventArgs e)
        {
            f = new DeleteDrug();
            f.ShowDialog();
            loadDugs();
        }
    }
}
