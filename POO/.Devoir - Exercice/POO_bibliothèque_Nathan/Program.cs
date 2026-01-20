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
            Console.WriteLine(biblio.inventaire());
        }
    }
}
