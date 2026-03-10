using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage4_Vehicule
{
    internal class Truck : RoadVehicule
    {
        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Truck(int weight, string brand, int km, int fuel) : base(km, brand, fuel)
        {
            _weight = weight;
        }

        public override string AfficheInfo()
        {
            return $"La camion est de la marque {_brand}, il a un reservoir de {_fuel}L. Il a {_km}km et peux prendre jusqu'à {_weight} tonnes";
        }
    }
}
