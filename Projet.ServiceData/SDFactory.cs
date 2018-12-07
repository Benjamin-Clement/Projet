using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.ServiceData
{
    public class SDFactory
    {
        public static SExigence GetDataExigence()
        {
            return new SExigence();
        }

        public static SJalon GetDataJalon()
        {
            return new SJalon();
        }

        public static SProjet GetDataProjet()
        {
            return new SProjet();
        }

        public static SResponsable GetDataResponsable()
        {
            return new SResponsable();
        }

        public static STache GetDataTache()
        {
            return new STache();
        }

        public static STypeExigence GetDataType()
        {
            return new STypeExigence();
        }
    }
}
