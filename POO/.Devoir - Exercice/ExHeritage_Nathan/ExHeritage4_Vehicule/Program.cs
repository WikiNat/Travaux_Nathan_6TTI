using System;

namespace ExHeritage4_Vehicule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reponse = "";
            string brand = "";
            int range = 0;
            int km = 0;
            int weigth = 0;
            int fuel = 0;
            int tonnage = 0;
            List<Vehicule> monGarage = new List<Vehicule>();
            do
            {
                Console.WriteLine("Donne moi une option entre A(Avion), C(Voiture), T(Camion), B(bateau) ou voir le garage actuellement");
                reponse = Console.ReadLine();
                switch (reponse)
                {   
                    
                    case "A":
                        Console.WriteLine("De quelle marque cera votre avion?");
                        brand = Console.ReadLine();
                        Console.WriteLine("Il aura combien en récevoir?");
                        fuel = int.Parse(Console.ReadLine());
                        Console.WriteLine("Il peut aller jusqu'à quelle distance?");
                        range = int.Parse(Console.ReadLine());
                        monGarage.Add(new Plane(range, brand, fuel));
                        break;
                    case "C":
                        Console.WriteLine("Il est de quelle marque ta voiture?");
                        brand = Console.ReadLine();
                        Console.WriteLine("Il a combien en récevoir");
                        fuel = int.Parse(Console.ReadLine());
                        Console.WriteLine("Il a combien de kilométrage?");
                        km = int.Parse(Console.ReadLine());
                        monGarage.Add(new Car(km, brand, fuel));
                        break;
                    case "T":
                        Console.WriteLine("Il est de quelle marque ton camion?");
                        brand = Console.ReadLine();
                        Console.WriteLine("Il a combien en récevoir");
                        fuel = int.Parse(Console.ReadLine());
                        Console.WriteLine("Il a combien de kilométrage?");
                        km = int.Parse(Console.ReadLine());
                        Console.WriteLine("Il peut contenir combien de tonne?");
                        weigth = int.Parse(Console.ReadLine());
                        monGarage.Add(new Truck(weigth, brand, km, fuel));
                        break;
                    case "B":
                        Console.WriteLine("Il est de quelle marque ton bateau?");
                        brand = Console.ReadLine();
                        Console.WriteLine("Il a combien de tonnage?(en tonne)");
                        tonnage = int.Parse(Console.ReadLine());
                        Console.WriteLine("Et il a combien en recevoir de fuel?");
                        fuel = int.Parse(Console.ReadLine());
                        monGarage.Add(new Boat(tonnage, brand, fuel));
                        break;
                    case "Garage":
                        for (int i = 0; i < monGarage.Count; i++)
                        {
                            // On accède au véhicule à la position [i]
                            Vehicule lesVehicules = monGarage[i];
                            Console.WriteLine($"Véhicule n°{i + 1} enregistré : {lesVehicules.Brand}");
                        }
                        break;
                } 
                // Demander à l'utilisateur s'il veut continuer
                Console.WriteLine("Voulez-vous continuer ? (oui/non)");
                reponse = Console.ReadLine();
            } while (reponse == "oui");
        }
    }
}
