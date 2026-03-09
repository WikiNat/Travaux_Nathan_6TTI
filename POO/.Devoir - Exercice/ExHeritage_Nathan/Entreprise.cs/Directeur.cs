using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise.cs
{
    internal class Directeur : Employe
    {
        private int _pourcentage;
        private int _chiffreA;

        public int Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; }
        }
        public int ChiffreA
        {
            get { return _chiffreA; }
            set { _chiffreA = value; }
        }

        public Directeur(int pourcentage, int chiffreA, int matricule, string nom, string prenom, DateTime dateN) : base(matricule, nom, prenom, dateN)
        {
            _pourcentage = pourcentage;
            _chiffreA = chiffreA;
        }

        public override double Salaire()
        {
            int salaireF = ((_chiffreA / 100) * _pourcentage);
            return salaireF;
        }

        public override string AfficheInfo()
        {
            return $"Le directeur s'appelle {_nom} {_prenom}, il a comme matricule : {_matricule}. Il/Elle est né le {_dateN}.Il a fait un chiffre d'affaire de : {_chiffreA} et un pourcentage de revenue de {_pourcentage}. Il a un salaire de {Salaire()}";
        }
    }
}
