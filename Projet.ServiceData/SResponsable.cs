using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;

namespace Projet.ServiceData
{
    public class SResponsable
    {
        DataSetTableAdapters.ResponsableTableAdapter MyAdapter = new DataSetTableAdapters.ResponsableTableAdapter();

        public List<SBResponsable> GetResponsables()
        {
            List<SBResponsable> LesResponsables = new List<SBResponsable>();

            foreach (DataSet.ResponsableRow R in MyAdapter.GetData() )
            {
                LesResponsables.Add(new SBResponsable(R.Id,R.Trigramme) );
            }

            return LesResponsables;
        }

        public SBResponsable GetByTri(string tri)
        {
            SBResponsable R = null;

            foreach (DataSet.ResponsableRow Res in MyAdapter.GetByTrigramme(tri) )
            {
                R = new SBResponsable(Res.Id, Res.Trigramme);
            }

            return R;
        }

        public void InsertResponsable(string tri)
        {
            
            MyAdapter.Insert(tri);

        }
    }
}
