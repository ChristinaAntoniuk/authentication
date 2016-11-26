using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuthProject
{
    /// <summary>
    /// This form is used for editing password of existing users.
    /// </summary>
    public partial class EditPasswordForm : Form
    {
        /// <summary>
        /// Class shows the main logic of editing password.
        /// </summary>
        private class Edit : Symbols
        {
            private KeyValuePair<string, string> editPassword;
            private Data data;
            private ListBox user_ListBox;
            private AuthForm authForm;
            bool admin;

            public Edit(Data data, ListBox user_ListBox, bool admin, AuthForm authForm)
            {
                editPassword = new KeyValuePair<string, string>();
                this.data = data;
                this.admin = admin;
                this.user_ListBox = user_ListBox;
                this.authForm = authForm;

            }

            /// <summary>
            /// Method edits password and checks the role of user for it.
            /// </summary>
            /// <param name="newPassword"></param>
            public void edit(string newPassword)
            {
                int index = 0;
                foreach (KeyValuePair<string, string> pair in data.getLoginPassword())
                {
                    index = user_ListBox.Items.IndexOf(pair.Key);
                    if (user_ListBox.SelectedIndex == index)
                    {
                        if (admin)
                        {
                            editPassword = pair;
                        }
                        else
                        {
                            if (authForm.getCurLoginPassword().Key.Equals(pair.Key))
                            {
                                editPassword = pair;
                            }
                            else
                            {
                                MessageBox.Show("You can change password only for your own account.");
                            }
                        }
                        
                    }
                }
                if (editPassword.Key != null)
                {
                    data.getLoginPassword()[editPassword.Key] = newPassword.Trim(Symbols.SYMBOLS);
                    data.rewriteLoginPassword();
                }
            }
        }
        private Data data;
        private AuthForm authForm;
        private Edit edit;
        /// <summary>
        /// User's role.
        /// </summary>
        private bool admin;
        /// <summary>
        /// New password which get's by TextBox.
        /// </summary>
        private string newPassword;

        public EditPasswordForm(Data data, bool admin, AuthForm authForm)
        {
            InitializeComponent();
            this.data = data;
            this.admin = admin;
            this.authForm = authForm;
            edit = new Edit(data, user_ListBox, admin, authForm);
        }

        private void EditPasswordForm_Load(object sender, EventArgs e)
        {
            setListBox();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            newPassword = newPassword_textBox.Text;
            edit.edit(newPassword);
            this.Close();
        }

        /// <summary>
        /// Method fill's the ListBox with active users.
        /// </summary>
        public void setListBox()
        {
            user_ListBox.Items.Clear();
            foreach (KeyValuePair<string, string> pair in data.getLoginPassword())
            {
                user_ListBox.Items.Add(pair.Key);
            }
        }

        private void newPassword_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            newPassword_textBox.Clear();
        }
    }
}
