using System;
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу русско-английский переводчик.
//Программа знает 10 слов о погоде.
//Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
//Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.


namespace TeachMeSkills.DotNet.Task8
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter russian word");
            string userInput = Console.ReadLine();
            string tempirature = "Температура";
            string wind = "Ветер";
            string humidity = "Влажность";
            string pressure = "Давление";
            string visibility = "Видимость";
            string precipitation = "Осадки";
            string weather = "Погода";
            string ultraviolet = "Ультрафиолетовый";
            string sun = "Солнце";
            string moon = "Луна";

            if (userInput==tempirature)
            {
                Console.WriteLine("a translation of a word " + nameof(tempirature));
            }
            else if (userInput==wind)
            {
                Console.WriteLine("a translation of a word " + nameof(wind));
            }
            else if (userInput==humidity)
            {
                Console.WriteLine("a translation of a word " + nameof(humidity));
            }
            else if (userInput==pressure)
            {
                Console.WriteLine("a translation of a word " + nameof(pressure));
            }
            else if (userInput==visibility)
            {
                Console.WriteLine("a translation of a word " + nameof(visibility));
            }
            else if (userInput==precipitation)
            {
                Console.WriteLine("a translation of a word " + nameof(precipitation));
            }
            else if (userInput==weather)
            {
                Console.WriteLine("a translation of a word " + nameof(weather));
            }
            else if (userInput==ultraviolet)
            {
                Console.WriteLine("a translation of a word " + nameof(ultraviolet));
            }
            else if (userInput==sun)
            {
                Console.WriteLine("a translation of a word " + nameof(sun));
            }
            else if (userInput==moon)
            {
                Console.WriteLine("a translation of a word " + nameof(moon));
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
    }
}
