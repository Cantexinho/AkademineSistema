using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkademineSistema
{
    public partial class AdminStudentAddGroup : Form
    {
        DataAccess db = new DataAccess();
        List<GroupClass> Groups = new List<GroupClass>();
        int ID;
        public AdminStudentAddGroup(int StudentID)
        {
            InitializeComponent();
            ID = StudentID;

            Groups = db.GetAllGroups();
            listAdminStudentGroups.DataSource = Groups;
            listAdminStudentGroups.DisplayMember = "GroupFullInfo";
        }

        private void btnAdminStudentGroupAssignOk_Click(object sender, EventArgs e)
        {
            string text = listAdminStudentGroups.GetItemText(listAdminStudentGroups.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int IDGroup = Int32.Parse(tempID);
            db.AddStudentToGroup(ID, IDGroup);
            this.Close();

        }

        private void btnAdminStudentAssignGroupCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
