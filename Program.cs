using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire();
            Kare kare = new Kare();
            Dikdortgen dikdortgen = new Dikdortgen();
            Sekil[] yazdirlar = { dikdortgen,kare, daire };

            foreach (Sekil yazdirmak in yazdirlar)
            {
                yazdirmak.yazdir();                             //yazdir() metodu polymorphism kullanılarak yapıldı.



            }

            Console.ReadKey();

        }
            

        
    }
}



  
