using System;
using System.Linq;
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется: Создать массив размера N элементов, заполнить его произвольными целыми значениями (размер массива задает пользователь).
//Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов, среднее арифметическое всех элементов, вывести все нечетные значения.
//```

namespace TeachMeSkills.DotNet.Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input array value");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] masiv = new int[N];
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = i;
            }
            int max = masiv.Max();
            int min = masiv.Min();
            Console.WriteLine("the minimum value in the array: " + max + "\nthe minimum value in the array: " + min);
        }
    }
}
