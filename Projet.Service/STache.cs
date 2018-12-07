using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;
using Projet.ServiceData;

namespace Projet.Service
{
    public class STache
    {
        public List<SBTache> GetTaches()
        {
            return SDFactory.GetDataTache().GetTaches(); ;
        }

        public SBTache GetById(int id)
        {
            return SDFactory.GetDataTache().GetById(id);
        }

        public void AddTache(string nom, string description, int responsable, int jalon, int nbJour, int tachePrecedente, int etat, DateTime datePrevu)
        {
            SDFactory.GetDataTache().InsertTache(new SBTache(nom,description,responsable,jalon,nbJour,tachePrecedente,etat,datePrevu));
        }

        public void UpdateTache(int id,string nom, string description, int responsable, int jalon, int nbJour, int tachePrecedente, int etat, DateTime datePrevu, DateTime dateReelle)
        {
            SDFactory.GetDataTache().UpdateTache(new SBTache(id,nom, description, responsable, jalon, nbJour, tachePrecedente, etat, datePrevu, dateReelle));
        }

        public void DeleteTache(int id)
        {
            SDFactory.GetDataTache().DeleteTache(id);
        }
    }
}
