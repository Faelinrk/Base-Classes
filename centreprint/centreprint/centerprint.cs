using System;

namespace centreprint
{
    //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    class centerprint
    { 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Введите ваше имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            var surname = Console.ReadLine();
            Console.WriteLine("Введите ваш город проживания");
            var city = Console.ReadLine();


            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

            Print($"Ваше имя: {name}. Ваша фамилия: {surname}. Город проживания: {city}", Console.WindowWidth / 2, Console.WindowHeight / 2);

            Console.ReadLine();




        }

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
    }
}
