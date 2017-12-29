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
    public partial class ChoixVierge : Form
    {
        List<string> lesBdd = new List<string>();
        private string bdd;

        public string Bdd { get => bdd; set => bdd = value; }

        public ChoixVierge()
        {
            InitializeComponent();
        }

        private void ChoixVierge_Load(object sender, EventArgs e)
        {
            //ajout bdd (.fbk)          -!-AJOUT A LA MAIN-!-
            lesBdd.Add("neptune_vierge.fbk");
            lesBdd.Add("NEPTUNE_VIERGE_LCF.fbk");

            //chargement ComboBox avec bases vierges
            foreach (string bdd in lesBdd) cbNomFBK.Items.Add(bdd);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Bdd = cbNomFBK.Text;
            if (cbNomFBK.SelectedIndex != -1)
            {
                Bdd = cbNomFBK.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Choisir une base vierge !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}