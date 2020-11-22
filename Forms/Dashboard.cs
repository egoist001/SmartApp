using Log_Reg_Form.Vizualizer;
using System;
using System.Windows.Forms;

namespace Log_Reg_Form
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private readonly Main_Form main_Form = Session.Main_Form;
        private readonly string path_toLogs = FileManager.GetPath("logs", "logs-list.txt");
        private User user = null;

        private void DisplayUserInfo(User user)
        {
            lbl_welcome.Text = "Welcome " + user.Email;
            lbl_name.Text = "Name: " + user.Name;
            lbl_surname.Text = "Surname: " + user.Surname;
            lbl_age.Text = "Age: " + user.Age;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            user = Session.User;
            DisplayUserInfo(user);

            if (!string.IsNullOrEmpty(user.ProfilePicturePath))
            {
                FileManager.ShowMyImage(user.ProfilePicturePath, pictureBox1, 300, 300);
            }
            else
            {
                FileManager.ShowMyImage(FileManager.GetPath("pictures", "user_pic_default.png"), pictureBox1, 300, 300);
            }

            

            FileManager.WriteLog(path_toLogs, FileManager.GetLogMessage(new XMLVizualizer(user.Email, Roles.LogStatus.LogIn)));
        }

        private void link_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FileManager.WriteLog(path_toLogs, FileManager.GetLogMessage(new XMLVizualizer(user.Email, Roles.LogStatus.LogOut)));

            Session.Dashboard = this;
            main_Form.Show();
            Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.CloseApp();  
        }

        private void link_setPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;

                user.ProfilePicturePath = FileManager.CopyPicture(fileName);
                FileManager.ShowMyImage(user.ProfilePicturePath, pictureBox1, 300, 300);
            }
        }
    }
}
