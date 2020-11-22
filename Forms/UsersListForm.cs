using System;
using System.Windows.Forms;

namespace Log_Reg_Form
{
    public partial class UsersList : Form
    {
        public UsersList()
        {
            InitializeComponent();
        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            User user = Session.User;
            lbl_welcome.Text = "Welcome " + user.Email;

            dataTable.DataSource = Users.GetUsers();
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            Session.ListForm = this;
            Session.AdminPanel.Show();
            Hide();

        }

        private void UsersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }
    }
}
