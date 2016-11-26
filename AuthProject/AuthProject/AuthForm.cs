using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AuthProject
{
    /// <summary>
    /// This form is user for user's authentication.
    /// </summary>
    public partial class AuthForm : Form
    {
        private Data data;
        /// <summary>
        /// Login and password which were put by user.
        /// </summary>
        private KeyValuePair<string, string> currentLoginPassword;

        public AuthForm(Data data)
        {
            InitializeComponent();
            TopMost = true;
            this.data = data;
            login_textBox.Text = "Admin";
            password_textBox.Text = "1111";
        }

        private void login_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            login_textBox.Clear();
        }

        private void password_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            password_textBox.Clear();
        }

        /// <summary>
        /// Main logic of authentication.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_Button_Click(object sender, EventArgs e)
        {
            setCurLoginPassword(login_textBox.Text, data.GetHash(password_textBox.Text));
            if (authenticated(currentLoginPassword, data.getLoginPassword()))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password.");
            }
        }

        public void setCurLoginPassword(string curLogin, string curPassword)
        {
            this.currentLoginPassword = new KeyValuePair<string, string>(curLogin, curPassword);
        }

        public KeyValuePair<string, string> getCurLoginPassword()
        {
            return currentLoginPassword;
        }

        /// <summary>
        /// Method checks the existence of current login and password in active dictionary of logins and
        /// passwords.
        /// </summary>
        /// <param name="curLoginPassword"></param>
        /// <param name="loginPassword"></param>
        /// <returns></returns>
        public bool authenticated(KeyValuePair<string,string> curLoginPassword,
                                        Dictionary<string,string> loginPassword)
        {
            return loginPassword.Contains(curLoginPassword);
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
