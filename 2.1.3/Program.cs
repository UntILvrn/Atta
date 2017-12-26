using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_44
{
    class Program
    {

        static void Main(string[] args)
        {
            double x00 = vvod("x1");
            double y00 = vvod("y1");
            double x10 = vvod("x2");
            double y10 = vvod("y2");
            double x20 = vvod("x3");
            double y20 = vvod("y3");
            Program.Koord(x00, x10, x20, y10, y20, y00);
            Console.ReadKey();
        }
        static double vvod(string f)
        {
            Console.Write("Введите {0} : ", f);
            double a = Convert.ToDouble(Console.ReadLine());
            return a;
        }
        static void Koord(double x0, double x1, double x2, double y1, double y2, double y0)
        {
            double y3, x3;
            bool cont = false;            
            do
            {                
                double h1, h2, h3;
                h1 = Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
                h2 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                h3 = Math.Sqrt((x0 - x2) * (x0 - x2) + (y0 - y2) * (y0 - y2)); 
                if (Math.Sqrt((h1 * h1) + (h2 * h2)) == h3)
                {
                    cont = true;
                    x3 = x0 - (x2 - x1);
                    y3 = x0 - (y2 - y1);

                }
                if (Math.Sqrt((h3 * h3) + (h2 * h2)) == h1)
                {
                    cont = true;
                }
                if (Math.Sqrt((h3 * h3) + (h1 * h1)) == h2)
                {
                    cont = true;
                }
                if (cont == false)
                {
                    Console.WriteLine("Данные точки не являются углами прямоугольника, введите координаты этих точек ещё раз");
                }
                else
                {
                    x3 = x2 - (x1 - x0);
                    y3 = y0 - (y1 - y2);
                    Console.WriteLine(x3);
                    Console.WriteLine(y3);
                }

            } while (cont == false);
        }
    }
}
