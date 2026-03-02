using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        protected string _nom;
        protected string _dateN;
        protected string _idPuce;
        protected double _taille;
        protected bool _concours;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string DateN
        {
            get { return _dateN; }
            set { _dateN = value; }
        }
        public string IdPuce
        {
            get { return _idPuce; }
            set { _idPuce = value; }
        }
        public double Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }
        public bool Concours
        {
            get { return _concours; }
            set { _concours = value; }
        }

        public Animal(string nom, string dateN, string idPuce, double taille, bool concours)
        {
            _nom = nom;
            _dateN = dateN;
            _idPuce = idPuce;
            _taille = taille;
            _concours = concours;
        }

        public virtual string Afficher()
        {
            return $"Nom: {_nom}, Date de naissance: {_dateN}, ID de puce: {_idPuce}, Taille: {_taille}, Concours: {_concours}";
        }

        public virtual string Manger()
        {
            return "Il est entrain de manger";
        }
        public virtual bool Dormir()
        {
            return true;
        }

    }
}
