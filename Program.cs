using System;

namespace Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loto newGame = new Loto();
            //newGame.Start();
            //Console.ReadKey();
            int[] numeros = new int[7];
            auHasard(numeros);
            Console.WriteLine("***** Tirage du Loto ******");
            Console.WriteLine(("").PadRight(26, '-'));
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            static void auHasard(int[] tabl)
            {
                Random rand = new Random();
                
                bool deja;
                
                for (int i = 1; i < tabl.Length; i++)
                {
                    tabl[i] = rand.Next(1, 49);
                    deja = dejaTirer(tabl[i], tabl);
                   
                    if (!deja)
                    {
                        tabl[i] = rand.Next(1, 49);
                    }   
                           
                }
            }

            static bool dejaTirer(int chiffre, int[] tabl)
            {

                for (int i = 0; i < tabl.Length; i++)
                {
                    if (tabl[i] == chiffre)
                    {
                        return true;
                    }
                }
                return false;
            }


        }
    }

}
