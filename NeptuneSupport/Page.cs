using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Security.Principal;
using System.DirectoryServices;
using System.Diagnostics;
using Microsoft.Win32;

namespace NeptuneSupport
{
    public partial class Page : Form
    {
        string user = Environment.UserName;  //variable obtention nom de session (%user%)
        
        public Page()
        {
            InitializeComponent();
        }
        
        private void dlFTPFile(string source, string destination)  //méthode de dl de fichier sur le FTP
        {
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(source);
            req.Method = WebRequestMethods.Ftp.DownloadFile;
            try
            {
                req.Credentials = new NetworkCredential("support", "Npvz355");  //(login ftp, mdp ftp)
            }
            catch(Exception ex)
            {
                MessageBox.Show("erreur NetworkCredential : " + ex.Message);
            }
            req.UseBinary = true;

            try
            {
                using (FtpWebResponse rep = (FtpWebResponse)req.GetResponse())
                {
                    using (Stream s = rep.GetResponseStream())
                    {
                        using (FileStream fs = new FileStream(destination, FileMode.Create))
                        {
                            byte[] buffer = new byte[2048];
                            int bytesRead = s.Read(buffer, 0, buffer.Length);

                            while (bytesRead > 0)
                            {
                                fs.Write(buffer, 0, bytesRead);
                                bytesRead = s.Read(buffer, 0, buffer.Length);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("erreur sur dl : " + ex.Message);
            }
        }

        private void Dezip(string source, string destination)  //méthode pour dézipper une archive
        {
            try
            {
                ZipFile.ExtractToDirectory(source, destination);
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur sur : " + ex.Message);
            }
        }

        private void Execute(string exe)  //méthode pour lancer un programme
        {
            try
            {
                var process = Process.Start(exe);
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
        }

        private void CopyFile(string source, string destination)  //méthode de copie de fichier
        {
            try
            {
                if (File.Exists(destination)) File.Delete(destination);  //verif si fichier déjà présent => suppression si oui
                File.Move(source, destination);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur la copie de" + source + " vers " + destination + " : " + ex.Message);
            }
        }

        private string GetAlias()  //méthode récup de l'alias
        {
            string alias = "";
            try
            {
                using (var form = new ChoixAlias())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK) alias = form.Alias;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
            return alias;
        }

        private int GetNbUsers()  //méthode récup nb users à créer
        {
            int nbUsers = 0;
            try
            {
                using (var form = new PopupNbUsers())  //demande nb users à créer
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK) nbUsers = form.NbUsers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur sur : " + ex.Message);
            }
            return nbUsers;
        }
        
        public string GetSidUsername(string username)  //méthode de récup du sid d'un user
        {
            try
            {
                NTAccount ntAcc = new NTAccount(username);
                string objectsid = ntAcc.Translate(typeof(SecurityIdentifier)).Value;
                return objectsid;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
                return "";
            }
        }

        private void registre(string cle, string nom, string val)  //clé : chemin depuis "HKU\"
        {
            try
            {
                RegistryKey key = Registry.Users.CreateSubKey(cle);
                key.OpenSubKey(cle, true);
                key.SetValue(nom, val);
                key.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
        }

        private void CreationRegistre(string alias, string usr)  //toutes les clés de registre utiles
        {
            string sid = GetSidUsername(usr);
            try
            {
                tbRetour.AppendText("Création des clés de registre ... \r\n");
                registre(sid + @"\SOFTWARE\Microtec Informatique", "", "");
                registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "", "");
                registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "Database", "localhost:" + alias);
                registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "Banette", @"C:\Users\" + usr + @"\Desktop\Banette");
                registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "HelpDesk", @"C:\Users\Public\Microtec\TeamViewerSQ_fr-idc527tavp.exe");
                registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "CustomDossierShrink",@"Non");
                registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "Agence", @"A");
                if (MessageBox.Show("Voulez-vous créer la clé de registre pour AltoPath (client non UDIF) ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    registre(sid + @"\SOFTWARE\Microtec Informatique\Neptune", "AltoPath", @"C:\Users\" + usr + @"\ALTO_FAPE\ALTO.exe");
                registre(sid + @"\SOFTWARE\Control Panel\International", "sDecimal", ".");
                registre(sid + @"\SOFTWARE\Control Panel\International", "sMonDecimalStep", ".");
                tbRetour.AppendText("Clés de registre crées \r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
        }

        private void CreationDossier(string usr)  //tous les répertoires utiles
        {
            try
            {
                try
                {
                    if (Directory.Exists(@"C:\Users\" + usr + @"\Desktop\Banette")) throw new DirectoryNotFoundException();
                    else
                    {
                        Directory.CreateDirectory(@"C:\Users\" + usr + @"\Desktop\Banette");
                        tbRetour.AppendText("Répertoire 'Banette' créé \r\n");
                    }
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show("Le répertoire existe sans doute déjà : " + ex);
                }

                try
                {
                    if (Directory.Exists(@"C:\Microtec")) throw new DirectoryNotFoundException();
                    else
                    {
                        Directory.CreateDirectory(@"C:\Microtec");
                        tbRetour.AppendText("Répertoire 'Microtec' créé \r\n");
                    }
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show("Le répertoire existe sans doute déjà : " + ex);
                }
                
                try
                {
                    if (Directory.Exists(@"C:\Microtec\Neptune")) throw new DirectoryNotFoundException();
                    else
                    {
                        Directory.CreateDirectory(@"C:\Microtec\Neptune");
                        tbRetour.AppendText("Répertoire 'Microtec\\Neptune' créé \r\n");
                    }
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show("Le répertoire existe sans doute déjà : " + ex);
                }

                try
                {
                    CopyFile(@".\Install\neptune.exe", @"C:\Microtec\Neptune\neptune.exe");
                    tbRetour.AppendText("Fichier 'neptune.exe' copié dans 'Microtec\\Neptune' \r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Le neptune.exe est sans doute déjà dans le répertoire 'Microtec\\Neptune' : " + ex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
        }

        private void InitBDD(string alias)  //initialisation de la bdd vierge
        {
            try
            {
                tbRetour.AppendText("Initialisation de la base vierge ... \r\n");
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = "/K \"C:\\Program Files\\Firebird\\Firebird_2_5\\bin\\gbak.exe\" -C -V -user SYSDBA -password 2309Fire C:\\Users\\" + user + "\\Desktop\\Install\\neptune_vierge.fbk localhost:" + alias;
                Process p = Process.Start(psi);
                p.WaitForExit();
                tbRetour.AppendText("Initialisation effectuée \r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur sur : " + ex.Message);
            }
        }

        private void CreationUniteOrgAD()  //méthode création OU dans AD
        {
            string nom = "";
            try
            {
                using (var form = new NouvelleOU())  //récup nom depuis popupOU
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        nom = form.Nom;

                        using (DirectoryEntry Ldap = new DirectoryEntry("LDAP://TRITON", "david", "Dv7gN@FU4"))  //connexion AD
                        {
                            DirectorySearcher src = new DirectorySearcher(Ldap);
                            src.Filter = "OU=" + nom;
                            src.SearchScope = SearchScope.Subtree;
                            SearchResult srcOU = src.FindOne();
                            if (srcOU == null)  //si non existant, nouvelle OU sera créée
                            {
                                DirectoryEntry OU = Ldap.Children.Add("OU=" + nom, nom);
                                //protéger contre suppr accidentelle !!
                                OU.CommitChanges();
                                tbRetour.AppendText("Nouvelle OU créée : " + nom);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur sur : " + ex.Message);
            }
        }

        private void CreationClientAD(User U, string triton, string nom)  //méthode création client (CN) dans AD
        {
            DirectoryEntry Ldap = new DirectoryEntry("LDAP://TRITON,OU=" + triton + ",OU=" + nom, "david", "Dv7gN@FU4");  //connexon AD
            try
            {
                //création user et init ses propriétés
                DirectoryEntry user = Ldap.Children.Add("cn=" + U.Prenom + " " + U.Nom, "user");  //CN = Common Name
                user.Properties["SamAccountName"].Add(U.Login);  //login
                user.Properties["Surname"].Add(U.Nom);  //nom
                user.Properties["GivenName"].Add(U.Prenom);  //prénom
                user.Properties["Sid"].Add(GetSidUsername(U.Login));  //sid
                user.CommitChanges();

                //définition mdp et activation compte
                user.Invoke("SetPassword", new object[] { U.Mdp });
                user.Properties["UserAccountControl"].Value = 0x0200;
                user.Properties["PasswordNeverExpires"].Add(false);  //mdp n'expire jamais
                user.Properties["UserCannotChangePassword"].Add(false);  //utilisateur ne peut pas changer mdp
                user.CommitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur sur : " + ex.Message);
            }
        }

        private void RDP(string srv, string login, string pswd)  //méthode connexion bureau à distance
        {
            bool check = true;
            try
            {
                //ouverture fenêtre RDP & demande si on veut ouvrir une autre session (cas des acquisitions par ex.)
                while (check == true)
                {
                    var form = new ConnexionRdp(srv, login, pswd);
                    form.ShowDialog();
                    var result = MessageBox.Show("Ouvrir une autre session RDP", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) check = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
        }

        private List<User> ListageAD()  //méthode listage user sur TRITON en fonction OU spécifié
        {
            List<User> lesU = new List<User>();
            string triton = "";
            string nom = "";
             
            using(var form = new ChoixOU())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    triton = form.Triton;
                    nom = form.Nom;

                    using (DirectoryEntry Ldap = new DirectoryEntry("LDAP://OU=TRITON,OU=" + triton + ",OU=" + nom, "david", "Dv7gN@FU4"))
                    {
                        DirectorySearcher src = new DirectorySearcher(Ldap);
                        src.Filter = "(objectClass=user)";
                        src.SearchScope = SearchScope.Subtree;
                        foreach (SearchResult srcResult in src.FindAll())
                        {
                            DirectoryEntry dirEntry = srcResult.GetDirectoryEntry();
                            lesU.Add(new User(dirEntry.Properties["SAMAccountName"].ToString(), dirEntry.Properties["Paswword"].ToString()));
                        }
                    }
                }
                return lesU;
            }
        }

        private void VerifInstall()  //Création dossier Install
        {
            if (!Directory.Exists(@".\Install\")) Directory.CreateDirectory(@".\Install\");
        }

        private void telechargementFichiersToolStripMenuItem_Click(object sender, EventArgs e)  //dl des fichiers
        {
            tbRetour.Clear();  //remise à blanc
            VerifInstall();
            progressBarPrincipale.Value = 0;
            progressBarPrincipale.Maximum = 12;
            progressBarPrincipale.Step = 1;

            //récup des fichiers/dossiers nécessaires
            tbRetour.AppendText("Téléchargement de neptune.exe ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/neptune.exe", @".\Install\neptune.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("neptune.exe téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de ibexpert.zip ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/ibexpert.zip", @".\Install\ibexpert.zip");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("ibexpert.zip téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de Firebird ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/Firebird.exe", @".\Install\Firebird.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("Firebird téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de TeamViwer ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/support/TeamViewerQS_fr-idc527tavp.exe", @".\Install\TeamViewerQS_fr-dc527tavp.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("TeamViewer téléchargé \r\n");

            //choix de la base vierge
            string bdd = "";
            try
            {
                using (var form = new ChoixVierge())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK) bdd = form.Bdd;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }
            tbRetour.AppendText("Téléchargement de " + bdd + " ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/" + bdd, @".\Install\" + bdd);
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText(bdd + " téléchargé \r\n");

            //récup fichiers/dossiers caisse
            tbRetour.AppendText("Téléchargement de firmware.zip ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/install/firmware_ht_630_1_01_1.zip", @".\Install\firmware_ht_630_1_01_1.zip");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("firmware.zip téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de neptune_pdv.exe ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/neptune_pdv.exe", @".\Install\neptune_pdv.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("neptune_pdv.exe téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de Opos.exe ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/install/Opos.exe", @".\Install\Opos.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("Opos.exe téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de Replicator.exe ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/install/Replicator.exe", @".\Install\Replicator.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("Replicator.exe téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de replicator.ini ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/install/replicator.ini", @".\Install\replicator.ini");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("replicator.ini téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de ADK280ER8.exe ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/install/ADK280ER8.exe", @".\Install\ADK280ER8.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("ADK280ER8.exe téléchargé \r\n");
            tbRetour.AppendText("Téléchargement de TMVirtualPort.exe ... \r\n");
            dlFTPFile("ftp://neptune-funerair@neptune-funeraire.fr/httpdocs/dl/install/TMVirtualPortDriver840a.exe", @".\Install\TMVirtualPortDriver840a.exe");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("TMVirtualPort.exe téléchargé \r\n");
            if(!Directory.Exists(@"C:\Users\Public\Microtec")) Directory.CreateDirectory(@"C:\Users\Public\Microtec");
            CopyFile(@".\Install\TMVirtualPortDriver840a.exe", @"C:\Users\Public\Microtec\TeamViewerSQ_fr-idc527tavp.exe");

            //dézippage IBExpert
            tbRetour.AppendText("Décompression de ibexpert.zip ... \r\n");
            Dezip(@".\Install\ibexpert.zip", @".\Install\ibexpert");
            progressBarPrincipale.PerformStep();
            tbRetour.AppendText("ibexpert.zip décompressé \r\n");

            MessageBox.Show("Téléchargement des fichiers principaux terminé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbRetour.Clear();
        }

        private void installationServeurToolStripMenuItem_Click(object sender, EventArgs e)  //acquisition : serveur
        {
            tbRetour.Clear();  //remise à blanc
            progressBarPrincipale.Value = 0;
            progressBarPrincipale.Maximum = 8;
            progressBarPrincipale.Step = 1;

            string alias = GetAlias();

            //installation IBExpert
            Execute(@".\Install\ibexpert\setup_customer_2011-12-01.exe");
            progressBarPrincipale.PerformStep();
            CopyFile(@".\Install\ibexpert\ibexpert.lic", @"C:\Program Files (x86)\HK-Software\IBExpert\ibexpert.lic");
            progressBarPrincipale.PerformStep();

            //installation Firebird
            Execute(@".\Install\Firebird.exe");
            progressBarPrincipale.PerformStep();
            using (StreamWriter sw1 = File.AppendText(@"C:\Program Files\Firebird\Firebird_2_5\aliases.conf")) sw1.WriteLine("\r\n" + alias + @" = C:\Datas\" + alias + ".FDB");  //ajout alias dans aliases.conf
            progressBarPrincipale.PerformStep();
            using (StreamWriter sw2 = File.AppendText(@"C:\Program Files\Firebird\Firebird_2_5\firebird.conf")) sw2.WriteLine("\r\nRemoteServicePort = 3051");  //ajout port dans firebird.conf
            progressBarPrincipale.PerformStep();

            //config mdp admin Firebird
            MessageBox.Show("Config mdp Firebird");
            try
            {
                tbRetour.AppendText("Changement du mot de passe Admin de Firebird");
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.Arguments = "/K \"C:\\Program Files\\Firebird\\Firebird_2_5\\bin\\gsec.exe \" -user sysdba -pas masterke -modify sysdba -pw 2309Fire";
                Process p = Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sur : " + ex.Message);
            }

            //création dossiers
            CreationDossier(user);
            progressBarPrincipale.PerformStep();
            
            //création clés registre
            CreationRegistre(alias, user);
            progressBarPrincipale.PerformStep();

            //init bdd vierge
            InitBDD(alias);
            progressBarPrincipale.PerformStep();

            //licence Neptune
            //Execute(@"C:\Microtec\Neptune\Install\CleNeptune.exe");

            MessageBox.Show("Y-a-t-il une réplication avec une caisse ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                CopyFile(@".\Install\Replicator.exe", @"C:\Microtec\Neptune");
                CopyFile(@".\Install\replicator.ini", @"C:\Microtec\Neptune");
            }

            MessageBox.Show("Installation 'Acquisition - Serveur' terminée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbRetour.Clear();
        }

        private void installationToolStripMenuItem_Click(object sender, EventArgs e)  //installation en hébergement
        {
            tbRetour.Clear();  //remise à blanc

            string alias = GetAlias();

            //config alias Firebird
            Execute(@".\Install\Firebird.exe");
            using (StreamWriter sw1 = File.AppendText(@"C:\Program Files\Firebird\Firebird_2_5\aliases.conf")) sw1.WriteLine("\r\n" + alias + @" = C:\Datas\" + alias + ".FDB");  //ajout alias dans aliases.conf

            //création OU
            CreationUniteOrgAD();
        }

        private void ajoutDutilisateurToolStripMenuItem_Click(object sender, EventArgs e)  //ajout user hébergement
        {
            tbRetour.Clear();  //remise à blanc

            List<User> lesUsers = new List<User>();
            int nbUsers = GetNbUsers();
            string alias = GetAlias();

            int i = 0;
            while (i < nbUsers)  //création des x users (x = nbUsers)
            {
                using (var form = new NouveauUser())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK) lesUsers.Add(form.Usr);
                    lesUsers[i].Alias = alias;
                    i++;
                    tbRetour.AppendText("Utilisateur n°" + i + "/" + nbUsers + " créé \r\n");
                }
            }

            //choix OU et sous-OU pour les users à créer
            string triton = "";
            string nom = "";
            using (var form = new ChoixOU())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    triton = form.Triton;
                    nom = form.Nom;
                }
            }

            //création de ces x users dans AD
            foreach (User u in lesUsers)
            {
                CreationClientAD(u, triton, nom);
                CreationDossier(u.Login);
                CreationRegistre(alias, u.Login);
                //licence Neptune
            }
        }
        
        private void caisseToolStripMenuItem_Click(object sender, EventArgs e)  //caisse (acquisition)
        {
            tbRetour.Clear();  //remise à blanc
            progressBarPrincipale.Value = 0;
            progressBarPrincipale.Maximum = 0;
            progressBarPrincipale.Step = 1;

            VerifInstall();

            installationServeurToolStripMenuItem_Click(sender, e);

            Execute(@".\Install\Opos.exe");

            CopyFile(@".\Install\neptune_pdv.exe", @"C:\Microtec\Neptune\neptune_pdv.exe");

            MessageBox.Show("Installation 'Caisse' terminée", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void caisseToolStripMenuItem1_Click(object sender, EventArgs e)  //caisse (hébergement)
        {
            caisseToolStripMenuItem_Click(sender, e);  //pointe sur même event que "caisse (acquisition)"
        }

        private void Page_Load(object sender, EventArgs e)
        {
            labelUser.Text = user;
        }

        private void installationClientLourdToolStripMenuItem_Click(object sender, EventArgs e)  //installation en acquisition : client lourd
        {
            tbRetour.Clear();  //remise à blanc
            string alias = GetAlias();

            foreach (User u in ListageAD())
            {
                CreationDossier(u.Login);  //neptune.exe copié dans cette méthode, pas besoin CopyFile()
                CreationRegistre(alias, u.Login);  //récup sid grâce au Login de l'utilisateur u
            }

            MessageBox.Show("Installation 'Acquisition - Client lourd' terminée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbRetour.Clear();
        }

        private void installationClientTSEToolStripMenuItem_Click(object sender, EventArgs e)  //installation en acquisition : client TSE
        {
            tbRetour.Clear();  //remise à blanc
            string alias = GetAlias();

            foreach (User u in ListageAD())
            {
                RDP("", u.Login, u.Mdp);  //voir cmt se connecter : demander mdp ou récup depuis (class)user ?
                CreationDossier(u.Login);  //neptune.exe copié dans cette méthode, pas besoin CopyFile()
                CreationRegistre(alias, u.Login);  //récup sid grâce au Login de l'utilisateur u
            }

            MessageBox.Show("Installation 'Acquisition - Client TSE' terminée !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbRetour.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}