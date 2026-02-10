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
        public string Emprunt()
        {

        }


    }
}
