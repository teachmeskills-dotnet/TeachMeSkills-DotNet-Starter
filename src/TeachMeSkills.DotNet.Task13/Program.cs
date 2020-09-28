using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран.
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.


namespace TeachMeSkills.DotNet.Task13
{
    class Program
    {
        private const string Value = "B > A";

        static void Main(string[] args)
        {

            Console.WriteLine(Value);
            Console.WriteLine("Input A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B:");
            int B = Convert.ToInt32(Console.ReadLine());
            if (B > A)
            {
                int sum = 0;

                int[] array1 = new int[100];
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = i;
                    if (array1[i] >= A && array1[i] <= B)
                    {
                        sum += array1[i];
                        Console.WriteLine("Sum all elements:" + sum);
                    }

                    if (array1[i] >= A && array1[i] <= B && array1[i] % 2 != 0)
                    {
                        int odd = array1[i];
                        Console.WriteLine("Odd Element: " + odd);
                    }

                }

            }
            else
            {
                Console.WriteLine("Input correct numbers");
            }
        }
    }
}
