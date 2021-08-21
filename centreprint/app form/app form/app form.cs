using System;

namespace app_form
{
    //Написать программу «Анкета».
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Пожалуйста, заполните анкету о себе!");

            Console.WriteLine("Ваше имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия:");
            var surname = Console.ReadLine();

            Console.WriteLine("Ваш возраст:");
            var age = Console.ReadLine();

            Console.WriteLine("Ваш вес:");
            var weight = Console.ReadLine();

            Console.WriteLine("Ваш рост:");
            var tall = Console.ReadLine();

            Console.WriteLine($"Ваша анкета: Имя: {name}, Фамилия: {surname}, Возраст: {age}, Вес: {weight}, Рост: {tall}");
            Console.WriteLine("Ваша анкета: " + "Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age + ", Вес: " +  weight + ", Рост: " + tall);
            Console.WriteLine("Ваша анкета: Имя: {0}, Фамилия: {1}, Возраст: {2}, Вес: {3}, Рост: {4}", name, surname, age, weight, tall);

            Console.ReadLine();
        }
    }
}
