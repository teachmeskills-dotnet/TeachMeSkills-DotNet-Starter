using System;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу - консольный калькулятор.
//Создайте две переменные с именами operand1 и operand2.
//Задайте переменным некоторые произвольные значения.
//Предложите пользователю ввести знак арифметической операции.
//Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
//Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
//Выведите на экран результат выполнения арифметической операции.
//В случае использования операции деления, организуйте проверку попытки деления на ноль.
//И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.

namespace TeachMeSkills.DotNet.Task6
{
    class Program
    {
        private const string Value = "Enter sign:(+,-,/,*) ";

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int operand1 = rnd.Next(0, 100);
            Console.WriteLine($"Enter operand1:{operand1} ");
            Console.Write("Enter operand2: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Value);
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        Console.WriteLine(operand1 + operand2);
                    }
                    break;
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                    }
                    break;
                case "/":
                    {
                        bool a = true;
                        do
                        {
                            if (operand2!=0)
                            {
                                Console.WriteLine(operand1 / operand2);
                                a = false;
                            }
                            else
                            {
                                Console.WriteLine("Incorect input");
                                a = false;
                            }
                        }
                        while (a);
                    }
                    break;
            }
        }
    }
}
