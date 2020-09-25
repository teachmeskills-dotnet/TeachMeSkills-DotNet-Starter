using System;
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу расчета начисления премий сотрудникам.
//Премии рассчитываются согласно выслуге лет.
//1. Если выслуга до 5 лет, премия составляет 10% от заработной платы.
//2. Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы.
//3. Если выслуга от 10 лет (включительно) до 15 лет, премия составляет 25% от заработной платы.
//4. Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы.
//5. Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы.
//6. Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы.
//Результаты расчета, выведите на экран.

namespace TeachMeSkills.DotNet.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double zp = 200;
            double workExperience = Convert.ToInt32(Console.ReadLine());

            if (workExperience < 5)
            {
                Console.WriteLine();
                double z = zp * 0.1;
                Console.WriteLine(z);
            }
            else if (workExperience >= 5 && workExperience < 10)
            {
                Console.WriteLine();
                double z = zp * 0.15;
                Console.WriteLine(z);
            }
            else if (workExperience >= 10 && workExperience < 15)
            {
                Console.WriteLine();
                double z = zp * 0.25;
                Console.WriteLine(z);
            }
            else if (workExperience >= 15 && workExperience < 20)
            {
                Console.WriteLine();
                double z = zp * 0.35;
                Console.WriteLine(z);
            }
            else if (workExperience >= 20 && workExperience < 25)
            {
                Console.WriteLine();
                double z = zp * 0.45;
                Console.WriteLine(z);
            }
            else if (workExperience >= 25 && workExperience < 100)
            {
                Console.WriteLine();
                double z = zp * 0.50;
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Incorent input");
            }
        }
    }
}