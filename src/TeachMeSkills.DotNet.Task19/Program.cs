using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите метод, который будет определять: Ряд всех простых и составных чисел в заданном диапазоне чисел!


namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sqr());
        }
        static int Sqr()
        {
            int[] masiv = new int[11];
            for (int i = 1; i<masiv.Length;i++)
            {
                masiv[i] = i;
                if (i % 1 == 0 && i % i == 0)
                {
                    Console.WriteLine($"simple value: {i}");
                }
                else
                {
                    Console.WriteLine($"hard value: {i}");
                }

            }
            return 1;
        }
    }
}
