using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    public class SBJalon
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public DateTime DatePrevu { get; set; }
        public int Responsable { get; set; }
        public DateTime DateReelle { get; set; }

        public SBJalon(int id, string label, DateTime datePrevu,int responsable,DateTime livraison)
        {
            Id = id;
            Label = label;
            DatePrevu = datePrevu;
            Responsable = responsable;
            DateReelle = livraison;
        }

        public SBJalon(int id, string label, DateTime datePrevu, int responsable)
        {
            Id = id;
            Label = label;
            DatePrevu = datePrevu;
            Responsable = responsable;
        }

        public SBJalon(string label, DateTime datePrevu,int responsable,DateTime livraison)
        {
            Label = label;
            DatePrevu = datePrevu;
            Responsable = responsable;
            DateReelle = livraison;
        }

        public SBJalon(string label, DateTime datePrevu, int responsable)
        {
            Label = label;
            DatePrevu = datePrevu;
            Responsable = responsable;
        }

    }
}
