using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage4_Vehicule
{
    abstract internal class RoadVehicule : Vehicule
    {
        protected int _km;

        public int Km
        {
            get { return _km; }
            set { _km = value; }
        }

        public RoadVehicule(int km, string brand, int fuel) : base(brand , fuel)
        {
            _km = km;
        }

        public override abstract string AfficheInfo();

    }
}
