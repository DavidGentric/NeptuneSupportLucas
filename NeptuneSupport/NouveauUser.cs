using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace NeptuneSupport
{
    public partial class NouveauUser : Form
    {
        private List<string> lesTritons = new List<string>();
        private int nbT = 2;  //nb de TRITON en OU dans AD            -!-MODIFIER EN FONCTION DU NB DE TRITON DANS AD-!-
        private List<string> lesSousOU = new List<string>();
        private List<string> lesGpAd = new List<string>();
        private User usr;
        
        internal User Usr { get => usr; set => usr = value; }

        public NouveauUser()
        {
            InitializeComponent();
        }

        private void NouveauUser_Load(object sender, EventArgs e)  //chargement de page
        {
            gbInfos.Visible = false;  //cache infos tant que OU pas choisie

            int i = 0;
            while (i < nbT)  //listage des x TRITON (x = nbT)
            {
                i++;
                lesTritons.Add("TRITON" + i.ToString());
            }

            foreach (string T in lesTritons) cbTriton.Items.Add(T);  //remplissage comboBox TRITON
        }

        private void cbTriton_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbInfos.Visible = true;

            DirectoryEntry Ldap = new DirectoryEntry("LDAP://TRITON/" + cbTriton.Text, "david", "Dv7gN@FU4");  //connexion AD
            DirectorySearcher src = new DirectorySearcher(Ldap);
            src.Filter = "(objectCategory=organizationalUnit)";
            try
            {
                foreach (SearchResult result in src.FindAll())  //recherche des sous-OU du TRITON séléctionné
                {
                    DirectoryEntry DirEntry = result.GetDirectoryEntry();
                    lesSousOU.Add(DirEntry.Name);  //listage sous-OU           
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }

            foreach (string S in lesSousOU) cbOU.Items.Add(S);  //remplissage comboBox sous-OU
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (tbPrenom.Text != "" && tbNom.Text != "" && tbLogin.Text != "" && tbMdp.Text != "" /*&& cbOU.Text != ""*/)
            {
                Usr = new User(tbNom.Text, tbPrenom.Text, tbLogin.Text, tbMdp.Text, "", lesGpAd);
                Close();
            }
            else MessageBox.Show("Vérifier que tous les champs soient bien remplis !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        Random rand = new Random();
        private void btnGenerer_Click(object sender, EventArgs e)  //génération mdp
        {
            char[] min = "abcdefghijkmnopqrstuvwxyz".ToCharArray();
            char[] maj = "ABCDEFGHJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] chf= "0123456789".ToCharArray();
            var str = new char[8];

            for (int i = 0; i < 3; i++) str[i] = maj[rand.Next(maj.Length)];
            for (int i = 3; i < 6; i++) str[i] = min[rand.Next(min.Length)];
            for (int i = 6; i < 8; i++) str[i] = chf[rand.Next(chf.Length)];
            str = str.OrderBy(x => rand.Next()).ToArray();  //mélange caractères

            tbMdp.Text = new string(str);
        }

        private void GpeAD_Check()
        {
            if (checkClients.Checked == true) lesGpAd.Add(checkClients.Text);
            if (checkNEPTUNE.Checked == true) lesGpAd.Add(checkNEPTUNE.Text);
            if (checkPF.Checked == true) lesGpAd.Add(checkPF.Text);
            if (checkUtilRDP.Checked == true) lesGpAd.Add(checkUtilRDP.Text);
            if (checkUtilDomaine.Checked == true) lesGpAd.Add(checkUtilDomaine.Text);
        }
    }
}