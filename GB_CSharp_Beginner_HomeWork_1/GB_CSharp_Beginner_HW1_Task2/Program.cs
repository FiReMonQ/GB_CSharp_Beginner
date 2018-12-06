using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YUMSHAN;


//Юмшанов Александр (Yumshanov Alexander)
//2. Ввести вес и рост человека.
//Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
//где m-масса тела в килограммах, h - рост в метрах

namespace GB_CSharp_Beginner_HW1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLib.ConsSetup();
            MassIndex();
            MyLib.Pause();
        }

        static void MassIndex()
        {
            double growht, weight, index;

            Console.Write("Ваш рост(М): ");
            growht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваш вес(Кг): ");
            weight = Convert.ToDouble(Console.ReadLine());

            index = weight / (growht * growht);

            Console.WriteLine("Индекс массы тела: "+ index);

        }
    }
}
