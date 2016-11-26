namespace AuthProject
{
    partial class AuthForm
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
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(12, 12);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(179, 20);
            this.login_textBox.TabIndex = 0;
            this.login_textBox.Text = "Login";
            this.login_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login_textBox_MouseClick);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(12, 38);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(179, 20);
            this.password_textBox.TabIndex = 1;
            this.password_textBox.Text = "Password";
            this.password_textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_textBox_MouseClick);
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(12, 64);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(83, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(101, 64);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(90, 23);
            this.cancel_Button.TabIndex = 3;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 95);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button cancel_Button;
    }
}