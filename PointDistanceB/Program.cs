using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. б) Выполнить задание по подсчсту расстояния между точками, используя метод.

// Выполнил: Суханов Александр.

namespace PointDistanceB
{
    class Program
    {

        static double Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        static void Main(string[] args)
        {

            double x1, x2, y1, y2;

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

            Console.WriteLine("Расстояние между точками r = " + "{0:f2}", Distance(x1, x2, y1, y2));

            Console.ReadKey();
        }
    }
}
