using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_bibliothèque_Nathan
{
    internal class bibliothèque
    {

		private string _titre;

        private string _auteur;

        private int _etat;

        private string _livre;

        public string Titre
		{
			get { return _titre; }
			set { _titre = value; }
		}

        public string Livre
        {
            get { return _livre; }
            set { _livre = value; }
        }

        public int Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        public bibliothèque(string auteur, int etat, string livre, string titre)
        {
            _auteur = auteur;
            _etat = etat;
            _auteur = livre;
            _titre = titre;
        }

        public string degradation()
        {
            int etat = 0;
            string etatLivre ="";
            etat = _etat;
            _etat = etat -1;
            if (_etat < 0)
            {
               etatLivre = "Il est cassé";
            }
            if (_etat == 0)
            {
                etatLivre = "bon a être jeter";
            }
            if (_etat == 1)
            {
                etatLivre = "limite";
            }
            if (_etat == 2)
            {
                etatLivre = "'ça passe'";
            }
            if (_etat == 3)
            {
                etatLivre = " moité de vie";
            }
            if (_etat == 4)
            {
                etatLivre = "usé";
            }
            if (etat == 5)
            {
                etatLivre = "neuf";
            }

            return etatLivre;
        }
        public string description()
        {
            return $"Le livre a comme titre {_titre}, l'auteur est {_auteur}. Il est "; 
        }

	}
}
