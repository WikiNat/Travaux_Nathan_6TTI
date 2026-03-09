using System;

namespace Entreprise.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe[] employes = new Employe[10];
            employes[0] = new Ouvrier(new DateTime(2022, 1, 10), 1002, "Lefebvre", "Marie", new DateTime(1992, 7, 14));
            employes[1] = new Ouvrier(new DateTime(2020, 5, 12), 1001, "Dupont", "Jean", new DateTime(1985, 3, 25));
            employes[2] = new Ouvrier(new DateTime(2018, 11, 30), 1003, "Morel", "Thomas", new DateTime(1978, 12, 5));
            employes[3] = new Ouvrier(new DateTime(2021, 9, 1), 1004, "Bertrand", "Sarah", new DateTime(1995, 2, 10));
            employes[4] = new Ouvrier(new DateTime(2023, 3, 15), 1005, "Petit", "Nicolas", new DateTime(1988, 11, 22));
            employes[5] = new Cadre(3, 2001, "Lefebvre", "Marc", new DateTime(1975, 6, 15));
            employes[6] = new Cadre(4, 2002, "Vannier", "Julie", new DateTime(1982, 11, 3));
            employes[7] = new Cadre(2, 2003, "Rousseau", "Antoine", new DateTime(1990, 4, 22));
            employes[8] = new Directeur(10, 500000, 3001, "Morel", "Clara", new DateTime(1970, 5, 12));
            employes[9] = new Directeur(15, 750000, 3002, "Girard", "Eric", new DateTime(1965, 12, 30));

            // Affichage : appeler AfficheInfo() pour chaque employé
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(employes[i].AfficheInfo());
                Console.WriteLine("");
            }

  
        }
    }
}
