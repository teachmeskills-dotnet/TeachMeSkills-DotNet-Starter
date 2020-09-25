using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Используя циклы и метод: Console.Write("*"), Console.Write(" "), Console.Write("\n")(для перехода на новую строку).
//Выведите на экран:
//1.прямоугольник;
//2.прямоугольный треугольник;
//3.равносторонний треугольник;
//4.ромб;
namespace TeachMeSkills.DotNet.Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int  i = 0;i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.SetCursorPosition(10, i);
            //    Console.WriteLine("*"+" ");
            //}

            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.SetCursorPosition(i, 10);
            //    Console.WriteLine("*");
            //}
            //for (int i = 10; i>=0;i--)
            //{
            //    Console.SetCursorPosition(i, 0);
            //    Console.WriteLine("*");
            //}
            int x = 10;
            int y = 10;
            for (int i = 5; i < 10; i++)
            {
                x += 1;
                y += 1;
                Console.SetCursorPosition(x,y);
                Console.WriteLine("*");
            }
            int z = 10;
            int b = 0;
            for (int i = 5; i < 10; i++)
            {
                z -= 1;
                b += 1;
                Console.SetCursorPosition(z, b);
                Console.WriteLine("*");
            }
            //Console.SetCursorPosition(5, 0);
            //Console.WriteLine("H");

            Console.ReadKey();





            //for (int i = 0; i < 10; ++i)
            //{
            //    Console.Write('.');
            //}
            //for (int i = 0; i < 10; ++i)
            //{
            //    Console.SetCursorPosition(10, i);
            //    Console.Write('.');
            //}
            //for (int i = 10; i >= 0; --i)
            //{
            //    Console.SetCursorPosition(i, 10);
            //    Console.Write('.');
            //}
            //for (int i = 10; i >= 0; --i)
            //{
            //    Console.SetCursorPosition(0, i);
            //    Console.Write('.');
            //}
            //Console.ReadKey();
            //Console.WindowHeight = 70;
            //Console.WindowWidth = 110;
            //int r = 30;
            //int x = 0;
            //for (int y = 0; y < r; ++y)
            //{
            //    x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));

            //    Console.SetCursorPosition(x + r, y + r);
            //    Console.Write('.');
            //    Console.SetCursorPosition(x + r, -y + r);
            //    Console.Write('.');
            //    Console.SetCursorPosition(-x + 2 * r, -y + r);
            //    Console.Write('.');
            //    Console.SetCursorPosition(-x + 2 * r, y + r);
            //    Console.Write('.');
            //}


            //Console.SetCursorPosition(0, r * 2 + 2);
        }
    }
}
