using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YUMSHAN;

//Юмшанов Александр (Yumshanov Alexander)
//
//4. Написать программу обмена значениями двух переменных
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

namespace GB_CSharp_Beginner_HW1_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLib.ConsSetup();
            RevertABC();
            RevertAB();
            MyLib.Pause();
        }

        static void RevertABC()
        {
            int a, b, c;
            Console.Write("Введите А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());

            //a=10 b=20 c=0
            c = a; //c=10
            a = b; //a=20
            b = c; //b=10

            Console.WriteLine("а) A= " + a + " B= " + b);
        }

        static void RevertAB()
        {
            int a, b;
            Console.Write("Введите А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());

            //a=10 b=20
            a = a + b; //10+20 = 30
            b = a - b; //30-20 = 10
            a = a - b; //30-10 = 20

            Console.WriteLine("б) A= " + a + " B= " + b);
        }
    }
}
