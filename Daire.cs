using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneOdev
{
    class Daire: Sekil
    {
        private double yariCap=7;               //Access modifier 

        public double getCevre
        {
            get
            {
                return (3.14*2*yariCap);
            }
        }
        public double getAlan
        {
            get
            {
                return (3.14*yariCap*yariCap);
            }
        }

        public bool kareyeSigar()
        {
            Kare kare = new Kare();

            if (kare.getAlan >= 3.14 * yariCap * yariCap)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override void yazdir()               //polymorphic method
        {
            Console.WriteLine("dairenin alanı:"+3.14 * yariCap * yariCap);
            Console.WriteLine("dairenin çevresi:"+2 * 3.14 * yariCap);
            if (kareyeSigar())
            {
                Console.WriteLine("kareye sıgar");
            }
            else
            {
                Console.WriteLine("kareye sığmaz");
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

        }
    }
}
