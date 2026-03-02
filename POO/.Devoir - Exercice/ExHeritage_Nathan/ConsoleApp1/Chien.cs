using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chien : Animal
    {
        public Chien(string nom, string dateN, string idPuce, double taille, bool concours) : base(nom, dateN, idPuce, taille, concours)
        {
        }

        public override string Afficher()
        {
            return base.Afficher() + $", Type: Chien";
        }

        public string Aboyer()
        {
            return "Ouaf!";
        }
        public override string Manger()
        {
            return base.Manger() + " votre chien";
        }
        public override bool Dormir()
        {
            return true;
        }
    }
}
