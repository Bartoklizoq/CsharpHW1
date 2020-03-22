using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. a) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2 по 
//    формуле: r = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)); Вывести результат, используя специфика-
//    тор формата .2f(с двумя знаками после запятой).

//                                            Выполнил: Суханов Александр.

namespace PointDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            double y1;
            double y2;

            Console.WriteLine("Посчитать расстояние между точками в Декартовой системе координат.");

            Console.Write("Введите x1: ");
            string onex = Console.ReadLine();
            x1 = Convert.ToDouble(onex);

            Console.Write("Ввелите x2: ");
            string twox = Console.ReadLine();
            x2 = Convert.ToDouble(twox);

            Console.Write("Введите y1: ");
            string oney = Console.ReadLine();
            y1 = Convert.ToDouble(oney);

            Console.Write("Введите y2: ");
            string twoy = Console.ReadLine();
            y2 = Convert.ToDouble(twoy);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками r = " + "{0:f2}", r);


            Console.ReadKey();
        }
    }
}
