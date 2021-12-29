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
    public partial class AdminSubjectF : Form
    {
        List<SubjectClass> Subjects = new List<SubjectClass>();
        DataAccess db = new DataAccess();
        int Identity;
        public AdminSubjectF(int id)
        {
            InitializeComponent();
            Identity = id;

            Subjects = db.GetAllSubjects();
            listAdminSubjects.DataSource = Subjects;
            listAdminSubjects.DisplayMember = "SubjectFullInfo";
        }

        private void btnAdminStudentSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminSubjectSearch.Text))
            {
                Subjects = db.GetAllSubjects();
            }
            else
            {
                Subjects = db.GetSubjectByName(txtAdminSubjectSearch.Text);
            }
            listAdminSubjects.DataSource = Subjects;
            listAdminSubjects.DisplayMember = "SubjecttFullInfo";
        }

        private void btnAdminSubjectAdd_Click(object sender, EventArgs e)
        {
            AdminSubjectAdd addF = new AdminSubjectAdd(Identity);
            addF.ShowDialog();

        }

        private void btnAdminSubjectLector_Click(object sender, EventArgs e)
        {
            string text = listAdminSubjects.GetItemText(listAdminSubjects.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int SubjectID = Int32.Parse(tempID);
            AdminSubjectLector aslF = new AdminSubjectLector(SubjectID);
            aslF.ShowDialog();

        }

        private void btnAdminSubjectGroup_Click(object sender, EventArgs e)
        {
            string text = listAdminSubjects.GetItemText(listAdminSubjects.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int SubjectID = Int32.Parse(tempID);
            AdminSubjectGroup gF = new AdminSubjectGroup(SubjectID);
            gF.ShowDialog();
        }

        private void btnAdminSubjectDelete_Click(object sender, EventArgs e)
        {
            string text = listAdminSubjects.GetItemText(listAdminSubjects.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int ID = Int32.Parse(tempID);
            db.DeleteSubject(ID);

            Subjects = db.GetAllSubjects();
            listAdminSubjects.DataSource = Subjects;
            listAdminSubjects.DisplayMember = "StudentFullInfo";
        }
    }
}
