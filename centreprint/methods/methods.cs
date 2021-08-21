using System;

namespace methods
{
    class methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа содержит методы.");
        }

        static void PrintMessage(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Pause()
        {
            Console.ReadKey();
        }




    }


}
