using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;
using Projet.ServiceData;

namespace Projet.Service
{
    public class SJalon
    {
        public List<SBJalon> GetJalons()
        {
            return SDFactory.GetDataJalon().GetJalon(); ;
        }

        public SBJalon GetById(int id)
        {
            return SDFactory.GetDataJalon().GetById(id);
        }

        public void AddJalon(string label,DateTime date,int responsable )
        {
            SDFactory.GetDataJalon().InsertJalon(new SBJalon(label,date,responsable));
        }

        public void UpdateJalon(int Id, string label,DateTime date,int responsable,DateTime livraison)
        {
            SDFactory.GetDataJalon().updateJalon(new SBJalon(Id, label, date,responsable,livraison));
        }

        public void DeleteJalon(int id)
        {
            SDFactory.GetDataJalon().DeleteJalon(id);
        }
    }
}
