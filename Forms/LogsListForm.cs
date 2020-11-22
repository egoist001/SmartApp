using System;
using System.Windows.Forms;


namespace Log_Reg_Form.Forms
{
    public partial class LogsListForm : Form
    {
        public LogsListForm()
        {
            InitializeComponent();
        }

        private void LogsListForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = Session.User.Email;

            rtxbx_logs.Text = FileManager.ReadLogs(FileManager.GetPath("logs", "logs-list.txt"));
            
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Session.LogsForm = this;
            Session.AdminPanel.Show();
            Hide();
        }

        private void LogsListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();
        }


    }
}
