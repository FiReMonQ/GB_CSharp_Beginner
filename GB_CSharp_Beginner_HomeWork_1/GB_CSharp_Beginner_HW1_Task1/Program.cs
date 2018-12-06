using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YUMSHAN;

//Юмшанов Александр (Yumshanov Alexander)
//1. Написать программу “Анкета”. Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
//В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.

namespace GB_CSharp_Beginner_HW1_Task1
{
    class Program
    {
        static string name, fam;
        static int age, weight, growth;

        static void Main(string[] args)
        {
           MyLib.ConsSetup();

           Anketa();
           ToScreen();

           MyLib.Pause();

        }

        static void Anketa()
        {
            Console.WriteLine("Добый день!");
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите фамилия: ");
            fam = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите вес: ");
            weight = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите рост: ");
            growth = Convert.ToInt16(Console.ReadLine());
        }

        static void ToScreen()
        {
            Console.WriteLine("a) "+ fam +" "+ name +" Возраст: "+ age +" Вес: "+ weight +" Рост: "+ growth);
            Console.WriteLine("б) {0} {1} Возраст: {2} Вес: {3} Рост: {4}",fam, name, age, weight, growth);
            Console.WriteLine($"в) {fam} {name} Возраст: {age} Вес: {weight} Рост: {growth}");
        }

    }
}
