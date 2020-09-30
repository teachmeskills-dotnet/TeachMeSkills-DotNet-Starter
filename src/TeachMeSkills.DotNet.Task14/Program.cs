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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(10, i);
                Console.WriteLine("*" + " ");
            }

            for (int i = 10; i >= 0; i--)
            {
                Console.SetCursorPosition(i, 10);
                Console.WriteLine("*");
            }
            for (int i = 10; i >= 0; i--)
            {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("*");
            }
            int x = 10;
            int y = 10;
            for (int i = 5; i < 10; i++)
            {
                x += 1;
                y += 1;
                Console.SetCursorPosition(x, y);
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
            int k1 = 10;
            int k2 = 10;
            for (int i=5;i<10;++i)
            {
                --k1;
                ++k2;
                Console.SetCursorPosition(k1,k2);
                Console.WriteLine("*");
            }
            //Console.SetCursorPosition(5,15);
            //Console.WriteLine("1");
            //Console.SetCursorPosition(15, 15);
            //Console.WriteLine("2");
            int v1 = 5;
            int v2 = 15;
            for (int i = 0; i<10;i++)
            {
                ++v1;
                Console.SetCursorPosition(v1,v2);
                Console.WriteLine("*");
            }
            int d1 = 5;
            for (int i=0;i<5;i++)
            {
                ++d1;
                Console.SetCursorPosition(d1,d1);
                Console.WriteLine("*");
            }
            int g1 = 10;
            int g2 = 0;
            for (int i= 0;i<5;i++)
            {
                ++g1;
                ++g2;
                Console.SetCursorPosition(g1,g2);
                Console.WriteLine("*");
            }
            int l1 = 15;
            int l2 = 5;
            for (int i=0;i<5;i++)
            {
                --l1;
                ++l2;
                Console.SetCursorPosition(l1,l2);
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
