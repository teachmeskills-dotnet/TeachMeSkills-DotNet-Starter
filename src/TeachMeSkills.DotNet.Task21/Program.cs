using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод с именем Calculate, который принимает в качестве
//параметров три целочисленных значения и возвращает значение каждого аргумента деленного на 5.

namespace TeachMeSkills.DotNet.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 value");
            var (name, age,age2) = GetTuple(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(name);    //
            Console.WriteLine(age);     //
            Console.WriteLine(age2);
            Console.Read();
        }

        private static (int name, int age, int age2) GetTuple(int n, int a,int b)
        {
            var result = (name:n/5, age:a/5, age2: b/5);
            return result;
        }
    }
}
