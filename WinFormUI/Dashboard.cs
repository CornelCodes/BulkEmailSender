using EmailLibrary;
using EmailLibrary.Models;
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
    public partial class Dashboard : Form
    {
        public Emailer emailer;
        public Dashboard()
        {
            InitializeComponent();
            emailer = new Emailer();
            ShowRecipients();
        }

        private void addRecipientButton_Click(object sender, EventArgs e)
        {
            AddRecipientForm addRecipientForm = new AddRecipientForm(this, emailer);
            addRecipientForm.Show();
            this.Enabled = false;
        }

        private void removeRecipientButton_Click(object sender, EventArgs e)
        {
            emailer.RemoveRecipient((Recipient)recipientsListBox.SelectedItem);
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            emailer.SendEmailToAll(emailSubjectTextBox.Text, emailBodyTextBox.Text);
        }

        private void ShowRecipients()
        {
            recipientsListBox.DataSource = emailer.recipients;
            recipientsListBox.DisplayMember = "EmailAddress";
        }
    }
}
