using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
//Используя формулу πR2, вычислите площадь круга и выведите результат на экран.

namespace TeachMeSkills.DotNet.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi1 = Math.PI;
            Console.WriteLine("Input R: ");
            Console.WriteLine(Area(Math.PI, Convert.ToDouble(Console.ReadLine())));
        }
        static double Area(double pi, double R)
        {
            double S = 2 * pi * R;
            return (int)S;
        }
    }
}
