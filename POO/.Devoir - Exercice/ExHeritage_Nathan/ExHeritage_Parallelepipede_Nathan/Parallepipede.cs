using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage_Parallelepipede_Nathan
{
    abstract internal class Parallepipede
    {
        protected string _couleur;
        
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public Parallepipede(string couleur) 
        {
            _couleur = couleur;
        }
        abstract public double CalculeSurface();
        abstract public double CalculePerimetre();
        abstract public string AfficheInfo();

    }
}
