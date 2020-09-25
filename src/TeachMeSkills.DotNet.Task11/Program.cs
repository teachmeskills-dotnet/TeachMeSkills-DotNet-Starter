using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу, которая будет выполнять проверку – является ли указанное число степенью двойки или нет.

namespace TeachMeSkills.DotNet.Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int userInput = Convert.ToInt32(Console.ReadLine());//2 2 4 8
            if (userInput%2==0 )
            {
                Console.WriteLine("Yes sqr 2");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
