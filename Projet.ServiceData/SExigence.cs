using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;

namespace Projet.ServiceData
{
    public class SExigence
    {
        DataSetTableAdapters.ExigenceTableAdapter MyAdapter = new DataSetTableAdapters.ExigenceTableAdapter();

        public List<SBExigences> GetExigences()
        {
            List<SBExigences> LesExigences = new List<SBExigences>();

            foreach (DataSet.ExigenceRow E in MyAdapter.GetData())
            {
                LesExigences.Add(new SBExigences(E.Id, E.Label,E.Fonctionnel,E.Type,E.Projet));
            }

            return LesExigences;
        }

        public List<SBExigences> GetExigencesByProjet(string id)
        {
            List<SBExigences> LesExigences = new List<SBExigences>();

            foreach (DataSet.ExigenceRow E in MyAdapter.GetDataByProjet(id))
            {
                LesExigences.Add(new SBExigences(E.Id, E.Label, E.Fonctionnel, E.Type, E.Projet));
            }

            return LesExigences;
        }

        public SBExigences GetById(int id)
        {
            SBExigences E = null;

            foreach (DataSet.ExigenceRow Ex in MyAdapter.GetById(id))
            {
                E = new SBExigences(Ex.Id,Ex.Label,Ex.Fonctionnel,Ex.Type,Ex.Projet);
            }

            return E;
        }

        public void InsertExigence(SBExigences E)
        {

            MyAdapter.InsertExigence(E.Label,E.Fonctionnel,E.type,E.Projet);

        }

        public void UpdateExigence(SBExigences E)
        {
            MyAdapter.UpdateExigence(E.Label,E.Fonctionnel,E.type,E.Projet,E.Id);
        }

        public void DeleteExigence(int id)
        {
            MyAdapter.DeleteExigence(id);
        }
    }
}
