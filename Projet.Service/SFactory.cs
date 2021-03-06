﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Service
{
    public class SFactory
    {

        public static SProjet GetServiceProjet()
        {
            return new SProjet();
        }

        public static SResponsable GetServiceResponsable()
        {
            return new SResponsable();
        }

        public static SExigence GetServiceExigence()
        {
            return new SExigence();
        }

        public static STypeExigence GetServiceType()
        {
            return new STypeExigence();
        }

        public static SJalon GetServiceJalon()
        {
            return new SJalon();
        }

        public static STache GetServiceTache()
        {
            return new STache();
        }
    }
}
