using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneOdev
{
    class Kare: Sekil
    {
        private double kenarUzunlugu=10;            //Access modifier 




        public double getCevre 
        {
            get
            { 
                return (kenarUzunlugu * 4); 
            }
        }
        public double getAlan
        {
            get
            {
                return (kenarUzunlugu * kenarUzunlugu);
            }
        }

        public bool dikdortgeneSigar()
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            if (dikdortgen.getAlan >= kenarUzunlugu * kenarUzunlugu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void yazdir()           //polymorphic method
        {
            Console.WriteLine("karenin alanı:" + kenarUzunlugu * kenarUzunlugu);
            Console.WriteLine("karenin çevresi:" + kenarUzunlugu * 4);
            if (dikdortgeneSigar())
            {
                Console.WriteLine("dikdortgene sıgar");
            }
            else
            {
                Console.WriteLine("dikdortgene sığmaz");
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

        }

    }
}
