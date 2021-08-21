using System;

namespace IMT
{
    //Рассчитать и вывести индекс массы тела (ИМТ)
    class IMT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте вычислим индекс массы вашего тела!");
            Console.WriteLine("Введите ваш вес (в килограммах)");
            var m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост (в метрах)");
            var h = Convert.ToDouble(Console.ReadLine());

            var l = (m / (h * h)).ToString("F2");
            Console.WriteLine("Ваш ИМТ = " + l);
            Console.ReadLine();

        }
    }
}
