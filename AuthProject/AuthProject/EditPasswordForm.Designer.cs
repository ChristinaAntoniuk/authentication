namespace AuthProject
{
    partial class EditPasswordForm
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
            this.cancel_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.user_ListBox = new System.Windows.Forms.ListBox();
            this.newPassword_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(126, 165);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(119, 23);
            this.cancel_Button.TabIndex = 12;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.Location = new System.Drawing.Point(12, 165);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(110, 23);
            this.edit_Button.TabIndex = 11;
            this.edit_Button.Text = "Edit password";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // user_ListBox
            // 
            this.user_ListBox.FormattingEnabled = true;
            this.user_ListBox.Location = new System.Drawing.Point(12, 12);
            this.user_ListBox.Name = "user_ListBox";
            this.user_ListBox.Size = new System.Drawing.Size(233, 121);
            this.user_ListBox.TabIndex = 10;
            // 
            // newPassword_textBox
            // 
            this.newPassword_textBox.Location = new System.Drawing.Point(12, 139);
            this.newPassword_textBox.Name = "newPassword_textBox";
            this.newPassword_textBox.Size = new System.Drawing.Size(233, 20);
            this.newPassword_textBox.TabIndex = 13;
            this.newPassword_textBox.Text = "New Password";
            this.newPassword_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.newPassword_textBox_MouseClick);
            // 
            // EditPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 195);
            this.Controls.Add(this.newPassword_textBox);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.user_ListBox);
            this.Name = "EditPasswordForm";
            this.Text = "EditPasswordForm";
            this.Load += new System.EventHandler(this.EditPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.ListBox user_ListBox;
        private System.Windows.Forms.TextBox newPassword_textBox;
    }
}