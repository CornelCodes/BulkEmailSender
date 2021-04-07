
namespace WinFormUI
{
    partial class AddRecipientForm
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
            this.recipientEmailLabel = new System.Windows.Forms.Label();
            this.recipientEmailTextBox = new System.Windows.Forms.TextBox();
            this.addRecipientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recipientEmailLabel
            // 
            this.recipientEmailLabel.AutoSize = true;
            this.recipientEmailLabel.Location = new System.Drawing.Point(13, 13);
            this.recipientEmailLabel.Name = "recipientEmailLabel";
            this.recipientEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.recipientEmailLabel.TabIndex = 0;
            this.recipientEmailLabel.Text = "Email:";
            // 
            // recipientEmailTextBox
            // 
            this.recipientEmailTextBox.Location = new System.Drawing.Point(16, 30);
            this.recipientEmailTextBox.Name = "recipientEmailTextBox";
            this.recipientEmailTextBox.Size = new System.Drawing.Size(335, 20);
            this.recipientEmailTextBox.TabIndex = 1;
            // 
            // addRecipientButton
            // 
            this.addRecipientButton.Location = new System.Drawing.Point(254, 56);
            this.addRecipientButton.Name = "addRecipientButton";
            this.addRecipientButton.Size = new System.Drawing.Size(91, 39);
            this.addRecipientButton.TabIndex = 2;
            this.addRecipientButton.Text = "Add";
            this.addRecipientButton.UseVisualStyleBackColor = true;
            this.addRecipientButton.Click += new System.EventHandler(this.addRecipientButton_Click);
            // 
            // AddRecipientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 107);
            this.Controls.Add(this.addRecipientButton);
            this.Controls.Add(this.recipientEmailTextBox);
            this.Controls.Add(this.recipientEmailLabel);
            this.Name = "AddRecipientForm";
            this.Text = "Add Recipient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipientEmailLabel;
        private System.Windows.Forms.TextBox recipientEmailTextBox;
        private System.Windows.Forms.Button addRecipientButton;
    }
}