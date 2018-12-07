using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;

namespace Projet.ServiceData
{
    public class SProjet
    {
        DataSetTableAdapters.ProjetTableAdapter MyAdapter = new DataSetTableAdapters.ProjetTableAdapter();

        public List<SBProjet> GetProjets()
        {
            List<SBProjet> LesProjets = new List<SBProjet>();

            foreach (DataSet.ProjetRow P in MyAdapter.GetData())
            {
                LesProjets.Add(new SBProjet(P.Id,P.Nom, P.Responsable, P.Debut));
            }

            return LesProjets;
        }

        public SBProjet GetById(string id)
        {
            SBProjet P = null;

            foreach (DataSet.ProjetRow Prj in MyAdapter.GetById(id))
            {
                P = new SBProjet(Prj.Id, Prj.Nom, Prj.Responsable, Prj.Debut);
            }

            return P;
        }

        public void InsertProjet(SBProjet P)
        {

            MyAdapter.InsertProjet(P.Id,P.Nom, P.Responsable, P.Debut);
            
        }

        public void UpdateProjet(SBProjet P)
        {
            MyAdapter.UpdateProjet(P.Nom, P.Responsable, P.Debut, P.Id);
        }

        public void DeleteProjet(string id)
        {
            MyAdapter.DeleteProjet(id);
        }
    }
}
