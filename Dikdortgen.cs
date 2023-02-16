using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneOdev
{
    class Dikdortgen: Sekil
    {
        private double kisaKenarUzunlugu=20;        //Access modifier 
        private double uzunKenarUzunlugu=6;         //Access modifier 


        public  double getCevre                     //getter method
        {
            get
            {
                return ((2*kisaKenarUzunlugu)+(2*uzunKenarUzunlugu));
            }
        }
        public  double getAlan                      //getter method
        {
            get
            {
                return (kisaKenarUzunlugu*uzunKenarUzunlugu);
            }
        }
        public override void yazdir()               //polymorphic method
        {
            Console.WriteLine("dikdörtgenin alanı:" + (kisaKenarUzunlugu * uzunKenarUzunlugu));
            Console.WriteLine("dikdörtgenin çevresi:" + (2 * kisaKenarUzunlugu + 2 * uzunKenarUzunlugu));
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            

        }

    }
}
