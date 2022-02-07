using System;

namespace TeachMeSkills.DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14F;
            int r = Convert.ToInt32(Console.ReadLine());
            float ploshad = pi * (r * r);
            Console.WriteLine($"Радиус круга ={ploshad}");
        }
    }
}
