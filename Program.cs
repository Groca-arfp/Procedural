using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre_parfaits
{
    class Program
    {
        static void Main(string[] args)
        {
            long divis, nbr, n, compt = 0;
            bool Est_premier;
            System.Console.Write("Veuillez saisir un nombre entier: ");
            nbr = Int64.Parse(System.Console.ReadLine());
            int Compteur = 0;
            string chaine = "";
            long somme = 1;
            string Continuer;
            bool continuer2 = true;

            do
            {
                divis = 2;
                Est_premier = true;

                do
                {
                    if (nbr % divis == 0)
                    {
                        Est_premier = false;
                        chaine += divis + " \t";
                        somme += divis;
                        Compteur++;
                    }

                    divis++;
                }
                while ((divis < nbr));
                if (Est_premier == true)
                {
                    Console.WriteLine("Nombre est premier, il n'a pas de diviseur");

                }
                else
                {
                    Console.WriteLine("les " + Compteur + " diviseurs du nombre saisi sont:" + chaine);
                    Console.WriteLine(somme);
                }
                Console.WriteLine("Souhaitez vous continuer?(oui/non)");
                Continuer = Console.ReadLine();
                if (Continuer == "non")
                {
                    continuer = false;
                }
            } while (continuer2 == true);

           

            Console.ReadKey();



        }
    }
}
