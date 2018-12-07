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

            this.Tag = projet.Id;

            LabelIdPrj.Text = projet.Id;
            LabelNomPrj.Text = projet.Nom;
            LabelRespProjet.Text = SFactory.GetServiceResponsable().GetById(projet.Responsable).Trigramme;
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

        private void BtnModifProjet_Click(object sender, EventArgs e)
        {
            ModifProjet Modif = new ModifProjet();
            Modif.StartPosition = this.StartPosition;
            Modif.ShowDialog(this);
        }

        private void BtnDeleteProjet_Click(object sender, EventArgs e)
        {
            DeleteProjet delete = new DeleteProjet();
            delete.StartPosition = this.StartPosition;
            delete.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabExigence":
                    if (this.Tag != null)
                    {
                        List<SBExigences> LesExigence = SFactory.GetServiceExigence().GetExigencesByProjet(this.Tag.ToString());

                        SourceExigence.DataSource = LesExigence;
                        GridExigence.DataSource = SourceExigence;
                    }

                break;

                case "tabJalon":

                    if (this.Tag != null) { 
                        List<SBJalon> LesJalons = SFactory.GetServiceJalon().GetJalons();

                        SourceJalon.DataSource = LesJalons;
                        GridJalon.DataSource = SourceJalon;
                    }
            break;

                case "tabTache":

                    if (this.Tag != null) { 
                        List<SBTache> LesTache = SFactory.GetServiceTache().GetTaches();

                        SourceTache.DataSource = LesTache;
                        GridTache.DataSource = SourceTache;
                     }   
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddExigence Add = new AddExigence();
            Add.StartPosition = this.StartPosition;
            Add.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddJalon Add = new AddJalon();
            Add.StartPosition = this.StartPosition;
            Add.ShowDialog(this);
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment supprimer cette exigence ?";
            string caption = "Suppression";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                SFactory.GetServiceExigence().DeleteExigence( (GridExigence.CurrentRow.DataBoundItem as SBExigences).Id );

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTache Add = new AddTache();
            Add.StartPosition = this.StartPosition;
            Add.ShowDialog(this);
        }
    }
}
