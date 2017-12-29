using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NeptuneSupport
{
    class User
    {
        private string nom, prenom, login, mdp, alias, sid;
        private List<string> lesGpAD = new List<string>();

        #region Accesseurs
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Alias { get => alias; set => alias = value; }
        public string Sid { get => sid; set => sid = value; }
        public List<string> LesGpAD { get => lesGpAD; set => lesGpAD = value; }
        #endregion

        public User(string n, string p, string l, string m, string a, List<string>lesG)  //constructeur
        {
            Nom = n;
            Prenom = p;
            Login = l;
            Mdp = m;
            Alias = a;
            LesGpAD = lesG;
        }

        public User(string l, string m)
        {
            Login = l;
            Mdp = m;
        }

        private string GetSidUsername()  //méthode récup sid d'un user
        {
            NTAccount ntAcc = new NTAccount(login);
            return ntAcc.Translate(typeof(SecurityIdentifier)).Value;
        }
    }
}
