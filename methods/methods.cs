using System;

namespace methods
{
    //Создать класс с методами
    class methods
    {
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
