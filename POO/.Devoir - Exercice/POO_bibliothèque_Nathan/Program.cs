namespace POO_bibliothèque_Nathan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliothèque biblio = new Bibliothèque();
            biblio.ajoute(new Livre("Nathan", 5, "L'histoire de ma vie"));
            biblio.ajoute(new Livre("Maxence", 4, "L'histoire de mon zigouigoui"));
            biblio.ajoute(new Livre("Amaury", 5, "Mes 'conquêtes'"));
            string? recommencer;
            do
            {
                Console.WriteLine("Voici les options possibles dans notre bibliothèque :");
                Console.WriteLine("A. Ajouter un livre");
                Console.WriteLine("S. Supprimer un livre");
                Console.WriteLine("I. Afficher l'inventaire");
                string? option = Console.ReadLine();
                if (option == "")
                {
                    Console.WriteLine("Aucune option saisie.");
                }
                switch (option)
                {
                    case "A":
                        Console.WriteLine("Ajouter un livre :\n");
                        Console.Write("Titre du livre : ");
                        string? titre = Console.ReadLine();
                        Console.Write("Auteur du livre : ");
                        string? auteur = Console.ReadLine();
                        Console.Write("État du livre (1-5) : ");
                        biblio.ajoute(new Livre(auteur ?? "Inconnu", int.Parse(Console.ReadLine() ?? "5"), titre ?? "Sans titre"));
                        Console.WriteLine("\n Voici votre livre");
                        Console.WriteLine(biblio.afficherLivre());
                        break;
                    case "S":
                        Console.WriteLine("Supprimer un livre :\n");
                        Console.Write("Titre du livre à supprimer : ");
                        string? titreASupprimer = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(titreASupprimer))
                        {
                            biblio.supprimer(titreASupprimer);
                            Console.WriteLine($"Le livre '{titreASupprimer}' a été supprimé de la bibliothèque.");
                            Console.WriteLine("\n Voici l'inventaire mis à jour :");
                            Console.WriteLine(biblio.inventaire());
                        }
                        else
                        {
                            Console.WriteLine("Titre invalide ou non saisi, suppression annulée.");
                        }
                        break;
                    case "I":
                        Console.WriteLine("Afficher l'inventaire :\n");
                        Console.WriteLine(biblio.inventaire());
                        break;
                }
                Console.WriteLine("Voulez vous recommencer ? (o/n)");
                recommencer = Console.ReadLine();
                if (recommencer != "o" && recommencer != "n")
                {
                    Console.WriteLine("Aucune réponse, t'es sûr de toi? Ok salut.");
                    return;
                }
            } while (recommencer == "o");      
        }
    }
}
