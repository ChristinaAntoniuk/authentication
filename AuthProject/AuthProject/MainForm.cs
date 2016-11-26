using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace AuthProject
{
    public partial class MainForm : Form
    {
        private Data data;
        private AuthForm authForm;
        private AddForm addForm;
        private DeleteForm deleteForm;
        private EditPasswordForm editPasswordForm;
        /// <summary>
        /// Indicatior for showing if users are blocked.
        /// </summary>
        private bool blocked;
        /// <summary>
        /// Indicatior for showing if current user is administrator.
        /// </summary>
        private bool admin;
        WindowsPrincipal myPrincipal;
        WindowsIdentity identity;
        AppDomain myDomain;

        public MainForm()
        {
            InitializeComponent();
            blocked = false;
            myDomain = Thread.GetDomain();
            myDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            myPrincipal = (WindowsPrincipal)Thread.CurrentPrincipal;
            identity = (WindowsIdentity)myPrincipal.Identity;
            admin = myPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
            data = new Data();
            authForm = new AuthForm(data);
            addForm = new AddForm(data);
            deleteForm = new DeleteForm(data);
            editPasswordForm = new EditPasswordForm(data, admin, authForm);
            data.setLoginPassword(); 
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            if (blocked && !admin)
            {
                MessageBox.Show("Users are blocked.");
            }
            else
            {
                authForm.ShowDialog();
                setListBox();
            }
        }

        /// <summary>
        /// Method fill's the ListBox with active users.
        /// </summary>
        public void setListBox()
        {
            int index = 0;
            user_ListBox.Items.Clear();
            foreach (KeyValuePair<string, string> pair in data.getLoginPassword())
            {
                user_ListBox.Items.Add(pair.Key);
                if (authForm.getCurLoginPassword().Key.Equals(pair.Key))
                {
                    index = user_ListBox.Items.IndexOf(pair.Key);
                    user_ListBox.SetSelected(index, true);
                }
            }
        }

        /// <summary>
        /// Method prints the main information about current windows user.
        /// </summary>
        /// <returns></returns>
        public string showInformation()
        {
            string informationBox = "Information about the current user:\n";
            informationBox += "Identification type: " + identity + "\n";
            informationBox += "Name: " + identity.Name + "\n";
            informationBox += "User?" + myPrincipal.IsInRole(WindowsBuiltInRole.User) + "\n";
            informationBox += "Admin? " + myPrincipal.IsInRole(@"BUILTIN\Administrators");
            informationBox += "\n";
            string Name = WindowsIdentity.GetCurrent().Name;
            IntPtr Token = WindowsIdentity.GetCurrent().Token;
            bool IsAuthenticated = WindowsIdentity.GetCurrent().IsAuthenticated;
            SecurityIdentifier SID = WindowsIdentity.GetCurrent().User;
            informationBox += "Name: " + Name + "\n" + "Authenticated: " + IsAuthenticated.ToString() +
                                "\n" + "SID: " + SID.ToString();
            return informationBox;
        }

        private void info_Button_Click(object sender, EventArgs e)
        {
            info_label.Text = showInformation();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm.ShowDialog();
            setListBox();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteForm.ShowDialog();
            setListBox();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            authForm.ShowDialog();
            info_label.Text = "";
            setListBox();
            if (!admin)
            {
                blockToolStripMenuItem.Enabled = false;
                addToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!blocked)
            {
                blocked = true;
                MessageBox.Show("Users are blocked.");
            }
            else
            {
                blocked = false;
                MessageBox.Show("Users are unblocked.");
            }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editPasswordForm.ShowDialog();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, info_label.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) Ch. Antoniuk\nEmail: christina_antoniuk@outlook.com");
        }
    }
}
