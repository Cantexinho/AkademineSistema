using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema
{
    public class GroupClass
    {
        private int GroupID { get; set; }
        private string GroupName { get; set; }
        private string AdminID { get; set; }
        public string GroupFullInfo
        {
            get
            {
                return $"{GroupID} - {GroupName} - {AdminID}";
            }
        }
    }
}
