using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Intro
{
    internal class Strings
    {
        public void Run()
        {
            String str = "";
            Random rnd = new();

            const Int32 N = 10;
            for (int i = 0; i < N; i++)
            {
                str += (char)rnd.Next(24, 127);
            }
            Console.WriteLine(str);

            StringBuilder sb = new();
            for (int i = 0; i < N; i++)
            {
                sb.Append((char)rnd.Next(24, 127));
            }
            str = sb.ToString();
            Console.WriteLine(str);

            char[] chars = new char[N];
            for (int i = 0; i < N; i++)
            {
                chars[i] = (char)rnd.Next(24, 127);
            }
            str = new string(chars);
            Console.WriteLine(str);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            str = "Hello, world!";
            Console.WriteLine(str[1]); // inclusive
            Console.WriteLine(str[1..10]); // end exclusive
            Console.WriteLine(str[..10]); // before end (exclusive)
            Console.WriteLine(str[1..]); // after start (inclusive)
            Console.WriteLine(str[..^1]); // before end (1 from end) (inclusive)

            // interpolation (formating)
            Console.WriteLine($"Випадкове значення {rnd.Next()}");
            Console.WriteLine($"{str[..10]}**{str[10..]}");

        }
    }
}

/*
 *Рядки у С# належать до незмінюваних типів (Immutable).
 * Це означає, що змінити об'єкт не можна, 
 * можна лише збудувати інший об'єкт,
 * беручі іншій за джерело даних.
 *  -- всі операції з рядками призводять до
 *     створення нових рядків (як об'єктів)
 */