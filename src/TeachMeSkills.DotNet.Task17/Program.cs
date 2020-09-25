using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу, которая будет выполнять конвертирование валют.
//Пользователь вводит: сумму денег в определенной валюте, курс для конвертации в другую валюту.
//Организуйте вывод результата операции конвертирования валюты на экран.

namespace TeachMeSkills.DotNet.Task17
{
    class Program
    {

        const decimal euro = 3.04M;
        const decimal dollar = 2.57M;
        const decimal ruble = 3.42M;
        static void Main(string[] args)
        {
            Console.WriteLine("Valute: \n1.euro \n2.dollar \n3.ruble \n4. bel ruble");
            Console.WriteLine("Input number");
            int str1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your value(bel ruble):");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());

            switch (str1)
            {
                case 1:
                    {
                        decimal result1 = userInput / euro;
                        Console.WriteLine((int)result1);
                    }
                    break;
                case 2:
                    {
                        decimal result2 = userInput / dollar;
                        Console.WriteLine((int)result2);
                    }
                    break;
                case 3:
                    {
                        decimal result3 = userInput / ruble;
                        Console.WriteLine((int)result3);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Incorect input");
                    }
                    break;


            }



        }
    }
}
