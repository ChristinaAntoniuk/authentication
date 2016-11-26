using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuthProject
{
    /// <summary>
    /// This form is used for adding new users.
    /// </summary>
    public partial class AddForm : Form
    {
        private Data data;
        /// <summary>
        /// Dictionary of existing users.
        /// </summary>
        private Dictionary<string, string> loginPassword;
        /// <summary>
        /// Login-password pair of new user.
        /// </summary>
        private KeyValuePair<string, string> newLoginPassword;

        public AddForm(Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void login_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            login_textBox.Clear();
        }

        private void password_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            password_textBox.Clear();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method adds new user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Button_Click(object sender, EventArgs e)
        {
            newLoginPassword = new KeyValuePair<string, string>(login_textBox.Text, password_textBox.Text);
            data.editLoginPassword(newLoginPassword);
            data.setLoginPassword();
            this.Close();
        }
    }
}
