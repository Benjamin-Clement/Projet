using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.ServiceData;

namespace Projet.Service
{
    public class SProjet
    {
        public List<Bean.SBProjet> GetProjects()
        {
            return SDFactory.GetDataProjet().GetProjets();
        }

        public Bean.SBProjet GetById(string id)
        {
            return SDFactory.GetDataProjet().GetById(id);
        }

        public void AddProjet(string Id,string LeNom,int LeResponsable, DateTime LeDebut)
        {
            SDFactory.GetDataProjet().InsertProjet(new Bean.SBProjet(Id,LeNom, LeResponsable, LeDebut));
        }

        public void UpdateProjet(string Id, string LeNom, int LeResponsable, DateTime LeDebut)
        {
            SDFactory.GetDataProjet().UpdateProjet(new Bean.SBProjet(Id, LeNom, LeResponsable, LeDebut));
        }

        public void DeleteProjet(string id)
        {
            SDFactory.GetDataProjet().DeleteProjet(id);
        }
    }
}
