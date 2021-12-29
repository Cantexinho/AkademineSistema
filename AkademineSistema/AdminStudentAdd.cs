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
    public partial class AdminStudentAdd : Form
    {
        DataAccess db = new DataAccess();
        int Identity;
        public AdminStudentAdd(int id)
        {
            InitializeComponent();
            Identity = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.CreateStudent(txtAdminStudentName.Text, txtAdminStudentSurnam.Text, Identity);
            this.Close();
        }

        private void btnAdminStudentAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
