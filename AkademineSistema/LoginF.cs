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
    public partial class LoginF : Form
    {
        DataAccess StudentsDb = new DataAccess();
        DataAccess AdminsDb = new DataAccess();
        DataAccess LectorsDb = new DataAccess();

        List<StudentClass> Students = new List<StudentClass>();
        List<AdminClass> Admins = new List<AdminClass>();
        List<LectorClass> Lectors = new List<LectorClass>();

        Exception NameExec = new Exception("User doesn`t exist");
        Exception PasswordExec = new Exception("Wrong password");
        public LoginF()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 14;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPassword.Text))
                {
                    throw PasswordExec;
                }
                else
                {
                    Students = StudentsDb.GetStudentsByName(txtUsername.Text);
                    if (Students.Count != 0)
                    {
                        StudentClass Student = Students[0];
                        string StudentName = Student.studentName;
                        string StudentSurname = Student.studentsSurname;
                        int StudentId = Student.studentID;
                        int GroupId = Student.groupID;
                        if (txtUsername.Text == StudentName && txtPassword.Text == StudentSurname)
                        {
                            this.Hide();
                            StudentGradeF sgF = new StudentGradeF(StudentId, GroupId);
                            sgF.ShowDialog();
                        }
                        else if (txtUsername.Text == StudentName && txtPassword.Text != StudentSurname)
                        {
                            throw PasswordExec;
                        }
                    }
                    else
                    {
                        Admins = AdminsDb.GetAdminByName(txtUsername.Text);
                        if (Admins.Count != 0)
                        {
                            AdminClass Admin = Admins[0];
                            string AdminName = Admin.adminName;
                            string AdminSurname = Admin.adminSurname;
                            int AdminId = Admin.adminID;
                            if (txtUsername.Text == AdminName && txtPassword.Text == AdminSurname)
                            {
                                this.Hide();
                                AdminMainF amF = new AdminMainF(AdminId);
                                amF.ShowDialog();
                            }
                            else if (txtUsername.Text == AdminName && txtPassword.Text != AdminSurname)
                            {
                                throw PasswordExec;
                            }
                        }
                        else
                        {
                            Lectors = LectorsDb.GetLectorByName(txtUsername.Text);
                            if (Lectors.Count != 0)
                            {
                                LectorClass Lector =Lectors[0];
                                string LectorName = Lector.lectorName;
                                string LectorSurname = Lector.lectorSurname;
                                int LectorId = Lector.lectorID;
                                if (txtUsername.Text == LectorName && txtPassword.Text == LectorSurname)
                                {
                                    this.Hide();
                                    LectorMainF lmF = new LectorMainF(LectorId);
                                    lmF.ShowDialog();
                                }
                                else if (txtUsername.Text == LectorName && txtPassword.Text != LectorSurname)
                                {
                                    throw PasswordExec;
                                }
                            }
                            else
                            {
                                throw NameExec;
                            }
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                string title = "Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(Convert.ToString(exc.Message), title, button);
            }
        }
    }
}
