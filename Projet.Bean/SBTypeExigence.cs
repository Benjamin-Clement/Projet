using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    public class SBTypeExigence
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public SBTypeExigence(int id, string label)
        {
            Id = id;
            Label = label;
        }

        public SBTypeExigence(string label)
        {
            Label = label;
        }

    }
}
