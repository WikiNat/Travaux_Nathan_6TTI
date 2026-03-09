using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise.cs
{
    abstract internal class Employe
    {
        protected int _matricule;
        protected string _nom ="";
        protected string _prenom = "";
        protected DateTime _dateN;

        public int Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public string Nom
        {
            get { return _nom; }
        }
        public string Prenom
        {
            get { return _prenom; }
        }
        public DateTime DateN
        {
            get { return _dateN; }
        }

        public Employe(int matricule, string nom, string prenom, DateTime dateN)
        {
            _matricule=matricule;
            _nom=nom;
            _prenom=prenom;
            _dateN=dateN;
        }

        public abstract string AfficheInfo();
        public abstract double Salaire();
        

    }
}
