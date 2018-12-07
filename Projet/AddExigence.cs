using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet.Bean;
using Projet.Service;

namespace Projet
{
    public partial class AddExigence : Form
    {
        public AddExigence()
        {
            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxFonctionnel_CheckedChanged(object sender, EventArgs e)
        {
            if ( checkBoxFonctionnel.Checked)
            {
                label3.Visible = true;
                comboBoxType.Visible = true;
            }
            else
            {
                label3.Visible = false;
                comboBoxType.Visible = false;
            }
        }

        private void AddExigence_Load(object sender, EventArgs e)
        {
            if ( SFactory.GetServiceType().count() == 0)
            {
                SFactory.GetServiceType().AddTypeExigence("Données");
                SFactory.GetServiceType().AddTypeExigence("Performances");
                SFactory.GetServiceType().AddTypeExigence("Interfaces utilisateur");
                SFactory.GetServiceType().AddTypeExigence("Qualité");
                SFactory.GetServiceType().AddTypeExigence("Services");

            }

            comboBoxType.DisplayMember = "display";
            comboBoxType.ValueMember = "value";

            foreach (SBTypeExigence Type in SFactory.GetServiceType().GetType())
            {
                comboBoxType.Items.Add(new { display = Type.Label, value = Type.Id });
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (checkBoxFonctionnel.Checked)
            {
                SFactory.GetServiceExigence().AddExigence(TextboxLabel.Text,0, (comboBoxType.SelectedItem as dynamic).value, this.Owner.Tag.ToString());
            }
            else
            {
                SFactory.GetServiceExigence().AddExigence(TextboxLabel.Text, 1, -1, this.Owner.Tag.ToString());
            }

            this.Close();
        }
    }
}
