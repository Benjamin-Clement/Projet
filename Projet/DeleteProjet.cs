using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet.Service;

namespace Projet
{
    public partial class DeleteProjet : Form
    {
        public DeleteProjet()
        {
            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            SFactory.GetServiceProjet().DeleteProjet(this.Owner.Tag.ToString());
            this.Close();
        }
    }
}
