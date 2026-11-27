using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.HW28_11
{
    internal class Hw2
    {
        public void Run()
        {   
            Console.WriteLine("TASK 2");
            //fill
            int[,] arr2 = new int[5, 5];

            Random rnd2 = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr2[i, j] = rnd2.Next(-100, 100);
                }
            }

            int posMinI, posMinJ, posMaxI, posMaxJ = 0;
            int minimal = arr2[0,0];
            int maximal = arr2[0,0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr2[i,j] <= minimal) { minimal = arr2[i, j]; posMinI = i; posMinJ = j; }
                    if (arr2[i,j] >= maximal) { maximal = arr2[i, j]; posMaxI = i; posMaxJ = j; }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
