using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Используя теорему Де Моргана, преобразуйте исходное выражение A | B, в эквивалентное выражение.
//```

namespace TeachMeSkills.DotNet.Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = true;

          
            if (A|B==!(!A&!B))
            Console.WriteLine("Morgan");
        }
    }
}
