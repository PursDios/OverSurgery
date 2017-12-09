using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineeringAssignment
{
    public class Rota
    {
#region privateVariables
        private int m_StaffID;
        private string m_FirstName;
        private string m_LastName;
        private string m_Monday;
        private string m_Tuesday;
        private string m_Wednesday;
        private string m_Thursday;
        private string m_Friday;
        private string m_Saturday;
        private string m_Sunday;
#endregion

#region properties
        public int getStaffID { get { return m_StaffID; }set { m_StaffID = value; } }
        public string getFirstName { get { return m_FirstName; } set { m_FirstName = value; } }
        public string getLastName { get { return m_LastName; } set { m_LastName = value; } }
        public string getMonday { get { return m_Monday; } set { m_Monday = value; } }
        public string getTuesday { get { return m_Tuesday; } set { m_Tuesday = value; } }
        public string getWednesday { get { return m_Wednesday; } set { m_Wednesday = value; } }
        public string getThursday { get { return m_Thursday; } set { m_Thursday = value; } }
        public string getFriday { get { return m_Friday; } set { m_Friday = value; } }
        public string getSaturday { get { return m_Saturday; } set { m_Saturday = value; } }
        public string getSunday { get { return m_Sunday; } set { m_Sunday = value; } }
#endregion
    }
}
