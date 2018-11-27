using System;
using YUMSHAN;

namespace GB_CSharp_Beginner_Lesson_1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MyLib.ConsSetup();

            int a, b;
            double sum, div, avr;

            Console.Write("Input A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input B:");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            Console.WriteLine("SUMM "+ a + "+" + b +" = " + sum);

            div = a / b;
            Console.WriteLine($"DIV {a} + {b} = {div}");
                  
            avr = (double)(a + b)/2.0;
            Console.WriteLine("AVR ({0} + {1}) / 2 = {2:F3}", a, b, avr);

            MyLib.Pause();
        }
    }
}
