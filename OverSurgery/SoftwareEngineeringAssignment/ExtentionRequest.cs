using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class ExtentionRequest
    {
        #region PrivateVariables
        private int m_ExtentionID;
        private int m_PatientID;
        private string m_FirstName;
        private string m_LastName;
        private string m_MedicineName;
        private DateTime m_StartDate;
        private DateTime m_EndDate;
        private DateTime m_NewEndDate;
        #endregion

        #region properties
        public int getExtentionID { get { return m_ExtentionID; } set { m_ExtentionID = value; } }
        public int getPatientID { get { return m_PatientID; } set { m_PatientID = value; } }
        public string getFirstName { get { return m_FirstName; } set { m_FirstName = value; } }
        public string getLastName { get { return m_LastName; } set { m_LastName = value; } }
        public string getMedicineName { get { return m_MedicineName; } set { m_MedicineName = value; } }
        public DateTime getStartDate { get { return m_StartDate; } set { m_StartDate = value; } }
        public DateTime getEndDate { get { return m_EndDate; } set { m_EndDate = value; } }
        public DateTime getNewEndDate { get { return m_NewEndDate; } set { m_NewEndDate = value; } }
        #endregion

    }
}
