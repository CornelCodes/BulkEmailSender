using EmailLibrary;
using EmailLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class AddRecipientForm : Form
    {
        private Emailer _emailer;
        private Form _parentForm;
        public AddRecipientForm(Form parentForm, Emailer emailer)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _emailer = emailer;
        }

        private void addRecipientButton_Click(object sender, EventArgs e)
        {
            if (EmailValidator.Validate(recipientEmailTextBox.Text))
            {
                _emailer.AddRecipient(recipientEmailTextBox.Text);
                _parentForm.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email address please try again");
            }
        }
    }
}
