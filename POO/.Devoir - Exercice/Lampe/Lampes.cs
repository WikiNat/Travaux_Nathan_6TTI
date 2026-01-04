using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lampe
{
    internal class Lampes
    {
        private string _lesLampes;
        private string _interrupteur;
        private string _couleur;


        public Lampes(string lampe, string interupteur, string couleur)
        {
            _lesLampes = lampe;
            _interrupteur = interupteur;
            _couleur = couleur;
        }

        public string Lampe
        {
            get { return _lesLampes; }
            set { _lesLampes = value; }
        }
        public string Interrupteur
        {
            get { return _interrupteur; }
            set { _interrupteur = value; }
        }
        public string Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public string ChangementDetat()
        {

            Console.WriteLine("Vous êtes dans le noir, voulez-vous allumer la lampe ? (oui/non)");
            string reponse = Console.ReadLine();
            if (reponse == "oui")
            {
                _interrupteur = "allumé";

                Console.WriteLine("Vous êtes enfin éclairé, bien\n");
                Console.WriteLine("Voulez vous changer de couleur?");
                if (Console.ReadLine() == "oui")
                {
                    Console.WriteLine("\n Quelle couleur vous voulez?");
                    Console.WriteLine("\n Vous avez le choix entre Rouge, Bleu, Violet, Vert, Rose ou Mutlicolore");
                    Couleurs();

                }
            }
            if (reponse == "non")
            {
                _interrupteur = "éteint";
                Console.WriteLine("Alors vous restez dans le noir c'est bien dommage");

            }
            if (reponse == "")
            {
                Console.WriteLine("Vous êtes encore en vie?");
                reponse = Console.ReadLine();
                if (reponse == "oui")
                {
                    Console.WriteLine("Bah alors amusez vous bon sang");
                }
                else
                {

                }
            }
                return $"Votre lampe est {_interrupteur}  et vous avez choisis la couleur {_couleur}";

        }
        public string Couleurs()
        {
            _couleur = Console.ReadLine();
            if (_couleur == "Rouge")
            {
                _couleur = "Rouge";
            }
            if (_couleur == "Bleu")
            {
                _couleur = "Bleu";
            }
            if (_couleur == "Violet")
            {
                _couleur = "Violet";
            }
            if (_couleur == "Vert")
            {
                _couleur = "Vert";
            }
            if (_couleur == "Rose")
            {
                _couleur = "Rose";
            }
            if (_couleur == "Multicolore")
            {
                _couleur = "Multicolor";
            }
            if (_couleur == "")
            {
                _couleur = "basique";
            }
            return _couleur;
        }
    }
}
