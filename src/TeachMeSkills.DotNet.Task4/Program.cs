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
            Console.WriteLine("Input R:");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input h: ");
            int h = Convert.ToInt32(Console.ReadLine());

            double V = 2 * R * Math.PI * h;
            double S = 2 * Math.PI * R*(R + h);
            Console.WriteLine($"Result:\nV= {(int)V}\nS= {(int)S}");

        }

    }
}
