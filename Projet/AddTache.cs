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
    public partial class AddTache : Form
    {
        public AddTache()
        {
            InitializeComponent();
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

        private void AddProjet_Load(object sender, EventArgs e)
        {
            ResponsableProjet.DisplayMember = "display";
            ResponsableProjet.ValueMember = "value";

            foreach (Bean.SBResponsable Res in SFactory.GetServiceResponsable().GetResponsables())
            {
                ResponsableProjet.Items.Add(new { display = Res.Trigramme, value = Res.Id });
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {

            DateTime LaDate = new DateTime(CalendarProject.SelectionRange.Start.Year, CalendarProject.SelectionRange.Start.Month, CalendarProject.SelectionRange.Start.Day);

            if (TextBoxResponsable.Text != "")
            {
                int identifiant = SFactory.GetServiceResponsable().AddResposable(TextBoxResponsable.Text);
                SFactory.GetServiceTache().AddTache(TextboxLabel.Text, richTextBox1.Text, -1, (comboBox1.SelectedItem as dynamic).value, Convert.ToInt32(numericUpDown1.Value), (comboBox2.SelectedItem as dynamic).value, 0, LaDate);
            } 
            else
            {
                SFactory.GetServiceTache().AddTache(TextboxLabel.Text, richTextBox1.Text, (ResponsableProjet.SelectedItem as dynamic).value, (comboBox1.SelectedItem as dynamic).value, Convert.ToInt32(numericUpDown1.Value), (comboBox2.SelectedItem as dynamic).value, 0, LaDate);
                
            }


            this.Close();
        }

        private void AddTache_Load(object sender, EventArgs e)
        {
            ResponsableProjet.DisplayMember = "display";
            ResponsableProjet.ValueMember = "value";

            foreach (Bean.SBResponsable Res in SFactory.GetServiceResponsable().GetResponsables())
            {
                ResponsableProjet.Items.Add(new { display = Res.Trigramme, value = Res.Id });
            }


        }
    }
}
