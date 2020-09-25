using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет.
//Допустим, ежемесячная сумма платежа должна составлять 100 BYN.
//Клиент должен выполнить 7 платежей, но может платить реже большими суммами.
//Т.е., может двумя платежами по 300 и 400 BYN. закрыть весь долг.
//Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка.
//Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).


namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
        }
        static int Calculate(int sum, int credit)
        {
            if (credit >= sum)

            {
                if (sum > credit)
                {
                    Console.WriteLine("You need pay");
                    return credit - sum;
                }

                if (sum < credit)
                {
                    Console.WriteLine("You need pay money");
                    return credit - sum;
                }
                if (sum == credit)
                {
                    Console.WriteLine("No need give money");
                    
                }
            }
            
            return 1;
        }
    }
}

