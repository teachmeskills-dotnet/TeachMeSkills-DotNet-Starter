using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте две целочисленные переменные и задайте им некоторые значения.
//Применяя технику вложенных циклов, нарисуйте прямоугольник из звездочек.
//Используйте значения ранее созданных переменных для указания высоты и ширины прямоугольника.

namespace TeachMeSkills.DotNet.Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            //int userInput1 = Convert.ToInt32(Console.ReadLine());
            //int userInput2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
                Console.Write("*");
            }
        }
    }
}
