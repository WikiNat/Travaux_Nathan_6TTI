using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise.cs
{
    internal class Cadre : Employe
    {
        private int _indice;

        public int Indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        public Cadre(int indice, int matricule, string nom, string prenom, DateTime dateN) : base(matricule, nom, prenom, dateN)
        {
            _indice = indice;
        }
        public override double Salaire()
        {
            double salaireF = 0;
            if (_indice == 1)
            {
                salaireF = Tarrification.SAL_I1;
            }
            if (_indice == 2)
            {
                salaireF = Tarrification.SAL_I2;
            }
            if (_indice == 3)
            {
                salaireF = Tarrification.SAL_I3;
            }
            if (_indice == 4)
            {
                salaireF = Tarrification.SAL_I4;
            }
            return salaireF;
        }

        public override string AfficheInfo()
        {
            return $"Le cadre s'appelle {_nom} {_prenom}, il a comme matricule : {_matricule}. Il/Elle est né le {_dateN}. Il a un indice de {_indice}. Il a un salaire de {Salaire()}";
        }

    }
}
