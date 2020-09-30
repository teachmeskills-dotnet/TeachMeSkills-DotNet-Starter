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
            Console.WriteLine("Введите M");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите N");
            int N = int.Parse(Console.ReadLine());
            for (int j = 0; j < N; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < M; i++)
                {
                    Console.Write("*");
                }
                
            }
            //Console.WriteLine();
            //for (int j = 0; j < N; j++)
            //{
            //    for (int i = 0; i < M; i++)
            //    {
            //        if (j == 0 || j == N - 1) Console.Write("*");
            //        else if (i == 0 || i == M - 1) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();

        }
    }
}
