using System;

namespace Distance
{
    //Написать программу, которая подсчитывает расстояние между точками с координатами
    class dist
    {
        private static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Здравствуйте! Давайте найдём расстояние между точкой А и Б, используя их координаты.");

            Console.WriteLine("Введите координаты x точки A.");
            var x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y точки A.");
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x точки Б.");
            var x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты y точки Б.");
            var y2 = Convert.ToDouble(Console.ReadLine());
            double r = Distance(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между точками А и Б: " + r.ToString("F2"));

            Console.ReadLine();

        }


    }
}
