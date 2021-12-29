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
    public partial class StudentGradeF : Form
    {
        List<SubjectClass> Subjects = new List<SubjectClass>();
        List<GradeClass> Grades = new List<GradeClass>();
        DataAccess db = new DataAccess();
        int StudentID;
        int GroupID;
        public StudentGradeF(int Studentid, int Groupid)
        {
            InitializeComponent();
            StudentID = Studentid;
            GroupID = Groupid;

            Subjects = db.StudentGetSubject(GroupID);
            cmbStudentGrane.DataSource = Subjects;
            cmbStudentGrane.DisplayMember = "SubjectFullInfo";


        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            string text = cmbStudentGrane.GetItemText(cmbStudentGrane.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int Subjectid = Int32.Parse(tempID);

            Grades = db.StudentGetGrades(Subjectid, StudentID);
            listStudentGrades.DataSource = Grades;
            listStudentGrades.DisplayMember = "GradeStudentInfo";

        }

        private void StudentGradeF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
