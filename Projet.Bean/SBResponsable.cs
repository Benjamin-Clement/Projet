using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    public class SBResponsable
    {
        public int Id { get; set; }
        public string Trigramme { get; set; }

        public SBResponsable(int id, string tri)
        {
            Id = id;
            Trigramme = tri;
        }

        public SBResponsable(string tri)
        {
            Trigramme = tri;
        }
    }
}
