using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;
namespace Projet.ServiceData
{
    public class STypeExigence
    {
        DataSetTableAdapters.TypeExigenceTableAdapter MyAdapter = new DataSetTableAdapters.TypeExigenceTableAdapter();

        public List<SBTypeExigence> GetTypes()
        {
            List<SBTypeExigence> LesTypes = new List<SBTypeExigence>();

            foreach (DataSet.TypeExigenceRow P in MyAdapter.GetData())
            {
                LesTypes.Add(new SBTypeExigence(P.Id, P.Label));
            }

            return LesTypes;
        }

        public void InsertType(SBTypeExigence T)
        {

            MyAdapter.InsertTypeExigence(T.Label);

        }

        public SBTypeExigence GetById(int id)
        {
            SBTypeExigence T = null;

            foreach (DataSet.TypeExigenceRow Ta in MyAdapter.GetById(id))
            {
                T = new SBTypeExigence(Ta.Id, Ta.Label);
            }

            return T;
        }

        public int count()
        {
            return (int)MyAdapter.Count();
        }
        
    }
}
