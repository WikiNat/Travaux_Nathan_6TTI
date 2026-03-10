using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage4_Vehicule
{
    internal class Boat : Vehicule 
    {
        private int _tonnage;

        public int Tonnage
        {
            get { return _tonnage; } set { _tonnage = value; }
        }
        public Boat (int tonnage, string  brand, int fuel) : base (brand, fuel)
        {
            _tonnage = tonnage;
        }

        public override string AfficheInfo()
        {
            return $"Le bateau est de la marque {_brand} et a un recevoir de {_fuel}. Il a un tonnage de {_tonnage} tonne";
        }
    }
}
