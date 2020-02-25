using SIS.BusinessLogic;
using System;
using System.Windows.Forms;

namespace StudentTrackingSystem
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var roleNo = txtStudentRoleNo.Text.Trim();
            var firstName = txtFirstName.Text.Trim();
            var lastName = txtLastName.Text.Trim();
            var place = txtPlace.Text.Trim();

            clsStudentSystem objStudentSystem = new clsStudentSystem();
            objStudentSystem.SaveStudentRecord(roleNo, firstName, lastName, place);

            FetchAllStudents();
        }

        private void FetchAllStudents()
        {
            clsStudentSystem objStudentSystem = new clsStudentSystem();
            dgStudent.DataSource = objStudentSystem.FetchStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentRoleNo.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPlace.Text = string.Empty;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            FetchAllStudents();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
