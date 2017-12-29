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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Neptune Installer \nVeuillez vous connecter", "Neptune Support", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnConnexion_Click(object sender, EventArgs e)  //tentative de connexion
        {

        }
    }
}
