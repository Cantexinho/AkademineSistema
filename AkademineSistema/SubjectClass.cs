using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class SubjectClass
    {
        private int SubjectID { get; set; }
        private string SubjectName { get; set; }
        private int AdminID { get; set; }
        private int GroupID { get; set; }
        private int LectorID { get; set; }

        public int subjectID
        {
            get { return SubjectID; }
            set { SubjectID = value; }
        }
        public string subjectName
        {
            get { return SubjectName; }
            set { SubjectName = value; }
        }
        public string SubjectFullInfo
        {
            get
            {
                return $"{SubjectID} - {SubjectName} - {LectorID} - {AdminID}";
            }
        }
        public string SubjectLectorInfo
        {
            get
            {
                return $"{SubjectID} - {SubjectName}";
            }
        }
    }
}
