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
    public partial class AdminMainF : Form
    {
        int Identity;
        public AdminMainF(int id)
        {
            InitializeComponent();
            Identity = id;
        }

        private void btnAdminStudents_Click(object sender, EventArgs e)
        {
            AdminStudentF asF = new AdminStudentF(Identity);
            asF.ShowDialog();

        }

        private void btnAdminLectors_Click(object sender, EventArgs e)
        {
            AdminLectorF alF = new AdminLectorF(Identity);
            alF.ShowDialog();
        }

        private void btnAdminGroups_Click(object sender, EventArgs e)
        {
            AdminGroupF agF = new AdminGroupF(Identity);
            agF.ShowDialog();
        }

        private void btnAdminSubjects_Click(object sender, EventArgs e)
        {
            AdminSubjectF asF = new AdminSubjectF(Identity);
            asF.ShowDialog();
        }

        private void AdminMainF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
