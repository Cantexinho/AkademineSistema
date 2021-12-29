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
    public partial class AdminSubjectLector : Form
    {
        List<LectorClass> Lectors = new List<LectorClass>();
        DataAccess db = new DataAccess();
        int ID;
        public AdminSubjectLector(int SubjectID)
        {
            InitializeComponent();
            ID = SubjectID;

            Lectors = db.GetAllLectors();
            listAdminSubjectLector.DataSource = Lectors;
            listAdminSubjectLector.DisplayMember = "LectorsFullInfo";
        }

        private void btnAdminSubjectLectorAddOk_Click(object sender, EventArgs e)
        {
            string text = listAdminSubjectLector.GetItemText(listAdminSubjectLector.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int IDLector = Int32.Parse(tempID);
            db.AssignSubjectLector(IDLector, ID);
            this.Close();

        }

        private void btnAdminStudentSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminSubjectLectorSearch.Text))
            {
                Lectors = db.GetAllLectors();
            }
            else
            {
                Lectors = db.GetLectorByName(txtAdminSubjectLectorSearch.Text);
            }
            listAdminSubjectLector.DataSource = Lectors;
            listAdminSubjectLector.DisplayMember = "LectorsFullInfo";
        }

        private void btnAdminSubjectLectorAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
