using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Reg_Form.Forms
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string enteredCode = txbx_code.Text;
            if (Session.Code == enteredCode)
            {
                Session.User.IsEmailConfirmed = true;
                MessageBox.Show("Email successfully confirmed!");
            }
            else
            {
                MessageBox.Show("Confirmation code is wrong! Please try again!");
            }
        }
    }
}
