using System;

namespace YUMSHAN
{
    class MyLib
    {
        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue..");
            Console.ReadLine();
        }

        public static void ConsSetup()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = true;            
            Console.Clear();
            Console.SetWindowSize(100, 10);
            Console.SetBufferSize(100, 10);
        }
    }

}