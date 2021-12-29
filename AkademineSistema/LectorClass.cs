using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class LectorClass
    {
        private int LectorID { get; set; }
        private string LectorName { get; set; }
        private string LectorSurname { get; set; }
        private int AdminID { get; set; }

        public int lectorID
        {
            get { return LectorID; }
            set { LectorID = value; }
        }
        public string lectorName
        {
            get { return LectorName; }
            set { LectorName = value; }
        }
        public string lectorSurname
        {
            get { return LectorSurname; }
            set { LectorSurname = value; }
        }
        public string LectorsFullInfo
        {
            get
            {
                return $"{LectorID} - {LectorName} - {LectorSurname} - {AdminID} ";
            }
        }
    }
}
