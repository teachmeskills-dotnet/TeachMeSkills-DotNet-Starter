using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.


namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        private const string Value = "number2>number1";

        static void Main(string[] args)
        {
            Console.WriteLine(Value);
            Console.WriteLine("Input number2:");
            int value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number1:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int min = value2 - value1;
            if (value2 > value1)
            {
                int sum = 0;
                int[] masiv = new int[min];
                for (int i = 1; i < masiv.Length; i++)
                {
                    masiv[i] = i;
                    sum += masiv[i];
                    Console.WriteLine(sum);
                    Console.WriteLine(masiv[i]);
                }
            }
            else
            {
                Console.WriteLine("Input correct numbers");
            }
        }
    }
}
