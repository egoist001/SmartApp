using System;
using System.Windows.Forms;
using System.Net;
using Log_Reg_Form.Forms;
using System.Net.Mail;
using Log_Reg_Form.Core;
using Log_Reg_Form.Exceptions;

namespace Log_Reg_Form
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        
        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            { 
                string
                    name = txbx_name.Text,
                    surname = txbx_surname.Text,
                    email = txbx_email.Text,
                    password = txbx_password.Text,
                    age = txbx_age.Text;

                if (!Validator.IsEmailValid(email))
                    throw new InvalidEmailException("Email format is not correct!");

                if (!Validator.IsPasswordValid(password))
                    throw new InvalidPasswordException("Password format is not correct! Password length must be more than 4 characters!");

                Validator.Validate(name, surname, age, email, password);
                sbyte convertedAge = Validator.CheckUserAge(age);

                    if (!Users.HasUser(email, password))
                    {
                        User user = new User(name, surname, convertedAge, email, password)
                        {
                            UserRole = UserRole.User
                        };
                        Session.User = user;
                        AccountManager.DisplayConfirmationWindow += AccountManager_DisplayConfirmationWindow;
                        AccountManager.SendMail(email);   
                        if (user.IsEmailConfirmed)
                        {
                            Users.AddUser(user);
                            MessageBox.Show("You succesfully registred!");
                        }
                        else
                        {
                            MessageBox.Show("Email Confirmation Failed!");
                        }
                    }

            }
            catch (OverflowException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch(ArgumentNullException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (FormatException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (SmtpException exp)
            {
                string message = "You did not give access to this app!";
                MessageBox.Show(message);
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidPasswordException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                EmptyTextBoxes(txbx_name, txbx_surname, txbx_age, txbx_email, txbx_password);
            }
        }

        private void AccountManager_DisplayConfirmationWindow()
        {
            Session.Code = AccountManager.ConfirmationCode;
            new ConfirmationForm().ShowDialog();
        }

        private void EmptyTextBoxes(params TextBox[] textBoxes)
        {
            if (textBoxes == null)
                throw new ArgumentNullException();

            foreach (var txbx in textBoxes)
            {
                txbx.Text = string.Empty;
            }
        }

        private void linklbl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (grbx_login.Visible, grbx_register.Visible) = (true, false);
        }

        private void linklbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (grbx_login.Visible, grbx_register.Visible) = (false, true);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string
                email = txbx_loginEmail.Text,
                password = txbx_loginPass.Text;

                Validator.Validate(email, password);
                if (!Validator.IsEmailValid(email))
                    throw new InvalidEmailException("Email format is not correct!");

                if (!Validator.IsPasswordValid(password))
                    throw new InvalidPasswordException("Password format is not correct! Password length must be more than 4 characters!");


                if (Users.HasUser(email, password))
                {
                    User currentUser = Users.GetUser(email, password);
                    Session.User = currentUser;
                    Session.Main_Form = this;
                    Hide();
                    if (currentUser.UserRole == UserRole.Admin)
                    {
                        AdminPanel adminPanel = Session.AdminPanel ?? new AdminPanel();
                        adminPanel.ShowDialog();
                    }
                    else
                    {
                        Dashboard dashboard = Session.Dashboard ?? new Dashboard();
                        dashboard.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Try again, please. Email or Password is given wrong!");
                }
            }
            catch (InvalidEmailException exp)
            {
                MessageBox.Show(exp.Message);
            }
            catch (InvalidPasswordException exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                EmptyTextBoxes(txbx_loginEmail, txbx_loginPass);
            }
        }   
    }
}
