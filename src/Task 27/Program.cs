using System;
//Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном порядке.


namespace Task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv1 = new int[10] {1,2,3,4,5,6,7,8,9,10};
            foreach(int x in masiv1)
            {
                Console.Write(x);
            }
            Console.WriteLine("\n");
            Array.Reverse(masiv1);
            foreach(int x in masiv1)
            {
                Console.Write(x);
            }
        }
    }
}
