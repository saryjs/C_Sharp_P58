using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Intro
{
    internal class Arrays
    {
        public void Run()
        {
            Console.WriteLine("Масиви, багатомірні масиви, цикли");
            // масиви є об'єктами, які "обслуговують"
            // послідовне однотипне сховище постійного розміру

            int[] arr1 = new int[10];  // base v
            int[] arr2 = { 1, 2, 3 };  // form ^
            int[] arr3 = [ 1, 2, 3 ]; // new syntax

            foreach(int x in arr2)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            // багатомірні масиви поділяються на дві групи:
            // 2D (multi-D) - grid array
            // jagged - array of arrays (each array can be different size)

            int[,] arr2d1 = new int[3, 4] {
                {1, 2, 3, 4 },
                {2, 3, 4, 5 },
                {3, 4, 5, 6 }
            };
            int[,,] arr3d1 = {
                { {1,2}, {3,4}, {5,6} },
                { {2,3}, {4,5}, {6,7} },
                { {3,4}, {5,6}, {7,8} },
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr2d1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            int[][] jarr =
            [
                [1, 2],
                [1, 2, 3 ,4],
                [1, 2, 3],
                [1, 2, 3, 4 ,5],
            ];

            foreach (int[] a in jarr)
            {
                foreach (int x in a)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }

            Random rnd1 = new Random(); // base syntax
            Random rnd2 = new(); // new syntax [Random rnd = new Random()]
            var rnd3 = new Random(); // автоматичне визначення типу (var)

            Console.WriteLine(rnd1.Next(0,100));
            Console.WriteLine(rnd2.Next(0,100));
            Console.WriteLine(rnd3.Next(0,100));
        }

        
    }
}
