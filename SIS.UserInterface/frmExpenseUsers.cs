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
            var name = txtName.Text.Trim();
            var userName = txtUserName.Text.Trim();
            var emailId = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();
            var confirmPassword = txtConfirmPassword.Text.Trim();

            clsStudentSystem objStudentSystem = new clsStudentSystem();
            objStudentSystem.SaveUserRecord(name, userName, emailId, password);

            FetchAllStudents();
        }

        private void FetchAllStudents()
        {
            clsStudentSystem objStudentSystem = new clsStudentSystem();
            dgStudent.DataSource = objStudentSystem.FetchUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            FetchAllStudents();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
