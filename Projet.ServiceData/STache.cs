using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;

namespace Projet.ServiceData
{
    public class STache
    {
        DataSetTableAdapters.TacheTableAdapter MyAdapter = new DataSetTableAdapters.TacheTableAdapter();

        public List<SBTache> GetTaches()
        {
            List<SBTache> LesTaches = new List<SBTache>();

            foreach (DataSet.TacheRow Ta in MyAdapter.GetData())
            {
                LesTaches.Add(new SBTache(Ta.Id, Ta.Nom, Ta.Description, Ta.Responsable, Ta.Jalon, Ta.Jour, Ta.Precedente, Ta.Etat, Ta.DatePrevu, Ta.Debut));
            }

            return LesTaches;
        }

        public SBTache GetById(int id)
        {
            SBTache T = null;

            foreach (DataSet.TacheRow Ta in MyAdapter.GetById(id))
            {
                T = new SBTache(Ta.Id,Ta.Nom,Ta.Description,Ta.Responsable,Ta.Jalon,Ta.Jour,Ta.Precedente,Ta.Etat,Ta.DatePrevu,Ta.Debut);
            }

            return T;
        }

        public void InsertTache(SBTache T)
        {

            MyAdapter.InsertTache(T.Nom,T.Description,T.Responsable,T.Jalon,T.NbJour,T.TachePrecedente,T.Etat,T.DatePrevu,T.DateReelle);

        }

        public void UpdateTache(SBTache T)
        {
            MyAdapter.UpdateTache(T.Nom,T.Description,T.Responsable,T.Jalon,T.NbJour,T.TachePrecedente,T.Etat,T.DatePrevu,T.DateReelle,T.Id);
        }

        public void DeleteTache(int id)
        {
            MyAdapter.DeleteTache(id);
        }
    }
}
