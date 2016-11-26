using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace AuthProject
{
    /// <summary>
    /// Class gets the active list of logins and passwords and sets it to the dictionary.
    /// </summary>
    public class Data : Symbols
    {
        /// <summary>
        /// Strings of login and password.
        /// </summary>
        private string[] firstSplit;
        /// <summary>
        /// Strings of separated login and password.
        /// </summary>
        private string[] secondSplit;
        /// <summary>
        /// The final dictionary of active users.
        /// </summary>
        Dictionary<string, string> loginPassword;
        

        public Data()
        {
            loginPassword = new Dictionary<string, string>();
        }

        /// <summary>
        /// Method reads the list of logins and passwords and puts it to the dictionary.
        /// </summary>
        public void setLoginPassword()
        {
            firstSplit = File.ReadAllText(@"E:\KPI\5\InformationSecurity\Lab5\Resourses.txt").Split('\n');
            KeyValuePair<string, string> logPas;
            foreach (string pair in firstSplit)
            {
                if (pair.Length >= 3)
                {
                    secondSplit = pair.Trim(Symbols.SYMBOLS).Split('-');
                    logPas = new KeyValuePair<string, string>(secondSplit[0].Trim(Symbols.SYMBOLS),
                                                    secondSplit[1].Trim(Symbols.SYMBOLS));

                    if (!loginPassword.Contains(logPas))
                    {
                        loginPassword.Add(logPas.Key, logPas.Value);
                    }
                }
            }
        }

        public Dictionary<string,string> getLoginPassword()
        {
            return loginPassword;
        }

        /// <summary>
        /// Method appends one line of login and password. It is used with adding new user.
        /// </summary>
        /// <param name="newLoginPassword"></param>
        public void editLoginPassword(KeyValuePair<string, string> newLoginPassword)
        {
            File.AppendAllText(@"E:\KPI\5\InformationSecurity\Lab5\Resourses.txt", Environment.NewLine +
                                                                 newLoginPassword.Key + "-" + GetHash(newLoginPassword.Value));
        }

        /// <summary>
        /// Method rewrite file with logins and passwords completely and checks if password was hashed.
        /// </summary>
        public void rewriteLoginPassword()
        {
            File.WriteAllText(@"E:\KPI\5\InformationSecurity\Lab5\Resourses.txt", "");
            foreach (KeyValuePair<string, string> pair in loginPassword)
            {
                if (pair.Value.Length >= 10)
                {
                    File.AppendAllText(@"E:\KPI\5\InformationSecurity\Lab5\Resourses.txt",
                    pair.Key + "-" + pair.Value + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(@"E:\KPI\5\InformationSecurity\Lab5\Resourses.txt",
                    pair.Key + "-" + GetHash(pair.Value) + Environment.NewLine);
                }
                
            }
        }

        /// <summary>
        /// Method creates the hashCode of some string.
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <returns></returns>
        public string GetHash(string currentPassword)
        {
            Byte[] strBytesPassword;
            Byte[] hashBytesPassword;
            string hashPassword = string.Empty;
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            strBytesPassword = Encoding.Default.GetBytes(currentPassword);
            hashBytesPassword = md5.ComputeHash(strBytesPassword);
            foreach (var item in hashBytesPassword)
            {
                hashPassword += string.Format("{0:x2}", item);
            }
            return hashPassword;
        }
    }
}
