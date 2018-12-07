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
    public partial class AddJalon : Form
    {
        public AddJalon()
        {
            InitializeComponent();
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

        private void AddJalon_Load(object sender, EventArgs e)
        {
            ResponsableProjet.DisplayMember = "display";
            ResponsableProjet.ValueMember = "value";

            foreach (Bean.SBResponsable Res in SFactory.GetServiceResponsable().GetResponsables())
            {
                ResponsableProjet.Items.Add(new { display = Res.Trigramme, value = Res.Id });
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            DateTime LaDate = new DateTime(CalendarJalon.SelectionRange.Start.Year, CalendarJalon.SelectionRange.Start.Month, CalendarJalon.SelectionRange.Start.Day);

            if (TextBoxResponsable.Text != "")
            {
                int identifiant = SFactory.GetServiceResponsable().AddResposable(TextBoxResponsable.Text);
                SFactory.GetServiceJalon().AddJalon(TextboxLabel.Text,LaDate, identifiant);
            }
            else
            {
                SFactory.GetServiceJalon().AddJalon(TextboxLabel.Text, LaDate, (ResponsableProjet.SelectedItem as dynamic).value);
            }
            
        }
    }
}
