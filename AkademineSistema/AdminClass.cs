using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class AdminClass
    {
        private int AdminID { get; set; }
        private string AdminName { get; set; }
        private string AdminSurname { get; set; }

        public int adminID
        {
            get { return AdminID; }
            set { AdminID = value; }
        }
        public string adminName
        {
            get { return AdminName; }
            set { AdminName = value; }
        }
        public string adminSurname
        {
            get { return AdminSurname; }
            set { AdminSurname = value; }
        }

    }
}
