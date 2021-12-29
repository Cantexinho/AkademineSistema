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
    public partial class AdminStudentF : Form
    {
        List<StudentClass> Students = new List<StudentClass>();
        DataAccess db = new DataAccess();
        int Identity;
        public AdminStudentF(int id) 
        {
            InitializeComponent();
            Identity = id;

            Students = db.GetAllStudents();
            listAdminStudent.DataSource = Students;
            listAdminStudent.DisplayMember = "StudentFullInfo";
        }

        private void btnAdminStudentSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminStudentSeacrh.Text))
            {
                Students = db.GetAllStudents();
            }
            else
            {
                Students = db.GetStudentsByName(txtAdminStudentSeacrh.Text);
            }
            listAdminStudent.DataSource = Students;
            listAdminStudent.DisplayMember = "StudentFullInfo";
        }
        private void btnAdminStudentAdd_Click(object sender, EventArgs e)
        {
            AdminStudentAdd addF = new AdminStudentAdd(Identity);
            addF.ShowDialog();

        }

        private void btnAdminStudentGroup_Click(object sender, EventArgs e)
        {
            string text = listAdminStudent.GetItemText(listAdminStudent.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int StudentID = Int32.Parse(tempID);
            AdminStudentAddGroup asaG = new AdminStudentAddGroup(StudentID);
            asaG.ShowDialog();
        }

        private void btnAdminStudentDelete_Click(object sender, EventArgs e)
        {
            string text = listAdminStudent.GetItemText(listAdminStudent.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int ID = Int32.Parse(tempID);
            db.DeleteStudent(ID);

            Students = db.GetAllStudents();
            listAdminStudent.DataSource = Students;
            listAdminStudent.DisplayMember = "StudentFullInfo";
        }

    }
}
