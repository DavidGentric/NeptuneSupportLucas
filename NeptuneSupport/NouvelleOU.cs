using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptuneSupport
{
    public partial class NouvelleOU : Form
    {
        private string nom, triton = "";
        private List<string> lesTritons = new List<string>();
        private int nbT = 2;  //nb de TRITON en OU dans AD            -!-MODIFIER EN FONCTION DU NB DE TRITON DANS AD-!-

        public NouvelleOU()
        {
            InitializeComponent();
        }

        #region Accesseurs
        public string Nom { get => nom; set => nom = value; }
        public string Triton { get => triton; set => triton = value; }
        #endregion
        
        private void NouvelleOU_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i < nbT)  //listage des x TRITON (x = nbT)
            {
                i++;
                lesTritons.Add("TRITON" + i.ToString());
            }

            foreach (string T in lesTritons) cbTriton.Items.Add(T);  //remplissage comboBox TRITON
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && cbTriton.Text!="")
            {
                Nom = tbNom.Text;
                Triton = cbTriton.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Entrer un nom et sélectionner une OU principale !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
