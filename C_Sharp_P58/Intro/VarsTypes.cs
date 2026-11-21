using System;                      // using - using namespace
using System.Collections.Generic;  // NOT like include
using System.Text;

namespace C_Sharp_P58.Intro        // namespace може вкладатись (через ".")
{                                 // традиційно - за іменем директорії

    /// <summary>
    /// Змінні та типи даних
    /// </summary>

    internal class VarsTypes // CapitalCamelCase
    {
        public void Run()
        {
            Console.WriteLine("Змінні та типи даних");
            // Типи даних у С# на вдміну від С++
            // Тип даних - це об'єкт, що містить інформацію про склад типу
            // Цей об'єкт можна одержувати під час роботи коду, діставати
            // інформацію про його склад. Такі дії називають "рефлексією"
            /*
             Типи даних поділяються на дві великі групи:
             - за значенням  (Value Types)
             - за посиланням (Reference Types)
             Відмінність між ними схожа на статичні та дикамічні об'єкти у С++
             */
            int x = 10; // псевдоним типу: int = System.Int32
            System.Int32 y = x; // Value Types - семантика копіювання: у - копія х
            // Value Types реалізуються структурами (struct)
            // для цих типів одразу задаються значення (х = 10)
            // cant be null, instead have value of "default" if empty
            int w;                // equal as v
            int v = default;      // equal as ^

            object obj1 = new Object(); // Reference Types - семантика переносу
            Object obj2 = obj1; // obj2 це друге (з obj1) посилання на эдиний об'єкт
            // зміни, внесені через будь-яку змінну (obj1 чи obj2), матимуть однаковий
            // ефект і відіб'ються на спільному об'єкті
            // Reference Types реалізуються класами (class)
            // для цих типів потрібне створення об'єкту (частіше за все оператором new)
            // Без об'єкта змінні цих типів мають значення null
        }
    }
}
