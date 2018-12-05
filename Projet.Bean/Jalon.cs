using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    class Jalon
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public DateTime DatePrevu { get; set; }

        public Jalon(int id, string label, DateTime datePrevu)
        {
            Id = id;
            Label = label;
            DatePrevu = datePrevu;
        }

        public Jalon(string label, DateTime datePrevu)
        {
            Label = label;
            DatePrevu = datePrevu;
        }
    }
}
