using ExerciceVariéeComplexe;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        double reel = 0;
        double imaginaire = 0;
        double reel2 = 0;
        double imaginaire2 = 0;
        double module = 0;
        double module2 = 0;
        string reponse="";

        do
        {
            Complexe complexe = new Complexe(reel, imaginaire, reel2, imaginaire2, module, module2);
            string complex = complexe.AfficheComplexe();
            Console.WriteLine(complex);
            string complex2 = complexe.AfficheComplexe2();
            Console.WriteLine(complex2);
            string addition = complexe.AdditionComplexe();
            Console.WriteLine(addition);
            Console.WriteLine("Voulez vous recommencer? (Tapez espace puis enter) :");
            reponse = Console.ReadLine();

        } while (reponse == " ");
    }
}
