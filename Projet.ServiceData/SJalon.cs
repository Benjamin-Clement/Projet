using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet.Bean;

namespace Projet.ServiceData
{
    public class SJalon
    {
        DataSetTableAdapters.JalonTableAdapter MyAdapter = new DataSetTableAdapters.JalonTableAdapter();

        public List<SBJalon> GetJalon()
        {
            List<SBJalon> LesJalons = new List<SBJalon>();

            foreach (DataSet.JalonRow J in MyAdapter.GetData())
            {
                if ( J["DateReelle"] == DBNull.Value )
                {
                    LesJalons.Add(new SBJalon(J.Id, J.Label, J.DatePrevu, J.Responsable));
                }
                else
                {
                    LesJalons.Add(new SBJalon(J.Id, J.Label, J.DatePrevu, J.Responsable, J.DateReelle));
                }
                
            }

            return LesJalons;
        }

        public SBJalon GetById(int id)
        {
            SBJalon J = null;

            foreach (DataSet.JalonRow Jal in MyAdapter.GetById(id))
            {
                if (Jal["DateReelle"] == DBNull.Value)
                {
                    J = new SBJalon(Jal.Id, Jal.Label, Jal.DatePrevu, Jal.Responsable);
                }
                else
                {
                    J = new SBJalon(Jal.Id, Jal.Label, Jal.DatePrevu, Jal.Responsable, Jal.DateReelle);
                }
            }

            return J;
        }

        public void InsertJalon(SBJalon J)
        {

            MyAdapter.InsertJalon(J.Label, J.DatePrevu, J.Responsable);

        }

        public void updateJalon(SBJalon J)
        {
            MyAdapter.UpdateJalon(J.Label,J.DatePrevu,J.Responsable,J.DateReelle,J.Id);
        }

        public void DeleteJalon(int id)
        {
            MyAdapter.DeleteJalon(id);
        }
    }
}
