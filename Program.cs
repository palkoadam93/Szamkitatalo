using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamkitatalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int szam = rnd.Next(1, 101);
            //Console.WriteLine(szam);
            int tipp;
            int szam2 = 0;
            do
            {
                Console.WriteLine("Kérek egy tippet 1 és 100 között! Tízszer tippelhetsz!");
                tipp = Convert.ToInt32(Console.ReadLine());
                if (szam != tipp)
                {
                    {
                        szam2++;
                        if (szam < tipp)
                        {
                            Console.WriteLine("A szám nagyobb, mint a tipp!");
                        }
                        else
                        {
                            Console.WriteLine("A szám kisebb, mint a tipp!");
                        };
                    };
                }
            } while ((szam2 < 10) && (tipp != szam));
            if(szam2<=10 && tipp==szam)
            {
                Console.WriteLine("Eltaláltad!");
            }
            else
            {
                Console.WriteLine("Vesztettél!");
            }
            Console.ReadLine();
        }
    }
}