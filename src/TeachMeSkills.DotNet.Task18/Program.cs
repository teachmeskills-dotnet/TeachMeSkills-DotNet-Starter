using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите метод, который будет определять:
//1.является ли введенное число положительным или отрицательным;
//2.является ли оно простым (используйте технику перебора значений);
//3.Делится ли на 2, 5, 3, 6, 9 без остатка.

//Простое число – это натуральное число, которое делится на 1 и само на себя.
//Чтобы определить простое число или нет, следует найти все его целые делители.
//Если делителей больше 2-х, значит оно не простое.
//```

namespace TeachMeSkills.DotNet.Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prost = true;
            Console.WriteLine("enter number\n");
            int n = int.Parse(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine("minus value");
            }
            else if (n>=0)
            {
                Console.WriteLine("positive value");
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine("easy");
            }
            else
            {
                Console.WriteLine("uneasy");
            }
            if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0 || n % 6 == 0 || n % 9 == 0)
            {
                Console.WriteLine("Task 3 ready");
            }
            else
            {
                Console.WriteLine("task 3 not ready");
            }
            Console.ReadKey();
        }

        }

}
