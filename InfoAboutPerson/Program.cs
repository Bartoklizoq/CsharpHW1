using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. а) Написать программу которая выводит на экран ваше имя фамилию и город проживания.

//                                Выполнил: Суханов Александр.
namespace InfoAboutAPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string fn = Console.ReadLine(); // firstname

            Console.Write("Введите вашу Фамилию: ");
            string ln = Console.ReadLine(); // lastname

            Console.Write("Введите город вашего проживания: ");
            string c = Console.ReadLine(); // city

            Console.WriteLine("Информация о человеке: " + " Имя: " + fn + ". " + "Фамилия: " + ln + ". " + "Город: " + c + ". ");
            Console.ReadLine();
        }
    }
}

