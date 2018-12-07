using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;
using Projet.ServiceData;

namespace Projet.Service
{
    public class STypeExigence
    {
        public List<SBTypeExigence> GetType()
        {
            return SDFactory.GetDataType().GetTypes(); ;
        }

        public SBTypeExigence GetById(int id)
        {
            return SDFactory.GetDataType().GetById(id);
        }

        public void AddTypeExigence(string label)
        {
            SDFactory.GetDataType().InsertType(new SBTypeExigence(label));
        }

        public int count()
        {
            return SDFactory.GetDataType().count();
        }
    }
}
