using System;

namespace centreprint
{
    //Написать программу обмена значениями двух переменных
    class swap
    { 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Давайте поменяем значения переменных a и b");
            Console.WriteLine("Введите значение переменной a");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b");
            var b = Convert.ToInt32(Console.ReadLine());
            var c = a;
            a = b;
            b = c;
            Console.WriteLine($"Переменная a = {a}. Переменная b = {b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Переменная a = {a}. Переменная b = {b}");



        }

    }
}
