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
    public partial class AdminGroupF : Form
    {
        List<GroupClass> Groups = new List<GroupClass>();
        DataAccess db = new DataAccess();
        int Identity;
        public AdminGroupF(int id)
        {
            InitializeComponent();
            Identity = id;

            Groups = db.GetAllGroups();
            listAdminGroups.DataSource = Groups;
            listAdminGroups.DisplayMember = "GroupFullInfo";
        }

        private void btnAdminStudentSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminGroupSearch.Text))
            {
                Groups = db.GetAllGroups();
            }
            else
            {
                Groups = db.GetGroupByName(txtAdminGroupSearch.Text);
            }
            listAdminGroups.DataSource = Groups;
            listAdminGroups.DisplayMember = "GroupFullInfo";

        }

        private void btnAdminGroupAdd_Click(object sender, EventArgs e)
        {
            AdminGroupAdd addF = new AdminGroupAdd(Identity);
            addF.ShowDialog();
        }

        private void btnAdminGroupDelete_Click(object sender, EventArgs e)
        {
            string text = listAdminGroups.GetItemText(listAdminGroups.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int ID = Int32.Parse(tempID);
            db.DeleteGroup(ID);

            Groups = db.GetAllGroups();
            listAdminGroups.DataSource = Groups;
            listAdminGroups.DisplayMember = "GroupFullInfo";
        }
    }
}
