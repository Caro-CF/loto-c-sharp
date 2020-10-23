using System;

namespace Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = new int[7];
            auHasard(numeros);
            Console.WriteLine("***** Tirage du Loto ******");
            foreach (int num in numeros)
            {
               Console.WriteLine(num);
            }

            static void auHasard(int []tabl)
            {
                var rand = new Random();
                tabl[0] = rand.Next(1, 49);
                //bool deja;
                for (int i = 1; i < tabl.Length; i++)
                {
                    //deja = dejaTirer(tabl);
                    if (tabl[i - 1] != tabl[i])
                    {
                        tabl[i] = rand.Next(1, 49);
                    }
                    else
                    {
                        break;
                    }                   
                    
                    //Console.WriteLine(tabl[i]);
                }
            }


            static bool dejaTirer(int[] tab)
            {
                bool deja = true;
                for (int i = 1; i < tab.Length; i++)
                {
                    if (tab[i-1] != tab[i])
                    {
                        deja = false;
                    }
                    else
                    {
                        deja = true;
                    }
                }
                return deja;

            }
        }

    }

       
}
