using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysBubbles__11._03._22_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] unsortierterIndex = new int[] { 45, 10, 15, 4 };
            Console.WriteLine("Unsortiert");

            for (int i = 0; i < unsortierterIndex.Length; i++)
            {
                Console.WriteLine(unsortierterIndex[i]);
            }

            int[] sortierterIndex = BubbleSort(unsortierterIndex);
            Console.WriteLine("Sortiert");
            for (int i = 0; i < sortierterIndex.Length; i++)
            {
                Console.WriteLine(sortierterIndex[i]);
            }
            Console.ReadLine();
        }

        private static int[] BubbleSort(int[] unsortierterIndex)
        {
            int länge = unsortierterIndex.Length;
            for (int i = 0; i < länge -1; i++)
            {
                for (int j = 0; j < länge -1 - i; j++)
                {
                    if (unsortierterIndex[j] > unsortierterIndex[j + 1])
                    {
                        int Zahl = unsortierterIndex[j];
                        unsortierterIndex[j] = unsortierterIndex[j + 1];
                        unsortierterIndex[j + 1] = Zahl;
                    }
                }
            }
            return unsortierterIndex;
        }
    }
}
