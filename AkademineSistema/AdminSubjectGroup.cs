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
    public partial class AdminSubjectGroup : Form
    {
        List<GroupClass> Groups = new List<GroupClass>();
        DataAccess db = new DataAccess();
        int Subjectid;
        public AdminSubjectGroup(int SubjectID)
        {
            InitializeComponent();
            Subjectid = SubjectID;

            Groups = db.GetAllGroups();
            listAdminSubjectGroup.DataSource = Groups;
            listAdminSubjectGroup.DisplayMember = "GroupFullInfo";
        }

        private void btnAdminSubjectGroupSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminSubjectGroupSearch.Text))
            {
                Groups = db.GetAllGroups();
            }
            else
            {
                Groups = db.GetGroupByName(txtAdminSubjectGroupSearch.Text);
            }
            listAdminSubjectGroup.DataSource = Groups;
            listAdminSubjectGroup.DisplayMember = "GroupFullInfo";
        }

        private void btnAdminSubjectGroupAddOk_Click(object sender, EventArgs e)
        {
            string text = listAdminSubjectGroup.GetItemText(listAdminSubjectGroup.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int IDGroup = Int32.Parse(tempID);
            db.AssignSubjectGroup(IDGroup, Subjectid);
            this.Close();
        }

        private void btnAdminSubjectGroupAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
