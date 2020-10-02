using System;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу расчета объема – V и площади поверхности – S цилиндра.
//Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR2h.
//Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR2 h + 2πR2 = 2πR(R+h).


namespace TeachMeSkills.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double ob;
            double plo;
            Console.WriteLine("Input R:");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input h: ");
            int h = Convert.ToInt32(Console.ReadLine());

            MATH1(R, h, out ob, out plo);
            Console.WriteLine($"Result:\nV= {(int)ob}\nS= {(int)plo}");

        }
        static double MATH1(double R, double h, out double V,out double S)
        {
            V = 2 * R * Math.PI * h;
            S = 2 * Math.PI * R * (R + h);
            return 1;
        }

    }
}
