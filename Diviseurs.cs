using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne
{
    class Program
    {
        static void Main(string[] args)
        {
            double nombre1;
            double nombre2;
            double res;
            bool testnb;
            bool testnb2;


            Console.WriteLine("Veuillez entrer nombre1");       
            testnb = double.TryParse(Console.ReadLine(),out nombre1);
            do
            {
                
                testnb = double.TryParse(Console.ReadLine(), out nombre1);

            } while (testnb==false);

            Console.WriteLine("Veuillez entrer nombre2");                       
            testnb = double.TryParse(Console.ReadLine(), out nombre2);
            do
            {
                
                testnb = double.TryParse(Console.ReadLine(), out nombre2);

            } while (testnb == false);


            Console.Write("\t appuyer sur une touche pour fermer!");

            Console.ReadKey();
        }
    }
}
