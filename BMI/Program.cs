using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2. Ввести вес рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
//    I = m / (h * h); где m - масса тела в килограммах, h - рост в метрах.

// Выполнил: Cуханов Александр

namespace BMI
{
    class Program
    {
        static double Bmi(double h, double m)
        {
            return m / Math.Pow(h, 2);
        }

        static void Main(string[] args)
        {
            double h;
            double m;

            Console.Write("Введите Рост: ");
            string height = Console.ReadLine();
            h = Convert.ToDouble(height);

            Console.Write("Введите Вес: ");
            string weight = Console.ReadLine();
            m = Convert.ToDouble(weight);

            Console.WriteLine("Индекс массы тела = " + Bmi(h, m));
            Console.ReadKey();
        }
    }
}
