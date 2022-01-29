using System;

namespace TeachMeSkills.DotNet.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable1 = "\nмоя строка 1";
            string variable2 = "\tмоя строка 2";
            string variable3 = "\aмоя строка 3";

            Console.WriteLine($"{variable1}{variable2}{variable3}");

        }
    }
}
