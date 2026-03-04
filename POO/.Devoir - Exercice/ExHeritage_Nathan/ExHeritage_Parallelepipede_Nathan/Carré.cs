using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage_Parallelepipede_Nathan
{
    internal class Carré : Parallepipede
    {
        protected double _cote;
    

        public double Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }


        public Carré(double cote, string couleur) : base(couleur)
        {
            _cote = cote;

        }

        public override string AfficheInfo()
        {
            return $"Votre carré à pour côté : {_cote}, donc il a un périmètre de {CalculePerimetre()} et une surface de {CalculeSurface()} \n Il a une couleur : {_couleur}";
        }
        public override double CalculePerimetre()
        {
            double resultatP = (_cote) * 4;
            return resultatP;
        }
        public override double CalculeSurface()
        {
            double resultatS = _cote * _cote;
            return resultatS;
        }

    }
}
