using System;
using System.Windows.Forms;

namespace AUHostelProject.UI
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Login";

            // Create labels for student and staff
            var labelStudent = new Label() { Text = "Student Login", Left = 50, Top = 20 }; 
            var labelStaff = new Label() { Text = "Staff Login", Left = 50, Top = 120 };

            // Create textboxes for credentials
            var textBoxUsername = new TextBox { Left = 50, Top = 50, Width = 200 }; 
            var textBoxPassword = new TextBox { Left = 50, Top = 80, Width = 200, PasswordChar = '*' };
            var textBoxStaffUsername = new TextBox { Left = 50, Top = 150, Width = 200 }; 
            var textBoxStaffPassword = new TextBox { Left = 50, Top = 180, Width = 200, PasswordChar = '*' };

            // Create buttons for login
            var buttonStudentLogin = new Button() { Text = "Login as Student", Left = 50, Top = 110 }; 
            var buttonStaffLogin = new Button() { Text = "Login as Staff", Left = 50, Top = 210 }; 

            // Add event handlers for buttons
            buttonStudentLogin.Click += (sender, e) => {};
            buttonStaffLogin.Click += (sender, e) => {};

            // Add controls to form
            this.Controls.Add(labelStudent);
            this.Controls.Add(textBoxUsername);
            this.Controls.Add(textBoxPassword);
            this.Controls.Add(buttonStudentLogin);
            this.Controls.Add(labelStaff);
            this.Controls.Add(textBoxStaffUsername);
            this.Controls.Add(textBoxStaffPassword);
            this.Controls.Add(buttonStaffLogin);
        }
    }
}