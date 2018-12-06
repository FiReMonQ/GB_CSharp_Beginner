using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YUMSHAN;

//Юмшанов Александр (Yumshanov Alexander)
//3.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
//по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
//Вывести результат используя спецификатор формата .2f(с двумя знаками после запятой);
//
//б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;

namespace GB_CSharp_Beginner_HW1_Task3
{
    class Program
    {
        static int x1, x2, y1, y2;

        static void Main(string[] args)
        {
            MyLib.ConsSetup();
            XYinput();
            XYdistance(x1,x2,y1,y2);
            MyLib.Pause();
        }

        static void XYinput()
        {
            Console.Write("Ведите X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведите X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведите Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ведите Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
        }

        static void XYdistance(int x1, int x2, int y1, int y2)
        {
            double R;
            R = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(" Расстояние между точками равно: "+ R);
        }
    }
}
