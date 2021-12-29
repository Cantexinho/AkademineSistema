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
    public partial class LectorMainF : Form
    {
        List<SubjectClass> Subjects = new List<SubjectClass>();
        List<GroupClass> Groups = new List<GroupClass>();
        List<StudentClass> Students = new List<StudentClass>();
        DataAccess db = new DataAccess();
        int LectorID;
        int SubjectID;
        public LectorMainF(int id)
        {
            InitializeComponent();
            LectorID = id;

            Subjects = db.GetAllSubjects(LectorID);
            cmbLectorSubject.DataSource = Subjects;
            cmbLectorSubject.DisplayMember = "SubjectLectorInfo";

        }

        private void btnLectorSubjectSelect_Click(object sender, EventArgs e)
        {
            string text = cmbLectorSubject.GetItemText(cmbLectorSubject.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            SubjectID = Int32.Parse(tempID);

            Groups = db.GetGroupSubject(SubjectID);
            cmbLectorGroup.DataSource = Groups;
            cmbLectorGroup.DisplayMember = "GroupFullInfo";
        }

        private void btnLectorGroupSelect_Click(object sender, EventArgs e)
        {
            string text = cmbLectorGroup.GetItemText(cmbLectorGroup.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int GrouptID = Int32.Parse(tempID);

            Students = db.GetStudentsByGroup(GrouptID);
            listLectorStudent.DataSource = Students;
            listLectorStudent.DisplayMember = "StudentFullInfo";
        }

        private void btnLectorSelectStudent_Click(object sender, EventArgs e)
        {
            string text = listLectorStudent.GetItemText(listLectorStudent.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int StudentID = Int32.Parse(tempID);

            LectorGradeF lgF = new LectorGradeF(StudentID, SubjectID, LectorID);
            lgF.ShowDialog();
        }

        private void LectorMainF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
