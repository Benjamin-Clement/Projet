using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;
using Projet.ServiceData;

namespace Projet.Service
{
    public class SExigence
    {
        public List<SBExigences> GetExigences()
        {
            return SDFactory.GetDataExigence().GetExigences(); ;
        }

        public List<SBExigences> GetExigencesByProjet(string id)
        {
            return SDFactory.GetDataExigence().GetExigencesByProjet(id);
        }

        public SBExigences GetById(int id)
        {
            return SDFactory.GetDataExigence().GetById(id);
        }

        public void AddExigence(string label, int fonctionnel, int type, string projet)
        {
            SDFactory.GetDataExigence().InsertExigence(new SBExigences(label,fonctionnel,type,projet));
        }

        public void UpdateExigence(int Id, string label, int fonctionnel, int type, string projet)
        {
            SDFactory.GetDataExigence().UpdateExigence(new SBExigences(Id,label,fonctionnel,type,projet));
        }

        public void DeleteExigence(int id)
        {
            SDFactory.GetDataExigence().DeleteExigence(id);
        }
    }
}
