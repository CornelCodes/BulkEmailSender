
namespace WinFormUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.senderEmailTextBox = new System.Windows.Forms.TextBox();
            this.senderEmailLabel = new System.Windows.Forms.Label();
            this.senderNameLabel = new System.Windows.Forms.Label();
            this.senderNameTextBox = new System.Windows.Forms.TextBox();
            this.senderPasswordLabel = new System.Windows.Forms.Label();
            this.senderPasswordTextBox = new System.Windows.Forms.TextBox();
            this.senderGroupBox = new System.Windows.Forms.GroupBox();
            this.emailGroupBox = new System.Windows.Forms.GroupBox();
            this.emailBodyTextBox = new System.Windows.Forms.TextBox();
            this.emailBodyLabel = new System.Windows.Forms.Label();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.emailSubjectLabel = new System.Windows.Forms.Label();
            this.recipientsGroupBox = new System.Windows.Forms.GroupBox();
            this.recipientsListBox = new System.Windows.Forms.ListBox();
            this.removeRecipientButton = new System.Windows.Forms.Button();
            this.addRecipientButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.senderGroupBox.SuspendLayout();
            this.emailGroupBox.SuspendLayout();
            this.recipientsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderEmailTextBox
            // 
            this.senderEmailTextBox.Location = new System.Drawing.Point(48, 19);
            this.senderEmailTextBox.Name = "senderEmailTextBox";
            this.senderEmailTextBox.Size = new System.Drawing.Size(317, 20);
            this.senderEmailTextBox.TabIndex = 1;
            // 
            // senderEmailLabel
            // 
            this.senderEmailLabel.AutoSize = true;
            this.senderEmailLabel.Location = new System.Drawing.Point(8, 22);
            this.senderEmailLabel.Name = "senderEmailLabel";
            this.senderEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.senderEmailLabel.TabIndex = 2;
            this.senderEmailLabel.Text = "Email:";
            // 
            // senderNameLabel
            // 
            this.senderNameLabel.AutoSize = true;
            this.senderNameLabel.Location = new System.Drawing.Point(8, 48);
            this.senderNameLabel.Name = "senderNameLabel";
            this.senderNameLabel.Size = new System.Drawing.Size(38, 13);
            this.senderNameLabel.TabIndex = 4;
            this.senderNameLabel.Text = "Name:";
            // 
            // senderNameTextBox
            // 
            this.senderNameTextBox.Location = new System.Drawing.Point(48, 45);
            this.senderNameTextBox.Name = "senderNameTextBox";
            this.senderNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.senderNameTextBox.TabIndex = 3;
            // 
            // senderPasswordLabel
            // 
            this.senderPasswordLabel.AutoSize = true;
            this.senderPasswordLabel.Location = new System.Drawing.Point(247, 48);
            this.senderPasswordLabel.Name = "senderPasswordLabel";
            this.senderPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.senderPasswordLabel.TabIndex = 6;
            this.senderPasswordLabel.Text = "Password:";
            // 
            // senderPasswordTextBox
            // 
            this.senderPasswordTextBox.Location = new System.Drawing.Point(309, 45);
            this.senderPasswordTextBox.Name = "senderPasswordTextBox";
            this.senderPasswordTextBox.Size = new System.Drawing.Size(178, 20);
            this.senderPasswordTextBox.TabIndex = 5;
            // 
            // senderGroupBox
            // 
            this.senderGroupBox.Controls.Add(this.senderEmailTextBox);
            this.senderGroupBox.Controls.Add(this.senderPasswordLabel);
            this.senderGroupBox.Controls.Add(this.senderEmailLabel);
            this.senderGroupBox.Controls.Add(this.senderPasswordTextBox);
            this.senderGroupBox.Controls.Add(this.senderNameTextBox);
            this.senderGroupBox.Controls.Add(this.senderNameLabel);
            this.senderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.senderGroupBox.Name = "senderGroupBox";
            this.senderGroupBox.Size = new System.Drawing.Size(497, 77);
            this.senderGroupBox.TabIndex = 7;
            this.senderGroupBox.TabStop = false;
            this.senderGroupBox.Text = "Sender";
            // 
            // emailGroupBox
            // 
            this.emailGroupBox.Controls.Add(this.emailBodyTextBox);
            this.emailGroupBox.Controls.Add(this.emailBodyLabel);
            this.emailGroupBox.Controls.Add(this.emailSubjectTextBox);
            this.emailGroupBox.Controls.Add(this.emailSubjectLabel);
            this.emailGroupBox.Location = new System.Drawing.Point(13, 96);
            this.emailGroupBox.Name = "emailGroupBox";
            this.emailGroupBox.Size = new System.Drawing.Size(496, 240);
            this.emailGroupBox.TabIndex = 8;
            this.emailGroupBox.TabStop = false;
            this.emailGroupBox.Text = "Email";
            // 
            // emailBodyTextBox
            // 
            this.emailBodyTextBox.Location = new System.Drawing.Point(59, 45);
            this.emailBodyTextBox.Multiline = true;
            this.emailBodyTextBox.Name = "emailBodyTextBox";
            this.emailBodyTextBox.Size = new System.Drawing.Size(427, 189);
            this.emailBodyTextBox.TabIndex = 9;
            // 
            // emailBodyLabel
            // 
            this.emailBodyLabel.AutoSize = true;
            this.emailBodyLabel.Location = new System.Drawing.Point(19, 48);
            this.emailBodyLabel.Name = "emailBodyLabel";
            this.emailBodyLabel.Size = new System.Drawing.Size(34, 13);
            this.emailBodyLabel.TabIndex = 10;
            this.emailBodyLabel.Text = "Body:";
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(59, 19);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(427, 20);
            this.emailSubjectTextBox.TabIndex = 7;
            // 
            // emailSubjectLabel
            // 
            this.emailSubjectLabel.AutoSize = true;
            this.emailSubjectLabel.Location = new System.Drawing.Point(7, 22);
            this.emailSubjectLabel.Name = "emailSubjectLabel";
            this.emailSubjectLabel.Size = new System.Drawing.Size(46, 13);
            this.emailSubjectLabel.TabIndex = 8;
            this.emailSubjectLabel.Text = "Subject:";
            // 
            // recipientsGroupBox
            // 
            this.recipientsGroupBox.Controls.Add(this.recipientsListBox);
            this.recipientsGroupBox.Controls.Add(this.removeRecipientButton);
            this.recipientsGroupBox.Controls.Add(this.addRecipientButton);
            this.recipientsGroupBox.Location = new System.Drawing.Point(516, 13);
            this.recipientsGroupBox.Name = "recipientsGroupBox";
            this.recipientsGroupBox.Size = new System.Drawing.Size(239, 379);
            this.recipientsGroupBox.TabIndex = 9;
            this.recipientsGroupBox.TabStop = false;
            this.recipientsGroupBox.Text = "Recipients";
            // 
            // recipientsListBox
            // 
            this.recipientsListBox.FormattingEnabled = true;
            this.recipientsListBox.Location = new System.Drawing.Point(6, 19);
            this.recipientsListBox.Name = "recipientsListBox";
            this.recipientsListBox.Size = new System.Drawing.Size(227, 303);
            this.recipientsListBox.TabIndex = 13;
            // 
            // removeRecipientButton
            // 
            this.removeRecipientButton.Location = new System.Drawing.Point(124, 332);
            this.removeRecipientButton.Name = "removeRecipientButton";
            this.removeRecipientButton.Size = new System.Drawing.Size(109, 41);
            this.removeRecipientButton.TabIndex = 12;
            this.removeRecipientButton.Text = "Remove Recipient";
            this.removeRecipientButton.UseVisualStyleBackColor = true;
            this.removeRecipientButton.Click += new System.EventHandler(this.removeRecipientButton_Click);
            // 
            // addRecipientButton
            // 
            this.addRecipientButton.Location = new System.Drawing.Point(6, 332);
            this.addRecipientButton.Name = "addRecipientButton";
            this.addRecipientButton.Size = new System.Drawing.Size(109, 41);
            this.addRecipientButton.TabIndex = 11;
            this.addRecipientButton.Text = "Add Recipient";
            this.addRecipientButton.UseVisualStyleBackColor = true;
            this.addRecipientButton.Click += new System.EventHandler(this.addRecipientButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(394, 345);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(115, 41);
            this.sendEmailButton.TabIndex = 10;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 396);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.recipientsGroupBox);
            this.Controls.Add(this.emailGroupBox);
            this.Controls.Add(this.senderGroupBox);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.senderGroupBox.ResumeLayout(false);
            this.senderGroupBox.PerformLayout();
            this.emailGroupBox.ResumeLayout(false);
            this.emailGroupBox.PerformLayout();
            this.recipientsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox senderEmailTextBox;
        private System.Windows.Forms.Label senderEmailLabel;
        private System.Windows.Forms.Label senderNameLabel;
        private System.Windows.Forms.TextBox senderNameTextBox;
        private System.Windows.Forms.Label senderPasswordLabel;
        private System.Windows.Forms.TextBox senderPasswordTextBox;
        private System.Windows.Forms.GroupBox senderGroupBox;
        private System.Windows.Forms.GroupBox emailGroupBox;
        private System.Windows.Forms.TextBox emailBodyTextBox;
        private System.Windows.Forms.Label emailBodyLabel;
        private System.Windows.Forms.TextBox emailSubjectTextBox;
        private System.Windows.Forms.Label emailSubjectLabel;
        private System.Windows.Forms.GroupBox recipientsGroupBox;
        private System.Windows.Forms.ListBox recipientsListBox;
        private System.Windows.Forms.Button removeRecipientButton;
        private System.Windows.Forms.Button addRecipientButton;
        private System.Windows.Forms.Button sendEmailButton;
    }
}

