using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    class Exigences
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Fonctionnel { get; set; }
        public int type { get; set; }
        public int Projet {get;set;}

        public Exigences(int id, string label, int fonctionnel, int type, int projet)
        {
            Id = id;
            Label = label;
            Fonctionnel = fonctionnel;
            this.type = type;
            Projet = projet;
        }
    }
}
