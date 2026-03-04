namespace ExHeritage_Parallelepipede_Nathan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cote = 0;
            double longueur = 0;
            double largeur = 0;
            string reponse = "";
            string couleur = "";
           

            do
            {
                Console.WriteLine("Tu veux faire quoi d'abord? Carré ou Rectangle? (R/C)");
                reponse = Console.ReadLine();
                if (reponse == "R")
                {
                    Console.WriteLine("\nDonne moi la largeur de ton rectangle :");
                    largeur = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDonne moi la longueur de ton rectangle :");
                    longueur = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDonne moi sa couleur : ");
                    couleur = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (couleur == null)
                    {
                        couleur = string.Empty;
                    }
                    Parallepipede petitRectangle = new Rectangle(longueur, largeur, couleur);
                    Console.WriteLine(petitRectangle.AfficheInfo());
                    Console.WriteLine("\n");
                    Console.WriteLine("Veux tu recommencé? ");
                    reponse = Console.ReadLine();
                }
                else if (reponse == "C")
                {
                    Console.WriteLine("Donne moi le coté de ton carré(nombre à virgule) :");
                    cote = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nDonne moi sa couleur maintenant : ");
                    couleur = Console.ReadLine();
                    if (couleur == null)
                    {
                        couleur = string.Empty;
                    }
                    Carré carre = new Carré(cote, couleur);
                    Parallepipede petitCarré = new Carré(cote, couleur);
                    Console.WriteLine(petitCarré.AfficheInfo());
                    Console.WriteLine("Veux tu recommencé? ");
                    reponse = Console.ReadLine();

                }



            } while (reponse == "oui");
            
        }
    }
}
