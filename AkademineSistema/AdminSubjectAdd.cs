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
    public partial class AdminSubjectAdd : Form
    {
        DataAccess db = new DataAccess();
        int Identity;
        public AdminSubjectAdd(int id)
        {
            InitializeComponent();
            Identity = id;
        }

        private void btnAdminSubjectAddOk_Click(object sender, EventArgs e)
        {
            db.CreateSubject(txtAdminSubjetName.Text, Identity);
            this.Close();
        }

        private void btnAdminSubjectAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
