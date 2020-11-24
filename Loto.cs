using System;
using System.Collections.Generic;
using System.Text;

namespace Loto
{
    public class Loto
    {
        Random random = new Random();
        int[] numeros = new int[7];

        public void Start()
        {
            AddIntToTable(numeros);
            ShowGeneratedArrays();
        }

        private int ChooseCaseBetween1to49()
        {
            return random.Next(1, 50);
        }

        private int FindTheGoodNumberToAdd(int[] tableToCheck)
        {
            int intToCheck = ChooseCaseBetween1to49();
            while (CheckIfExist(intToCheck, tableToCheck))
            {
                intToCheck = ChooseCaseBetween1to49();
            }
            return intToCheck;
        }

        private void AddIntToTable(int[] tableToUpdate)
        {
            for (int i = 0; i < tableToUpdate.Length; i++)
            {
                tableToUpdate[i] = FindTheGoodNumberToAdd(tableToUpdate);
            }
        }

        private bool CheckIfExist(int intToAdd, int[] tableToUpdate)
        {
            foreach (int item in tableToUpdate)
            {
                if (intToAdd == item)
                    return true;
            }
            return false;
        }

        private void ShowGeneratedArrays()
        {
            foreach (var item in numeros)
            {
                Console.WriteLine($" Numbers : { item }");
            }
        }
    }    
}
