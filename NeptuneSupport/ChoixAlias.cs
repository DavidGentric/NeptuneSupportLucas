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
    public partial class ChoixAlias : Form
    {
        private string alias;

        public string Alias { get => alias; set => alias = value; }

        public ChoixAlias()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Alias = tbAlias.Text;
            if (tbAlias.Text != "")
            {
                Alias = tbAlias.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else MessageBox.Show("Entrer un alias !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ChoixAlias_Load(object sender, EventArgs e)
        {
            ActiveControl = tbAlias;
        }
    }
}