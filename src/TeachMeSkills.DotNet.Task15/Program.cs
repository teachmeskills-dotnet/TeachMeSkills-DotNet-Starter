using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу, которая будет рассчитывать,
//и выводить на экран количество возможных вариантов доставки товара.
//Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while.


namespace TeachMeSkills.DotNet.Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число клиентов");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            do
            {
                result *= x;
                x -= 1;
            } while (x > 0);
            Console.WriteLine("Количество вариантов доставки: {0}", result);
            Console.ReadKey();
        }
    }
    }

