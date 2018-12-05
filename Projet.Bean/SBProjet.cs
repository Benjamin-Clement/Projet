using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    public class SBProjet
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public int Responsable { get; set; }
        public DateTime Debut { get; set; }

        public SBProjet(string id, string nom, int responsable, DateTime debut)
        {
            Id = id;
            Nom = nom;
            Responsable = responsable;
            Debut = debut;
        }
    }
}
