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
    public partial class AdminLectorF : Form
    {
        List<LectorClass> Lectors = new List<LectorClass>();
        DataAccess db = new DataAccess();
        int Identity;
        public AdminLectorF(int id)
        {
            InitializeComponent();
            Identity = id;

            Lectors = db.GetAllLectors();
            listAdminLectors.DataSource = Lectors;
            listAdminLectors.DisplayMember = "LectorsFullInfo";
        }

        private void btnAdminLectorAdd_Click(object sender, EventArgs e)
        {
            AdminLectorAdd addF = new AdminLectorAdd(Identity);
            addF.ShowDialog();
        }

        private void btnAdminStudentSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminLectorSearch.Text))
            {
                Lectors = db.GetAllLectors();
            }
            else
            {
                Lectors = db.GetLectorByName(txtAdminLectorSearch.Text);
            }
            listAdminLectors.DataSource = Lectors;
            listAdminLectors.DisplayMember = "LectorsFullInfo";
        }

        private void btnAdminLectorDelete_Click(object sender, EventArgs e)
        {
            string text = listAdminLectors.GetItemText(listAdminLectors.SelectedItem);
            string tempID = text.Substring(0, text.IndexOf(" "));
            int ID = Int32.Parse(tempID);
            db.DeleteLector(ID);

            Lectors = db.GetAllLectors();
            listAdminLectors.DataSource = Lectors;
            listAdminLectors.DisplayMember = "LectorsFullInfo";
        }
    }
}
