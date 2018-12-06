using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YUMSHAN;

//Юмшанов Александр (Yumshanov Alexander)
//5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

namespace GB_CSharp_Beginner_HW1_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLib.ConsSetup();

            ShowMyNameCenter();

            MyLib.Print("Юмшанов Александр", 1, 1);
            MyLib.Print("Москва", 1, 2);

            MyLib.Pause();
        }

        static void ShowMyNameCenter()
        {
            string a;

            a = "Юмшанов Александр";
            Console.SetCursorPosition((Console.WindowWidth / 2)-(a.Length/2), (Console.WindowHeight/2)); 
            Console.WriteLine(a);
            
            a = "Москва";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (a.Length / 2), (Console.WindowHeight / 2)+1);
            Console.WriteLine(a);
        }
                
    }
}
