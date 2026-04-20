using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_BilbliothèqueV2_Nathan
{
    internal class Emprunter
    {

        private List<Livre> _livres;
        private string _emprunteur;

        public List<Livre> Livres
        {
            get { return _livres; }
            set { _livres = value; }
        }
        public string Emprunteur
        {
            get { return _emprunteur; }
            set { _emprunteur = value; }
        }

        public Emprunter(string emprunteur, List<Livre> livres)
        {
            _livres = livres;
            _emprunteur = emprunteur;
        }
        public string description()
        {
            string descriptionEmprunt = $"Emprunteur : {_emprunteur}\nLivres empruntés :\n";
            foreach (var livre in _livres)
            {
                descriptionEmprunt += $"- {livre.Titre} par {livre.Auteur} (État : {livre.Etat})\n";
            }
            return descriptionEmprunt;
        }
        public void Emprunt()
        { 
           if (string.IsNullOrWhiteSpace(_emprunteur))
            {
                Console.WriteLine("Nom de l'emprunteur invalide.");
            }

            if (_livres == null || !_livres.Any())
            {
                Console.WriteLine($"Aucun livre à emprunter pour {_emprunteur}.");
            }

            Console.WriteLine($"Emprunt effectué par {_emprunteur} :");
            Console.WriteLine($"Nombre de livres : {_livres.Count}");
            Console.WriteLine("Détails :");

            foreach (var livre in _livres)
            {
                try
                {
                    string degradationMessage = livre.degradation();
                    if (!string.IsNullOrWhiteSpace(degradationMessage))
                    {
                        Console.WriteLine(degradationMessage);
                    }
                }
                catch
                {
                  
                }

                try
                {
                    string desc = livre.description();
                    if (!string.IsNullOrWhiteSpace(desc))
                    {

                        string indentedDesc = string.Join("\n", desc.Split('\n').Select(line => "  " + line));
                        Console.WriteLine(indentedDesc);
                    }
                    else
                    {
                        Console.WriteLine($"  - {livre.Titre} par {livre.Auteur} (État : {livre.Etat})");
                    }
                }
                catch
                {
                    Console.WriteLine ($"  - {livre.Titre} par {livre.Auteur} (État : {livre.Etat})");
                }
            }

            Console.WriteLine ("Merci de rendre les livres à la date prévue.");
           
        }
    }
}
