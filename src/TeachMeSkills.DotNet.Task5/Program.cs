using System;
using System.Reflection.Metadata;
//Создайте две целочисленные переменные и выведите на
//экран результаты всех арифметических операций над этими двумя переменными.

namespace TeachMeSkills.DotNet.Task5
{
    class Program
    {
        static int userInput1 = Convert.ToInt32(Console.ReadLine());
        static int userInput2 = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            Console.WriteLine("Sum userInput1 + userInput2: " + Sum(userInput1, userInput2));
            Console.WriteLine("Minus userInput1 - userInput2: " + Minus(userInput1,userInput2));
            Console.WriteLine("Divided userInput1 / userInput2: " + Divided(userInput1,userInput2));
            Console.WriteLine("Multiplication userInput1 * userInput2: " + Multiplication(userInput1,userInput2));
        }
        static int Sum(int userInput1, int userInput2 )
        {
            return userInput1+userInput2;
        }
        static int Minus(int userInput1, int userInput2)
        {
            return userInput1 - userInput2;
        }
        static int Divided(int userInput1,int userInput2)
        {
            return userInput1 / userInput2;
        }
        static int Multiplication(int userInput1, int userInput2)
        {
            return userInput1 * userInput2;
        }


    }
}
