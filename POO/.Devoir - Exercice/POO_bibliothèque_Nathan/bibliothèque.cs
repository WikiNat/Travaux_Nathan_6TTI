using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_bibliothèque_Nathan
{
	internal class Bibliothèque
	{
		private List<Livre> _listBb;

		public List<Livre> ListBb
		{
			get { return _listBb; }
			set { _listBb = value; }
		}

		public Bibliothèque()
		{
			_listBb = new List<Livre>();
		}

		public void ajoute(Livre livre)
		{
			_listBb.Add(livre);
		}
		public void suppLivresAbimes(Livre livre)
		{
			for (int i = 0; i < 0; i++)
			{
				if (_listBb.Count > 0)
				{
					_listBb.Remove(livre);
				}
			}
		}
		public void supprimer(string titreASupprimer)
		{
			for (int i = 0; i < _listBb.Count; i++)
			{
				if (_listBb[i].Titre == titreASupprimer)
				{
					_listBb.RemoveAt(i);
					break;
				}
			}
        }
        public string inventaire()
		{
			string monInventaire = "";
			for (int i = 0;i < _listBb.Count ;i++)
			{
				monInventaire += _listBb[i].description() + "\n";
			}
			return monInventaire;
		}
		public string afficherLivre()
		{
			string livres = "";
			foreach (var livre in _listBb)
			{
				livres += livre.description() + "\n";
			}
			return livres;
		}
    }
}
