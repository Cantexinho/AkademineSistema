using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class GradeClass
    {
        private int GradeID { get; set; }
        private string GradeSource { get; set; }
        private int Grade { get; set; }
        private DateTime GradeDate { get; set; }
        private int StudentID { get; set; }
        private int LectorID { get; set; }
        private int SubjectID { get; set; }

        public string GradeFullInfo
        {
            get
            {
                return $"{GradeID}  {GradeSource} {Grade} {GradeDate.ToString("dd/MM/yyyy")} {StudentID} {LectorID} {SubjectID}";
            }
        }
        public string GradeStudentInfo
        {
            get
            {
                return $"{GradeID} - {GradeSource} - {Grade} - {GradeDate.ToString("dd/MM/yyyy")}";
            }
        }
    }
}
