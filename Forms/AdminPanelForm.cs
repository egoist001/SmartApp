using Log_Reg_Form.Forms;
using System;
using System.Windows.Forms;

namespace Log_Reg_Form
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            User user = Session.User;
            lbl_welcome.Text = "Welcome " + user.Email;
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel = Session.AdminPanel ?? this;
            Session.Main_Form.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel = Session.AdminPanel ?? this;
            UsersList usersList = Session.ListForm ?? new UsersList();
            Hide();
            usersList.ShowDialog();
        }

        private void link_logsList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.AdminPanel = Session.AdminPanel ?? this;
            LogsListForm logsListForm = Session.LogsForm ?? new LogsListForm();
            Hide();
            logsListForm.ShowDialog();
        }
    }
}
