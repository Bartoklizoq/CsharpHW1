using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Написать программу "Анкета". Последовательно задаются вопросы (имя, фамилия, возраст,
//    рост, вес). В результате вся информация выводится в одну строчку:
//    а) используя склеивание;
//    б) используя форматированный вывод;
//    в) используя вывод со знаком $.

// Выполнил: Cуханов Александр

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // вспомогательные переменные
            double y;
            double z;

            Console.Write("Введите Фамилию: ");
            string firstname = Console.ReadLine();

            Console.Write("Введите Имя: ");
            string lastname = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            string age = Console.ReadLine();
            x = Convert.ToInt32(age);

            Console.Write("Введите Рост: ");
            string height = Console.ReadLine();
            y = Convert.ToDouble(height);

            Console.Write("Введите Вес: ");
            string weight = Console.ReadLine();
            z = Convert.ToDouble(weight);

            Console.WriteLine(" ");

            string str = "Фамилия: " + firstname + ". " + "Имя: " + lastname + ". " + "Возраст: " + x + ". " + "Рост: " + y + ". " + "Вес: " + z + ".";
            Console.WriteLine("Используя склеивание: " + str);

            Console.WriteLine(" ");

            string str1 = String.Format("Фамилия: {0}. Имя: {1}. Возраст: {2}. Рост: {3}. Вес: {4}.", firstname, lastname, x, y, z);
            Console.WriteLine("Используя форматированный вывод: " + str1);

            Console.WriteLine(" ");

            string str2 = $"Фамилия: {firstname}. Имя: {lastname}. Возраст: {x}. Рост: {y}. Вес: {z}";
            Console.WriteLine("Используя вывод со знаком $: " + str2);
            Console.ReadKey();
        }
    }
}
