using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Basics
{
    public class Classes
    {
        private int x; // це поле з доступом в межах класу
        protected int y; // це поле доступно також у спадкових класах
        public int a; // це поле доступно з усіх класів (не рекомендується)

        // Propreties - Властивості. Конструкції, що формують аксесори автоматично або спрощено

        public int X { get; set; }

        private int _y;
        
        public int Y
        {
            get => _y;
            set
            {
                _y = value;
                Console.WriteLine($"Fixed var Y = {value}");
            }
        }

        public int A { get; private set; } // read for all, set for this class
        public int B { get => 10; } // read only
        public int C { get; init; } // read and init

        public String TypeName { get=>this.GetType().Name; }

        // Конструктори: може бути декілька з різними модіфикаторами доступу

        public Classes()
        {
            A = 10;
        }
        //public Classes(int a)
        //{
        //    A = a;
        //}
        //private Classes(int a, int c)
        //{
        //    A = a;
        //    C = c;
        //}
        public void Start()
        {
            City city = new()
            {
                CityName = "Niko",
                CountryName = "UA",
                Citizens = 500_000,
                PhonePrefix = "+380512",
                Districts = ["Central", "Ingul"]
            };
        }
        public void Demo() // цій метод доступно з усіх класів (це ок)
        {
            Console.WriteLine("Типи даних. Класи.");
            Y = 10; // set{} value = 10
            Console.WriteLine(Y);
            Console.WriteLine("Type of object: " + TypeName);
        }

        class City
        {
            public String CityName { get; set; } = "City Default";
            public String CountryName { get; set; } = "Country Default";
            public long Citizens { get; set; } = 0;
            public String PhonePrefix { get; set; } = "+Default";
            public String[] Districts { get; set; } = ["District1", "District2"]; // Tairovo, Poskot
        }

        public void Task2()
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsFibonacci(num) ? "Yes" : "No");
        }

        public void Task3()
        {
            const int N = 10;
            Random rnd = new();
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(100);
            }
            Console.WriteLine($"Data: {String.Join(',', arr)}");
            Console.WriteLine("+/- to sort ASC/DESC");
            ConsoleKeyInfo c = Console.ReadKey();
            if (c.KeyChar == '+')
            {
                bool swapped = false;
                do
                {
                    swapped = false;
                    for (int i = 1; i < N; i++)
                    {
                        if (arr[i] < arr[i - 1])
                        {
                            swapped = true;
                            (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                        }
                    }
                } while (swapped == true);
                Console.WriteLine($"Data: {String.Join(',', arr)}");
            }
            else if (c.KeyChar == '-')
            {
                bool swapped = false;
                do
                {
                    swapped = false;
                    for (int i = 1; i < N; i++)
                    {
                        if (arr[i] > arr[i - 1])
                        {
                            swapped = true;
                            (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);
                        }
                    }
                } while (swapped == true);
                Console.WriteLine($"Data: {String.Join(',', arr)}");
            }
            else
            {
                Console.WriteLine("Wrong option");
            }
        }
        
        private bool IsFibonacci(int num)
        {
            if (num < 1) { return false; }
            else if (num == 1) { return true; }
            long a = 1, b = 1;
            do
            {
                if (b == num) return true;
                (a, b) = (b, a + b);
            } while (b <= num);
            return false;
        }

        public void Run()
        {
            Console.Write("Enter range start: ");
            int rangeStart = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter range end: ");
            int rangeEnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Mult of numbers in range {rangeStart}-{rangeEnd} = {MultRange(rangeStart,rangeEnd)}");
        }

        private long MultRange(int start, int end)
        {
            if (start > end) { (start, end) = (end, start); }
            long mult = 1;
            for (int i = start; i <= end; i++)
            {
                mult *= i;
            }
            return mult;
        }

        class SubClass // nested type (nested class) - class in another class
        {
            public int Sub{ get; set; }
        }
    }
}

/* Типи даних. Класи.
 *  Типи даних у С# (.NET) - це об'єкти, які формуються (набираються) із
 *  заданого переліку "будівельних блоків". Їх перелік та особливості
 *  використання регулюються положенням CTS (Common Type System): 
 *  - є декілька модифікаторів видності: для типів та їх частин
 *      public, private - для всіх,
 *      internal - для типів, 
 *      protected - для елементів
 *  - "будівельними блоками" є:
 *   = поля
 *   = методи
 *   = властивості - new
 *   = конструктори
 *   = nested types
*/ 