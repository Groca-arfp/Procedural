using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnéeBissextile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int A;                     


            Console.WriteLine("Saisir une année");
            A = int.Parse(Console.ReadLine());

            if (A % 4 == 0)
            {
                if (A % 100 == 0)

                {
                    if (A % 400 == 0)
                    {
                        Console.WriteLine("Annee bissextile");
                    }
                    else
                    {
                        Console.WriteLine("Annee non bissextile");

                    }
                }
                else
                {
                    Console.WriteLine("Annee bissextile");
                }
            }
            else
            {
                Console.WriteLine("Année non bissextile");


            }
            Console.ReadKey();

            

         

        }
   
    }

}
