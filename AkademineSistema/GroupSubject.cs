using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class GroupSubject
    {
        private int GroupID { get; set; }
        public string SubjectID { get; set; }
        public string GroupSubjectFullInfo
        {
            get
            {
                return $"{GroupID} {SubjectID}";
            }
        }
    }
}
