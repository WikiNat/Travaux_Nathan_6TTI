namespace Lampe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string interupteur = "";
            string lampe = "belle";
            string couleur = "";
            string recommencer = "";


            Lampes lampes = new Lampes( lampe,  interupteur, couleur);
            string lamp = lampes.ChangementDetat();
            do
            {
                Console.WriteLine(lamp);
                Console.WriteLine("Vous voulez recommencer à vous amuser avec la lampe?");
                recommencer = Console.ReadLine();
            } while (recommencer == "oui");

        }
    }
}
