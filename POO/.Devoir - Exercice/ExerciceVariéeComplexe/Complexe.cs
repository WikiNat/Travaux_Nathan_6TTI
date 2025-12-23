using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExerciceVariéeComplexe
{
    internal class Complexe
    {
        private double _reel;
        private double _reel2;
        private double _imaginaire;
        private double _imaginaire2;
        private double _module;
        private double _module2;

        public Complexe(double reel, double imaginaire, double reel2, double imaginaire2, double module, double module2)
        {
            _reel = reel;
            _reel2 = reel2;
            _imaginaire = imaginaire;
            _imaginaire2 = imaginaire2;
            _module = module;
            _module2 = module2;
        }
        public double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }
        public double Reel2
        {
            get { return _reel2; }
            set { _reel2 = value; }
        }
        public double Imaginaire
        {
            get { return _imaginaire; }
            set { _imaginaire = value; }
        }
        public double Imaginaire2
        {
            get { return _imaginaire2; }
            set { _imaginaire2 = value; }
        }
        public double Module
        {
            get { return _module; }
            set { _module = value; }
        }


        public string AfficheComplexe() 
        {
            Console.WriteLine("Que vaut la partie réelle du complexe de départ?");
            _reel = double.Parse(Console.ReadLine());
            Console.WriteLine("Que vaut la partie imaginaire du complexe de départ?");
            _imaginaire = double.Parse(Console.ReadLine());
            CalculeModule();
            return $"Le premier complexe : ({_reel}, {_imaginaire}) a pour module : {_module}";
        }
        public string AfficheComplexe2()
        {
            Console.WriteLine("Que vaut la partie du réelle du second complexe?");
            _reel2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Que vaut la partie imaginaire du complexe?");
            _imaginaire2 = double.Parse(Console.ReadLine());    
            CalculeModule2();
            return $"le deuxième complexe :  ({_reel2}, {_imaginaire2}) a pour module : {_module2}";
        }
        public double CalculeModule()
        {
            Complex z = new Complex(_reel, _imaginaire);
            _module = z.Magnitude;
            return _module;
        }
        public double CalculeModule2()
        {
            Complex z2 = new Complex(_reel2, _imaginaire2);
            _module2 = z2.Magnitude;
            return _module2;
        }

        public string AdditionComplexe()
        {
            double imaginaireAd = _imaginaire + _imaginaire2;
            double reelAd = _reel + _reel2;
            return "Le premier complexe devient : (" +reelAd + "," + imaginaireAd + ") après ajout du second."  ;
        }
     }
}
