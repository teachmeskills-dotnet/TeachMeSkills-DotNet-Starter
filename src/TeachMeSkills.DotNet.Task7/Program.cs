using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 50] [50 - 100].
//Если да, то укажите, в какой именно промежуток.
//Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.

namespace TeachMeSkills.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int operand1 = rnd.Next(0, 100);
            int  operand1 = Convert.ToInt32(Console.ReadLine());
            int[] mas1 = new int[15];// 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15
            int[] mas2 = new int[100];
            int[] mas3 = new int[100];
            int[] mas4 = new int[102];

            if (operand1 <= 100 && operand1 >= 0)
            {
                for (int x = 0; x < 15; x++)
                {
                    mas1[x] = x;
                    if (operand1 == x)
                    {
                        Console.WriteLine($"Operand insert in mas1 {operand1}");
                        break;
                    }
                    //Console.WriteLine(mas1[x]);
                }
                for (int y = 15; y < 36; y++)
                {

                    mas2[y] = y;
                    if (operand1 == y)
                    {
                        Console.WriteLine($"Operand insert in mas2 {operand1}");
                        break;
                    }
                    //Console.WriteLine(mas2[y]);
                }

                for (int z = 36; z < 52; z++)
                {
                    mas3[z] = z;
                    if (operand1 == z)
                    {
                        Console.WriteLine($"Operand insert in mas3 {operand1}");
                        break;
                    }
                    //Console.WriteLine(mas3[z]);

                }
                for (int n = 50; n < 101; n++)
                {
                    mas4[n] = n;
                    if (operand1 == n)
                    {
                        Console.WriteLine($"Operand insert in mas4 {operand1}");
                        break;
                    }
                    //Console.WriteLine(mas4[n]);
                }
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
            Console.ReadKey();
        }
    }
}
