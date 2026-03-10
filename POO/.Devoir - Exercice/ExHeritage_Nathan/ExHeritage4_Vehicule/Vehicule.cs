using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeritage4_Vehicule
{
    abstract internal class Vehicule
    {
        protected string _brand ="";
        protected int _fuel;

        public int Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }
        public string Brand
        {
            get { return _brand; }
        }

        public Vehicule(string brand, int fuel)
        {
            _brand = brand;
            _fuel = fuel;
        }

        public abstract string AfficheInfo();

    }
}
