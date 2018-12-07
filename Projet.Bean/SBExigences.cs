using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    public class SBExigences
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Fonctionnel { get; set; }
        public int type { get; set; }
        public string Projet {get;set;}

        public SBExigences(int id, string label, int fonctionnel, int type, string projet)
        {
            Id = id;
            Label = label;
            Fonctionnel = fonctionnel;
            this.type = type;
            Projet = projet;
        }

        public SBExigences( string label, int fonctionnel, int type, string projet)
        {
            Label = label;
            Fonctionnel = fonctionnel;
            this.type = type;
            Projet = projet;
        }
    }
}
