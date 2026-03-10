using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage4_Vehicule
{
    internal class Plane : Vehicule
    {
        private int _range;

        public int Range
        {
            get { return _range; }
            set { _range = value; }
        }
        public Plane(int range, string brand, int fuel) : base(brand, fuel)
        {
            _range = range;
        }

        public override string AfficheInfo()
        {
            return $"L'avion est de la marque {_brand} et a un recevoir de {_fuel}. Et il peut aller jusqu'à {_range} km";
        }
    }
}
