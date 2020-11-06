using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombres_par_ordre_croissant
{
    class Program
    {
        static void Main(string[] args)

        {
            string reponse = "oui";
            do
            {

            

            decimal Nbr1, Nbr2, Nbr3, a, b, c; //DECLARATION DES VARIABLES & INITIALISATION DES VARIABLES EN X
            a = 0;
            b = 0;
            c = 0;
            
            Console.WriteLine("Vous allez devoir entrez trois nombres différents"); //SAISIE DES VALEURS PAR L'UTILISATEUR
            Console.Write("\nVeuillez saisir un premier nombre SVP : ");
            Nbr1 = decimal.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir un second nombre SVP : ");
            Nbr2 = decimal.Parse(Console.ReadLine());
            Console.Write("Veuillez saisir un dernier nombre SVP : ");
            Nbr3 = decimal.Parse(Console.ReadLine());           

            if ((Nbr1 > Nbr2) & (Nbr2 > Nbr3))  //CLASSEMENT DES NOMBRES
            {
                a = Nbr1;
                b = Nbr2;
                c = Nbr3;
            }

            else if (Nbr1 > Nbr3 & Nbr3 > Nbr2)
            {
                a = Nbr1;
                b = Nbr3;
                c = Nbr2;
            }
            else if (Nbr2 > Nbr1 & Nbr1 > Nbr3)
            {
                a = Nbr2;
                b = Nbr1;
                c = Nbr3;
            }
            else if (Nbr2 > Nbr3 & Nbr3 > Nbr1)
            {
                a = Nbr2;
                b = Nbr3;
                c = Nbr1;
            }
            else if (Nbr3 > Nbr1 & Nbr1 > Nbr2)
            {
                a = Nbr3;
                b = Nbr1;
                c = Nbr2;
            }
            else if (Nbr3 > Nbr1 & Nbr2 > Nbr1)
            {
                a = Nbr3;
                b = Nbr2;
                c = Nbr1;
            }          
                        //Nombre dans l'ordre croisant
            if (a != 0)
                Console.WriteLine("Voici les nombres dans l'ordre croisant :  " + c + "  " + b + "  " + a);

            Console.WriteLine("souhaitez vous continuer?");
                ConsoleKeyInfo saisie = Console.ReadKey(true);

                if
                    (saisie.Key == ConsoleKey.O)

                {
                    Console.WriteLine("On continue?...");
                    Console.ReadKey();

                }

                else
                {
                    Console.WriteLine("On s'arrête...");
                    Console.ReadKey();

                }
                goto Start;


            } while (reponse=="oui");

            //FIN DU PROGRAMME
            Console.ReadKey();

        }

    }
}

