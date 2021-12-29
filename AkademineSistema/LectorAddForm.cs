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
    public partial class LectorAddForm : Form
    {
        DataAccess db = new DataAccess();
        int StudentID;
        int SubjectID;
        int LectorID;
        public LectorAddForm(int Studentid, int Subjectid, int Lectorid)
        {
            InitializeComponent();
            StudentID = Studentid;
            SubjectID = Subjectid;
            LectorID = Lectorid;
        }

        private void btnLectorGradeAdd_Click(object sender, EventArgs e)
        {
            string Grade = txtLectorAddGrade.Text;
            int GradeInt = Int32.Parse(Grade);
            db.AddGrade(txtLectorAddSource.Text, dateLectorAddDate.Value.ToString("yyyy-MM-dd"),
                GradeInt, StudentID, SubjectID, LectorID);
            this.Close();
        }

        private void btnLectorGradeCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
