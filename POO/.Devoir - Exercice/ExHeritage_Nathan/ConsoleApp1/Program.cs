using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[5];

            animal[0] = new Chien("Christophe", "20 Septembre 2007", "IAJG444", 1.2, true);
            animal[1] = new Chien("Maxence", "3 octobre 2020", "FZJGIEEJ2", 0.7, false);
            animal[2] = new Chat("ChubaCat", "5 janvier 2024", "GJDJKG34G",1.0, false);
            animal[3] = new Chat("Zazou", "30 fevrier 2027", "GJGEL35KG0", 1.1, false);
            animal[4] = new Lapin(0.062, "Gilbert", "10 avril 2025", "HRR?GE34", 0.5, true);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(animal[i].Afficher());
            }

        }
    }
}
