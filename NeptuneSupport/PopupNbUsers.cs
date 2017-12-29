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
    public partial class PopupNbUsers : Form
    {
        private int nbUsers;

        public PopupNbUsers()
        {
            InitializeComponent();
        }

        public int NbUsers { get => nbUsers; set => nbUsers = value; }

        private void btnValider_Click(object sender, EventArgs e)
        {
            NbUsers = Convert.ToInt32(numUD_nbUsers.Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PopupNbUsers_Load(object sender, EventArgs e)
        {
            ActiveControl = numUD_nbUsers;
        }
    }
}
