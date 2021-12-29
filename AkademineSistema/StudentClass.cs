using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class StudentClass
    {
        private int StudentID { get; set; }
        private string StudentName { get; set; }
        private string StudentsSurname { get; set; }
        private int AdminID { get; set; }
        private int GroupID { get; set; }
        public int studentID
        {
            get { return StudentID; }
            set { StudentID = value; }
        }
        public string studentName
        {
            get { return StudentName; }
            set { StudentName = value; }
        }
        public string studentsSurname
        {
            get { return StudentsSurname; }
            set { StudentsSurname = value; }
        }
        public int groupID
        {
            get { return GroupID; }
            set { GroupID = value; }
        }
        public string StudentFullInfo
        {
            get
            {
                return $"{StudentID} - {StudentName} - {StudentsSurname} - {GroupID} - {AdminID}";
            }
        }
    }
}
