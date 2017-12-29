using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSTSCLib;
using System.Diagnostics;

namespace NeptuneSupport
{
    public partial class ConnexionRdp : Form
    {
        public ConnexionRdp(string s, string u, string m)
        {
            InitializeComponent();
            tbServeur.Text = s;
            tbUser.Text = u;
            tbMdp.Text = m;
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            try
            {
                //Vérif si connecté
                if (rdp.Connected.ToString() == "1") rdp.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de déconnexion du serveur : " + tbServeur.Text + "\r\nErreur sur : " + ex.Message);
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            try
            {   //NEPTUNE utilisateur neptune
                rdp.Server = tbServeur.Text;
                rdp.UserName = tbUser.Text;

                IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
                secured.ClearTextPassword = tbMdp.Text;
                try
                {
                    rdp.Connect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CATCH1 : Problème de connexion : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("CATCH2 : Erreur de connexion au serveur : " + tbServeur.Text + "\r\nErreur sur : " + ex.Message);
            }
        }

        private void ConnexionRdp_Load(object sender, EventArgs e)
        {

        }
    }
}