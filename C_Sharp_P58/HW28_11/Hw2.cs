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

            int posMinI = 0;
            int posMaxI = 0;
            int posMinJ = 0;
            int posMaxJ = 0;
            int min = arr2[0, 0];
            int max = arr2[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr2[i, j] <= min)
                    {
                        min = arr2[i, j];
                        posMinI = i;
                        posMinJ = j;
                    }
                    if (arr2[i, j] >= max)
                    {
                        max = arr2[i, j];
                        posMaxI = i;
                        posMaxJ = j;
                    }
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

            // swap

            if (posMinI > posMaxI || posMinI == posMaxI && posMinJ > posMaxJ) 
            { 
                (posMinI, posMaxI) = (posMaxI, posMinI);
                (posMinJ, posMaxJ) = (posMaxJ, posMinJ);
            } 

            // sum

            int sum = 0;
            for (int i = posMinI; i <= posMaxI; i++)
            {

                int startJ;
                if (i == posMinI) { startJ = posMinJ + 1; }
                else { startJ = 0; }

                int endJ;
                if (i == posMaxI) { endJ = posMaxJ - 1; }
                else { endJ = 4; }

                for (int j = startJ; j <= endJ; j++)
                {
                    sum += arr2[i, j];
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
