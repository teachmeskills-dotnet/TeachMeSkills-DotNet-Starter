using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50] [50 - 100].
//Если да, то укажите, в какой именно промежуток.
//Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1;
            Console.WriteLine("100 >= value1 >= 0");
            Console.WriteLine("Enter value1:");
            string str1 = Console.ReadLine();
            bool canparse = int.TryParse(str1, out value1);
            if (canparse)
            {
                if (value1 > 0 && value1 < 100)
                {
                    if (value1 >= 0 && value1 <= 14)
                    {
                        Console.WriteLine("Interval 1: [0 - 14]");
                    }
                    else if (value1 >= 15 && value1 <= 35)
                    {
                        Console.WriteLine("Interval 2: [15 - 35]");
                    }
                    else if (value1 >= 36 && value1 <= 50)
                    {
                        Console.WriteLine("Interval 3: [36 - 50]");
                    }
                    else if (value1 >= 50 && value1 <= 100)
                    {
                        Console.WriteLine("Interval 4: [36 - 50]");
                    }
                }
                else
                {
                    Console.WriteLine("Incorect input");
                }
            }
            else
            {
                Console.WriteLine("Incorect input");
            }

        }
    }
}
