using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Написать программу обмена значениями двух переменных.
//    а) С использованием третьей переменной.

// Выполнил: Суханов Александр.

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = 0;
            int t;

            Console.WriteLine("Обмен значениями.");

            Console.Write("Введите а: ");
            string onenum = Console.ReadLine();
            a = Convert.ToInt32(onenum);

            Console.Write("Введите b: ");
            string twonum = Console.ReadLine();
            b = Convert.ToInt32(twonum);

            t = a;
            a = b;
            b = t;

            Console.WriteLine("a = " + a + ". " + "b = " + b + ".");
            Console.ReadKey();
        }
    }
}
