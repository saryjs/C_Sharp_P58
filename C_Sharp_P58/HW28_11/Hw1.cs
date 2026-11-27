using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.HW28_11
{
    internal class Hw1
    {
        public void Run()
        {   
            Console.WriteLine("TASK 1");
            
            int[] A = new int[5];
            double[,] B = new double[3, 4];


            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number: ");
                String line = Console.ReadLine()!;
                int b = Convert.ToByte(line);
                A[i] = b;
            }


            double maxm = -1;
            double minm = 1;
            Random rnd2 = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double rand = rnd2.NextDouble() * (maxm - minm) + minm;
                    rand = Math.Round(rand, 1);
                    B[i, j] = rand;
                }
            }

            //read
            double max = A[0];
            double min = A[0];
            double sum = 0;
            int sumEvenA = 0;
            double sumOddB = 0;
            for (int i = 0; i < 5; i++)
            {
                if (A[i] >= max) { max = A[i]; }
                if (A[i] <= min) { min = A[i]; }
                sum += A[i];
                if ((A[i] % 2) == 0) { sumEvenA += A[i]; }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] >= max) { max = B[i, j]; }
                    if (B[i, j] <= min) { min = B[i, j]; }
                    sum += B[i, j];
                    if (B[i, j] < 1){ if (((B[i, j] * 10) % 2) != 0) { sumOddB += B[i, j]; } }
                }
            }

            //print
            Console.WriteLine("A: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("Sum of even numbers in array A: " + sumEvenA);

            Console.WriteLine("B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum of odd numbers in array B: " + Math.Round(sumOddB, 3));
            Console.WriteLine();
            Console.WriteLine("Max number in both arrays: " + max);
            Console.WriteLine("Min number in both arrays: " + min);
            Console.WriteLine("Total sum of both arrays: " + Math.Round(sum, 3));
        }
    }
}
