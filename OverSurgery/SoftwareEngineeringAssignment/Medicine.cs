﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Medicine
    {
        private int m_MedicineID;
        public int getMedicineID { get { return m_MedicineID; } set { m_MedicineID = value; } }
        private string m_MedicineName;
        public string getMedicineName { get { return m_MedicineName; } set { m_MedicineName = value; } }
        private DateTime m_StartDate;
        public DateTime getStartDate { get { return m_StartDate; } set { m_StartDate = value; } }
        private DateTime m_EndDate;
        public DateTime getEndDate { get { return m_EndDate; } set { m_EndDate = value; } }
        private string m_medicineDescription;
        public string getMedicineDescription { get { return m_medicineDescription; } set { m_medicineDescription = value; } }
    }
}
