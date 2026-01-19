using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSupp2_Nathan
{
	internal class SandwichMaker
	{

		private string[] _proteine = { "jambon", "fromage", "roast beef", "salami"};
		private string [] _condiments = {"Ketchup","Moutard","Mayo","Andalouse"};
		private string [] _pain = {"Pain blanc","Pain Grainé","Pain Noir","Pain saucisse"};
		private string [] _crudite = {"Totale","Moitié","9/34","Rien"};

	public string ComposeSandwich()
		{

			Random alea = new Random();
			string randomProteine = _proteine[alea.Next(_proteine.Length)];
			string randomCondiments = _condiments[alea.Next(_condiments.Length)];
			string randomPain = _pain[alea.Next(_pain.Length)];
			string randomCrudite = _crudite[alea.Next(_crudite.Length)];

			return randomProteine + randomCondiments + randomPain + randomCrudite;
		}
	}
}
