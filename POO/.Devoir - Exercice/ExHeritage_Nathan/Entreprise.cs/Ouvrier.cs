using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise.cs
{
    internal class Ouvrier : Employe
    {
        private DateTime _dateEnt;
        public DateTime DateEnt
        {
            get { return _dateEnt; }
        }
        public Ouvrier(DateTime dateEnt, int matricule, string nom, string prenom, DateTime dateN) : base (matricule, nom, prenom, dateN)
        {
            _dateEnt = dateEnt;
        }

        public override double Salaire()
        {
            double salaireB = 2500;
            int anneeEmb = _dateEnt.Year;
            int dateNow = DateTime.Now.Year;
            int valeur = dateNow - anneeEmb;
            if (valeur < 0) valeur = 0;
            int valeurN = valeur * 100;
            double salaireF = salaireB + valeurN;
            if (salaireF >= 5000)
            {
                salaireF = 5000;
            }
            
            return salaireF;
        }
        public override string AfficheInfo()
        {
            return $"L'ouvrier s'appelle {_nom} {_prenom}, il a comme matricule : {_matricule}. Il/Elle est né le {_dateN}. Il est arrivé dans l'entreprise le {_dateEnt}. Il a un salaire de {Salaire()}";
        }
    }
}
