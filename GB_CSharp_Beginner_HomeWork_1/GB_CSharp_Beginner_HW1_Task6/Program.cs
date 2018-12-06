using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Юмшанов Александр (Yumshanov Alexander)
//6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

namespace YUMSHAN
{
    class MyLib
    {
        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue..");
            Console.Read();
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

        public static void Print(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);

        }
    }