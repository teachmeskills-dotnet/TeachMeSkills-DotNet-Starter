using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод с именем Calculate, который принимает в
//качестве параметров три целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.


namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Sum: "+ Calculate(val1:12,val2:12,val3:15));
        }
        static int Calculate(int val1,int val2,int val3)
        {
            return (val1 + val2 + val3) / 3;
        }
    }
}
