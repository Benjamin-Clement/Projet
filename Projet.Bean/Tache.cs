﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Bean
{
    class Tache
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Responsable { get; set; }
        public int NbJour { get; set; }
        public int TachePrecedente { get; set; }
        public int Etat { get; set; }
        public DateTime DatePrevu { get; set; }
        public DateTime DateReelle { get; set; }

        public Tache(int id, string nom, string description, int responsable, int nbJour, int tachePrecedente, int etat, DateTime datePrevu, DateTime dateReelle)
        {
            Id = id;
            Nom = nom;
            Description = description;
            Responsable = responsable;
            NbJour = nbJour;
            TachePrecedente = tachePrecedente;
            Etat = etat;
            DatePrevu = datePrevu;
            DateReelle = dateReelle;
        }
    }
}
