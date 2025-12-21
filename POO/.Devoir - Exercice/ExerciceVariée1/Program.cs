using ExerciceVariée1;
using Microsoft.Win32.SafeHandles;
using System.Net.WebSockets;
using System.Security.AccessControl;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string saisie ="";
        do
        {
            Console.WriteLine("Quelle est le rayon de votre cercle ?");
            double rayon = double.Parse(Console.ReadLine());
            Cercle cercle = new Cercle(rayon);
            Console.WriteLine("Ton cercle à un rayon de " + rayon + ", donc il a une aire de : " + cercle.CalculerAire() + " et un Périmètre de " + cercle.CalculerPerimetre());
            Console.WriteLine("Avec un cercle de rayon diminué de moitié : \n-------------------------------------------");
            Console.WriteLine("Ton cercle à un rayon de " + rayon / 2 + ", donc il a une aire de: " + cercle.CaclulerMoitierAir() + " et un Périmètre de " + cercle.CalculerMoitierPer());
            Console.WriteLine("Vous avez un autre cercle? (Tapez sur espace) ");
            saisie = Console.ReadLine();
        } while (saisie == " ");
    }
}
