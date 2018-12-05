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
using Projet.Bean;

namespace Projet
{
    public partial class LesProjets : Form
    {
        public LesProjets()
        {
            InitializeComponent();

        }

        private void BtnAddProjet_Click(object sender, EventArgs e)
        {
            AddProjet Add = new AddProjet();
            Add.StartPosition = this.StartPosition ;
            Add.ShowDialog(this);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeProjets_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.projetTableAdapter.FillBy(this.databaseDataSet.Projet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void LesProjets_Load(object sender, EventArgs e)
        {
            ComboProjet.DisplayMember = "display";
            ComboProjet.ValueMember = "value";

            foreach (SBProjet P in SFactory.GetServiceProjet().GetProjects())
            {
                ComboProjet.Items.Add( new {display = P.Nom, value = P.Id } );
            }

        }

        private void ComboProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SBProjet projet = SFactory.GetServiceProjet().GetById( (ComboProjet.SelectedItem as dynamic).value );

            LabelIdPrj.Text = projet.Id;
            LabelNomPrj.Text = projet.Nom;
            LabelRespProjet.Text = projet.Responsable.ToString();
            LabelDebutPrj.Text = projet.Debut.ToShortDateString();
        }

        private void ComboProjet_DropDown(object sender, EventArgs e)
        {
            ComboProjet.Items.Clear();

            ComboProjet.DisplayMember = "display";
            ComboProjet.ValueMember = "value";

            foreach (SBProjet P in SFactory.GetServiceProjet().GetProjects())
            {
                ComboProjet.Items.Add(new { display = P.Nom, value = P.Id });
            }
        }
    }
}
