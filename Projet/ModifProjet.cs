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
    public partial class ModifProjet : Form
    {
        public ModifProjet()
        {
            InitializeComponent();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            DateTime LaDate = new DateTime(CalendarProject.SelectionRange.Start.Year, CalendarProject.SelectionRange.Start.Month, CalendarProject.SelectionRange.Start.Day);

            if (TextBoxResponsable.Text != "")
            {
                int identifiant = SFactory.GetServiceResponsable().AddResposable(TextBoxResponsable.Text);
                SFactory.GetServiceProjet().UpdateProjet(IdProjet.Text, ProjectName.Text, identifiant, LaDate);
            }
            else
            {
                SFactory.GetServiceProjet().UpdateProjet(IdProjet.Text, ProjectName.Text, (ResponsableProjet.SelectedItem as dynamic).value, LaDate);
            }

            this.Close();
        }

        private void ModifProjet_Load(object sender, EventArgs e)
        {
            ResponsableProjet.DisplayMember = "display";
            ResponsableProjet.ValueMember = "value";

            foreach (Bean.SBResponsable Res in SFactory.GetServiceResponsable().GetResponsables())
            {
                ResponsableProjet.Items.Add(new { display = Res.Trigramme, value = Res.Id });
            }

            Bean.SBProjet P = SFactory.GetServiceProjet().GetById( this.Owner.Tag.ToString() );

            IdProjet.Text = P.Id;
            ProjectName.Text = P.Nom;
            CalendarProject.SetDate(P.Debut);
            ResponsableProjet.SelectedIndex = ResponsableProjet.FindStringExact(SFactory.GetServiceResponsable().GetById(P.Responsable).Trigramme);
                

           
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddResponsable_Click(object sender, EventArgs e)
        {
            TextBoxResponsable.Visible = true;
            ResponsableProjet.Visible = false;
            AddResponsable.Visible = false;
            ReturnResponsable.Visible = true;
        }

        private void ReturnResponsable_Click(object sender, EventArgs e)
        {
            TextBoxResponsable.Visible = false;
            TextBoxResponsable.Text = "";

            ResponsableProjet.Visible = true;
            AddResponsable.Visible = true;
            ReturnResponsable.Visible = false;
        }
    }
}
