using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AuthProject
{
    /// <summary>
    /// Class is used for removing some pair of login and password.
    /// </summary>
    partial class DeleteForm : Form
    {
        Data data;
        /// <summary>
        /// Pair of login and password which have to be removed.
        /// </summary>
        KeyValuePair<string, string> deleteLoginPassword;

        public DeleteForm(Data data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            setListBox();
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

        /// <summary>
        /// Main logic of removing user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Button_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (KeyValuePair<string, string> pair in data.getLoginPassword())
            {
                index = user_ListBox.Items.IndexOf(pair.Key);
                if (user_ListBox.SelectedIndex == index)
                {
                    deleteLoginPassword = pair;
                }
            }
            data.getLoginPassword().Remove(deleteLoginPassword.Key);
            data.rewriteLoginPassword();
            this.Close();
        }
    }
}
