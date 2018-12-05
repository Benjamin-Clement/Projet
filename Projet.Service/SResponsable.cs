using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.ServiceData;

namespace Projet.Service
{
    public class SResponsable
    {
        public List<Bean.SBResponsable> GetResponsables()
        {
            return SDFactory.GetDataResponsable().GetResponsables();
        }

        public Bean.SBResponsable GetByTrigramme(string tri)
        {
            return SDFactory.GetDataResponsable().GetByTri(tri);
        }

        public int AddResposable(string tri)
        {
            SDFactory.GetDataResponsable().InsertResponsable(tri);
            Bean.SBResponsable Res = SDFactory.GetDataResponsable().GetByTri(tri);

            return Res.Id;
        }
    }
}
