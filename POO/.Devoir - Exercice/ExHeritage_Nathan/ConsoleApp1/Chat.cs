using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Chat : Animal
    {
        public Chat(string nom, string dateN, string idPuce, double taille, bool concours) : base(nom, dateN, idPuce, taille, concours)
        {

        }
        public override string Afficher()
        {
            return base.Afficher() + $", Type: Chat";
        }
        public string Miauler()
        {
           return "Miaou!";
        }
        public override string Manger()
        {
            return base.Manger() + " votre Chat";
        }
        public override bool Dormir()
        {
            return true;
        }
    }
}
