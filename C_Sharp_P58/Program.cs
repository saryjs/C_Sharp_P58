using System.Text;

namespace C_Sharp_P58         // Простори імен групують класи
{
    internal class Program    // Весь код групується у класах (методах)
    {                         // поза класами код не створюється
        static void Main(string[] args)  // Першим запускаються даний метод
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding  = Encoding.UTF8;

            Console.WriteLine("Платформа Microsoft .NET та мова програмування C#");
            //new Intro.VarsTypes().Run(); // Видаляти об'єкти немає потреби
            // за це відповідає окремий модуль платформи - QC Garbage Collector
            //new Intro.Arrays().Run();
            //new Intro.Strings().Run();
            new HW28_11.Hw1().Run();

        }
    }
}

/*
Платформа Microsoft .NET та мова програмування C#
C# (C-Sharp) - мова 4 покоління (4GL), що базується на платформу .NET
Загальна ідея: 
програма мовою C# компілюється (транслюється) до проміжної мови
 MSIL (Microsoft Intermediate Language), схожою на Асемблер.
Цей файл з проміжним байт-кодом є виконачвим (.ехе) і опрацьовується
платформою, яка "на льоту" (just in time, JIT) докомпільовує його
до процесорного коду, який реально виконується.
                          
                       | .NET |         
C# (text) --> MSIL --> |  JIT | --> CPU
                       |  CLR |  Unmanaged  
                        Managed

Така схема виконання дозволяє зробити мову програмування придатною
для різних операційних платформ (Windows, Linux, Mac, Android etc)
дя яких випускаються різні збірки .NET, які приймають однакові програми.

IDE (Integrated Development Equipment - устаткування розробника)
    Microsoft Visual Studio
    Jetbrains Rider
    Mono
    VS Code

CLR - Common Language Runtime - Середовище виконання (спільне для різних мов)
JIT - Just In Time Compiler - Компілятор виконання (перетворювач IL коду до процесорного)
FCL - Framework Class Library - Набір бібліотек класів для використання у програмах .NET
 */