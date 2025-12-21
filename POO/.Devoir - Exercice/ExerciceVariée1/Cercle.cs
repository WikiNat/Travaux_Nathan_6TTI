using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceVariée1
{

    public class Cercle
    {
        public double Rayon { get; set; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }


        public double CalculerAire()
        {
            return Math.PI * Rayon * Rayon;
        }
        public double CalculerPerimetre()
        {
            return 2 * Math.PI * Rayon;
        }
        public double CalculerMoitierPer()
        {
            return Rayon/2 *Math.PI *2 ;   
        }
        public double CaclulerMoitierAir() 
        {
            return Math.PI * Rayon/2 * Rayon/2;
        }

    }
}
