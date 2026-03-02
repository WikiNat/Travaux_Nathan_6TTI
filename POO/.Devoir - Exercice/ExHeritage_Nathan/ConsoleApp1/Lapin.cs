using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lapin : Animal
    {
        private double _tailleO;

        public double TailleO
        {
            get { return _tailleO; }
            set { _tailleO = value; }
        }

        public Lapin(double tailleO,string nom, string dateN, string idPuce, double taille, bool concours) : base(nom, dateN, idPuce, taille, concours)
        {
            _tailleO = tailleO;
        }
        public override string Afficher()
        {
            return base.Afficher() + $", Type: Lapin";
        }
        public string Sauter()
        {
            return "Hop!";
        }
        public override string Manger()
        {
            return base.Manger() + " votre lapin";
        }
        public override bool Dormir()
        {
            return true;
        }
    }
}
