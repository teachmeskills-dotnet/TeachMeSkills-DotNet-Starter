using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
             const float pi = 3.14F;
            Console.Write("Введите радиус цилиндра: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            int h = Convert.ToInt32(Console.ReadLine());
            float V = pi * (r * r) * h;
            float s = 2 * pi * r * (r + h);
            Console.WriteLine($"Объём цилиндра = {V}");
            Console.WriteLine($"Площадь поверхности цилиндра = {s}");
        }
    }
}
