using System;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу, которая будет выполнять проверку чисел на четность.
//Предложите два варианта решения поставленной задачи.


namespace TeachMeSkills.DotNet.Task9
{
    class Program
    {
        static int userInput = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            if (userInput % 2 == 0)
                Console.WriteLine("userInput divisible by two");
            Console.WriteLine("Yes" + IsEven(2));
        }
         private static  bool IsEven(int userInput)
        {
            return (userInput & 1) == 0;
        }
    }
}
