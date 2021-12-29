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
    public partial class LectorGradeF : Form
    {
        List <StudentClass> Students = new List<StudentClass>();
        List<GradeClass> Grades = new List<GradeClass>();
        DataAccess db = new DataAccess();
        int StudentID;
        int SubjectID;
        int LectorID;
        public LectorGradeF(int Studentid, int Subjectid, int Lectorid)
        {
            InitializeComponent();
            StudentID = Studentid;
            SubjectID = Subjectid;
            LectorID = Lectorid;

            Students = db.GetStudentById(StudentID);
            StudentClass Student = Students[0];
            lblStudent.Text = Student.studentName + " " + Student.studentsSurname;

            Grades = db.GetStudentGrades(StudentID);
            listLectorStudentGrade.DataSource = Grades;
            listLectorStudentGrade.DisplayMember = "GradeStudentInfo";
        }

        private void btnLectorAdd_Click(object sender, EventArgs e)
        {
            LectorAddForm laddF = new LectorAddForm(StudentID, SubjectID, LectorID);
            laddF.ShowDialog();
        }

        private void btnLectorBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLectorDeleteGrade_Click(object sender, EventArgs e)
        {
            string text = listLectorStudentGrade.GetItemText(listLectorStudentGrade.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int ID = Int32.Parse(tempID);
            db.DeleteGrade(ID);

            Grades = db.GetStudentGrades(StudentID);
            listLectorStudentGrade.DataSource = Grades;
            listLectorStudentGrade.DisplayMember = "GradeStudentInfo";
        }
    }
}
