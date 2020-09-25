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
            Console.WriteLine(Sqr());
        }
        static double Sqr()
        {
            double userInput = Convert.ToDouble(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                Console.WriteLine("1) Input value even");
            }
            else
            {
                Console.WriteLine("1) Input value odd");
            }
            if (userInput % 1 == 0 && userInput % userInput == 0)
            {
                Console.WriteLine("2) userInput simple value");
            }
            else
            {
                Console.WriteLine("2) userInput hard value");
            }
            if (userInput % 2 == 0 || userInput % 3 == 0 || userInput % 5 == 0 || userInput % 6 == 0 || userInput % 9 == 0)
            {
                Console.WriteLine("3) userInput 3 case works");
            }
            else
            {
                Console.WriteLine("3) userInput 3 case not works ");
            }
            return 1;

        }
    }
}
