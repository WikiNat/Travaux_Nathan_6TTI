using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage4_Vehicule
{
    internal class Car : RoadVehicule 
    {
        public Car (int km, string brand, int fuel) : base (km, brand, fuel)
        {

        }
        public override string AfficheInfo()
        {
            return $"La voiture est de la marque {_brand}, il a un recervoir de {_fuel}L. il a {_km}km ";
        }
    }
}
