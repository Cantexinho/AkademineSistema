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
    public partial class AdminLectorAdd : Form
    {
        DataAccess db = new DataAccess();
        int Identity;
        public AdminLectorAdd(int id)
        {
            InitializeComponent();
            Identity = id;
        }

        private void btnAdminLectorAddOk_Click(object sender, EventArgs e)
        {
            db.CreateLector(txtAdminLectorName.Text, txtAdminLectorSurname.Text, Identity);
            this.Close();
        }

        private void btnAdminLectorAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
