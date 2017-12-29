using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptuneSupport
{
    public partial class Licence : Form
    {
        string dParamsSP_SOC;
        DateTime dParamsSP_VALIDITE = new DateTime();
        int dParamsSP_LIC;
        string dParamsSP_CLE;
        string dParamsINVENTAIRE_CLE;
        string dParamsCOMPTA_CLE;

        public Licence()
        {
            InitializeComponent();
        }

        private void Licence_Load(object sender, EventArgs e)  //chargement de la page
        {
            //reset des infos + par défaut
            foreach(Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
                if (c is CheckBox) ((CheckBox)c).Checked = false;
            }
            tbNom.Text = "PF";
            dtpValidite.Text = "01/01/2100";
            nudNbLic.Value = 1;
        }

        private void LoadDB()
        {
            if (MessageBox.Show("Attention ! N'éxecuter que sur Triton !\r\nLecture des données de la base " + tbNom.Text + 
                "\r\nSouhaitez-vous continuer ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Modele vmodele = new Modele(tbAlias.Text);
                vmodele.ConnexionFB();  //connexion bdd

                //requête pour récup les infos
                vmodele.Query("select ...");                

                vmodele.DeconnexionFB();  //déconnexion bdd
            }
        }

        private void btnRecharger_Click(object sender, EventArgs e)
        {
            Licence_Load(sender, e);  //recharge la page
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {

        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {

        }
    }
}
