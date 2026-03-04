using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage_Parallelepipede_Nathan
{
    internal class Rectangle : Parallepipede
    {
        protected double _longueur;
        protected double _largeur;

        public double Longueur
        {
            get { return _longueur; } 
            set { _longueur = value; }
        }
        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public Rectangle(double longueur, double largeur, string couleur) : base (couleur)
        {
            _longueur = longueur;
            _largeur = largeur;
        }
        public override double CalculePerimetre()
        {
            double resultat = (_longueur + _largeur)*2;
            return resultat;
        }
        public override double CalculeSurface()
        {
            double resusltat = _longueur * _largeur;
            return resusltat;
        }
        public override string AfficheInfo()
        {
            return $"Votre rectangle à une longueur de {_longueur} et une largeur de {_largeur}, donc il a un périmètre de {CalculePerimetre()} et une surface de {CalculeSurface()} \n Il a une couleur : {_couleur}";
        }
    }
}
