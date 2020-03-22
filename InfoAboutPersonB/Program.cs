using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 5. б) * Сделать программу, только вывод организовать в центре экрана.

//                       Выполнил: Суханов Александр.

namespace InfoAboutAPersonB
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 27;
            int y = 14;

            Console.Write("Введите ваше имя: ");
            string fn = Console.ReadLine(); // firstname

            Console.Write("Введите вашу Фамилию: ");
            string ln = Console.ReadLine(); // lastname

            Console.Write("Введите город вашего проживания: ");
            string c = Console.ReadLine(); // city

            Console.SetCursorPosition(x, y);

            Console.WriteLine("Информация о человеке: " + " Имя: " + fn + ". " + "Фамилия: " + ln + ". " + "Город: " + c + ". ");
            Console.ReadLine();
        }
    }
}
